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
using JCDecauxSoapClient.JCDecauxSoapGateway;

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

        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {

            SoapGatewayClient gateway = new SoapGatewayClient();
            Contract[] contracts = gateway.GetContracts();
            foreach (Contract contract in contracts)
            {
                ((ComboBox)sender).Items.Add(contract);
            }
            ((ComboBox)sender).SelectedIndex = 0;
            ((ComboBox)sender).DisplayMemberPath = "name";
            gateway.Close();
        }
    }
}
