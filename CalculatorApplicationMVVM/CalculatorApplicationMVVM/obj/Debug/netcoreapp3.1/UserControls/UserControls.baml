   M S B A M L   `   `   `  ����T  PCalculatorApplicationMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:CalculatorApplicationMVVM.UserControls&CalculatorApplicationMVVM.UserControls  5      Y1clr-namespace:CalculatorApplicationMVVM.ViewModel#CalculatorApplicationMVVM.ViewModel  5      9    3CalculatorApplicationMVVM.UserControls.UserControls   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:CalculatorApplicationMVVM.UserControls     5      Dlocal11clr-namespace:CalculatorApplicationMVVM.ViewModel     5      .��5      �   � ColumnDefinitions  5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $
��btn7��5      $��2��6   $��0��6*   ��6:   ��  �� Path$ Button7Command�.��6c   76f   �� 5   
   -   5        $
��btn8��5      $��2��6   $��1��6*   ��6:   �� $ Button8Command�.��6c   86f   �� 5   
   -   5        $
��btn9��5      $��2��6   $��2��6*   ��6:   �� $ Button9Command�.��6c   96f   �� 5   
   -   5        $
��btn4��5      $��3��6   $��0��6*   ��6:   �� $ Button4Command�.��6c   46f   �� 5    
   -   5        $
��btn5��5       $��3��6   $��1��6*   ��6:   �� $ Button5Command�.��6c   56f   �� 5!   
   -   5        $
��btn6��5!      $��3��6   $��2��6*   ��6:   �� $ Button6Command�.��6c   66f   �� 5#   
   -   5        $
��btn1��5#      $��4��6   $��0��6*   ��6:   �� $ Button1Command�.��6c   16f   �� 5$   
   -   5        $
��btn2��5$      $��4��6   $��1��6*   ��6:   �� $ Button2Command�.��6c   26f   �� 5%   
   -	   5        $
��btn3��5%      $��4��6   $��2��6*   ��6:   �� $ Button3Command�.��6c   36f   �� 5'   
   -
   5        $
��btn0��5'      $��5��6   $��1��6*   ��6:   �� $ Button0Command�.��6c   06f   �� 5*   
   -   5        $��btnPlus��5*      $��2��6    $��3��6-   ��6=   �� $ 
AddCommand�.��6b   +6e   �� 5+   
   -   5        $��btnMinus��5+      $��3��6!   $��3��6.   ��6>   �� $ 
SubCommand�.��6c   -6f   �� 5,   
   -   5        $��btnMultiply��5,      $��4��6$   $��3��61   ��6A   �� $ 
MulCommand�.��6g   *6j   �� 5-   
   -   5        $��	btnDivide��5-      $��4��6"   $��3��6/   $��Center=�6d   $��0,69,0,0q�6�   $��2��6�   $	��199��6�   ��6?   �� $ 
DivCommand�.��6�   /6�   �� 5.   
   -   5        $��btnEqual��5.      $��6��6!   $��2��6.   ��6>   �� $ EqualCommand�.��6e   =6h   �� 51   
   -   5        $��btnCE��51      $��1��6   $��0��6+   ��6;   �� $ 
CE_Command�.��6`   CE6d   �� 52   
   -   5        $
��btnC��52      $��1��6   $��1��6*   ��6;   �� $ 	C_Command�.��6_   C6b   �� 53   
   -   5        $��BackspaceButton��53      $��1��6(   $��2��6e   $��<=��6u   ��6;   �� $ BackSpaceCommand�6�   55      56      