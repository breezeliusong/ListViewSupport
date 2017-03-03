using ListViewSupport.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.BulkAccess;
using Windows.Storage.FileProperties;
using Windows.Storage.Pickers;
using Windows.Storage.Search;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
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
        public ObservableCollection<Children> childList { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel mo = new ViewModel();
            Answers = new ObservableCollection<Data>();
            foreach(var ite in mo.SelectedItems)
            {
            Answers.Add(ite);
            }

            childList = new ObservableCollection<Children>();
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            childList.Add(new Children() { number = 1 });
            childList.Add(new Children() { number = 2 });
            childList.Add(new Children() { number = 3 });
            childList.Add(new Children() { number = 4 });
            parentList = new ObservableCollection<Data>();
            parentList.Add(new Data() { Name = "xiaoming", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaohei", Child = "girl", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaoli", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaobai", Child = "girl", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaoming", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaohei", Child = "girl", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaoli", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaobai", Child = "girl", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaoming", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaohei", Child = "girl", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaoli", Child = "boy", ChildList = childList });
            parentList.Add(new Data() { Name = "xiaobai", Child = "girl", ChildList = childList });

            MyGrid.DataContext = parentList;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //var pictureQueryOptions = new QueryOptions();
            ////Read through all the subfolders. 
            //pictureQueryOptions.FolderDepth = FolderDepth.Deep;
            ////Apply the query on the PicturesLibrary 
            //var pictureQuery = KnownFolders.PicturesLibrary.CreateFileQueryWithOptions(pictureQueryOptions);

            //// get the files
            //var files = await pictureQuery.GetFilesAsync();
            //FolderPicker picker = new FolderPicker();
            //StorageFolder folder =await picker.PickSingleFolderAsync();
            //var files=await folder.GetFilesAsync();
            ////var picturesInformation = new FileInformationFactory(pictureQuery, ThumbnailMode.PicturesView);
            ////PicGrid.DataContext = picturesInformation.GetVirtualizedFilesVector();
            //ObservableCollection<Model> list = new ObservableCollection<Model>();
            //foreach (var file in files)
            //{
            //    var stream = await file.OpenReadAsync();
            //    var image = new BitmapImage();
            //    image.SetSource(stream);
            //     var model=new Model() { bitImage = image };
            //    list.Add(model);
            //}
            //PicGrid.DataContext = list;
            Debug.Write("");
        }
        private BitmapImage image { get; set; }

        private void GridViewItem_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            var s = (FrameworkElement)sender;

            if (s != null)
            {

                MenuFlyout myFlyout = new MenuFlyout();
                MenuFlyoutItem callItem = new MenuFlyoutItem { Text = "Call" };
                MenuFlyoutItem sendItem = new MenuFlyoutItem { Text = "Send a message" };
                MenuFlyoutItem deleteItem = new MenuFlyoutItem { Text = "Delete" };

                myFlyout.Items.Add(callItem);
                myFlyout.Items.Add(sendItem);
                myFlyout.Items.Add(deleteItem);

                myFlyout.ShowAt(sender as UIElement, e.GetPosition(sender as UIElement));

                deleteItem.Click += (sender2, args) =>
                {
                    //scenario 1

                    //if (args != null)
                    //{

                    //    GridView gv = sender as GridView;
                    //    var selectedItems = gv.SelectedItems.Cast<Data>().ToList();
                    //    if (selectedItems != null)
                    //    {

                    //        foreach (Data del in selectedItems)
                    //        {
                    //            parentList.Remove(del);
                    //        }
                    //    }
                    //}

                    //scenario 2
                    if (args != null)
                    {
                        var parent = sender as DependencyObject;
                        while (!(parent is GridView))
                        {
                            parent = VisualTreeHelper.GetParent(parent);
                        }
                        var gv = (parent as GridView);

                        var selectedItems = gv.SelectedItems.Cast<Data>().ToList();
                        if (selectedItems != null)
                        {
                            foreach (var item in selectedItems)
                            {
                                parentList.Remove(item);
                            }
                        }
                    }
                };
            }
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = sender as DependencyObject;
            while (!(parent is ListView))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            var gv = (parent as ListView);
            var num = gv.SelectedItem;
            Debug.WriteLine(gv.Name);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderPicker picker = new FolderPicker();
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.MusicLibrary;
            picker.FileTypeFilter.Add("*");
            StorageFolder folder = await picker.PickSingleFolderAsync();
            var files = await folder.GetFilesAsync();
            ObservableCollection<Model> list = new ObservableCollection<Model>();
            foreach (var file in files)
            {
                var stream = await file.OpenReadAsync();
                var image = new BitmapImage();
                image.SetSource(stream);
                var model = new Model() { bitImage = image };
                list.Add(model);
            }
            PicGrid.DataContext = list;
        }

        public ObservableCollection<Data> Answers { get; set; }
        //private void ListView_Loaded(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in (this.DataContext as ViewModel).SelectedItems)
        //    {
        //        listView.SelectedItems.Add(item);
        //    }
        //}
    }
}
