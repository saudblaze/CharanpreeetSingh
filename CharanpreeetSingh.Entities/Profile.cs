using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharanpreeetSingh.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
        public virtual ICollection<Experience> ListExperience { get; set; }
    }
}
