using System.Collections.Generic;
using Tra.Traline.Launcher.Models;

namespace Tra.Traline.Launcher.ViewModels;
internal class SkinVM : BaseViewModel<Skin>
{
	public ICollection<Folder> Folders
	{
		get => _model.Folders;
	}

	public SkinVM(Skin skin) :
		base(skin)
	{ }

	public void Add(Folder folder)
	{
		_model.Folders.Add(folder);
	}

	public void Remove(int index)
	{
		_model.Folders.RemoveAt(index);
	}

	public void Move(int oldindex, int newindex)
	{
		if (oldindex == newindex) return;
		_model.Folders.Move(oldindex, newindex);
	}

	public void Move(Folder src, Folder dst)
	{
		int srci = _model.Folders.IndexOf(src);
		int dsti = _model.Folders.IndexOf(dst);
		Move(srci, dsti);
	}
}
