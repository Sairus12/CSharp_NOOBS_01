using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Admin: Uzivatel
    {
        public int Stupen { get; set; }
        public Admin(string jmeno, string prijmeni, int vek, int id, int stupen): base(jmeno,prijmeni,vek,id)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Id = id;
            Stupen = stupen;
        }
    }
}
