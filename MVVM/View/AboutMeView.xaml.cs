using System.Windows;
using System.Windows.Controls;

namespace Todo.MVVM.View
{
    /// <summary>
    /// Interaction logic for AboutMeView.xaml
    /// </summary>
    public partial class AboutMeView : UserControl
    {
        public AboutMeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/maurommcfreire/");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mmmcreire");
        }
    }
}
