using System.Diagnostics;
using System.IO;
using System.Reflection;
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
            Stopwatch time = new Stopwatch();
            time.Start();

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

            time.Stop();
            txbInfo.Text += $"Čas zpracování: {time.ElapsedMilliseconds} ms";
        }

        private void btnSeq2_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;

            Stopwatch time = new Stopwatch();
            time.Start();

            txbInfo.Text = "";
            string filesdir = @"C:\Users\Student\Downloads\bigfiles";

            List<string> files = Directory.EnumerateFiles(filesdir, "*.txt")
                                          .ToList();

            Dictionary<string, int> wordCount = new();

            foreach (var file in files)
            {
                var words = File.ReadAllLines(file);

                foreach (var word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount.Add(word, 1);
                }
            }

            var top10 = wordCount
                            .OrderByDescending(x => x.Value)
                            .Take(10);

            foreach (var item in top10)
            {
                txbInfo.Text += $"{item.Key} - {item.Value}{Environment.NewLine}";
            }
            txbInfo.Text += Environment.NewLine;

            time.Stop();
            txbInfo.Text += $"Čas zpracování: {time.ElapsedMilliseconds} ms";

            Mouse.OverrideCursor = null;
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Background = GetRandomSolidBrush();
        }

        Brush GetRandomSolidBrush()
        {
            var brushes = typeof(Brushes)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(p => p.GetValue(null))
                .OfType<SolidColorBrush>()
                .ToList();

            return brushes[Random.Shared.Next(brushes.Count)];
        }
    }
}