using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCourse.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public string DisplayOrders { get; set; }
    }
}
