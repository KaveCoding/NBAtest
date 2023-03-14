using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoDel2_2.Models
{
    internal class Lagmedlem
    {
        public Guid Id { get; set; }
        public string Namn { get; set; }
        public int Längd { get; set; }
        public int Vikt { get; set; }
        public string Position { get; set; }
        public string Bild { get; set; }
        public string Beskrivning { get; set; }

    }
}
