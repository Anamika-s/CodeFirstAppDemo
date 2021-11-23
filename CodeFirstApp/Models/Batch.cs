using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    class Batch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
       
        // Add FK
        public int CourseId { get; set; }
        public Course Course { get; set; }


    }
}
