using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        [Column(Order = 0)]
        public int StudentCode { get; set; }

        [Column("Name", Order = 1)]
        public string StudentName { get; set; }

        [Column("DoB", Order = 5)]
        public DateTime DateOfBirth { get; set; }
        [Column(Order = 3)]
        public byte[] Photo { get; set; }
        [Column(Order = 2)]
        public decimal Height { get; set; }
        [Column(Order = 4)]
        public float Weight { get; set; }
    }
}
