using formulas;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using FastReport;
using FastReport.Export.Image;
using FastReport.Export.PdfSimple;
using System.IO;
using System.Diagnostics;

namespace WPF
{
    public class TaskViewModel : ReactiveObject
    {
        public TaskViewModel()
        {
            this.WhenAnyValue(vm => vm.ProductPrice_search, 
                vm => vm.VariableCosts, 
                vm => vm.SellVolume, 
                vm => vm.SellSummary, 
                vm => vm.QuantityPoint,
                vm => vm.MoneyPoint,
                vm => vm.Profit
                ).Subscribe(value =>
            {
                SeriesCollection = new SeriesCollection {
                new ColumnSeries
                {
                    Title = "Цена продукции в рублях",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item1 }.AsChartValues(),
                    DataLabels = true
                },
                new ColumnSeries
                {
                    Title = "Переменные затраты в рублях",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item2 }.AsChartValues(),
                    DataLabels = true
                },
                new ColumnSeries
                {
                    Title = "Объём продаж",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item3 }.AsChartValues(),
                    DataLabels = true
                },
                new ColumnSeries
                {
                    Title = "Сумма продаж в рублях",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item4 }.AsChartValues(),
                    DataLabels = true
                },
                new ColumnSeries
                {
                    Title = "Безубыточность в количестве",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item5 }.AsChartValues(),
                    DataLabels = true
                },
                new ColumnSeries
                {
                    Title = "Безубыточность в рублях",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item6 }.AsChartValues(),
                    DataLabels = true
                },
                new ColumnSeries
                {
                    Title = "Прибыль в рублях",
                    PointGeometry = DefaultGeometries.Circle,
                    Values = new List<double> { value.Item7 }.AsChartValues(),
                    DataLabels = true
                }
            };
            });

            RecCom = ReactiveCommand.Create(PDFLoad);

        }
        public List<string> ChartLabels { get; set; } = new List<string> { "Сводка нужных критерий производства" };
        
        public Func<double, string> YFormatter { get; set; } = number => number.ToString();

        private double _productPrice = 5000;

        public double ProductPrice
        {
            get => _productPrice;
            set
            {
                this.RaiseAndSetIfChanged(ref _productPrice, value);
                this.RaisePropertyChanged(nameof(DesiredProfitPercantage));
                this.RaisePropertyChanged(nameof(SellVolume));
                this.RaisePropertyChanged(nameof(SellSummary));
                this.RaisePropertyChanged(nameof(VariableCostsPercantage));
                this.RaisePropertyChanged(nameof(VariableCosts));
                this.RaisePropertyChanged(nameof(CostPrice));
                this.RaisePropertyChanged(nameof(QuantityPoint));
                this.RaisePropertyChanged(nameof(MoneyPoint));
            }
        }

      
        private double _variableCostsPercantage_have = 30;

        public double VariableCostsPercantage_have
        {
            get => _variableCostsPercantage_have;
            set
            {
                this.RaiseAndSetIfChanged(ref _variableCostsPercantage_have, value);
                this.RaisePropertyChanged(nameof(VariableCosts));
                this.RaisePropertyChanged(nameof(CostPrice));
                this.RaisePropertyChanged(nameof(ProductPrice_search));
                this.RaisePropertyChanged(nameof(QuantityPoint));
                this.RaisePropertyChanged(nameof(MoneyPoint));
            }
        }
        private double _fixedCosts = 80000;

        public double FixedCosts
        {
            get => _fixedCosts;
            set
            {
                this.RaiseAndSetIfChanged(ref _fixedCosts, value);
                this.RaisePropertyChanged(nameof(SellVolume));
                this.RaisePropertyChanged(nameof(CostPrice));
                this.RaisePropertyChanged(nameof(ProductPrice_search));
                this.RaisePropertyChanged(nameof(QuantityPoint));
                this.RaisePropertyChanged(nameof(MoneyPoint));
            }
        }

        private double _desiredProfit_have = 800000;

        public double DesiredProfit_have
        {
            get => _desiredProfit_have;
            set
            {
                this.RaiseAndSetIfChanged(ref _desiredProfit_have, value);
                this.RaisePropertyChanged(nameof(SellVolume));
                this.RaisePropertyChanged(nameof(SellSummary));
                this.RaisePropertyChanged(nameof(DesiredProfitPercantage));
                this.RaisePropertyChanged(nameof(ProductPrice_search));
            }
        }

        private double _volumeOfProduction = 1500;

        public double VolumeOfProduction
        {
            get => _volumeOfProduction;
            set
            {
                this.RaiseAndSetIfChanged(ref _volumeOfProduction, value);
                this.RaisePropertyChanged(nameof(CostPrice));
                this.RaisePropertyChanged(nameof(ProductPrice_search));
            }
        }
        public double DesiredProfitPercantage
        {
            get => Math.Round(Formulas.DesiredProfitPercantage(DesiredProfit_have, ProductPrice), 3);
            set
            {
            }
        }

        public double SellVolume
        {
            get => Math.Round(Formulas.SellVolume(FixedCosts, DesiredProfit_have, ProductPrice, VariableCosts), 0);

            set
            {
            }
        }

        public double SellSummary
        {
            get => Math.Round(Formulas.SellSummary(ProductPrice, SellVolume), 3);
        }
        public double VariableCosts
        {
            get => Math.Round(Formulas.VariableCosts(ProductPrice, VariableCostsPercantage_have), 3);
        }
        public double VariableCostsPercantage
        {
            get => Math.Round(Formulas.VariableCostsPercantage(ProductPrice, VariableCosts), 3);
            set { }
        }

        public double Profit
        {
            get => Math.Round(Formulas.Profit(ProductPrice, VariableCosts, SellVolume, FixedCosts), 3);
        }

        public double CostPrice
        {
            get => Math.Round(Formulas.CostPrice(VariableCosts, FixedCosts, VolumeOfProduction), 3);
        }

        public double ProductPrice_search
        {
            get => Math.Round(Formulas.ProductPrice(CostPrice, DesiredProfitPercantage), 3);
        }

        public double QuantityPoint
        {
            get => Math.Round(Formulas.QuantityPoint(FixedCosts, ProductPrice, VariableCosts), 0);
        }

        public double MoneyPoint
        {
            get => Math.Round(Formulas.MoneyPoint(ProductPrice, QuantityPoint), 3);
        }


        private SeriesCollection _seriesCollection;
        public SeriesCollection SeriesCollection
        {
            get => _seriesCollection;
            set => this.RaiseAndSetIfChanged(ref _seriesCollection, value);
        }

        
        
        public ReactiveCommand<Unit, Unit> RecCom { get; }
        private void PDFLoad()
        {
            List<Data> Dataa = new();
            Dataa.Add(new Data { Name = "Желаемый доход %", Value = DesiredProfitPercantage });
            Dataa.Add(new Data { Name = "Объём продаж", Value = SellVolume });
            Dataa.Add(new Data { Name = "Сумма продаж", Value = SellSummary });
            Dataa.Add(new Data { Name = "Прибыль", Value = Profit });
            Dataa.Add(new Data { Name = "Себестоимость производства", Value = CostPrice });
            Dataa.Add(new Data { Name = "Цена продукции", Value = ProductPrice });
            Dataa.Add(new Data { Name = "Безубыточность в количестве", Value = QuantityPoint});
            Dataa.Add(new Data { Name = "Безубыточность в деньгах", Value = MoneyPoint});
            Dataa.Add(new Data { Name = "Переменные затраты", Value = VariableCosts });
            Dataa.Add(new Data { Name = "Переменные затраты %", Value = VariableCostsPercantage });
            Report report = new();
            report.Load("Table.frx");
            report.RegisterData(Dataa, "Data");
            report.Prepare();

            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appDataFullPath = Path.GetFullPath(appDataPath);

            if (!Directory.Exists($"{appDataFullPath}/Reports"))
            {
                Directory.CreateDirectory($"{appDataFullPath}/Reports");
            }

            report.SavePrepared($"{appDataFullPath}/Reports/Prepared_Table.fpx");

            ImageExport image = new();
            image.ImageFormat = ImageExportFormat.Jpeg;
            report.Export(image, $"{appDataFullPath}/Reports/report.jpg");

            PDFSimpleExport pdfExport = new();

            pdfExport.Export(report, $"{appDataFullPath}/Reports/report.pdf");
            report.Dispose();

        }
        
    }
}
