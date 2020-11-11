﻿using DesktopUI_Logic;
using DesktopUI_Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameFetcherUI.ViewModel
{
    public class GameStatusViewModel : UserControl, INotifyPropertyChanged
    {
        private GameDetailsModel _game = new GameDetailsModel();
        public GameDetailsModel Game
        {
            get
            {
                return _game;
            }
            set
            {
                _game = value;
                NotifyPropertyChanged("Game");
            }
        }
        public GameStatusViewModel()
        {
            DataContext = this;
            Game = StaticData.Instance.Model;
            UpdateCommand = new RelayCommand(new Action<object>(UpdateGame));
        }

        private void UpdateGame(object obj)
        {
            GameDetailsModel newGame = obj as GameDetailsModel;
            ToSqlConnection sqlConn = new ToSqlConnection();
            sqlConn.UpdateCommand(newGame);
        }

        public ICommand UpdateCommand { get; private set; }

        /// <summary>
        /// INotifyPropertyChanged Methods
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
