   M S B A M L   `   `   `  ����C  ?MusicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MusicApp.ControlsMusicApp.Controls  5      (    "MusicApp.Controls.VolumeController   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MusicApp.Controls     5      $��30��5        � 	Resources  5
         VolumeStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name ��Name �� RadiusX �� RadiusY��%>  &	        �� 5   
   " �6$   .�5      ��  � �� �	#FFB006066+   �� 5       � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 0q�60   �� 5       � �� 5      �� 5      " �6&   .R�5      � $ TemplateRoot��6   .+�5      �� #��z��6%   #��z��6Q   #��z��6�   �� 5      $ 
PART_Track��6(   � 5      $ PART_Indicator��6#   $
}�True��6;   $
��Left=�6O   .+�5   "   �� $ 	Indicator��6,   #��z��6?   $ 5��6c   $ 3��6o   5      5      5      5      5      5      .��5       � .+�5"   
   �� 
�������
���   �$��1q�67   	 �� Padding$	 2q�6K   $��Stretch=�5#      $��Stretch=�6/   
 �� CornerRadius$
 10��6K   ._�5%      �� 
���   �$
 10��6(   $		 5 3q�6:   ._�5'      �  � ColumnDefinitions 5(      �� 5)      $
��Auto �6+   �� 5*      �� 5+      $
��Auto �6+   .+�5.      (� .��5/      �� $
��🔉��6$   
�������$��Center=�6A   50      � 52      -   5         �Name$ 	volumeBar��52   "   #���   56   "   $��1��6H   $��5q�57   "    � Value 52   5   �� *Volume+57   "   (� 59      $��2��6   .��5:      �� $
��🔊��6$   
�������$��Center=�6A   5;      5=      5?      5A      5C      5E      