﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
namespace SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }

    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename,journal.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");
            Console.WriteLine(journal);

            var p = new Persistence();
            var filename = @"journal.txt";
            p.SaveToFile(journal, filename, true);
            Process.Start(filename);
        }
    }
}
