   M S B A M L   `   `   `  ����I  EHerbalismRoler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HerbalismRolerHerbalismRoler  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       HerbalismRoler.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   (localclr-namespace:HerbalismRoler  5   	   3System&clr-namespace:System;assembly=mscorlib  5   	     � Title$  
MainWindow��5
   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   �� -   5         ��Name$ GenoratorButton��5      $��Generate��6*   $
��Left=�6=   $��
10,135,0,0q�6X   $	��Top=�6l   $��75��6�   6�   �� 5   
   -   5         ��Name$ RollTimesText��5      $
��Left=�6)   $��23��6D   $��	10,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $��Times Rolled: ��6w   $	��Top=�6�   $��88��6�    �� 
IsReadOnly . $��0q�6�   �� 5   
   -   5        $ DifCheckText��5      $
��Left=�6(   $��23��6C   $��	10,38,0,0q�6O   $
 Wrap=�6b   $
��DC: ��6v   $	��Top=�6�   $��88��6�    . $��0q�6�   �� 5   
   -   5        $ EnviromentText��5      $
��Left=�6*   $��23��6E   $��	10,66,0,0q�6Q   $
 Wrap=�6d   $��Enviroment: ��6x   $	��Top=�6�   $��88��6�    . $��0q�6�   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5          Name$ TimesRolledNumber��5      $��
103,10,0,0q�68   $
��Left=�6L   $��53��6g   $��23��6r   $	��Top=�6~   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   DefaultValue$ 0X�6�   %   DisplayDefaultValueOnEmptyText .    Maximum$ 30X�6�   	   Minimum$	 0X�6�   
 J� IsManipulationEnabled
 . 6�     5   
   -   5        $ 	DifNumber��5      $��
103,38,0,0q�60   $
��Left=�6D   $��53��6_   $��23��6j   $	��Top=�6v   $ 0X�6�   $ 30X�6�   $	 0X�6�    . 6�   �� 5   
   -   5         ��Name$ EnviromentComboBox��5      $
��Left=�6/   $��
103,67,0,0q�6J   $	��Top=�6^   $	��120��6v    �� Text$ Select Enviroment��6�    �� SelectedIndex$ 0��6�   .@�5      �� -   5        $��Arctic��5      $��Arctic��6"   $��11(�63   �� 5      -	   5        $��CostalUnderwater��5      $��Costal/Underwater��6,   $��11(�6H   �� 5      -
   5        $��Desert��5      $��Desert��6"   $��11(�63   �� 5      -   5        $��Forest��5      $��Forest��6"   $��11(�63   �� 5      -   5        $��	Grassland��5      $��	Grassland��6%   $��11(�69   �� 5      -   5        $��Hills��5      $��Hills��6!   $��11(�61   �� 5      -   5        $��Mountain��5      $��Mountain��6$   $��11(�67   �� 5      -   5        $��Swamp��5      $��Swamp��6!   $��11(�61   �� 5      -   5        $��	Underdark��5      $��	Underdark��6%   $��11(�69   �� 5      -   5        $��Common��5      $��Common��6"   $��11(�63   5      �� 5   
   -   5        $ RollMod��5      $
��Left=�6#   $��23��6>   $��
176,10,0,0q�6J   $
 Wrap=�6^   $��	Modifier:��6r   $	��Top=�6�   $��88��6�    . $��0q�6�     5   
   -   5        $ ModifierNum��5      $��
237,10,0,0q�62   $
��Left=�6F   $��53��6a   $��23��6l   $	��Top=�6x   $ 0X�6�    . $ 30X�6�   $	 0X�6�   
 . 6�   �� 5    
   -   5        $ GenoratedIngredients��5       $��10,160,10,10q�60   $
 Wrap=�6F   $�� ��6Z    . $��0q�6t   5"      5#      