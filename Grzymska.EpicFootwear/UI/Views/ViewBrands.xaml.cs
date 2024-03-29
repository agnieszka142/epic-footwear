﻿using Grzymska.EpicFootwear.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grzymska.EpicFootwear.UI.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ViewBrands.xaml
    /// </summary>
    public partial class ViewBrands : UserControl
    {
        public ViewBrands()
        {
            InitializeComponent();
        }

        private void TextBoxChanged(object sender, TextChangedEventArgs e)
        {
            if (DataContext is BrandListViewModel brandListViewModel)
            {
                brandListViewModel.FilterDataCommand.Execute(brandListViewModel);
            }
        }
    }
}
