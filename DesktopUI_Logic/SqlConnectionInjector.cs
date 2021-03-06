﻿using DesktopUI_Logic.Models;
using DesktopUI_Logic.SqlServices;
using DesktopUI_Logic.Unity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DesktopUI_Logic
{
    public class SqlConnectionInjector<T> : ISqlConnectionInjector<T>
    {

        readonly ISqlQueries<T> Sql;
        public SqlConnectionInjector(ISqlQueries<T> sql) => Sql = sql;
        public SqlConnectionInjector()
        {

            IUnityContainer container = new UnityContainer();
            UnityRegister.Register(container);
            //Plugs in Sql Queries depending on T type
            Sql = container.Resolve<ISqlQueries<T>>();

        }



        public List<T> SelectAll() => Sql.SelectAll();

        public void Delete(T model) => Sql.Delete(model);

        public void DeleteAll() => Sql.DeleteAll();

        public void InsertAll(List<T> models) => Sql.InsertAll(models);

        public void UpdateGame(T model) => Sql.Update(model);

        public void InsertGame(T model) => Sql.Insert(model);





    }
}
