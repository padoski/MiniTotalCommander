   M S B A M L   `   `   `  ����D  @Commander, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Commander.PropertiesCommander.Properties  5      /clr-namespace:Commander.ViewCommander.View  5      K*clr-namespace:Commander.ViewModel.WindowVMCommander.ViewModel.WindowVM  5	      !    Commander.View.MiniTCWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      .r"clr-namespace:Commander.Properties    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .localclr-namespace:Commander.View     5      9vm*clr-namespace:Commander.ViewModel.WindowVM     5	      ���#FFFFFF$	��800��5      $
��1000��5        � Title$  MiniTtotalCommander��5       � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5      +  %Commander.ViewModel.WindowVM.MiniTCVM   vm��%!   &	          5   
   5      5      .��5      �  � DataContext# [  5   	    � RowDefinitions 5   
   �� 5      $��* �5      �� 5      $��40 �5      .+�5!   
   �� ��5"      �� *Panels+��5$      �� 5%      .R�5&      A�  A� Rows$ 1��5'       A� Columns$ 2��5(      5*      5+      ��5.      �� 50      .R�51      #   Commander.View.PanelTCControl     SelectedFile 52      �� *SelectedFile+   	ErrorText 53      �� *	ErrorText+	   
SelectPath	 54      �� *PathSelectCommand+
   PathContent
 55      �� *	Content+   SelectedDriveIndex 56      �� *SelectedDriveIndex+ �� Mode$ TwoWay=�   Drivers 57      ��  �� Path$ Drivers�   Path 58      �� $
 Path�5:      5<      � 5>   
   $��	10,0,10,5q�5?      $��1��5@       � ColumnDefinitions 5B      �� 5C      $��* �5D      �� 5E      $
��Auto �5F      �� 5G      $��* �5H      .+�5K      (� $
��10,0q�5L       (� StretchDirection$
 Both=�5M       (� Stretch$ Uniform=�5N      .��5O      �� 
���  ����5Q      �� *	CopyError+5R      (� 5T      $��2��5U      $
��10,0q�5V      $
 Both=�5W      $ Uniform=�5X      .��5Y      �� 
���/�����5[      �� *SuccesfullCopy+5\      �� 5^      $��1��5_      $��5q�5a      $	��100��5b      ��5`      �� *CopyCommand+.��5c      �� $   Commander.Properties.Resources   copy#��Z 5d      5e      5g      5i      5k      