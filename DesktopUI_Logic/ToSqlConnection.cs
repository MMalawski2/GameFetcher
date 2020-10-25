﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using DesktopUI_Logic.Models;
using System.Linq;
using System.Windows;
using System.Data;

namespace DesktopUI_Logic
{
    public class ToSqlConnection
    {
        private SqlConnection Connect()
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameFetcherDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            cnn = new SqlConnection(connectionString);
            return cnn;
            
        }
        public void PostCommand(GameDetailsModel game)
        {
            SqlConnection cnn = Connect();
            SqlCommand comm;
                cnn.Open();
                 comm = new SqlCommand("InsertGame", cnn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@title", game.Name));
                comm.Parameters.Add(new SqlParameter("@date", game.FirstReleaseDate));
                comm.Parameters.Add(new SqlParameter("@summary", game.Summary));
                comm.ExecuteReader();
                comm.Dispose();
                cnn.Close();
              
                

           
        }
    }
}
