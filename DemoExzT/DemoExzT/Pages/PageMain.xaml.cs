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

namespace DemoExzT.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frMain.Navigate(new Pages.PageClient());
        }

        private void btnModel_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frMain.Navigate(new Pages.PageModel());
        }

        private void btnDeal_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frMain.Navigate(new Pages.PageDeal());
        }

        private void btnPostafshik_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frMain.Navigate(new Pages.PagePostafshik());
        }

        private void btnFirm_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frMain.Navigate(new Pages.PageFirm());
        }

        private void btnPriceList_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frMain.Navigate(new Pages.PagePriceList());
        }
    }
}
