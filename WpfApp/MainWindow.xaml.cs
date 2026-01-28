using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Tracing;
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
using static System.Net.WebRequestMethods;

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
        async Task<int> LoadFromFiles()
        {
            string filesdir = @"C:\Users\Student\Downloads\bigfiles";

            List<string> files = Directory.EnumerateFiles(filesdir, "*.txt")
                                          .ToList();
            int cnt = 0;
            foreach (string file in files)
            {
                var words = await System.IO.File.ReadAllLinesAsync(file);
                cnt += words.Length;
            }
            return cnt;
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
        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Background = GetRandomSolidBrush();
        }

        private void btnSeq1_Click(object sender, RoutedEventArgs e)
        {
            /*
              10 nejcastejsich slov v kazdem souboru => 10 x statistika
              blokujici - sync
           */

            Stopwatch time = new Stopwatch();
            time.Start();

            txbInfo.Text = "";
            string filesdir = @"C:\Users\Student\Downloads\bigfiles";

            List<string> files = Directory.EnumerateFiles(filesdir, "*.txt")
                                          .ToList();

            foreach (var file in files)
            {
                Dictionary<string, int> wordCount = new();

                var words = System.IO.File.ReadAllLines(file);

                foreach (var word in words)
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
                foreach (var item in top10)
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
            /*
              10 nejcastejsich slov celkem ve všech souborech - globálně
           blokujici - sync
           */
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;

            Stopwatch time = new Stopwatch();
            time.Start();

            txbInfo.Text = "";

            var top10 = FileProcessing.StatsAllFiles();

            foreach (var item in top10)
            {
                txbInfo.Text += $"{item.Key} - {item.Value}{Environment.NewLine}";
            }
            txbInfo.Text += Environment.NewLine;

            time.Stop();
            txbInfo.Text += $"Čas zpracování: {time.ElapsedMilliseconds} ms";

            Mouse.OverrideCursor = null;
        }

        private async void btnAllAsync_Click(object sender, RoutedEventArgs e)
        {
            /*
               10 nejcastejsich slov ve všech souborech globálně NEBLOKUJICIM
                asynchronnim zpusobem
            */

            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;

            Stopwatch time = new Stopwatch();
            time.Start();

            txbInfo.Text = "";

            var top10 = await Task.Run(() => FileProcessing.StatsAllFiles());

            foreach (var item in top10)
            {
                txbInfo.Text += $"{item.Key} - {item.Value}{Environment.NewLine}";
            }
            txbInfo.Text += Environment.NewLine;

            time.Stop();
            txbInfo.Text += $"Čas zpracování: {time.ElapsedMilliseconds} ms";

            Mouse.OverrideCursor = null;
        }

        private async void btnPerFileAsync_Click(object sender, RoutedEventArgs e)
        {
            /*
            * 10 nejcastejsich slov v kazdem souboru
            * neblokujicim zpusobem - upldate gui po kazdem souboru
            */

            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            txbInfo.Text = "";

            var files = Directory.EnumerateFiles(FileProcessing.filesdir, "*.txt")
                                         .ToList();

            foreach (var file in files)
            {
                var result
                    = await Task.Run(() => FileProcessing.StatsSingleFile(file));

                foreach (var word_kv in result)
                {
                    txbInfo.Text += $"{word_kv.Key}: {word_kv.Value} {Environment.NewLine}";
                }

                txbInfo.Text += Environment.NewLine;
            }

            stopwatch.Stop();
            txbInfo.Text += $"elapsed ms: {stopwatch.ElapsedMilliseconds}";
            Mouse.OverrideCursor = null;
        }

        private void btnAllParallel_Click(object sender, RoutedEventArgs e)
        {
            /*
              10 nejcastejsich slov ve všech souborech globálně
               PARALELENIM zpusobem
           */

            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;

            Stopwatch time = new Stopwatch();
            time.Start();

            txbInfo.Text = "";

            List<string> files = Directory.EnumerateFiles(FileProcessing.filesdir, "*.txt")
                                         .ToList();

            ConcurrentDictionary<string, int> wordCount = new();

            //foreach (var file in files)
            Parallel.ForEach(files,
                             //new ParallelOptions { MaxDegreeOfParallelism = 4 },
                             file =>
            {
                var words = System.IO.File.ReadAllLines(file);

                foreach (var word in words)
                {
                    wordCount.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
                }
            });

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

        private async void btnAllParallelAsync_Click(object sender, RoutedEventArgs e)
        {
            /*
             10 nejcastejsich slov ve všech souborech globálně
              PARALELENIM ASYNCHRONNNIM zpusobem
          */

            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;

            Stopwatch time = new Stopwatch();
            time.Start();

            txbInfo.Text = "";

            List<string> files = Directory.EnumerateFiles(FileProcessing.filesdir, "*.txt")
                                         .ToList();

            ConcurrentDictionary<string, int> wordCount = new();

            //foreach (var file in files)
            await Parallel.ForEachAsync(files, async (file, cancellationToken) =>
            {
                var words = System.IO.File.ReadAllLines(file);

                foreach (var word in words)
                {
                    wordCount.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
                }
            });
                       

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
    }
}