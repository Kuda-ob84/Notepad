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
using System.Windows.Shapes;

namespace Notepad
{
    /// <summary>
    /// Логика взаимодействия для PolybiusWindow.xaml
    /// </summary>
    public partial class PolybiusWindow : Window
    {
        public PolybiusWindow()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            rtbCrypt.Text = Polibian.encodeText(rtbText.Text).ToString();
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            rtbCrypt.Text = Polibian.decodeText(rtbText.Text).ToString();
        }
    }
}
