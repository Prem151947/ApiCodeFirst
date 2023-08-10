using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TestTable
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? StandardId { get; set; }
        public int? Age { get; set; }
    }
}
