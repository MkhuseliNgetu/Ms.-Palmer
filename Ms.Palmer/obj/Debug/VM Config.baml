   M S B A M L   `   `   `  ����D  @Ms.Palmer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Ms.Palmer	Ms.Palmer  5   	       Ms.Palmer.VM_Config   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Ms.Palmer     5   	     � Title$  	VM_Config��5   	   $	��800��6   $	��800��6(    � Icon$ Icon.png��64    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      � -   5         �Name$ 
Background��5      
���   �.+�5   
   ��  �� CornerRadius$ 15��6   $��
0,10,0,-10q�6#   5      �� 5   
   $��Select a operating system��6   $��274,100,236,634q�64   
�������$��Center=�6`   $��Center=�6�   $��Arial)�6�   $
��Bold"�6�   $��16(�6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�6�   �� 5   
   -   5         ��Name$ SuggestedVMConfigView��5      $��21,166,526,448q�62   
���   �
���   �
�������	 �� View	 5      �� 5      .P�5      �� 5      5      �� 5    
   -   5        
 ��Name$
 ISOPathQuery��5       $��ISO Path��6&   $
��Left=�69   $��44��6T   $��318,198,0,0q�6`   $	��Top=�6u   $	��206��6�   
�������$��Arial)�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��16(�6  �� 5!   
   -   5         ��Name$ ISOPath��5!       �� TextWrapping$
 Wrap=�6#   $��290,230,252,536q�67   $��Arial)�6P   $��Center=�6c   $��Center=�6�   $��16(�6�   $��Italic$�6�   6�   �� 5"   
   -   5         ��Name$ ConfirmISOButton��5"      $�� ��6+   $��562,220,188,536q�66   $��Arial)�6O   $��16(�6b   $
��Bold"�6p    J� RenderTransformOrigin$ 
0.06,0.545&�6�   ��5#      �� 5$       �� ImageSource$ ConfimButton.png��6    � 	Resources 5&       �� 
TargetType �� Property �� Value��%_   '��       �� 5'      " ��6   .�5(      ��  �@��CornerRadius$ 15��65   5)      5*      5+      �� 5,   
   -   5         ��Name$ OperatingSystemType��5,      $��290,166,252,602q�60   $
��Bold"�6m   $��Arial)�6   $��16(�6�   $ Fixed=�6�   $��Center=�6�   $��Center=�6�   $��1q�6
  ��5-      �� 5.       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5/      �  � Color$ 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 50      $ White��6#   $ 1Q�61   51      53      �� 55   
   -   5         ��Name$
 Logo��55      $
��Left=�6   $��76��69   $��
318,24,0,0q�6E   $	��Top=�6Y   $	��208��6q   $*��$Ms. Palmer (Logo Version 3 Dark).png��6}   $ 0.347,0.018&�6�   �� 56   
   -   5        $ 
VMUsername��56      $
��Left=�6&   $��36��6A   $��290,378,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��258��6�   $ 0.5,0.5&�6�   $��Center=�6�   $��Center=�6�   $��Arial)�6  $��16(�6  $
��Bold"�6)  $��Oblique$�6;  $ Fixed=�6O  .��6s  z�57      V� 58      .~�59      �� �� 5:      �� 5;       �� Angle$ -0.348Q�6&   T� 5<      5=      .��5>   '   5?      G� 5@   
   -	   5         G�Name$ 
VMPassword��5@      $��290,455,252,307q�6*   $ Fixed=�6C    G� 	MaxLength$ 15��6g   4  .System.Windows.Automation.AutomationProperties   HelpText$ Enter a password��6v   $��Center=�6�   $��Center=�6�   	� 5A   
   -
   5         	�Name$ InstallGuestAdditions��5A      $��189,498,151,263q�65   $?��9Install VirtualBox Guest Additions (Improves Performance)��6N   $ Fixed=�6�   $
��Bold"�6�   $��16(�6�   
�������$��Center=�6�   $��Center=�6  �� 5B   
   -   5        $ OSKey��5B      $
��Left=�6!   $��41��6<   $��230,542,0,0q�6H   $
 Wrap=�6]   $)��#Enter a Window's License (Optional)��6q   $	��Top=�6�   $	��368��6�   $��Center=�6�   $��Center=�6�   $��Arial)�6  $
��Bold"�6  $��16(�6+  $��Italic$�69  �� 5C   
   -   5        $ DeployVM��5C      $�� ��6#   $
��Left=�6.   $��274,714,0,0q�6I   $	��Top=�6^   $	��274��6v   $��76��6�   $ 0.533,0.974&�6�   ��5D      �� 5E      $, &Deploy Virtual Machine ImageButton.png��6    5G      ��%_   '��       �� 5H      " ��6   .�5I      ��  �@��CornerRadius$ 15��65   5J      5K      5L      �� 5M   
   -   5        $ VMSize��5M      $
��Left=�6#   $��290,301,0,0q�6>   $	��Top=�6S   $	��258��6k   $��36��6w   $
��Bold"�6�   $��Arial)�6�   $��18(�6�   $ Fixed=�6�   $��Center=�6�   $��Center=�6  �� 5N   
   $�� Virtual Machine Size��6   $��318,264,276,499q�60   
�������$��Center=�6\   $��Center=�6�   $��Arial)�6�   $
��Bold"�6�   $��16(�6�   $ Fixed=�6�   �� 5O   
   $��Enter a username��6   $��274,337,236,419q�6+   
�������$��Center=�6W   $��Center=�6{   $��Arial)�6�   $
��Bold"�6�   $��16(�6�   $ Fixed=�6�   �� 5P   
   $��Enter a password��6   $��274,413,236,345q�6+   
�������$��Center=�6W   $��Center=�6{   $��Arial)�6�   $
��Bold"�6�   $��16(�6�   $ Fixed=�6�   $ 0.498,-0.619&�6�   5S      5T      