using System.IO;
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

namespace WpfApp
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

        private void btnSeq1_Click(object sender, RoutedEventArgs e)
        {
            txbInfo.Text = "";
            string filesdir = @"C:\Users\Student\Downloads\bigfiles";

            List<string> files = Directory.EnumerateFiles(filesdir, "*.txt")
                                          .ToList();

            foreach(var file in files)
            {
                Dictionary<string, int> wordCount = new();

                var words = File.ReadAllLines(file);

                foreach(var word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount.Add(word, 1);
                }

                var top10 = wordCount
                                    .OrderByDescending(x => x.Value)
                                    .Take(10);

                txbInfo.Text += $"Soubor: {System.IO.Path.GetFileName(file)}{Environment.NewLine}";
                foreach(var item in top10)
                {
                    txbInfo.Text += $"   {item.Key} - {item.Value}{Environment.NewLine}";
                }
                txbInfo.Text += Environment.NewLine;

            }
        }
    }
}