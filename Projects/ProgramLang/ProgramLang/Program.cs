using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgramLang
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

            foreach (var l in languages)
            {
                Console.WriteLine(l.Prettify());
            }
        }
    }
}
