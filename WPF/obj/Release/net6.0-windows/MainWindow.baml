   M S B A M L   `   `   `  ���� >  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf     WPF.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     #localclr-namespace:WPF     Dlve4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf       � Title$  
MainWindow��$	��640��$	��960�� � DataContext    WPF.TaskViewModel  .����  �� Orientation$ Vertical=�
�������.+�#  LiveCharts.Wpf.CartesianChart  $	��240��&   LiveCharts.Wpf.Charts.Base.Chart   Series �� *SeriesCollection+   AxisX   LiveCharts.Wpf.Axis     Title$  ��   Labels �� *ChartLabels+   AxisY   $  �� �� *
YFormatter+� .+��� $��Center=�$��0,17,0,0q�$
��Wrap=�$	��Top=�$	��940���� $���Компания производит технические устройства, переменные затраты на которые составляют                         от цены продукции, а постоянные затраты -                       рублей. Цена продукции составляет                        рублей за единицу. Компания планирует получить прибыль в		           рублей���� $��� общий объём производства составляет                          единиц(а/ы) продукции в месяц���� -    ��Name$ variableCosts_have��$
��Left=�$��
524,17,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$��71������ *VariableCostsPercantage_have+
 �� Mode$
 TwoWay=��� -   $ fixedCosts_have��$
��Left=�$��
849,17,0,0q�$
	 Wrap=�$	��Top=�$��71������ *
FixedCosts+$
 TwoWay=��� -   $ productPrice_have��$
��Left=�$��
208,33,0,0q�$
	 Wrap=�$	��Top=�$��71������ *ProductPrice+$
 TwoWay=��� -   $ desiredProfit_have��$
��Left=�$��
630,33,0,0q�$
	 Wrap=�$	��Top=�$��71������ *DesiredProfit_have+$
 TwoWay=��� -   $ desiredProfit_have1��$
��Left=�$��	69,50,0,0q�$
	 Wrap=�$	��Top=�$��71������ *VolumeOfProduction+$
 TwoWay=��� -    ��Name$  DesiredProfitPercantage_LB��$#��Желаемый доход %��$
��Left=�$��
20,130,0,0q�$	��Top=��� -   $ desiredProfitPercantage��$
��Left=�$��165,135,0,0q�$
	 Wrap=�$	��Top=�$��71������ *DesiredProfitPercantage+$
 TwoWay=��� -   $ productPrice_Copy1��$
��Left=�$��165,165,0,0q�$
	 Wrap=�$	��Top=�$��71������ *
SellVolume+$
 OneWay=��� -	   $ productPrice_Copy2��$
��Left=�$��165,195,0,0q�$
	 Wrap=�$	��Top=�$��71������ *SellSummary+$
 OneWay=��� -
   $ productPrice_Copy3��$
��Left=�$��165,225,0,0q�$
	 Wrap=�$	��Top=�$��71������ *Profit+$
 OneWay=��� -   $ productPrice_Copy4��$
��Left=�$��165,255,0,0q�$
	 Wrap=�$	��Top=�$��71������ *	CostPrice+$
 OneWay=��� -   $ productPrice_Copy5��$
��Left=�$��518,135,0,0q�$
	 Wrap=�$	��Top=�$��72������ *ProductPrice_search+$
 OneWay=��� -   $ productPrice_Copy6��$
��Left=�$��518,165,0,0q�$
	 Wrap=�$	��Top=�$��71������ *QuantityPoint+$
 OneWay=��� -   $ productPrice_Copy7��$
��Left=�$��518,195,0,0q�$
	 Wrap=�$	��Top=�$��71������ *
MoneyPoint+$
 OneWay=��� -   $ productPrice_Copy8��$
��Left=�$��518,225,0,0q�$
	 Wrap=�$	��Top=�$��71������ *VariableCosts+$
 OneWay=��� -   $ productPrice_Copy9��$
��Left=�$��518,255,0,0q�$
	 Wrap=�$	��Top=�$��70������ *VariableCostsPercantage+$
 TwoWay=��� $��Объём продаж��$
��Left=�$��
20,160,0,0q�$	��Top=��� $��Сумма продаж��$
��Left=�$��
20,190,0,0q�$	��Top=��� $��Прибыль��$
��Left=�$��
20,220,0,0q�$	��Top=��� $ ��Себестоимость��$
��Left=�$��
20,250,0,0q�$	��Top=��� $!��Цена продукции��$
��Left=�$��345,130,0,0q�$	��Top=��� $:��4Безубыточность в количестве��$
��Left=�$��345,160,0,0q�$	��Top=��� $4��.Безубыточность в деньгах��$
��Left=�$��345,190,0,0q�$	��Top=��� $)��#Переменные затраты��$
��Left=�$��346,220,0,0q�$	��Top=��� $+��%Переменные затраты %��$
��Left=�$��345,250,0,0q�$	��Top=��� $��Создать отчёт��$
��Left=�$��347,316,0,0q�$	��Top=����� *RecCom+