   M S B A M L   `   `   `  ����C  ?TableTUR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5   	       Main.InfoOfGameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Main     5   	   -   5          �Name$  InfoOfGameWin��5	   	    � Title$( "Информация об игре��5   	   $	��250��5   	   $	��400��6    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	      WindowStyle#���   5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5&   
   �� $��0��6   $��0��6$   $��2��61    �� TextAlignment$ Center=�6E   Первый участник5(      �� 5*   
   $��3��6   $��0��6$   $��2��61   $ Center=�6E   Второй участник5,      �� 5.   
   -   5         ��Name$ firstt��5.      $��0��6%   $��1��65   $��2��6B   $ Center=�6V   50      �� 52   
   -   5        $ secondt��52      $��3��6%   $��1��65   $��2��6B   $ Center=�6V   54      �� 56   
   $��1��6   $��2��6%   $��3��62   $ Center=�6F   Победитель58      	� 5;   
   -   5         	�Name$ check1��5;      $��0��6&   $��3��66   $��2��6C   	 	� 	GroupName$	 Winner��6W   $��Первый��6j   $��Center=�6{   	� 5<   
   -   5        $ check2��5<      $��3��6&   $��3��66   $��2��6C   $	 Winner��6W   $��Второй��6j   $��Center=�6{   �� 5>   
   -   5        
 ��Name$
 	Winner_on��5>      $��2��6$   $��4��64   .��6Y   Сохранить5@      5B      5C      