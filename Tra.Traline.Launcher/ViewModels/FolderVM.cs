using System.Collections.Generic;
using Tra.Traline.Launcher.Models;

namespace Tra.Traline.Launcher.ViewModels;
internal class FolderVM : BaseViewModel<Folder>
{
	public string Name
	{
		get => _model.Name;
		set => _model.Name = value;
	}

	public ICollection<Item> Items
	{
		get => _model.Items;
	}

	public FolderVM(Folder folder) :
		base(folder)
	{ }

	public void Add(Item item)
	{
		_model.Items.Add(item);
	}

	public void Remove(int index)
	{
		_model.Items.RemoveAt(index);
	}

	public void Move(int oldindex, int newindex)
	{
		if (oldindex == newindex) return;
		_model.Items.Move(oldindex, newindex);
	}

	public void Move(Item src, Item dst)
	{
		int srci = _model.Items.IndexOf(src);
		int dsti = _model.Items.IndexOf(dst);
		Move(srci, dsti);
	}
}
