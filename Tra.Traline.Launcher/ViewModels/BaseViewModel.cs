using System.ComponentModel;
using System.Runtime.CompilerServices;
using Tra.Traline.Launcher.Models;

namespace Tra.Traline.Launcher.ViewModels;
internal abstract class BaseViewModel :
	INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

internal abstract class BaseViewModel<T> : BaseViewModel
	where T : BaseModel
{
	protected readonly T _model;

	public BaseViewModel(T model)
	{
		_model = model;
	}
}
