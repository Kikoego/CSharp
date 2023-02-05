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
using System.Xml.Linq;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Stat.xaml
    /// </summary>
    public partial class Stat : Window, Observer
    {
        private float max_temp;
        private float min_temp;
        private float temp_sum;
        private float num_readings;



        
        public Stat(Subject weatherData)
        {
            InitializeComponent();
            max_temp = 200;
            min_temp = 200;
            temp_sum = 0;
            num_readings = 0;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            temp_sum += temperature;
            num_readings += 1;

            if (temperature > max_temp) max_temp = temperature;

            if (temperature < min_temp) min_temp = temperature;

            maxTempBox.Content = max_temp.ToString();
            minTempBox.Content = min_temp.ToString();
            averageTempBox.Content = temp_sum.ToString();

        }
    }
}
