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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Subject
    {
        List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public MainWindow()
        {
            InitializeComponent();
            observers = new List<Observer>(); ;
        }

        public void setupGUI()
        {
            CurrentConditionDisplay current = new CurrentConditionDisplay(this);
            current.Show();
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float t, float h, float p)
        {
            this.temperature = t;
            this.humidity = h;
            this.pressure = p;

            measurementsChanged();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setupGUI();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float temp = float.Parse(textBoxTemp.Text);
            float humidity = float.Parse(textBoxHum.Text);
            float pressure = float.Parse(textBoxPress.Text);

            setMeasurements(temp, humidity, pressure);
        }




    }
}
