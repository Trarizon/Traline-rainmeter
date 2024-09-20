using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Tra.Traline.Launcher.Models;

namespace Tra.Traline.Launcher.Entities;
public class LauncherManager : FileManager
{
	#region Predefinations
	public const string VARIABLES_PREFIX =
	@"[Variables]
;PREDEFINE
res=#@#Launcher\
;indicate displaying folder
curFolder=~
;count of system meter(except recycle bin), use for measure pos of sys meter
SystemMeterCount=4

";
	public const string VARIABLES_HINT_VARIABLES = "VARIABLES";
	public const string VARIABLES_HINT_FOLDERS = "FOLDERS";

	public const string MAINL_PREFIX =
		@"[Rainmeter]
Update=100
DefaultUpdateDivider=-1
ContextTitle=Variables
ContextAction=#@#Launcher\Variables.inc

;VARIABLES INCLUDE
@include-1=#@#Launcher\Variables.inc

[Metadata]
Name=Launcher
Author=Trarizon
Version=1.0

;Comments begin with ;; are
;identifiers for the related program,
;you'd better change data after them by the program
;you can edit other datas as you like

;INCLUDE
;MEASURE_INC
@include00=#res#measure\MScript.inc
@include01=#res#measure\MCpu.inc
@include02=#res#measure\MDisk.inc
@include03=#res#measure\MMemory.inc
@include04=#res#measure\MRecycle.inc
;STYLE_INC
@include10=#res#style\loc_l\SFolderLocate.inc
@include11=#res#style\loc_l\SSystemLocate.inc
@include12=#res#style\SFont.inc
@include13=#res#style\SGroup.inc
@include14=#res#style\SGlobal.inc
@include15=#res#style\SFolder_l.inc
@include16=#res#style\SSystem.inc
;GLOBAL_INC
@include20=#res#dsp\glo_l\Global.inc
@include21=#res#dsp\glo_l\Expander.inc
@include22=#res#dsp\sys\SystemInfo.inc
@include23=#res#dsp\sys\RecycleBin.inc
@include24=#res#dsp\fdr\Folders.inc

;Every thing adding to here will be lost.
";
	public const string HINT_GENERATE = ";AUTO GENERATED";
	#endregion

	private string VariablesPrefix { get; }
	private string MainLPrefix { get; }
	private string MainRPrefix => MainLPrefix.Replace("_l", "_r");

	private string MainLPath => MainDir + "\\Left.ini";
	private string MainRPath => MainDir + "\\Right.ini";

	public Skin Skin { get; }

	public LauncherManager() : base("Launcher")
	{
		Skin = new(new(), new());

		// ReadVariables
		{
			if (File.Exists(VariablesPath)) {
				using var sr = new StreamReader(VariablesPath, s_Encoding);

				// Store the prefix.
				var pfxSb = new StringBuilder();
				// Currernt action
				Action<string>? load = null;

				while (!sr.EndOfStream) {
					string str = sr.ReadLine()!;

					if (load is null) {
						if (str.EndsWith(';' + VARIABLES_HINT_VARIABLES)) {
							load = LoadVariables;
							continue;
						}
						pfxSb.AppendLine(str);
					}
					else {
						if (str == "") continue;
						if (load == LoadVariables && str.EndsWith(';' + VARIABLES_HINT_FOLDERS)) {
							load = LoadFolders;
							continue;
						}
						load(str);
					}
				}

				VariablesPrefix = pfxSb.ToString();

				#region LoadDelegates
				void LoadVariables(string line)
				{
					VariableType type = VariableType.String;
					StringBuilder? cmt = null;

					var match = Regex.Match(line, @"^;(?:([a-zA-Z0-9]+):)?(.*)$");
					if (match.Success) {
						var typestr = match.Groups[1].Value;
						if (!Enum.TryParse(typestr, out type))
							type = VariableType.String;

						cmt = new(match.Groups[2].Value);
						while (true) {
							if (sr.EndOfStream) return;
							line = sr.ReadLine()!;
							if (line.StartsWith(';'))
								cmt.Append(line[1..]);
							else break;
						}
					}
					match = Regex.Match(line, @"^([^=]+)=(.*)$");
					if (match.Success) {
						Skin.Variables.Add(new Variable(match.Groups[1].Value, match.Groups[2].Value, type, cmt?.ToString() ?? ""));
					}
					else
						throw new FileFormatException(new Uri(VariablesPath), "Wrong file format of variables_variables");
				}

				void LoadFolders(string line)
				{
					var match = Regex.Match(line, @"^(\w+)=([^""][^=]*|"".*"")$");
					if (!match.Success)
						throw new FileFormatException(new Uri(VariablesPath), "Wrong file format of variables_folders");
					var key = match.Groups[1].Value;
					var value = match.Groups[2].Value;

					// Foldername
					if (Regex.IsMatch(key, @"^Fdr\d+Text$")) {
						Skin.Folders.Add(new(value));
						return;
					}
					// Item
					var mItem = Regex.Match(key, @"^Fdr(\d+)_(\d+)(Text|Path)$");
					if (mItem.Success) {
						if (mItem.Groups[3].Value == "Text")
							Skin.Folders[int.Parse(mItem.Groups[1].Value)]
								.Items.Add(new Item(value, ""));
						else
							Skin.Folders[int.Parse(mItem.Groups[1].Value)]
								.Items[int.Parse(mItem.Groups[2].Value)]
								.Path = value;
					}
				}
				#endregion
			}
			else {
				VariablesPrefix = VARIABLES_PREFIX;
			}

		}

		// ReadMain
		{
			if (File.Exists(MainDir)) {
				using var sr = new StreamReader(MainLPath, s_Encoding);

				// Prefix
				var pfxSb = new StringBuilder();

				while (!sr.EndOfStream) {
					string str = sr.ReadLine()!;

					pfxSb.AppendLine(str);
					if (str.EndsWith(";ITEM_INC"))
						break;
				}

				MainLPrefix = pfxSb.ToString();
			}
			else {
				MainLPrefix = MAINL_PREFIX;
			}
		}
	}

	public void Save(FileEditKind knd)
	{
		if (knd.HasFlag(FileEditKind._Main)) SaveMain();
		if (knd.HasFlag(FileEditKind._Variables)) SaveVariables();
		if (knd.HasFlag(FileEditKind._Folder)) SaveFolder();
		if (knd.HasFlag(FileEditKind._Item)) SaveItem();
	}

	private void SaveVariables()
	{
		const string FMT_VAR = ";{0}:{1}\n{2}={3}";
		const string FMT_FDR = "Fdr{0}Text={1}";
		const string FMT_ITM = "Fdr{0}_{1}Text={2}\nFdr{0}_{1}Path={3}";

		using var sw = new StreamWriter(VariablesPath, false, s_Encoding);
		sw.Write(VariablesPrefix);

		// Write variables
		sw.WriteLine(";;" + VARIABLES_HINT_VARIABLES);
		foreach (var v in Skin.Variables) {
			sw.WriteLine(FMT_VAR, v.Type, v.Comment, v.Key, v.Value);
		}
		sw.WriteLine();

		// Write folders
		sw.WriteLine(";;" + VARIABLES_HINT_FOLDERS);
		for (int iFdr = 0; iFdr < Skin.Folders.Count; iFdr++) {
			var fdr = Skin.Folders[iFdr];
			sw.WriteLine(FMT_FDR, iFdr, fdr.Name);
			for (int iItm = 0; iItm < fdr.Items.Count; iItm++) {
				sw.WriteLine(FMT_ITM, iFdr, iItm,
					fdr.Items[iItm].Name, fdr.Items[iItm].Path);
			}
			sw.WriteLine();
		}
	}

	private void SaveMain()
	{
		const string FMT_INC = @"@include{0}=#res#dsp\fdr\Fdr{1}.inc";

		using var swl = new StreamWriter(MainLPath, false, s_Encoding);
		using var swr = new StreamWriter(MainRPath, false, s_Encoding);

		swl.Write(MainLPrefix);
		swr.WriteLine(HINT_GENERATE);
		swr.Write(MainRPrefix);

		for (int i = 0; i < Skin.Folders.Count; i++) {
			var inc = string.Format(FMT_INC, 100 + i, i);
			swl.WriteLine(inc);
			swr.WriteLine(inc);
		}
	}
	private void SaveFolder()
	{
		const string ARG_FIRST = "Head";
		const string ARG_REST = "Image";

		const string STR_GRP = $@"{HINT_GENERATE}
[SExpandedGroup]
Group=Expanded
";
		const string FMT_FDR = @"
[Fdr{0}Image]
Meter=Image
MeterStyle=SFolderImage | SFolder{1}Locate | SExpandedGroup

[Fdr{0}]
Meter=String
MeterStyle=SFolderText | SFolderTextLocate | SFolderFont | SExpandedGroup
";
		const string FMT_GRP = @"
[SFdr{0}Group]
Group=Fdr{0} | Expanded
";

		using var sw = new StreamWriter(ResourceDir + @"\dsp\fdr\Folders.inc", false, s_Encoding);
		using var sws = new StreamWriter(ResourceDir + @"\style\SGroup.inc", false, s_Encoding);

		sw.Write(HINT_GENERATE);
		sw.Write(FMT_FDR, 0, ARG_FIRST);
		sws.Write(STR_GRP);
		sws.Write(FMT_GRP, 0);

		for (int i = 1; i < Skin.Folders.Count; i++) {
			sw.Write(FMT_FDR, i, ARG_REST);
			sws.Write(FMT_GRP, i);
		}
	}
	private void SaveItem()
	{
		const string ARG_FIRST = "Head";
		const string ARG_REST = "Image";

		const string FMT_ITM = @"
[Fdr{0}_{1}Image]
Meter=Image
MeterStyle=SItemImage | SItem{2}Locate | SFdr{0}Group

[Fdr{0}_{1}]
Meter=String
MeterStyle=SItemText | SItemTextLocate | SFolderFont | SFdr{0}Group
";
		string FMT_PATH = ResourceDir + @"\dsp\fdr\Fdr{0}.inc";

		int iFdr = 0;
		for (; iFdr < Skin.Folders.Count; iFdr++) {
			using var sw = new StreamWriter(string.Format(FMT_PATH, iFdr), false, s_Encoding);

			sw.Write(HINT_GENERATE);
			sw.Write(FMT_ITM, iFdr, 0, ARG_FIRST);

			for (int iItm = 0; iItm < Skin.Folders[iFdr].Items.Count; iItm++) {
				sw.Write(FMT_ITM, iFdr, iItm, ARG_REST);
			}
		}

		// Remove redundant files
		while (File.Exists(string.Format(FMT_PATH, iFdr)))
			File.Delete(string.Format(FMT_PATH, iFdr++));
	}
}
