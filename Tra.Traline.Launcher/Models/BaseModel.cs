using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tra.Traline.Launcher.Models;
public abstract class BaseModel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
