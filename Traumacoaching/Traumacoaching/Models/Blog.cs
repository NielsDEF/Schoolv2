using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Traumacoaching.Models
{
    public class Blog
    {
        [Key]
        public int Bid { get; set; }
        public string Btitle { get; set; }
        public string BDesc { get; set; }
        public string BUrl { get; set; }
    }
}
