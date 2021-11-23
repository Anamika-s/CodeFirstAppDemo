using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        // Add reference to child Table
        public List<Batch> Batches { get; set; }
    }
}
