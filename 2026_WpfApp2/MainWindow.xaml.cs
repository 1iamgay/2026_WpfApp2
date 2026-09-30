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
            // 1. 取得觸發事件的 TextBox
            var targetTextBox = sender as TextBox;
            if (targetTextBox == null) return;

            // 2. 取得父階層 StackPanel
            var targetStackPanel = targetTextBox.Parent as StackPanel;
            if (targetStackPanel == null) return;

            // 3. 取得同排的品名 Label 與價格 Label
            var targetNameLabel = targetStackPanel.Children[0] as Label;
            var targetPriceLabel = targetStackPanel.Children[1] as Label;

            if (targetNameLabel != null && targetPriceLabel != null)
            {
                string drinkName = targetNameLabel.Content.ToString();

                // 去掉「元」字以利轉換數字（例如 "60元" -> "60"）
                string priceText = targetPriceLabel.Content.ToString().Replace("元", "");

                // 4. 轉換數量並計算金額
                if (int.TryParse(targetTextBox.Text, out int quantity) && quantity > 0)
                {
                    int price = Convert.ToInt32(priceText);
                    int totalPrice = price * quantity;

                    ResultTextBlock.Text = $"訂購品項：{drinkName}\n單價：{price} 元\n數量：{quantity}\n總計：{totalPrice} 元";
                }
                else
                {
                    ResultTextBlock.Text = "";
                }
            }
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("訂單已送出！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}