   M S B A M L   `   `   `  ����O  KTra.Traline.Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Tra.Traline.Launcher.ViewsTra.Traline.Launcher.Views  5      Q-clr-namespace:Tra.Traline.Launcher.ViewModelsTra.Traline.Launcher.ViewModels  5      )    #Tra.Traline.Launcher.Views.SkinView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Tra.Traline.Launcher.Views     5      <vm-clr-namespace:Tra.Traline.Launcher.ViewModels     5      .��5      �   � RowDefinitions  5      �� 5      �� 5      $
��Auto �6   .+�5      �� -   5         ��Name$ c_lbx��5      
������ $��0q�5       J� 	AllowDrop$
 True��5      ��5      ��  �� Path$ Folders���5      �� 5       �� 
TargetType" ��6   .�5      -   5        �� 5        �� Property � �� �� Value 5!      �� 5"   	    �� 
TargetType" ��6   .R�5$   
   ��  ��Name$ border��6    
  StdBdr#��[  5%      $��1q�5&      $��0,0,1,1q�5'      	 �� CornerRadius$	 	12,0,0,12��5(      $��Stretch=�5)      ._�5*      �� 
 ��Name$
 txtbox��6   -   5        
������ $��0q�5-      $��Stretch=�5.      $��Right=�5/      $��16(�50       J� IsHitTestVisible$ False��51      ��5+      �� $
 Name� �� Mode$ TwoWay=�53      54       �� Triggers 56   
   P� 57       P� Property �@��
IsSelected P� Value$
 True��6)   . �58      ��  �� 
TargetName$ border��6    � ��
 �����6=   �� 59      $ border��6    � ��$ 1,1,0,0q�6B   5:      P� 5;       �@��
IsSelected$ False��6)   . �5<      �� $ txtbox��6    �@J�IsHitTestVisible$ False��6C   5=      P� 5>       �@J�IsMouseOver$
 True��6*   . �5?      �� $ border��6    � ��
 �����6=   5@      5C   
   5E      5F      5I      �� 5K       �� Orientation$ 
Horizontal=�6   $��RightToLeft=�5L      $��1��5M      .+�5O      �� -   5         
 StdBtn#��[ 5O      $��4q�5P      $��8,2,8,2q�5Q      $��20(�5R      $��Remove��5S      5T      �� 5U      -   5        #��[ 5U      $��4q�5V      $��8,2,8,2q�5W      $��20(�5X      $	��Add��5Y      5Z      5\      5^      5`      