   M S B A M L   `   `   `  ����D  @JumpBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:JumpBoard	JumpBoard  5          JumpBoard.Start   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:JumpBoard     5        N� Title$  Start��5	      .��5      � -   5         �Name$ MainGrid��5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ WelcomeTextBlock��5      $��Center=�6.   $��Welcome!��6K   $
��Wrap=�6[   $��Center=�6o   $��36(�6�   $��1��6�   �� 5   
   -   5        $  OutputInstructionTextBlock��5      $��1��68   $��Center=�6H   $��1��6e   $$��Start by choosing the outputs:��6r   $
��Wrap=�6�   $	��Top=�6�   $��14(�6�   �� 5   
   -   5         ��Name$ FirstOutputComboBox��5      $��1��60   $��Center=�6@   $��0,50,0,0q�6]   $��1��6o   $	��Top=�6|   $	��192��6�    �� SelectedIndex$ 0��6�   .@�5      �� $��<None>��6   5      �� 5   
   -   5        $ SecondOutputComboBox��5      $��1��61   $��Center=�6A   $��0,97,0,0q�6^   $��1��6p   $	��Top=�6}   $	��192��6�   $ 0��6�   .@�5      �� $��<None>��6   5      �� 5   
   -   5         ��Name$ ConfirmButton��5      $��Get Started!��6(   $��1��6?   $��Center=�6O   $��2��6l   $	��Top=�6y   $��20(�6�   $��0,10,0,0q�6�   $	��132��6�   6�   �� 5    
   -   5        $ FirstOutputTextBlock��5       $
��Left=�62   $��
173,53,0,0q�6M   $��1��6a   $��First Output:��6n   $
��Wrap=�6�   $	��Top=�6�   �� 5!   
   -   5        $ SecondOutputTextBlock��5!      $
��Left=�63   $��173,100,0,0q�6N   $��1��6c   $��Second Output:��6p   $
��Wrap=�6�   $	��Top=�6�   5"      5#      