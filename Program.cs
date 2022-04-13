using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace StreamReader_Writer
{
    class Program
    {


        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"C:/Users/Naz02/Desktop/Folderrr");
            //Console.WriteLine("Folder Created");
            //File.Create(@"C:/Users/Naz02/Desktop/Folderrr/Fileee.txt");
            //Console.WriteLine("File Created");
            //File.Create(@"C:/Users/Naz02/Desktop/Folderrr/Filee.txt");
            //Console.WriteLine("File Created");
            //using (StreamWriter sw = new StreamWriter(@"C:/Users/Naz02/Desktop/Folderrr/Filee.txt"))
            //{
            //    sw.WriteLine("Helloooo");
            //    sw.WriteLine("Byeee");
            //}
            //File.Delete(@"C:/Users/Naz02/Desktop/Folderrr/Fileee.txt");
            //using (StreamReader sr = File.OpenText(@"C:/Users/Naz02/Desktop/Folderrr/Filee.txt"))
            //{
            //    String s = "abc";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            List<Dress> dresses = new List<Dress>();
            Dress dress1 = new Dress();
            {
                dress1.Size = 36;
                dress1.Colour = "Black";
                dress1.Price = 200;
            };
            Dress dress2 = new Dress();
            {
                dress2.Size = 38;
                dress2.Colour = "Purple";
                dress2.Price = 255;
            };
            Dress dress3 = new Dress();
            {
                dress3.Size = 36;
                dress3.Colour = "Red";
                dress3.Price = 300;
            };
            dresses.Add(dress1);
            dresses.Add(dress2);
            dresses.Add(dress3);
            string jsonString1 = JsonConvert.SerializeObject(dresses);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Naz02\source\repos\StreamReader_Writer\StreamReader_Writer\Files\json1.json"))
            {
                sw.Write(jsonString1);
            }
            string result;

            using (StreamReader sr = new StreamReader(@"C:\Users\Naz02\source\repos\StreamReader_Writer\StreamReader_Writer\Files\json1.json"))
            {
                result = sr.ReadToEnd();
            }
            var parsejson = JsonConvert.DeserializeObject<Dress>(result);
            Console.WriteLine(parsejson.Size);
        }
    }
}