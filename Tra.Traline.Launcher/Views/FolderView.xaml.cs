using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Tra.Traline.Launcher.Dialogs;
using Tra.Traline.Launcher.Entities;
using Tra.Traline.Launcher.Models;
using Tra.Traline.Launcher.UserEvents;
using Tra.Traline.Launcher.Utilities;
using Tra.Traline.Launcher.ViewModels;

namespace Tra.Traline.Launcher.Views;
/// <summary>
/// FolderView.xaml 的交互逻辑
/// </summary>
public partial class FolderView : UserControl
{
	public event EventHandler<DataChangedEventArgs>? DataChanged;

	public FolderView()
	{
		InitializeComponent();
	}

	private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		var s = (ListView)sender;
		var listVItem = Util.HitVisualParent<ListViewItem>(s, e.GetPosition(s));
		if (listVItem is null) return;
		var win = new ItemModifyDialog((Item)listVItem.Content);
		if (win.ShowDialog() == true) {
			DataChanged?.Invoke(this, new(FileEditKind.EditItem));
		}
	}

	private void RemoveClick(object sender, RoutedEventArgs e)
	{
		FolderVM vm = (FolderVM)DataContext;
		int index = c_lvw.SelectedIndex;
		vm.Remove(index);
		c_lvw.SelectedIndex = index;

		DataChanged?.Invoke(this, new(FileEditKind.RemoveItem));
	}

	private void AddClick(object sender, RoutedEventArgs e)
	{
		var newitm = new Item("", "");
		var win = new ItemModifyDialog(newitm);
		if (win.ShowDialog() == true) {
			FolderVM vm = (FolderVM)DataContext;
			vm.Add(newitm);
			DataChanged?.Invoke(this, new(FileEditKind.AddItem));
		}
	}

	private void List_KeyDown(object sender, KeyEventArgs e)
	{
		FolderVM vm = (FolderVM)DataContext;
		ListView lvw = (ListView)sender;
		int index = lvw.SelectedIndex;

		switch (e.Key) {
			case Key.Delete:
				vm.Remove(index);
				lvw.SelectedIndex = index;

				DataChanged?.Invoke(this, new(FileEditKind.RemoveItem));
				e.Handled = true;
				break;
			default:
				break;
		}
	}

	private void ListView_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.LeftButton == MouseButtonState.Released) return;

		var s = (ListView)sender;
		var item = Util.HitVisualParent<ListViewItem>(s, e.GetPosition(s));
		if (item is null || item.Content != s.SelectedItem) return;

		DragDrop.DoDragDrop(s, item, DragDropEffects.Move);
	}

	private void ListView_Drop(object sender, DragEventArgs e)
	{
		var s = (ListView)sender;
		var vm = (FolderVM)s.DataContext;
		if (e.Data.GetData(typeof(ListViewItem)) is not ListViewItem srcitm)
			return;

		var dstitm = Util.HitVisualParent<ListViewItem>(s, e.GetPosition(s));
		if (dstitm is null) return;

		var src = (Item)srcitm.DataContext;
		var dst = (Item)dstitm.DataContext;
		if (ReferenceEquals(src, dst)) return; // No change
		vm.Move(src, dst);
		DataChanged?.Invoke(this, new(FileEditKind.MoveItem));
	}
}
