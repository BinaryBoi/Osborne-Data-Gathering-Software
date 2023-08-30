using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace DataGatheringTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataHandler dataHandler = new DataHandler();

        string sortMethod = "A";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SortA(object sender, RoutedEventArgs e)
        {
            sortMethod = "A";
        }

        public void SortB(object sender, RoutedEventArgs e)
        {
            sortMethod = "B";
        }

        public void SortC(object sender, RoutedEventArgs e)
        {
            sortMethod = "C";
        }

        public void GatherData(object sender, RoutedEventArgs e)
        {
            float temp;
            int dp;
            if (URL.Text != "" && float.TryParse(Temp.Text, out temp))
            {
                dataHandler.GatherData(URL.Text);
                if (dataHandler.dh_DataSet != null)
                {
                    if (dataHandler.dh_DataSet.Count != 0)
                    {
                        GatheredData gatheredData = new GatheredData(URL.Text, temp, sortMethod, dataHandler.dh_DataSet);
                        gatheredData.Show();         
                    }
                    else
                    {
                        Error error = new Error("No data to show");
                        error.Show();
                    }
                }
                else
                {
                    Error error = new Error("No data found");
                    error.Show();
                }
            }
            else
            {
                Error error = new Error("One or more inputs are invalid");
                error.Show();
            }
        }
    }
}
