   M S B A M L   `   `   `  ����G  CRPG_TODOLIST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RPG_TODOLISTRPG_TODOLIST  5   	   &     RPG_TODOLIST.AuthorizationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:RPG_TODOLIST     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AuthorizationWindow��5	   	   $	��333��6%   $	��549��62   .��5
      �� .+�5   
   �� $���Прежде чем приступить к работе, давайте создадим нового пользователя��6   $��48��6_   $	��477��6k    �� Left$ 52��6w   
 �� Top$ 10��6�   $
��Left=�6�   $	��Top=�6�   6�   �� 5   
   $��Ваше имя:��6   $	 158��6$   $ 83��66   $
��Left=�6F   $	��Top=�6a   �� 5   
   -   5        $��
userNameTB��5       J� RenderTransformOrigin$ 0.5,0.5&�6$   $	 116��6D   $	��138��6U   $	 123��6a   $��18��6s   $
��Left=�6   $	��Top=�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.155Q�6&   T� 5      5      .��5   '   5      �� 5   
   $	 355��6   $ 45��6%   $��Center=�65   $	��262��6R   $	��Top=�6_   $	��174��6w   $2��,Выберите фото персонажа��6�   .��5      �� $��	0,-31,0,0q�6   .+�5      	� -   5         d� 	IsChecked$
 TrueY�5      $
��Left=�6/   $ 47��6J   $	��Top=�6Z   $ 10��6�   $	��105��6�   .��5      �� $��/assets/beginner.png��6   $��63��6:   $ 65��6F   $��58��6W   5      	� 5      -   5        $��Center=�5      $	 184��6;   $	��Top=�6L   $ 10��6d   $��61��6u   $	��105��6�   .��5      �� $��/assets/girlmoment.png��6   $��42��6<   $ 65��6H   $��64��6Y   5      	� 5       -   5        $
��Left=�5       $	 114��69   $��Center=�6J   $��70��6�   $	��105��6�   $ 10��6�   .��5!      �� $��/assets/man1.png��6   $��40��66   $ 65��6B   $��60��6S   5"      5#      5$      �� 5&   
   -   5        $��67��5&   #   $��
Войти��6/   $	��115��6@   $	 134��6L   $	 159��6^   $
��Left=�6o   $	��Top=�6�   6�   5'      5(      