using System.Windows;
using System.Windows.Controls;

namespace Todo.MVVM.View
{
    /// <summary>
    /// Interaction logic for AgendaView.xaml
    /// </summary>
    public partial class AgendaView : UserControl
    {
        public AgendaView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.motorolasolutions.com/");
        }
    }
}
