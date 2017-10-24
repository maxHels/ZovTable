using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

namespace ZovTable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Db db = new Db())
            {
                List<Ship> sh = db.Ships.ToList();
                //sh.Clear();
                //db.SaveChanges();
                //sh = db.Ships.ToList();

                try
                {
                    string y;
                    using (StreamReader inp = new StreamReader("packs_13.07.2017.json"))
                    {
                        y = inp.ReadToEnd();
                        inp.Close();
                    }
                    Rootobject a = JsonConvert.DeserializeObject<Rootobject>(y);
                    foreach (Ship s in a.Ships.Skip(1))
                    {
                        db.Ships.Add(s);
                        db.SaveChanges();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
