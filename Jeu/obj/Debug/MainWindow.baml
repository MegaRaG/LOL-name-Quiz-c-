   M S B A M L   `   `   `  ����>  :Jeu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JeuJeu  5   	       Jeu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Jeu     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��450��6)    � 
ResizeMode$ NoResize=�65   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      � -   5        premiereCouleur�� � Color$ 	#FF101E1E��5   8    � Offset$ 0Q�6J   � 5      -   5        deuxiemeCouleur��$ White��5   8   $ 1Q�6F   5      .+�5   
   �� -   5         ��Name$ ImmageIntero��5      $	��Top=�6&   $��0,85,0,0q�6>   $��Center=�6P   $��interrogation.jpg��6m   $	��216��6�   $	��322��6�   �� 5   
   -   5         ��Name$ 
bouttonLol��5      $��Lancer��6%   $��Center=�66   $	��Top=�6S   $��20, 0, 20, 0q�6k   $��	0,450,0,0q�6�   $��44��6�   $��30(�6�   $
��Bold"�6�   
����������	#FF778574
�������6  �� 5   
   -   5         ��Name$ BoxNom��5      $
��Left=�6"   $��43��6=   $��
92,402,0,0q�6I   	 �� TextWrapping$
	 Wrap=�6]   $	��Nom��6q   $	��Top=�6|   $	��250��6�   
 �� TextAlignment$
 Center=�6�   $��30(�6�   $y�Hidden=�6  �� 5   
   -   5         ��Name$ 
LabelFaire��5      $ ��Entrez le nom du champion ��6$   $
��Left=�6I   $��121,367,0,0q�6d   $	��Top=�6y   $��35��6�   $	��250��6�   $��15(�6�   $y�Hidden=�6�   �� 5   
   -   5        $ bouttonVerif��5      $��	Véfifier��6'   $
��Left=�6:   $��44��6U   $��316,450,0,0q�6a   $	��Top=�6v   $	��104��6�   $��20(�6�   $
��Bold"�6�   $y�Hidden=�6�   �� 5   
   -   5        $��Quitter��5      $
��Left=�6#   $��37��6>   $��
10,523,0,0q�6J   $	��Top=�6^   $	��125��6v   
����������	#FFCE3838$��15(�6�   $
��Bold"�6�   6�   �� 5   
   -	   5        $ NbPoints��5      $��Points : --��6"   $
��Left=�68   $��34��6S   $��
316,10,0,0q�6_   $	��Top=�6s   $	��117��6�   ���	#FFF17B67$��19(�6�   �� 5   
   -
   5        $ NumQuestion��5      $��	N°--/159��6%   $
��Left=�68   $��34��6S   $��	18,10,0,0q�6_   $	��Top=�6r   $	��117��6�   ���	#FFF17B67$��19(�6�   �� 5   
   -   5        $ Answer��5      $��Label��6    $��Center=�60   $��	0,306,0,0q�6M   $	��Top=�6`   $	��450��6x   $��Center=�6�   $��22(�6�   $��Center=�6�   $
��Bold"�6�   5      5      