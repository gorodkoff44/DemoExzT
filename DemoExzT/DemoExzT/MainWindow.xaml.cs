using DemoExzT.AppDateFiles;
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

namespace DemoExzT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameObject.frMain = FrmMain;

            FrmMain.Navigate(new Pages.PageMain());
           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if(FrameObject.frMain.CanGoBack)
            {
                FrameObject.frMain.GoBack();
            }
        }

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {
            if(FrmMain.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }
            else
            {
                btnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}
