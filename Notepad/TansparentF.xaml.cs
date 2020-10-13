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
    /// Логика взаимодействия для TansparentF.xaml
    /// </summary>
    public partial class TansparentF : Window
    {
        public TansparentF(string text)
        {
            InitializeComponent();
            //rtbText.Document.Blocks.Clear();
            rtbText.Text = text;
            //string richText = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            if (tbKey.Text.Length == 0)
                MessageBox.Show("Ключ не заполнен");
            else
            {
                rtbCrypt.Text = Transposition.Decipher(rtbText.Text, tbKey.Text);
            }
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            if (tbKey.Text.Length == 0)
                MessageBox.Show("Ключ не заполнен");
            else
            {
                rtbCrypt.Text = Transposition.Encipher(rtbText.Text, tbKey.Text, '+');
            }

        }
    }
}
