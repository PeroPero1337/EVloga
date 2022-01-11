using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Models
{
    public class Dokument
    {
        public int Id { get; set; }
        public string DocName { get; set; }
        public string FileType { get; set; }
        public byte[] File { get; set; }
        public string Oseba { get; set; }
        public DateTime? CreatedOn { get; set; }

        //public int? OsebniId { get; set; }
        //public OsebniPodatki OsebniPodatki { get; set; }
    }
}
