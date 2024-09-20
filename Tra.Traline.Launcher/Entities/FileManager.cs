using System.Text;
using System.IO;
using Tra.Traline.Launcher.Utilities;

namespace Tra.Traline.Launcher.Entities;
public abstract class FileManager
{
	#region Predefination
	protected static readonly string s_RootConfigDir =
#if DEBUG
		@"C:\Users\Lenovo\Desktop\Traline";
#else
		Directory.GetCurrentDirectory();
#endif
	protected static readonly string s_AtResourceDir = $@"{s_RootConfigDir}\@Resources";

	protected static readonly Encoding s_Encoding = Util.GetEncoding(936);
	#endregion

	protected string ResourceDir => $@"{s_AtResourceDir}\{SkinName}";
	protected string MainDir => $@"{s_RootConfigDir}\{SkinName}";
	protected string VariablesPath => $@"{ResourceDir}\Variables.inc";
	protected string SkinName { get; }

	public FileManager(string skinName)
	{
		SkinName = skinName;
	}
}
