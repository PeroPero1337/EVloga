using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Models
{
    public class OsebniPodatki
    {
        [Key]
        public int OsebniId { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public DateTime RojDan { get; set; }
        public string KrajRojstva { get; set; }
        public string EMSO { get; set; }
        public int Davcna { get; set; }
        public string Vlagatelj { get; set; }
        public DateTime DatumOddaje { get; set; }
        public string Status { get; set; }

        //public ICollection<Dokument> Dokumenti { get; set; }

    }
}
