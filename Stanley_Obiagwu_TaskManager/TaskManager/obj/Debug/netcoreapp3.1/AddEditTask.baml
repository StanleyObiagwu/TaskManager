   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5   	       TaskManager.AddEditTask   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TaskManager     5   	   -   5          � Title$  Update Task��5   	   $	��450��64   $	��671��6A   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FFA8A8A8��6    � Offset$ 0.068Q�61   5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ TaskNameTextbox��5      $
��Left=�6+   $��
178,94,0,0q�6F   $�� ��6Z    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��172��6�    J� RenderTransformOrigin$ 0.496,0.568&�6�   $��27��6�   6�   �� 5   
   -   5        	 ��Name$	 TaskNameBlock��5      $
��Left=�6+   $��	76,94,0,0q�6F   $��	Task Name��6Y   $
��Wrap=�6j   $	��Top=�6~   $��27��6�   $��82��6�   �� 5   
   -   5        $	 DateCreated��5      $
��Left=�6)   $��
76,155,0,0q�6D   $��Date Created��6X   $
��Wrap=�6l   $	��Top=�6�   �� 5   
   -   5        $ DateCreatedTextBox��5      $
��Left=�6.   $��178,155,0,0q�6I   $�� ��6^   $
 Wrap=�6f   $	��Top=�6z   $	��172��6�   $��27��6�   �� 5   
   -   5        $	 DateDue��5      $
��Left=�6%   $��
76,218,0,0q�6@   $��Date Due��6T   $
��Wrap=�6d   $	��Top=�6x   $ 	0.479,3.9&�6�   �� 5   
   -   5        $	 Status��5      $
��Left=�6$   $��
76,284,0,0q�6?   $��Status:��6S   $
��Wrap=�6b   $	��Top=�6v   $ 	0.479,3.9&�6�   �� 5   
   -   5        $ DateDueTextBox��5      $
��Left=�6*   $��178,220,0,0q�6E   $�� ��6Z   $
 Wrap=�6b   $	��Top=�6v   $	��172��6�   $��27��6�   �� 5   
   -	   5        $ StatusTextBox��5      $
��Left=�6)   $��178,278,0,0q�6D   $�� ��6Y   $
 Wrap=�6a   $	��Top=�6u   $	��172��6�   $��27��6�   ${�False��6�   $y�Hidden=�6�   �� 5   
   -
   5        
 ��Name$
 AddtaskButton��5      $��Submit��6(   $
��Left=�69   $��178,350,0,0q�6T   $	��Top=�6i   $ 0.512,0.671&�6�   $��22��6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateCreatedpicker��5      $
��Left=�60   $��367,155,0,0q�6K   $	��Top=�6`   $��27��6�     5   
   -   5        $ DateDuepicker��5      $
��Left=�6,   $��367,220,0,0q�6G   $	��Top=�6\   $��27��6�   �� 5   
   -   5         ��Name$ StatusComboBox��5      $
��Left=�6+   $��178,284,0,0q�6F   $	��Top=�6[   $	��172��6s   $��27��6   4  .System.Windows.Automation.AutomationProperties   
ItemStatus$ 0��6�   .@�5      �� $��Not Completed��6    �� 
IsSelected$
 true��63   6G   �� 5       $��	Completed��6   61   5!      5$      5%      