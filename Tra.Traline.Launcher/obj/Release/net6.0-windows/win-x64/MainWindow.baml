   M S B A M L   `   `   `  ���� O  KTra.Traline.Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Tra.Traline.LauncherTra.Traline.Launcher  Q-clr-namespace:Tra.Traline.Launcher.ViewModelsTra.Traline.Launcher.ViewModels  G(clr-namespace:Tra.Traline.Launcher.ViewsTra.Traline.Launcher.Views  %    Tra.Traline.Launcher.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:Tra.Traline.Launcher     <vm-clr-namespace:Tra.Traline.Launcher.ViewModels     6v(clr-namespace:Tra.Traline.Launcher.Views     -     � Title$  
MainWindow��$	��450��$	��800�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������ .����  
  StdBdr#��[   �� Padding$ 12q�._��  � RowDefinitions �� $
��Auto ��� $��* �.+���  �� Orientation$ 
Horizontal=�$��RightToLeft=�.+��� -    
 StdBtn#��[ $��20��$��20��$��x��$
��Bold"�$��2q��� -   #��[ $��20��$��20��$��-��$
��Bold"�$��2q��� 
������ $��1q�$��1��.@��� $��Folders��
������ 
����� �$��0,0,0,1q�.���  � ColumnDefinitions �� $
��Auto �$	��250���� $��* �.+�)   #Tra.Traline.Launcher.Views.SkinView  -     Name$ v_fdrLst��)   #Tra.Traline.Launcher.Views.SkinView   
SelectItem$$ SelectFolder_VFdrLstSelectItem��	   DataChanged$	 DataChanged��$��8q�+   %Tra.Traline.Launcher.Views.FolderView  -   
  Name$
 v_itmlst��+   %Tra.Traline.Launcher.Views.FolderView   DataChanged$ DataChanged��$��8q�$��1��$y�Hidden=��� $��	Variables��
������ 
����� �$��0,0,0,1q�.���� $��Coming s∞n��$��50(�$��Center=�$��Center=�