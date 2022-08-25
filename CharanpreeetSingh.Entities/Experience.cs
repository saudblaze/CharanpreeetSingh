using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanpreeetSingh.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = null!;
        public int ProfileID { get; set; }

        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
    }
}
