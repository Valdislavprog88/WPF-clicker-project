   M S B A M L   `   `   `  ����B  >Clicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ClickerClicker  5   	       Clicker.Levels   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Clicker     5   	     � Title$  Levels��5   	   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61   $��734.5��6V   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��17* �6   �� 5      $��8* �6    � RowDefinitions 5   
   �� 5      $	��49* �6   �� 5      $	��66* �6   �� 5      $
��195* �6   �� 5      $
��124* �6   .+�5   
   �� $��91,10,271,2q�6   $
��Wrap=�6)   $��Уровни:��6=   $��36(�6L   $��	CocoBikeR)�6Z   $��1��6q   �� 5   
   -   5         ��Name$ LBlevels��5      $��
57,21,0,12q�6$   $��2��68   $
��Left=�6E   $	��175��6`   .@�5      	� -   5         	�Name$ RBlevel1��5      $��Уровень 1��6,    	� 	GroupName$ levels��6@   $��24(�6S    d� 	IsChecked$
 TrueY�6a   	� 5      -   5        $ RBlevel2��5      $��Уровень 2��6,   $ levels��6@   $��24(�6S   {�.  6a   5      �� 5   
   -   5         ��Name$ enterLevelBtn��5      $��Начать игру!��6(   $��	57,0,0,58q�6?   $��3��6n   $
��Left=�6{   $	��216��6�   $��45��6�   $��Bottom=�6�   �� 5   
   -   5        $ LBlevels_progress��5      $��237,21,0,12q�6-   $��2��6B   $
��Left=�6O   $	��147��6j   .@�5      � -   5        	 �Name$	 level1Progress��5      $��30��62   $	��114��6>   
 � Orientation$
 
Horizontal=�6i   ��5      �� 5       �� EndPoint$	 1,0&�6*    �� 
StartPoint$	 0,0&�69   .��5      �  � Color$ 	#FF0080BF��6'    � Offset$ 1Q�69   � 5      $ 	LimeGreen��6'   $ 0Q�69   5       5"      � 5#      -   5        $	 level2Progress��5#      $��30��62   $	��114��6>    � Maximum$	 400Q�6J   ��5$      �� 5%      $	 1,0&�6+   $	 0,0&�6:   .��5&      � $ 	#FFFE5F75��6'   � 5'      $ 	#FFFC9842��6'   $ 1Q�69   5(      5*      5+      �� 5,   
   -   5        $ LBlevels_text_progress��5,      $��389,21,26,12q�62   $��2��6H   .@�5-      �� -	   5         ��Name$ textLevel1Progress��5-      $��31��64   $
��Wrap=�6@   $��0/100��6T   $��92��6a   $��16(�6l   6z   �� 5.      -
   5        $ textLevel2Progress��5.      $��31��64   $
��Wrap=�6@   $��0/400��6T   $��92��6a   $��16(�6l    �� TextAlignment$
 Left=�6z   6�   50      �� 51   
   -   5         ��Name$ balanceLabel��51      $��Баланс: ��6&   $
��Left=�69   $��36��6T   $��	32,19,0,0q�6`   $	��Top=�6s   $	��214��6�   $��20(�6�   $��1��6�   $��1��6�   $
��Bold"�6�      Clicker.questionSignal  52   
   $
��Left=�6   $��	57,19,0,0q�6:   $��29��6M    � ToolTip$p jЧтобы выбрать серые уровни - надо пройти уровни перед ними��6X   $��1��6�   $��28��6�   $	��Top=�6�   �� 53   
   $
��Left=�6   $��37��6+   $��	21,20,0,0q�67   $	��Top=�6J   $��35��6b   $��2��6m   �� 54   
   -   5         ��Name$ 
backToMenu��54      $
��Left=�6$   $��38��6?   $��	10,10,0,0q�6K   $	��Top=�6^   $��39��6v   $!��/Resources/img/left (1).png��6�   $��UniformToFill=�6�   6�   56      57      