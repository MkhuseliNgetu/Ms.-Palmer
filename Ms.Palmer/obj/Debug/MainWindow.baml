   M S B A M L   `   `   `  ����D  @Ms.Palmer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Ms.Palmer	Ms.Palmer  5   	       Ms.Palmer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Ms.Palmer     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � Icon$ Icon.png��65    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5         �Name$ 
Background��5      
���   �.+�5   
   ��  �� CornerRadius$ 15��6   5      �� 5   
   -   5         ��Name$
 Logo��5      $
��Left=�6   $	��156��69   $��
194,10,0,0q�6F   $	��Top=�6Z   $	��432��6r   $*��$Ms. Palmer (Logo Version 3 Dark).png��6~   �� 5   
   -   5         ��Name$ VirtualizationStatus��5      $��(Virtualization Status)��6.   $��98,208,417,324q�6P   $��Arial)�6�   $��16(�6�   $
��Bold"�6�   
�������$��Center=�6�   $��Center=�6  &   System.Windows.Media.TextOptions	   TextHintingMode$	 Animated=�6%  �� 5   
   -   5        $ HyperVisorStatus��5      $��(Hypervisor Status)��6*   $��406,190,80,306q�6H   $��Arial)�6�   $��16(�6�   $
��Bold"�6�   
�������$��Center=�6�   $��Center=�6�   �� 5   
   -   5        
 ��Name$
 
UseCaseOne��5      $�� ��6%   $
��Left=�60   $��135,299,0,0q�6K   $	��Top=�6`   $	��211��6x   $��91��6�   ��5      �� 5       �� ImageSource$  UseCaseOne (Version 2).png��6    j� Stretch$ Uniform=�6F    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 15��65   5      5      5       �� 5!   
   -   5        $
 
UseCaseTwo��5!      $�� ��6%   $
��Left=�60   $��441,299,0,0q�6K   $	��Top=�6`   $	��232��6x   $��91��6�   ��5"      �� 5#      $  UseCaseTwo (Version 2).png��6   $ Uniform=�6F    5%      ��%_   '��       �� 5&      " ��6   .�5'      ��  �@��CornerRadius$ 15��65   5(      5)      5*      �� 5+   
   -   5        $
 UseCaseThree��5+      $�� ��6'   $
��Left=�62   $��135,420,0,0q�6M   $	��Top=�6b   $	��211��6z   $��91��6�   ��5,      �� 5-      $" UseCaseThree (Version 2).png��6   $ Uniform=�6H    5/      ��%_   '��       �� 50      " ��6   .�51      ��  �@��CornerRadius$ 15��65   52      53      54      �� 55   
   -   5        $
 UseCaseFour��55      $�� ��6&   $
��Left=�61   $��441,420,0,0q�6L   $	��Top=�6a   $	��226��6y   $��91��6�    J� RenderTransformOrigin$ 0.209,0.557&�6�   ��56      �� 57      $! UseCaseFour (Version 2).png��6   $ Uniform=�6G    59      ��%_   '��       �� 5:      " ��6   .�5;      ��  �@��CornerRadius$ 15��65   5<      5=      5>      5A      5B      