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

namespace auto1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vehicle auto1;
        Vehicle auto2;

        public MainWindow()
        {
            InitializeComponent();
            auto1 = new Vehicle("Škoda");            
            auto1.Type = "Osobní auto";
            ShowVehicle(auto1, txt1); 
            auto2 = new Vehicle("WM");            
            auto2.Type = "Dodávka";
            ShowVehicle(auto2, txt2);
        }

        public void ShowVehicle(Vehicle vehicle, TextBox textBox)
        {
            textBox.Text = $"brand: { vehicle.Brand}\n";
            textBox.Text += $"Type: {vehicle.Type}\n";
            textBox.Text += $"Fuel: {vehicle.Fuel}\n";
            textBox.Text += $"EngineVolume: {vehicle.EngineVolume}\n";
            textBox.Text += $"FuelLevel: {vehicle.FuelLevel}\n";
            textBox.Text += $"Distance: {vehicle.Distance}\n";
            textBox.Text += $"PneuState: {Math.Round(vehicle.PneuState,2)}\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            auto1.Move();
            auto2.Move();
            ShowVehicle(auto1, txt1);
            ShowVehicle(auto2, txt2);
        }
    }
}
