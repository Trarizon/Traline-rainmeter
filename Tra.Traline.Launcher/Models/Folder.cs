using System.Collections.ObjectModel;

namespace Tra.Traline.Launcher.Models;
public class Folder : BaseModel
{
	private string _name;
	private ObservableCollection<Item> _items;

	public string Name
	{
		get => _name;
		set {
			if (_name != value) {
				_name = value;
				NotifyPropertyChanged();
			}
		}
	}

	public ObservableCollection<Item> Items
	{
		get => _items;
	}

	public static Folder Empty { get; } = new Folder(null!, null!);

	public Folder(string name, ObservableCollection<Item> items)
	{
		_name = name;
		_items = items;
	}

	public Folder(string name) :
		this(name, new())
	{ }
}
