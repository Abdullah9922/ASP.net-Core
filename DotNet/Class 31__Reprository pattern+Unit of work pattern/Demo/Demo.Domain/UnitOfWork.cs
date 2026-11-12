using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
    public class UnitOfWork
    {
        private ArrayList _itemsToAdd = new ArrayList();
        private ArrayList _itemsToUpdate = new ArrayList();
        private ArrayList _itemsToDelete = new ArrayList();

        public void Add(object o)
        {
            _itemsToAdd.Add(o);
        }

        public void Remove(object o)
        {
            _itemsToDelete.Add(o);
        }

        public void Update(object o)
        {
            _itemsToUpdate.Add(o);
        }

        public void SaveChanges()
        {
            /**
             * try
             * {
             *      SqlTransation t = new SqlTransaction(sqlConnection);
             *      t.Start();
             *      
             *      foreach(var i in _itemsToAdd)
             *      {
             *         SqlCommand c = new SqlCommand(sqlConnection, generateSql(i))
             *        // ado.net code to add 
             *      }
             *      
             *      foreach(var i in _itemsToDelete)
             *      {
             *      
             *      }
             *      
             *      
             *      foreach(var i in _itemsToUpdate)
             *      {
             *      
             *      
             *      }
             *      
             *      t.Commit();
             *  }
             *  catch(Exception e)
             *  {
             *      t.Rollback();
             *  }
             */
        }
    }
}
