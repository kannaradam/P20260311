using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P20260311
{
    internal class auto
    {
        int Id;
        string Marka;
        string Tipus;
        string Szin;
        int Ar;
        int Evjarat;


        public auto(int id, string marka, string tipus, string szin, int ar, int evjarat)
        {
            Id = id;
            Marka = marka;
            Tipus = tipus;
            Szin = szin;
            Ar = ar;
            Evjarat = evjarat;

        }

        public int Id1 { get => Id; set => Id = value; }
        public string Marka1 { get => Marka; set => Marka = value; }
        public string Tipus1 { get => Tipus; set => Tipus = value; }
        public string Szin1 { get => Szin; set => Szin = value; }
        public int Ar1 { get => Ar; set => Ar = value; }
        public int Evjarat1 { get => Evjarat; set => Evjarat = value; }
        public static List<auto> feltolt(string fnev)
        {
            List<auto> autoLista = new List<auto>();
            string[] sorok = File.ReadAllLines(fnev);

            for (int i = 1; i < sorok.Length; i++)
            {
                string[] mezok = sorok[i].Split(',');
                auto a = new auto(int.Parse(mezok[0]), mezok[1], mezok[2], mezok[3], int.Parse(mezok[4]), int.Parse(mezok[5]));
                autoLista.Add(a);
            }


            return autoLista;
        }
    }
}
