using ListViewSupport.DataModel;
using System.Collections.Generic;

namespace ListViewSupport
{
    public class ViewModel
    {
        public List<Data> SelectedItems { get; set; }

        public ViewModel()
        {
            SelectedItems = new List<Data>();
            // add some Items to this.SelectedItems 
            SelectedItems.Add(new Data { Name = "item1" });
            SelectedItems.Add(new Data { Name = "item2" });
            SelectedItems.Add(new Data { Name = "item3" });

        }
    }
}