using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotTema
{
    class Table
    {
        public int id { get; set; }

        public string Lande { get; set; }

        public string Rang { get; set; }

        public string Foedselsrate { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ Lande } { Rang } { Foedselsrate } ";
            }
        }
    }
}
