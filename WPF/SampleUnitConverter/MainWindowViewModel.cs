using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel{
        
        private double metricValue;
        private double imperialValue;

        //▲ボタンで呼ばれるコマンド{ヤード単位からメートル単位}
        public ICommand ImperialUnitToMetric { get; private set; }

        //▼ボタンで呼ばれるコマンド{メートル単位からヤード単位}
        public ICommand MetricToImperialUnit { get; private set; }

        //上のComboboxで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }

        //下のComboboxで選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get { return this.metricValue; }
            set { 
                this.metricValue = value;
                this.OnPropertyChanged(); //viewへ通知
            }
        }

        public double ImperialValue {
            get { return this.imperialValue; }
            set { 
                this.imperialValue = value;
                this.OnPropertyChanged(); //viewへ通知
            }
        }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();

            this.MetricToImperialUnit =
                new DelegateCommand(
                    () => this.ImperialValue = 
                    this.CurrentImperialUnit.FromMetricUnit(this.CurrentMetricUnit,this.MetricValue));

            this.ImperialUnitToMetric =
                new DelegateCommand(
                    () => this.MetricValue =
                    this.CurrentMetricUnit.FromImperialUnit(this.CurrentImperialUnit,this.ImperialValue));
        }
    }
}
