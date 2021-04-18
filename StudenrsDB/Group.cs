using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudenrsDB
{
    public class Group
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>(); 
        }
    }
}
