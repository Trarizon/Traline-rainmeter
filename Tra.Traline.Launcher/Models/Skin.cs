using System.Collections.ObjectModel;

namespace Tra.Traline.Launcher.Models;
public class Skin : BaseModel
{
	private ObservableCollection<Variable> _variables;
	private ObservableCollection<Folder> _folders;

	public ObservableCollection<Variable> Variables => _variables;

	public ObservableCollection<Folder> Folders => _folders;

	public static Skin Empty { get; } = new(null!, null!);

	public Skin(ObservableCollection<Variable> variables, ObservableCollection<Folder> folders)
	{
		_variables = variables;
		_folders = folders;
	}
}
