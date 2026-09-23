using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2026_WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
            public MainWindow()
            {
                InitializeComponent();
            }

            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {
                var targetTextBox = sender as TextBox;
                var targetStackPanel = targetTextBox.Parent as StackPanel;
                var targetNameLabel = targetStackPanel.Children[0] as Label;
                var targetPriceLabel = targetStackPanel.Children[1] as Label;
            }

            private void OrderButton_Click(object sender, RoutedEventArgs e)
            {

            }
        }
    }