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
using System.Configuration;

namespace HW_WPF_20200227_StylesAndTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imgCheck.Source = new BitmapImage(new Uri(ConfigurationManager.AppSettings["imgesPath"] + "\\Capture.JPG"));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var rbPressed = (RadioButton)sender;
            string imgNumber = (string)rbPressed.Content;
            if(imgNumber == null) imgNumber = "1";

            string imgesPath = ConfigurationManager.AppSettings["imgesPath"];
            imgesPath += $"\\slide_{imgNumber}.jpg";
            imgbrush.ImageSource = new BitmapImage(new Uri(imgesPath));
        }
    }
}
