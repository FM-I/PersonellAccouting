using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudenrsDB
{
    public class Specialty
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Specialty()
        {
            Students = new List<Student>();
        }

    }
}
