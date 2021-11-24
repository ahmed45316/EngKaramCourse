using System.Collections.Generic;
using Learning.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace Learning.Entity.Entites
{
    public class Department : BaseEntity<int>
    {
        [MaxLength(127)]
        public string Name { get; set; }
        [MaxLength(63)]
        [Required]
        public string Code { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
