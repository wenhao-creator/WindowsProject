   M S B A M L   `   `   `  ����I  EWindowsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WindowsProjectWindowsProject  5   	       WindowsProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WindowsProject     5   	   -   5        $��WindowClose��5   	     � Title$  Window关机小程序��5	   	   $	��450��5
   	   $	��800��6   $��Center=�6"   ���	#FF595959 � 
ResizeMode$ CanMinimize=�5   	    � Topmost .  � WindowStartupLocation$ CenterScreen=�5   	    J� Opacity$	 0.4Q�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � Icon$ iocn.ico��6   ��5   	   Z� .��5      � .+�5   
   � 
�������.+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   $	��Top=�6>   $��Right=�6V   .+�5      �� -   5        ���	#FF4456C5$��22(�5   s   ��6/   Z� ��6E   Z� .��6�   	最小化6�   5      5      �� 5   
   -   5        $��Label1��5      $	 0.9Q�6   $��Oblique$�6.   $��50(�6B   $��关机倒计时 999 秒��6P   $
��Left=�6f   $��
218,61,0,0q�6�   $	��Top=�6�   ���	#FFF32F536�   �� 5   
   -   5        $��Button1��5      $	 0.9Q�6!   $	��220��60   $��80��6<   $��50(�5      $��Normal$�5      $��92,266,440,73q�6$   ��5!      �� 5"      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5#      �  � Color$ 	#FF83DEE2��6#    � Offset$ 0Q�65   $��RightToLeft=�6@   � 5$      $ 	#FFD9F6F7��6#   $ 1Q�65   $��RightToLeft=�6@   5%      .��5'      �� ���	#FF558FF4$	��220��6+   .��67   立即关机6=   5(      �� 5)   
   -   5        $��Button2��5)      $	 0.9Q�6!   $	��220��6/   $��80��6;   $��50(�5*      $��Normal$�5+      $��464,266,68,73q�6$   ��5-      �� 5.      $	 0.5,1&�6&   $
 0.5,0&�67   .��5/      � $ 	#FF04F5B4��6#   $ 0Q�65   $��RightToLeft=�6@   � 50      $ 	#FFC5ECE1��6#   $ 1Q�65   $��RightToLeft=�6@   51      .��53      �� ���	#FFF65B4B$	��220��6+   .��67   取消关机6=   54      56      57      