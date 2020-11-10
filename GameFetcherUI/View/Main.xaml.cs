﻿using DesktopUI_Logic;
using DesktopUI_Logic.Models;
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
using System.Windows.Shapes;

namespace GameFetcherUI
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
       
        public Main()
        {
             
            InitializeComponent();
            
        }

       

        void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListViewItem v = new ListViewItem();
            v = (ListViewItem)sender;
            
            GameDetailsModel model = (GameDetailsModel)v.Content;
            GameStatus gameStatus = new GameStatus(model);
                gameStatus.Show();
        }

        

      
    }
}
