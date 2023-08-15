using System;
using System.Collections.Generic;
using System.IO;
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

namespace DataGatheringTool
{
    /// <summary>
    /// Interaction logic for SaveSuccess.xaml
    /// </summary>
    public partial class SaveSuccess : Window
    {
        string ss_FileName;

        public SaveSuccess(string fileName)
        {
            InitializeComponent();
            ss_FileName = fileName;
        }

        public void Return(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Open(object sender, RoutedEventArgs e)
        {
            //        <Button Click="Open" HorizontalAlignment="Left" VerticalAlignment="Bottom" Width="100" Height="30" FontSize="20">Open File</Button>

            string debugFolder = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(debugFolder).Parent.Parent.Parent.FullName;
            string fileDirectory = projectDirectory + "\\" + ss_FileName;
        }
    }
}
