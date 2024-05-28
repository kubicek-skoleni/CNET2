using PersonModel;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
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

		private void btnBlocking_Click(object sender, RoutedEventArgs e)
		{
			txtInfo1.Text = "začínám stahovat";

			var url = "https://localhost:7031";
			var client = new HttpClient();
			var data = client.GetFromJsonAsync<List<Person>>($"{url}/people/all").Result;

			txtInfo1.Text = $"staženo {data.Count()} položek";
		}

		private async void btnAsync_Click(object sender, RoutedEventArgs e)
		{
			txtInfo1.Text = "začínám stahovat";

			var url = "https://localhost:7031";
			var client = new HttpClient();
			var data = await client.GetFromJsonAsync<List<Person>>($"{url}/people/all");

			txtInfo1.Text = $"staženo {data.Count()} položek";
		}

		private async void btnWithProgress_Click(object sender, RoutedEventArgs e)
		{
			IProgress<int> progress = new Progress<int>(progress =>
			{
				progres1.Value = progress;
				txtInfo1.Text = $"{progress}%";
			});

			await DownloadDataAsyncWithProgress(progress);
		}

		private async Task DownloadDataAsyncWithProgress(IProgress<int> progress)
		{
			int totalItems = 5000;
			int itemsPerRequest = 100;
			int totalRequests = totalItems / itemsPerRequest;

			for (int i = 0; i < totalRequests; i++)
			{
				// Call the API to get 100 items
				//var items = await GetItemsFromApiAsync(i * itemsPerRequest, itemsPerRequest);
				await Task.Delay(250);

				// Process the downloaded items as needed

				// Report progress
				int progressPercentage = (int)((i + 1) * 100.0 / totalRequests);
				progress.Report(progressPercentage);
			}

			txtInfo1.Text = $"staženo {totalItems} položek";
		}
	}
}