   M S B A M L   `   `   `  ����C  ?MusicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MusicApp.ControlsMusicApp.Controls  5      )    #MusicApp.Controls.MusicControlPanel   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MusicApp.Controls     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   � $��1��6   $��1��6   $��Stretch=�6,   $��5q�6J    � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� -   5        $��
PrevButton��5      
������ 
������ $��Right=�5      .��5      (� .��5      �� ⏮6#   5      5      �� 5      -   5        $��PlayPauseButton��5      
������ 
������ $��1��5      .��5      (� .��5       �� ⏸6#   5!      5"      �� 5#      -   5        $��
NextButton��5#      
������ 
������ $
��Left=�5$      $��2��60   .��5%      (� .��5&      �� ⏭6#   5'      5(      5)      (   "MusicApp.Controls.VolumeController  5+   
   $��2��6!   $��1��6.   $	��250��6>   5-      5/      