using ListViewSupport.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListViewSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Data> parentList { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            List<Children> childList = new List<Children>();
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            parentList = new ObservableCollection<Data>();
            parentList.Add(new Data() { Name = "xiaoming", Child = "boy", ChildList=childList});
            parentList.Add(new Data() { Name = "xiaohei", Child = "girl", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaoli", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaobai", Child = "girl", ChildList = childList });
            //this.DataContext = parentList;
        }
    }
}
