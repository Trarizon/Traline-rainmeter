   M S B A M L   `   `   `  ����O  KTra.Traline.Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Tra.Traline.LauncherTra.Traline.Launcher  5   	   Q-clr-namespace:Tra.Traline.Launcher.ViewModelsTra.Traline.Launcher.ViewModels  5      G(clr-namespace:Tra.Traline.Launcher.ViewsTra.Traline.Launcher.Views  5      %    Tra.Traline.Launcher.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Tra.Traline.Launcher     5   	   <vm-clr-namespace:Tra.Traline.Launcher.ViewModels     5      6v(clr-namespace:Tra.Traline.Launcher.Views     5      -   5          � Title$  
MainWindow��5   	   $	��450��5      $	��800��5       � WindowStyle$
 None=�5       � AllowsTransparency$
 True��5      
������ .��5      ��  
  StdBdr#��[  6
    �� Padding$ 12q�5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��RightToLeft=�5      .+�5       �� -   5         
 StdBtn#��[ 5       $��20��5!      $��20��5"      $��x��5#      $
��Bold"�5$      $��2q�5%      5&      �� 5'      -   5        #��[ 5'      $��20��5(      $��20��5)      $��-��5*      $
��Bold"�5+      $��2q�5,      5-      5.      �� 50      
������ $��1q�51      $��1��52      .@�54      �� $��Folders��6   
������ 
����� �$��0,0,0,1q�57      .��59      �  � ColumnDefinitions 5:      �� 5;   	   $
��Auto �6   $	��250��6'   �� 5<   	   $��* �6   .+�5?      )   #Tra.Traline.Launcher.Views.SkinView  -   5          Name$ v_fdrLst��5?      )   #Tra.Traline.Launcher.Views.SkinView   
SelectItem$$ SelectFolder_VFdrLstSelectItem��5A   
   	   DataChanged$	 DataChanged��5B   
   $��8q�5@   
   5B   
   +   %Tra.Traline.Launcher.Views.FolderView  5C      -   5        
  Name$
 v_itmlst��5C      +   %Tra.Traline.Launcher.Views.FolderView   DataChanged$ DataChanged��5G      $��8q�5D      $��1��5E      $y�Hidden=�5F      5G      5I      5K      �� 5M      $��	Variables��6   
������ 
����� �$��0,0,0,1q�5P      .��5Q      �� $��Coming s∞n��6   $��50(�5R      $��Center=�5S      $��Center=�5T      5U      5W      5X      5Z      5\      