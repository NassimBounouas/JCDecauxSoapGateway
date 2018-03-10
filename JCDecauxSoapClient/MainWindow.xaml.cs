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

        private void TextBox_Initialized(object sender, EventArgs e)
        {
            SoapGatewayClient gateway = new SoapGatewayClient();
            CompositeType com = new CompositeType();
            com.StringValue = "Nassim";
            com.BoolValue = true;
            

            CompositeType compo = gateway.GetDataUsingDataContract(com);
            Console.WriteLine(compo.StringValue);
            ((TextBox)sender).Text = gateway.GetStations("wawa");
            gateway.Close();
        }
    }
}
