using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Navigation;

namespace WpfApp
{
    public class FileProcessing
    {
        static string filesdir = @"C:\Users\Student\Downloads\bigfiles";
        public static Dictionary<string, int> StatsAllFiles()
        {
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

            return top10.ToDictionary();

        }
    }
}
