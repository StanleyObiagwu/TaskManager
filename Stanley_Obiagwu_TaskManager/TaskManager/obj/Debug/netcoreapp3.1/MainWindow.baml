   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5   	       TaskManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TaskManager     5   	   -   5          � Title$  Task Manager��5   	   $	��450��65   $	��800��6B   .��5	      � ���	#FFC1C1C1.+�5   
   �� -   5        $��listBox1��5   %   $��	300,0,0,0q�6   $
��Left=�65   $��Center=�6P   $	��390��6k   $	��275��6w   
�������5      �� 5   
   -   5         ��Name$ AddTask��5   o   $��Create Task��6   $
��Left=�6'   $��300,377,0,0q�6B   $	��Top=�6W    J� RenderTransformOrigin$ 0.533,0.693&�6�   $��91��6�   �� 5   
   -   5        $ 
DeleteTask��5   j   $��Delete��6   $
��Left=�6"   $��449,377,0,0q�6=   $	��Top=�6R   $��92��6�   �� 5   
   -   5        $ 
UpdateTask��5   o   $��Update Task��6   $
��Left=�6'   $��594,377,0,0q�6B   $	��Top=�6W   $ 5.421,0.323&�6�   $��96��6�   �� 5   
   -   5         ��Name$ currentDateTextBlock��5      $��65,58,545,0q�62   $��Current Date:��6G   $
��Wrap=�6\   $	��Top=�6p   $��14(�6�   �� 5   
   $��Task Manager Application��6   $
��Left=�63   $��
422,10,0,0q�6N   $	��Top=�6b   $��14(�6z   �� 5   
   $
��Left=�6   $��
311,54,0,0q�6/   $
��Task��6C   $
��Wrap=�6O   $	��Top=�6c   �� 5   
   $
��Left=�6   $��
380,54,0,0q�6/   $��Date Created��6C   $
��Wrap=�6W   $	��Top=�6k   �� 5   
   $
��Left=�6   $��
506,54,0,0q�6/   $��Due Date��6C   $
��Wrap=�6S   $	��Top=�6g   �� 5   
   $
��Left=�6   $��
626,54,0,0q�6/   $��Status��6C   $
��Wrap=�6Q   $	��Top=�6e   5      5      