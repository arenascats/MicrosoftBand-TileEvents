/*
    Copyright (c) Microsoft Corporation All rights reserved.  
 
    MIT License: 
 
    Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
    documentation files (the  "Software"), to deal in the Software without restriction, including without limitation
    the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
    and to permit persons to whom the Software is furnished to do so, subject to the following conditions: 
 
    The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. 
 
    THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
    TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
    TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Windows;
using System.Collections.Generic;
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
using Windows.Storage.Pickers;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TileEvents
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = this.viewModel = App.Current;
        }

        private async void btStImageSmall_Click(object sender, RoutedEventArgs e)
        {
            
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;//指示当前视图模式
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;//跳转到win10图片库
            openPicker.FileTypeFilter.Add(".jpg");//显示文件的类型
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();//打开一个文件选取窗口
            tbSmallImage.Text = file.Path;
          



        }

        private async void btStImage_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;//指示当前视图模式
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;//跳转到win10图片库
            openPicker.FileTypeFilter.Add(".jpg");//显示文件的类型
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();//打开一个文件选取窗口
            tbImage.Text = file.Path;
        }
    }
}
