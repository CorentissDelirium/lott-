using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottó
{
    class Program
    {
        enum fegyverek {apaökle,shotgun, m4a1, bfg9000, luger, rocket_launcher};
        static void Main(string[] args)
        {
            HashSet<fegyverek> inventory = new HashSet<fegyverek>();

            //egy fegyvert csak egy példányban lehet tárolni az inventory-ban
            //Töltsük fel az inventory-t 6 féle fegyverrel.
            Felpakol(inventory);  //Az összes fegyvert berakja az inventory-ba
            Listázó(inventory);
            Console.WriteLine(Fegyverszám(inventory));
            
            Kivesz(inventory);   //Egy fegyvert kivesz az inventory-ból
            Listázó(inventory);
            Felvesz(inventory,fegyverek.apaökle);  //Egy fegyvert berak a tár végére
            Listázó(inventory);
            Felvesz2(inventory, fegyverek.luger);  //Egy fegyvert berak a tár valamelyik helyére
            Listázó(inventory);
            Kiürít();   //Kiüríti az inventory-t
            Listázó(inventory);


            int db = Fegyverszám(inventory);
            Listázó(inventory);

            Console.ReadKey();
        }

        private static void Felvesz2(HashSet<fegyverek> inventory, fegyverek luger)
        {
            throw new NotImplementedException();
        }

        private static void Felvesz(HashSet<fegyverek> inventory, fegyverek fegyver)
        {
            if (!inventory.Contains(fegyver))
            {
                inventory.Add(fegyver);
            }
        }

        static int Fegyverszám(HashSet<fegyverek> inventory)
        {
            int db = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                db++;
            }
            return db;
        }

        private static void Listázó(HashSet<fegyverek> inventory)
        {
            foreach (var item in inventory)
            {
                Console.WriteLine();
            }
        }

        static void Kivesz(HashSet<fegyverek> inventory)
        {
            
        }

        static void Felpakol(HashSet<fegyverek> inventory)
        {
            inventory.Add(fegyverek.apaökle);
            inventory.Add(fegyverek.bfg9000);
            inventory.Add(fegyverek.luger);
            inventory.Add(fegyverek.m4a1);
            inventory.Add(fegyverek.rocket_launcher);
            inventory.Add(fegyverek.shotgun);
        }
    }
}
