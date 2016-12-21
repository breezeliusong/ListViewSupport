using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewSupport.DataModel
{
    public class Data
    {
        public string Name { get; set; }
        public string Child { get; set; }
        public List<Children> ChildList { get; set; }

    }
}
