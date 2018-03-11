using JCDecauxSoapClient.ServiceReference1;
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

namespace JCDecauxSoapClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBoxCities.SelectedIndex = 0;
            comboBoxStations.SelectedIndex = 0;
        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {
            
            SoapGatewayClient gateway = new SoapGatewayClient();        
            Contract[] contracts = gateway.GetContracts();
            foreach (Contract contract in contracts)
            {
                ((ComboBox)sender).Items.Add(contract);
            }
            ((ComboBox)sender).DisplayMemberPath = "name";
            gateway.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = ((Contract)((ComboBox)sender).SelectedItem).name;
            SoapGatewayClient gateway = new SoapGatewayClient();

            if(comboBoxStations != null)
            {
                comboBoxStations.Items.Clear();
                foreach (Station station in gateway.GetStations(((Contract)((ComboBox)sender).SelectedItem)))
                {
                    comboBoxStations.Items.Add(station);
                }
                comboBoxStations.DisplayMemberPath = "name";
                comboBoxStations.SelectedIndex = 0;
            }
            
            gateway.Close();
        }
    }
}
