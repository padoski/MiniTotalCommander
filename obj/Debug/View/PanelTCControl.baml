   M S B A M L   `   `   `  ����D  @Commander, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Commander.ViewModel.ConvertersCommander.ViewModel.Converters  5      ;"clr-namespace:Commander.PropertiesCommander.Properties  5	      #    Commander.View.PanelTCControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      7conv,clr-namespace:Commander.ViewModel.Converters  5      *r"clr-namespace:Commander.Properties  5	        � 	Resources  5      8   2Commander.ViewModel.Converters.PathToFileConverter   
PathToFile��%!   &	          5   
   5      5      .��5      ]� $��10q�5   	   .+�5   
   ]� $	��Top=�5      $	��0,5q�5      .+�5      �� ���#FFFFFF$   Commander.Properties.Resources   path#��Z 5      $
��10,0q�5      �� 5      $
��10,0q�5'      {�.  $��Stretch=�5)      ��5       ��  �� Path$
 Path� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" >�.��5)   /   5+      5-      � 5/   
   $	��Top=�50      $	��0,5q�51       � ColumnDefinitions 53      �� 54      $
��Auto �55      �� 56      $��* �57      �� 58      $
��Auto �59      �� 5:      $
��Auto �5;      .+�5?      �� ���#FFFFFF$��Right=�5A         selected_file#��Z 5B      $
��10,0q�5C      �� 5E      $��1��5F      $
��10,0q�5O      {�.  $��Stretch=�5Q      ��5G      �� $ SelectedFile� �� 	Converter# [   �� $ FindAncestor=�" >�.��5Q   /   5S      �� 5U      $��3��5V      $��65��5e      $��Right=�5f      $
��10,0q�5g      $��Stretch=�5h      ��5W      �� $ Drivers� �� $ FindAncestor=�" >�	 �� SelectedIndex	 5^      �� $ SelectedDriveIndex� �� $ FindAncestor=�" >�5i      �� 5k      $��2��5l      ���#FFFFFF$��Right=�5n      
   drive#��Z
 5o      $
��10,0q�5p      5r      �� 5t   
   $	��Top=�5u      
����  �$��Right=�5w      $
��10,5q�5      ��5x      �� $ 	ErrorText� �� $ FindAncestor=�" >�5      �� 5�   
   -   5        $��lb��5�      ���#000000���#FFFFFF��5�      �� $ PathContent� �� $ FindAncestor=�" >�.  (System.Windows.Interactivity.Interaction   Triggers 5�      /  )System.Windows.Interactivity.EventTrigger  5�         	EventName$ MouseDoubleClick��5�      .  (System.Windows.Interactivity.TriggerBase   Actions. 5�      6  0System.Windows.Interactivity.InvokeCommandAction     Command 5�      �� $ 
SelectPath� �� Mode$ OneTime=� �� $ FindAncestor=�" >�   CommandParameter 5�      ��  �� ElementName$ lb��$ SelectedIndex�5�      5�      5�      5�      