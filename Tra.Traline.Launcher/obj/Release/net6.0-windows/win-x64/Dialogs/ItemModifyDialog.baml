   M S B A M L   `   `   `  ���� O  KTra.Traline.Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tra.Traline.Launcher.DialogsTra.Traline.Launcher.Dialogs  Q-clr-namespace:Tra.Traline.Launcher.ViewModelsTra.Traline.Launcher.ViewModels  3    -Tra.Traline.Launcher.Dialogs.ItemModifyDialog   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:Tra.Traline.Launcher.Dialogs     <vm-clr-namespace:Tra.Traline.Launcher.ViewModels     -     � Title$  ItemModifyDialog�� � SizeToContent$ WidthAndHeight=� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������  � 
ResizeMode$ NoResize=� J� 	AllowDrop$
 True��.����  
  StdBdr#��[   �� Padding$ 16q�._��  � ColumnDefinitions �� $
��Auto ��� $	��300 � � RowDefinitions �� $��1* ��� $��1* ��� $��1* �.+��� $
��Name��$��4q�$��20(�$��0���� $
��Path��$��4q�$��20(�$��1���� -   	 ��Name$	 c_nameTb�� 
 StdTbx#��[ $��4q�$��20(�$��0��$��1������ 
 �� Path$

 Name�.���� -   $	 c_pathTb��#��[ $��4q�$��20(�$��1��$��1������ $

 Path�� $	��240��$��Right=�$��2��$��1�� �� $��1* ��� $��1* �.+��� -    
 StdBtn#��[ $��Confirm��$��4q�$��4q�$��20(�$��0���� -   #��[ $��Cancel��$��4q�$��20(�$��1��