   M S B A M L   `   `   `  ����  	VotingWPF$    VotingWPF.Views.ElectionsPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  ElectionsPanel��5   	   $	��450��6    $	��800��6-    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$ Images/back-image.jpg��6    j� Stretch$
 None=�5      ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$
 0.95Q�5      ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8A16C1��6#   $ 1Q�63   5      ��5       �� 5!      $		 0,1&�6&   $	
 1,0&�67   .��5"      � $ #060531��6#   $ 0Q�63   � 5#      $ #1B1448��6#   $ 1Q�63   5$      ._�5'      �  � RowDefinitions 5(      �� 5)      $��30 �6$   �� 5*      .+�5-      � $��0��6    � ColumnDefinitions 5/      �� 50      �� 51      $��25 �6+   �� 52      $��25 �6+   �� 53      $��5 �6+   .+�56      �� $��ElectionPanel��6    
�������$��10(�58       $��
Montserrat)�59       $��0��5:       $��Center=�5;       $��10,0,0,0q�5<       �� 5>      -   5         ��Name$ btnMinimize��5>      $��0q�5?      $��-��5@      
�������$��16(�5B      $��
Montserrat)�5C       � Cursor$
 Hand��5D      $��1��5E      ���	#FF3E28ED��5H      �� 5I       �� 
TargetType" ��6$   .�5J   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5K   "   P� 5L   &    P� Property �@J�IsMouseOver P� Value . . �5M   *   ��  � �� �#278BEF6G   5N   '   5P      ��5S      �� 5T       �� 
TargetType" ��6.   .R�5U   "   �� $��18��6)   $��18��64   $ 9��5V   )   #��z��5W   )   ._�5X   &   �� $��Center=�67   $��Center=�5Y   7   5Z   #   5[      5]      �� 5_      -   5        $ btnClose��5_      $��0q�5`      $��X��5a      
�������$��12(�5c      $��
Montserrat)�5d      $
 Hand��5e      $��2��5f      ��5i      �� 5j      " ��6$   .�5k   "   ��  � �� �	#FF3E28ED6?    5l   "   P� 5m   &    �@J�IsMouseOver . . �5n   *   ��  � �� �#C62DAE6G   5o   '   5q      ��5t      �� 5u      " ��6.   .R�5v   "   �� $��18��6)   $��18��64   $ 9��5w   )   #��z��5x   )   ._�5y   &   �� $��Center=�67   $��Center=�5z   7   5{   #   5|      5~      5      �� 5�      $��1��5�       �� Orientation$ Vertical=�5�      $��0,35,0,0q�5�      .+�5�      � .+�5�      �� -   5        $ GoBackButton��5�   3   $��Log out��6!   $��Right=�6d   $	��Top=�6�   $	��128��6�   
����� �$��40��6�    J� RenderTransformOrigin$ 
0.735,0.51&�6�   $��0,332,658,0q�6�   �� 5�      $5��/Please, choose election and click twice to vote��6    
�������$
��Left=�6m   $	��Top=�6�   $��439,332,0,0q�6�   $��16(�6�   $��36��6�   $	��347��6�   &   System.Windows.Controls.DataGrid  5�      -   5          Name$ electionList��5�   #   $��Center=�69      SelectionMode$ Single=�6V   $	��Top=�6n   
�������   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6L      Header$ Id��6Y      HeaderStringFormat$  ��6e       
IsReadOnly  . 1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 65   �� *Id+6{     5�   "   $ * 6O   $
 Name��6Y     . ! 65   �� *Name+6g     5�   "   $ * 6S   $ Question��6]     . ! 65   �� *
Question+6o   ��5�      �� 5�   "   $
 None=�6.   " j� 
AlignmentX$
" Left=�5�   )   5�      5�      5�      5�      5�      5�      5�      