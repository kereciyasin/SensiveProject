using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.EntityLayer.Concrete
{
    public class Artikel
    {
        public int ArtikelId { get; set; }
        public string ArtikelTitle { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string CoverImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
