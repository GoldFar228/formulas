   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	       WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	   Dlve4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	     � Title$  
MainWindow��5	   	   $	��640��6   $	��960��6)    � DataContext 5         WPF.TaskViewModel  5   
   .��5      ��  �� Orientation$ Vertical=�6   
�������.+�5   
   #  LiveCharts.Wpf.CartesianChart  $	��240��6A   &   LiveCharts.Wpf.Charts.Base.Chart   Series 6   �� *SeriesCollection+   AxisX 5        LiveCharts.Wpf.Axis     Title$  ��6      Labels 6$   �� *ChartLabels+   AxisY 5        $  ��6    6$   �� *
YFormatter+5      � 5   
   .+�5      �� $��Center=�6   $��0,17,0,0q�65   $
��Wrap=�6G   $	��Top=�6[   $	��940��6s   �� 6�   $���Компания производит технические устройства, переменные затраты на которые составляют                         от цены продукции, а постоянные затраты -                       рублей. Цена продукции составляет                        рублей за единицу. Компания планирует получить прибыль в		           рублей��6�   �� 6�  $��� общий объём производства составляет                          единиц(а/ы) продукции в месяц��6�  61  �� 5      -   5         ��Name$ variableCosts_have��5   �   $
��Left=�6   $��
524,17,0,0q�61   	 �� TextWrapping$
	 Wrap=�6E   $	��Top=�6�   $��71��6�   ��6Y   �� *VariableCostsPercantage_have+
 �� Mode$
 TwoWay=�6�   �� 5      -   5        $ fixedCosts_have��5   �   $
��Left=�6   $��
849,17,0,0q�61   $
	 Wrap=�6E   $	��Top=�6�   $��71��6�   ��6Y   �� *
FixedCosts+$
 TwoWay=�6�   �� 5      -   5        $ productPrice_have��5   �   $
��Left=�6   $��
208,33,0,0q�61   $
	 Wrap=�6E   $	��Top=�6�   $��71��6�   ��6Y   �� *ProductPrice+$
 TwoWay=�6�   �� 5      -   5        $ desiredProfit_have��5   �   $
��Left=�6   $��
630,33,0,0q�61   $
	 Wrap=�6E   $	��Top=�6�   $��71��6�   ��6Y   �� *DesiredProfit_have+$
 TwoWay=�6�   �� 5      -   5        $ desiredProfit_have1��5   �   $
��Left=�6   $��	69,50,0,0q�61   $
	 Wrap=�6D   $	��Top=�6�   $��71��6�   ��6X   �� *VolumeOfProduction+$
 TwoWay=�6�   �� 5       -   5         ��Name$  DesiredProfitPercantage_LB��5    v   $#��Желаемый доход %��6   $
��Left=�6/   $��
20,130,0,0q�6J   $	��Top=�6^   6v   �� 5!      -   5        $ desiredProfitPercantage��5!   �   $
��Left=�6   $��165,135,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *DesiredProfitPercantage+$
 TwoWay=�6�   �� 5"      -   5        $ productPrice_Copy1��5"   �   $
��Left=�6   $��165,165,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *
SellVolume+$
 OneWay=�6�   �� 5#      -	   5        $ productPrice_Copy2��5#   �   $
��Left=�6   $��165,195,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *SellSummary+$
 OneWay=�6�   �� 5$      -
   5        $ productPrice_Copy3��5$   �   $
��Left=�6   $��165,225,0,0q�61   $
	 Wrap=�6F   $	��Top=�6   $��71��6�   ��6Z   �� *Profit+$
 OneWay=�6�   �� 5%      -   5        $ productPrice_Copy4��5%   �   $
��Left=�6   $��165,255,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *	CostPrice+$
 OneWay=�6�   �� 5&      -   5        $ productPrice_Copy5��5&   �   $
��Left=�6   $��518,135,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��72��6�   ��6Z   �� *ProductPrice_search+$
 OneWay=�6�   �� 5'      -   5        $ productPrice_Copy6��5'   �   $
��Left=�6   $��518,165,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *QuantityPoint+$
 OneWay=�6�   �� 5(      -   5        $ productPrice_Copy7��5(   �   $
��Left=�6   $��518,195,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *
MoneyPoint+$
 OneWay=�6�   �� 5)      -   5        $ productPrice_Copy8��5)   �   $
��Left=�6   $��518,225,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��71��6�   ��6Z   �� *VariableCosts+$
 OneWay=�6�   �� 5*      -   5        $ productPrice_Copy9��5*   �   $
��Left=�6   $��518,255,0,0q�61   $
	 Wrap=�6F   $	��Top=�6�   $��70��6�   ��6Z   �� *VariableCostsPercantage+$
 TwoWay=�6�   �� 5+      $��Объём продаж��6   $
��Left=�6+   $��
20,160,0,0q�6F   $	��Top=�6Z   �� 5,      $��Сумма продаж��6   $
��Left=�6+   $��
20,190,0,0q�6F   $	��Top=�6Z   �� 5-      $��Прибыль��6   $
��Left=�6&   $��
20,220,0,0q�6A   $	��Top=�6U   �� 5.      $ ��Себестоимость��6   $
��Left=�6,   $��
20,250,0,0q�6G   $	��Top=�6[   �� 5/      $!��Цена продукции��6   $
��Left=�6-   $��345,130,0,0q�6H   $	��Top=�6]   �� 50      $:��4Безубыточность в количестве��6   $
��Left=�6:   $��345,160,0,0q�6U   $	��Top=�6j   �� 51      $4��.Безубыточность в деньгах��6   $
��Left=�67   $��345,190,0,0q�6R   $	��Top=�6g   �� 52      $)��#Переменные затраты��6   $
��Left=�61   $��346,220,0,0q�6L   $	��Top=�6a   �� 53      $+��%Переменные затраты %��6   $
��Left=�63   $��345,250,0,0q�6N   $	��Top=�6c   �� 54      $��Создать отчёт��6   $
��Left=�6-   $��347,316,0,0q�6H   $	��Top=�6]   ��6u   �� *RecCom+55      56      58      