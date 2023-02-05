using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для CurrentConditionDisplay.xaml
    /// </summary>
    public partial class CurrentConditionDisplay : Window, Observer
    {
        public Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            InitializeComponent();
            this.weatherData = weatherData;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            weatherData.registerObserver(this);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            weatherData.removeObserver(this);
        }



        public void update(float temp, float humadity, float pressure)
        {
            ContTemp.Content = temp.ToString();
            ContPress.Content = humadity.ToString();
            ContHum.Content = pressure.ToString();
        }
    }
}
