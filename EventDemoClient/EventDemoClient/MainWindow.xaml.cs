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
using EventDemoClient.ServiceReference;

namespace EventDemoClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window,IDisposable
    {
        private SubscriptionContractClient proxy;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubscriptionContractCallback callback = new SubscriptionContractCallback();
            proxy=  new SubscriptionContractClient(callback);
            proxy.Subscribe(EventType.Type1);
            proxy.Subscribe(EventType.AllEvents);
            proxy.FiringEvents(EventType.AllEvents);
        }

        public void Dispose()
        {
            proxy.UnSubsctibe(EventType.AllEvents);
        }
    }

  
    class SubscriptionContractCallback : ISubscriptionContractCallback
    {
        public void Event1()
        {

        }

        public void Event2(int num)
        {

        }

        public void Event3(int num, string text)
        {

        }
    }
}
