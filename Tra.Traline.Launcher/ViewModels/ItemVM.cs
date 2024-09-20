using Tra.Traline.Launcher.Models;

namespace Tra.Traline.Launcher.ViewModels;
internal class ItemVM : BaseViewModel<Item>
{
	public string Name
	{
		get => _model.Name;
		set => _model.Name = value;
	}

	public string Path
	{
		get => _model.Path;
		set => _model.Path = value;
	}

	public ItemVM(Item item) :
		base(item)
	{ }
}
