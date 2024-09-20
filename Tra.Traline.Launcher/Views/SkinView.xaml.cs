using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Tra.Traline.Launcher.Entities;
using Tra.Traline.Launcher.Models;
using Tra.Traline.Launcher.UserEvents;
using Tra.Traline.Launcher.Utilities;
using Tra.Traline.Launcher.ViewModels;

namespace Tra.Traline.Launcher.Views;
/// <summary>
/// SkinView.xaml 的交互逻辑
/// </summary>
public partial class SkinView : UserControl
{
	public event EventHandler<SelectItemEventArgs<Folder>>? SelectItem;
	public event EventHandler<DataChangedEventArgs>? DataChanged;

	public SkinView()
	{
		InitializeComponent();
	}

	private void SelectItem_LbxSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var lst = (ListBox)sender;
		SelectItem?.Invoke(this, new(GetItem(e.RemovedItems), (Folder)lst.SelectedItem));

		static Folder? GetItem(IList list)
			=> list.Count == 0 ? null : (Folder?)list[0];
	}

	private void StartEdit_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		var itm = (ListBoxItem)sender;
		var txb = itm.GetChildBfs<TextBox>()!;
		txb.IsHitTestVisible = true;
		txb.SelectAll();
		txb.Focus();
		e.Handled = true;
	}

	private void EndEdit_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
	{
		var tbx = (TextBox)sender;
		tbx.IsHitTestVisible = false;
	}

	private void EditName_TextChanged(object sender, TextChangedEventArgs e)
	{
		DataChanged?.Invoke(this, new(FileEditKind.EditFolder));
	}

	private void RemoveClick(object sender, RoutedEventArgs e)
	{
		SkinVM vm = (SkinVM)DataContext;
		int index = c_lbx.SelectedIndex;
		vm.Remove(index);
		c_lbx.SelectedIndex = index;

		DataChanged?.Invoke(this, new(FileEditKind.RemoveFolder));
		SelectItem?.Invoke(this, new(null, (Folder)c_lbx.SelectedItem));
	}

	private void AddClick(object sender, RoutedEventArgs e)
	{
		SkinVM vm = (SkinVM)DataContext;
		Folder oldfdr = (Folder)c_lbx.SelectedItem;
		Folder newfdr = new("NewFolder");

		vm.Add(newfdr);
		c_lbx.SelectedIndex = vm.Folders.Count - 1;

		DataChanged?.Invoke(this, new(FileEditKind.AddFolder));
		SelectItem?.Invoke(this, new(oldfdr, newfdr));
	}

	private void ListBox_KeyDown(object sender, KeyEventArgs e)
	{
		SkinVM vm = (SkinVM)DataContext;
		ListBox lbx = (ListBox)sender;
		int index = lbx.SelectedIndex;

		switch (e.Key) {
			case Key.Delete:
				vm.Remove(index);
				lbx.SelectedIndex = index;

				DataChanged?.Invoke(this, new(FileEditKind.RemoveFolder));
				SelectItem?.Invoke(this, new(null, (Folder)lbx.SelectedItem));
				e.Handled = true;
				break;
			default:
				break;
		}
	}

	private void ListBox_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.LeftButton == MouseButtonState.Released) return;

		var s = (ListBox)sender;
		if (!s.IsKeyboardFocused) return;
		var item = Util.HitVisualParent<ListBoxItem>(s, e.GetPosition(s));
		if (item is null || item.Content != s.SelectedItem) return;

		DragDrop.DoDragDrop(s, item, DragDropEffects.Move);
	}

	private void ListBox_Drop(object sender, DragEventArgs e)
	{
		var s = (ListBox)sender;
		var vm = (SkinVM)s.DataContext;
		if (e.Data.GetData(typeof(ListBoxItem)) is not ListBoxItem srcitm)
			return;

		var dstitm = Util.HitVisualParent<ListBoxItem>(s, e.GetPosition(s));
		if (dstitm is null) return;

		var src = (Folder)srcitm.DataContext;
		var dst = (Folder)dstitm.DataContext;
		if (ReferenceEquals(src, dst)) return; // No change
		vm.Move(src, dst);
		DataChanged?.Invoke(this, new(FileEditKind.MoveFolder));
	}
}
