using Tra.Traline.Launcher.Entities;

namespace Tra.Traline.Launcher.ViewModels;
internal class MainVM : BaseViewModel
{
	private FileEditKind editKind = FileEditKind.None;
	private readonly LauncherManager _manager;

	public bool IsSaved => editKind == FileEditKind.None;

	public LauncherManager SkinManager => _manager;

	public MainVM(LauncherManager manager)
	{
		_manager = manager;
	}

	public void Save()
	{
		if (IsSaved) return;
		else {
			_manager.Save(editKind);
			editKind = FileEditKind.None;
		}
	}

	public void DataChanged(FileEditKind knd) => editKind |= knd;
}
