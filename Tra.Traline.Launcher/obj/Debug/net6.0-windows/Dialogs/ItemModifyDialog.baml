   M S B A M L   `   `   `  ����O  KTra.Traline.Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tra.Traline.Launcher.DialogsTra.Traline.Launcher.Dialogs  5   	   Q-clr-namespace:Tra.Traline.Launcher.ViewModelsTra.Traline.Launcher.ViewModels  5      3    -Tra.Traline.Launcher.Dialogs.ItemModifyDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Tra.Traline.Launcher.Dialogs     5   	   <vm-clr-namespace:Tra.Traline.Launcher.ViewModels     5      -   5          � Title$  ItemModifyDialog��5
   	    � SizeToContent$ WidthAndHeight=�5       � WindowStyle$
 None=�5       � AllowsTransparency$
 True��5      
������  � 
ResizeMode$ NoResize=�5       J� 	AllowDrop$
 True��5      .��5      ��  
  StdBdr#��[  6
    �� Padding$ 16q�5      ._�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6   �� 5      $	��300 �6    � RowDefinitions 5      �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   .+�5#      �� $
��Name��6   $��4q�5$   	   $��20(�5%   	   $��0��5&   	   �� 5'      $
��Path��6   $��4q�5(   	   $��20(�5)   	   $��1��5*   	   �� 5+      -   5        	 ��Name$	 c_nameTb��5+       
 StdTbx#��[ 5,      $��4q�5.      $��20(�5/      $��0��50      $��1��51      ��5-      �� 
 �� Path$

 Name�.��51      52      �� 53      -   5        $	 c_pathTb��53      #��[ 54      $��4q�56      $��20(�57      $��1��58      $��1��59      ��55      �� $

 Path�59      � 5;      $	��240��6
   $��Right=�5<      $��2��5=      $��1��5>       5?      �� 5@      $��1* �6   �� 5A      $��1* �6   .+�5D      �� -   5         
 StdBtn#��[ 5D      $��Confirm��5E      $��4q�5F      $��4q�5G      $��20(�5H      $��0��5I      5J      �� 5L      -   5        #��[ 5L      $��Cancel��5M      $��4q�5N      $��20(�5O      $��1��5P      5Q      5R      5T      5V      5X      