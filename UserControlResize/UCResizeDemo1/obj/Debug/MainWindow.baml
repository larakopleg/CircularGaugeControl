   M S B A M L   `   `   `  ����H  DUCResizeDemo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:UCResizeDemo1UCResizeDemo1  5   	       UCResizeDemo1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:UCResizeDemo1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $	��400��65   $	��400��6E    � 	Resources 5      (  "UCResizeDemo1.RoundNumberConverter   RoundNumberConverter��%   &	          5   
   6%   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   "   UCResizeDemo1.SizableControl  -   5          Name$ sizableControl��5         StartingAngle$ 30Q�67      EndingAngle$	 150Q�6J      MinValue$ 0Q�6\      MaxValue$	 100Q�6i      KazaljkaWidth$ 2Q�6y   $
��Left=�6�   $	��218��6�   $��
282,74,0,0q�6�   $	��Top=�6  $	��280��6  $��1��6)  	   Value	 6�   �� 
 �� Path$
 Value� �� ElementName$ slider�� �� Mode$ TwoWay=�6)  �� 5   
   -   5         ��Name$ slider��5      $��Center=�6�   $	��Top=�6�   $	��300��6�   $��0��6�    � Minimum 6!   �� $
 MinValue�$ sizableControl�� � Maximum 6_   �� $
 MaxValue�$ sizableControl��6�   �� 5   
   $��Center=�6~   $��Bottom=�6�   $��50��6�   $	��200��6�   $��30(�6�    �� TextAlignment$ Center=�6�   $��2��6�   ��6   �� $
 Value�$ sizableControl�� �� 	Converter# [  6�   5      5      