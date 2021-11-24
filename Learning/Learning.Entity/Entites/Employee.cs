using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Learning.Entity.Base;

namespace Learning.Entity.Entites
{
    public class Employee : BaseEntity<long>
    {
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(63)]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }
    }
}
