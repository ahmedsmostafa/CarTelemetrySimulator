using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Azure.Management.EventHub;
using Microsoft.Azure.Management.ServiceBus;
using Microsoft.Azure.EventHubs;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarTelemetrySimulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> VinList = new List<string>();

        public MainPage()
        {
            this.InitializeComponent();
            var resources = new Windows.ApplicationModel.Resources.ResourceLoader("azureResources");

            HighEngineTempProbabilityPowerTextBox.Text  = resources.GetString("HighEngineTempProbabilityPower");

            HighOilProbabilityPowerTextBox.Text = resources.GetString("HighOilProbabilityPower");

            HighOutsideTempProbabilityPowerTextBox.Text = resources.GetString("HighOutsideTempProbabilityPower");

            HighSpeedProbabilityPowerTextBox.Text = resources.GetString("HighSpeedProbabilityPower");

            HighTyrePressureProbabilityPowerTextBox.Text = resources.GetString("HighTyrePressureProbabilityPower");

            inputeventhubTextBox.Text = resources.GetString("inputeventhub");

            inputservicebusTextBox.Text = resources.GetString("inputservicebus");

            LowEngineTempProbabilityPowerTextBox.Text = resources.GetString("LowEngineTempProbabilityPower");

            LowOilProbabilityPowerTextBox.Text = resources.GetString("LowOilProbabilityPower");

            LowOutsideTempProbabilityPowerTextBox.Text = resources.GetString("LowOutsideTempProbabilityPower");

            LowSpeedProbabilityPowerTextBox.Text = resources.GetString("LowSpeedProbabilityPower");

            LowTyrePressureProbabilityPowerTextBox.Text = resources.GetString("LowTyrePressureProbabilityPower");

            ServiceBusConnectionStringTextBox.Text = resources.GetString("Microsoft.ServiceBus.ConnectionString");

            servicebusconnectionstringTextBox.Text = resources.GetString("servicebusconnectionstring");

            Stop.IsEnabled = false;

            //GetVINMasterList();
        }

        private void Simulate_Click(object sender, RoutedEventArgs e)
        {
            //enable the Stop button
            Stop.IsEnabled = true;

            //disable this button
            Simulate.IsEnabled = false;

            string eventHubName = inputeventhubTextBox.Text;
            //static string connectionString = "Endpoint=sb://tisensordemosh.servicebus.windows.net/;SharedAccessKeyName=all;SharedAccessKey=mcxBEocF6f0KHQGhP2MtT7A44tUC+zhqyDcetP/Jt0o=";
            string connectionString = servicebusconnectionstringTextBox.Text;

            Random random = new Random();
            
            //SendingCarEventData().Wait();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            //enable Simulate button
            Simulate.IsEnabled = true;

            //disable this button
            Stop.IsEnabled = false;

        }
    }
}
