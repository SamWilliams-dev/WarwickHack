using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TalkingTrump
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String st = File.ReadAllText("C://Users/Owner/Documents/WarwickHack/97284caa/align.json");
                Console.WriteLine(st);
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.Read();
            JsonReader.LoadJson();

        }




    }

    public class JsonReader
    {
        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("C://Users/Owner/Documents/WarwickHack/97284caa/align.json"))
            {
                string json = r.ReadToEnd();

                //Item item = new Item();
               // item.alignedWord = getproprty

                //List<Item> items = new Item;
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }  
    }

    public class Item
    {
        private string AlignedWord = "N/A";      //Aligned word
        private string Word = "N/A";             //Actual word
        private int End = 0;                 //End time of the word
        private int Start = 0;               //Start time of the word
        private int EndOffSet = 0;           //What ever this means

        public string alignedWord
        {
        get { return AlignedWord; }
        set { AlignedWord = value; }
        }
        public string word
        {
            get { return Word; }
            set { Word = value; }
        }
        public int end
        {
            get { return End; }
            set { End = value; }
        }
        public int start
        {
            get { return Start; }
            set { Start = value; }
        }
        public int endOffSet
        {
            get { return EndOffSet; }
            set { EndOffSet = value; }
        }


    }

}

