using System;

namespace Tra.Traline.Launcher.UserEvents;
public class SelectItemEventArgs<TItem> : EventArgs
{
	public TItem? OldItem { get; }
	public TItem? NewItem { get; }

	public SelectItemEventArgs(TItem? oldItem, TItem? newItem)
	{
		OldItem = oldItem;
		NewItem = newItem;
	}
}
