using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ahmed_nawar.Models
{
    public class ModelClass
    {
        public IEnumerable<About> abouts { set; get; }
        public IEnumerable<Slider> sliders { get; set;}
        public IEnumerable<Project> projects { get; set; }
    }
}