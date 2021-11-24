using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learning.Entity.Base
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        [DefaultValue("0")]
        public bool IsDelete { get; set; }
        [MaxLength(10)]
        [Column(TypeName = "VARCHAR")]
        public string CreatedById { get; set; }
        [DefaultValue("GetDate()")]
        public DateTime? CreatedDate { get; set; }
        [MaxLength(10)]
        [Column(TypeName = "VARCHAR")]
        public string ModifiedById { get; set; }
        [DefaultValue("GetDate()")]
        public DateTime? ModifiedDate { get; set; }
    }
}
