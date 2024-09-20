using System;
using System.Windows;
using Tra.Traline.Launcher.Entities;
using Tra.Traline.Launcher.Models;
using Tra.Traline.Launcher.UserEvents;
using Tra.Traline.Launcher.ViewModels;
using System.ComponentModel;
using System.Windows.Input;
using Tra.Traline.Launcher.Utilities;

namespace Tra.Traline.Launcher;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		LauncherManager manager;
		try {
			manager = new();
		} catch (Exception ex) {
			MessageBox.Show(this, ex.Message, "Exception", MessageBoxButton.OK);
			throw;
		}

		DataContext = new MainVM(manager);
		v_fdrLst.DataContext = new SkinVM(manager.Skin);
	}

	private void SelectFolder_VFdrLstSelectItem(object sender, SelectItemEventArgs<Folder> e)
	{
		if (e.NewItem is not null)
			v_itmlst.DataContext = new FolderVM(e.NewItem);
		if (v_itmlst.Visibility == Visibility.Hidden)
			v_itmlst.Visibility = Visibility.Visible;
	}

	private void DataChanged(object sender, DataChangedEventArgs e)
	{
		MainVM vm = (MainVM)DataContext;
		vm.DataChanged(e.FileEditKind);
	}

	private void Window_Closing(object sender, CancelEventArgs e)
	{
		MainWindow win = (MainWindow)sender;
		MainVM vm = (MainVM)win.DataContext;
		if (!vm.IsSaved) {
			var res = MessageBox.Show("Data changed, save befor quit?", "Data unsaved.", MessageBoxButton.YesNoCancel);
			switch (res) {
				case MessageBoxResult.Cancel:
					e.Cancel = true;
					break;
				case MessageBoxResult.Yes:
					vm.Save();
					break;
				case MessageBoxResult.No:
					break;
				default:
					throw new InvalidOperationException();
			}
		}
	}

	private void Window_KeyDown(object sender, KeyEventArgs e)
	{
		MainWindow win = (MainWindow)sender;
		MainVM vm = (MainVM)win.DataContext;

		switch (e.Key) {
			case Key.S:
				if (Util.IsControlKeyDown(ctrl: true))
					vm.Save();
				break;
			default:
				break;
		}
	}

	private void WindowClose_ButtonClick(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void WindowMinimize_ButtonClick(object sender, RoutedEventArgs e)
	{
		WindowState = WindowState.Minimized;
	}

	private void DrageWindow_MouseDown(object sender, MouseButtonEventArgs e)
	{
		DragMove();
	}
}
