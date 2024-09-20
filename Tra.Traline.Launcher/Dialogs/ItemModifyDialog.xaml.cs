using System.Windows;
using Tra.Traline.Launcher.ViewModels;
using System.Windows.Input;
using Tra.Traline.Launcher.Models;
using System;
using Tra.Traline.Launcher.Utilities;
using System.IO;

namespace Tra.Traline.Launcher.Dialogs;
/// <summary>
/// ItemModifyDialog.xaml 的交互逻辑
/// </summary>
public partial class ItemModifyDialog : Window
{
	private readonly ItemVM _vm;

	public ItemModifyDialog(Item item)
	{
		InitializeComponent();

		DataContext = _vm = new ItemVM(item);
	}

	private void Confirm_ButtonClick(object sender, RoutedEventArgs e)
	{
		_vm.Name = c_nameTb.Text;
		_vm.Path = c_pathTb.Text;
		DialogResult = true;
		Close();
	}

	private void Cancel_ButtonClick(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void DragWindow_WindowMouseDown(object sender, MouseButtonEventArgs e)
	{
		DragMove();
	}

	private void Window_DragEnter(object sender, DragEventArgs e)
	{
		e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ?
			DragDropEffects.All : DragDropEffects.None;
	}

	private void Window_Drop(object sender, DragEventArgs e)
	{
		var path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0)?.ToString();
		if (path is null) return;

		c_pathTb.Text = path;
		if (Util.IsControlKeyDown(ctrl: true))
			c_nameTb.Text = Path.GetFileNameWithoutExtension(path);
	}
}
