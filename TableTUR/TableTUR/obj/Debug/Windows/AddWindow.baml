   M S B A M L   `   `   `  ����C  ?TableTUR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5   	       Main.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Main     5   	   -   5          �Name$  AddWin��5	   	    � Title$- 'Добавление участника��5   	   $	��180��5   	   $	��320��6    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	      WindowStyle#���   5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6   �� 5      $
��0.4* �6    � ColumnDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $��* �6   .+�5    
   �� $��0��6   $��1��6$    �� TextAlignment$ Right=�61   %#Название участника5"      �� 5$   
   -   5         ��Name$
 name��5$      $��1��6"   $��1��62    �� TextAlignment$
 Left=�6?   $	��160��6T   .��6`   5&      �� 5(   
   -   5        	 ��Name$	 acsess��5(      $��0��6"   $��3��62   $	��120��6?   $��2��6K   .��5)      �� $ Center=�6   Добавить5+      5,      5-      5/      