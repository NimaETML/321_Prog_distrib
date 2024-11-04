using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _321_serial_ex2_nima_zarrabi
{
    public class Episode
    {
        public string Title { get; set; }
        public int DurationMinute { get; set; }
        public int SequenceNumber { get; set; }
        public string Director { get; set; }
        public string Synopsis { get; set; }
        public List<Character> Characters { get; set; }
    }
}
