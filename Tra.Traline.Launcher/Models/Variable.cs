using Tra.Traline.Launcher.Entities;

namespace Tra.Traline.Launcher.Models;
public class Variable : BaseModel
{
	private readonly string _key;
	private string _value;
	private readonly VariableType _type;
	private readonly string _comment;

	public string Key => _key;

	public string Value
	{
		get => _value;
		set {
			if (_value == value) {
				_value = value;
				NotifyPropertyChanged();
			}
		}
	}

	public VariableType Type => _type;

	public string Comment => _comment;

	public Variable(string key, string value, VariableType type, string comment = "")
	{
		_key = key;
		_value = value;
		_type = type;
		_comment = comment;
	}
}
