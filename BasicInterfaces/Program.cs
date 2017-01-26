using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    // no implementation code, just 2 methods and a property
    // no access modifiers (public, private...)
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }

    // MUST implement IStorable
    class Document : IStorable
    {
        private string name;
        private Boolean mNeedsSave = false;

        public Document(string s) {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        public void Save() {
            Console.WriteLine("Saving Private Document...");
        }

        public void Load() {
            Console.WriteLine("Loading the Document Gun");
        }

        public Boolean NeedsSave {
            get { return mNeedsSave; }
            set { mNeedsSave = value; }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Document d = new Document("Test Document");

            d.Load();
            d.Save();
            d.NeedsSave = false;

            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}
