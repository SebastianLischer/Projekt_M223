   M S B A M L   `   `   `  ����D  @VotingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VotingWPF.ViewsVotingWPF.Views  5   	       VotingWPF.Views.DoTheVote   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VotingWPF.Views     5   	   -   5          � Title$  	DoTheVote��5   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
       � WindowStartupLocation$ CenterScreen=�5      
������  � AllowsTransparency .  � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$ Images/back-image.jpg��6    j� Stretch$
 None=�5      ._�5   
   �� $ 10��6   $��2q�5      	 J� Opacity$
	 0.95Q�5      ��5      �� 5      
 �� 
StartPoint$	
 0,0&�6&    �� EndPoint$	 1,1&�67   .��5       �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5!      $ #DA34AE��6#   $
 0.75Q�63   � 5"      $ #8A16C1��6#   $ 1Q�63   5#      ��5&      �� 5'      $	
 0,1&�6&   $	 1,0&�67   .��5(      � $ #060531��6#   $ 0Q�63   � 5)      $ #1B1448��6#   $ 1Q�63   5*      ._�5-      �  � RowDefinitions 5.      �� 5/      $��30 �6$   �� 50      .+�53      � $��0��6    � ColumnDefinitions 55      �� 56      �� 57      $��25 �6+   �� 58      $��25 �6+   �� 59      $��5 �6+   .+�5<      �� $
��Vote��6    
�������$��10(�5>       $��
Montserrat)�5?       $��0��5@       $��Center=�5A       $��10,0,0,0q�5B       �� 5D      -   5         ��Name$ btnMinimize��5D      $��0q�5E      $��-��5F      
�������$��16(�5H      $��
Montserrat)�5I       � Cursor$
 Hand��5J      $��1��5K      ��5N      �� 5O       �� 
TargetType" ��6$   .�5P   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5Q   "   P� 5R   &    P� Property �@J�IsMouseOver P� Value . . �5S   *   ��  � �� �#278BEF6G   5T   '   5V      ��5Y      �� 5Z       �� 
TargetType" ��6.   .R�5[   "   �� $��18��6)   $��18��64   $ 9��5\   )   #��z��5]   )   ._�5^   &   �� $��Center=�67   $��Center=�5_   7   5`   #   5a      5d      �� 5f      -   5        $ btnClose��5f      $��0q�5g      $��X��5h      
�������$��12(�5j      $��
Montserrat)�5k      $
 Hand��5l      $��2��5m      ��5p      �� 5q      " ��6$   .�5r   "   ��  � �� �#DA34AE6?    5s   "   P� 5t   &    �@J�IsMouseOver . . �5u   *   ��  � �� �#C62DAE6G   5v   '   5x      ��5{      �� 5|      " ��6.   .R�5}   "   �� $��18��6)   $��18��64   $ 9��5~   )   #��z��5   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      �� 5�      $��1��6    �� Orientation$ Vertical=�5�      $��0,35,0,0q�5�      .+�5�      � .+�5�      �� $��Choose your answer : ��6    
�������$��50(�6S   $��Center=�6a   �� 5�      -   5        $��Question��5�   $   $�� ��64   
�������$��Center=�6O   $��172,70,173.6,288q�6l   $��30(�6�   $	��448��6�   &   System.Windows.Controls.DataGrid  5�      -   5          Name$ electionList��5�   #   $
��Left=�6V      SelectionMode$ Single=�6q   $	��Top=�6�   
�������$��0,152,-0.4,0q�6�      Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Z      Header$
 Name��6d      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn    Binding  65   �� *VoteElementText+6r   5�      �� 5�      -   5        $
 Vote��5�   1   $��0��6!   $��313,380,330.6,10q�6R   $��20(�6l   $
��Bold"�6z   $
��Vote��6�   $	��150��6�   $��30��6�   
����� �6�   5�      5�      5�      5�      5�      5�      