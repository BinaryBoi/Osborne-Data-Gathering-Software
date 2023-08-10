using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.DirectoryServices;
using System.ComponentModel;

namespace DataGatheringTool
{
    /// <summary>
    /// Interaction logic for GatheredData.xaml
    /// </summary>
    public partial class GatheredData : Window
    {
        DataHandler dataHandler = new DataHandler();

        public GatheredData(string gd_URL, double gd_Temp, string gd_SortMethod, List<DataHandler.DataSet> gd_Dataset)
        {
            InitializeComponent();
            URL.Text = gd_URL;
            UnderText.Text = "Under " + gd_Temp + "°C";
            OverText.Text = "Over " + gd_Temp + "°C";
            dataHandler.dh_DataSet = gd_Dataset;
            
            OrganiseLists(gd_Temp);

            if (gd_SortMethod == "A")
            {
                Under.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(UnderID.SortMemberPath, ListSortDirection.Ascending));
                UnderID.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
                Over.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(OverID.SortMemberPath, ListSortDirection.Ascending));
                OverID.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
            }
            if (gd_SortMethod == "B")
            {
                Under.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(UnderAge.SortMemberPath, ListSortDirection.Ascending));
                UnderAge.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
                Over.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(OverAge.SortMemberPath, ListSortDirection.Ascending));
                OverAge.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
            }
            if (gd_SortMethod == "C")
            {
                Under.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(UnderTemp.SortMemberPath, ListSortDirection.Ascending));
                UnderTemp.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
                Over.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(OverTemp.SortMemberPath, ListSortDirection.Ascending));
                OverTemp.SortDirection = System.ComponentModel.ListSortDirection.Ascending;
            }
        }

        public void SaveData(object sender, RoutedEventArgs e)
        {
            dataHandler.SaveData(FileName.Text, dataHandler.dh_DataSet);
        }

        private void OrganiseLists(double temp)
        {
            List<DataHandler.DataSet> under = new List<DataHandler.DataSet>();
            List<DataHandler.DataSet> over = new List<DataHandler.DataSet>();

            foreach (DataHandler.DataSet ds in dataHandler.dh_DataSet)
            {
                if (ds.temperature < temp)
                {
                    under.Add(ds);
                }
                else
                {
                    over.Add(ds);
                }
            }

            Under.DataContext = under;
            Over.DataContext = over;
        }
    }
}
