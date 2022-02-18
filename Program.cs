// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Linq;


namespace vdv
{
    public class Program
    {
        public static string PROJECTPATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName; // Visual Studio (bin)
        //public string PROJECTPATH = Path.Combine(
        //    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,
        //    "UserRights"
        //); // UnitTest

        public static void Main(string[] args)
        {
            var path = Path.Combine(PROJECTPATH, "data");
            //string path = @"C:\Projekte\793_Stadtverkehr_Luebeck\Stoerungsmelder\PS - Scripts\cache\of.xml";
            string fileText = File.ReadAllText(Path.Combine(path, "of.xml"));
            XmlParser parser = new XmlParser(fileText);
            parser.ConvertToJson();
            Console.ReadLine();
        }

    }
}

