   M S B A M L   `   `   `  ���� O  KTra.Traline.Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Tra.Traline.Launcher.ViewsTra.Traline.Launcher.Views  Q-clr-namespace:Tra.Traline.Launcher.ViewModelsTra.Traline.Launcher.ViewModels  )    #Tra.Traline.Launcher.Views.SkinView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:Tra.Traline.Launcher.Views     <vm-clr-namespace:Tra.Traline.Launcher.ViewModels     .���   � RowDefinitions  �� �� $
��Auto �.+��� -    ��Name$ c_lbx��
������ $��0q� J� 	AllowDrop$
 True������  �� Path$ Folders�����  �� 
TargetType" ��.�-   ��  �� Property � �� �� Value ��  �� 
TargetType" ��.R���  ��Name$ border�� 
  StdBdr#��[  $��1q�$��0,0,1,1q�	 �� CornerRadius$	 	12,0,0,12��$��Stretch=�._��� 
 ��Name$
 txtbox��-   
������ $��0q�$��Stretch=�$��Right=�$��16(� J� IsHitTestVisible$ False������ $
 Name� �� Mode$ TwoWay=� �� Triggers P�  P� Property �@��
IsSelected P� Value$
 True��. ���  �� 
TargetName$ border�� � ��
 ������� $ border�� � ��$ 1,1,0,0q�P�  �@��
IsSelected$ False��. ��� $ txtbox�� �@J�IsHitTestVisible$ False��P�  �@J�IsMouseOver$
 True��. ��� $ border�� � ��
 �������  �� Orientation$ 
Horizontal=�$��RightToLeft=�$��1��.+��� -    
 StdBtn#��[ $��4q�$��8,2,8,2q�$��20(�$��Remove���� -   #��[ $��4q�$��8,2,8,2q�$��20(�$	��Add��