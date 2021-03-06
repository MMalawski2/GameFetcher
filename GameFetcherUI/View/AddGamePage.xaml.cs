﻿using DesktopUI_Logic;
using DesktopUI_Logic.Models;
using GameFetcherUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace GameFetcherUI
{
    public partial class AddGamePage : Window, IView
    {
        public AddGamePage(IView view)
        {
            InitializeComponent();
            DataContext = view;
        }
    }
}
