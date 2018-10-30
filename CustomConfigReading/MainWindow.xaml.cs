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
using Microsoft.VisualBasic;
using System.Collections.Specialized;

namespace CustomConfigReading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //GetConfigurationUsingSectionGroup();
        }

        private void btnLoadAppConfig_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(FilepathsSettings[1]);
            string custTestStr = GetConfigSettingBySection("Names", 0);
            Console.WriteLine(custTestStr);
        }
        //public static void GetConfigurationUsingSectionGroup()
        //{
        //    var custNames = System.Configuration.ConfigurationManager.GetSection("Names") as NameValueCollection;


        //}
        //public static NameValueCollection GetConfigurationUsingSectionGroup(string sectionName, int ine)
        //{
        //    var FilepathsSettings = System.Configuration.ConfigurationManager.GetSection("Filepaths") as NameValueCollection;
        //    if (FilepathsSettings.Count == 0)
        //    {
        //        Console.WriteLine("Post Settings are not defined");
        //    }
        //    else
        //    {
        //        foreach (var key in FilepathsSettings.AllKeys)
        //        {
        //            Console.WriteLine(key + " = " + FilepathsSettings[key]);
        //        }
        //        //MessageBox.Show(FilepathsSettings[1]);

        //    }
        //}

        //Get configuration values according to Section Name and index position
        public static string GetConfigSettingBySection(string sectionName, int index)
        {
            var custSettings = System.Configuration.ConfigurationManager.GetSection(sectionName) as NameValueCollection;

            return custSettings[index];
        }

    }

}
