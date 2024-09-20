namespace Tra.Traline.Launcher.Models;
public class Item : BaseModel
{
	private string _name;
	private string _path;

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

	public string Path
	{
		get => _path;
		set {
			if (_path != value) {
				_path = value;
				NotifyPropertyChanged();
			}
		}
	}

	public Item(string name, string path)
	{
		_name = name;
		_path = path;
	}
}
