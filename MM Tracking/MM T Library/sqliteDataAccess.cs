using MM_T_Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MM_T_Library
{
    public class sqliteDataAccess : IDataConnection 
    {
        public List<Models.instrument> instrument_GetAll()
        {
            List<instrument> output;
            //open the connection and close when done , never leave connection open
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                output = cnn.Query<instrument>("SELECT * FROM instrument").ToList();
            }
            return output;
        }

        public void instrument_Create(Models.instrument ins)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into instrument (Number, Client, Money, Date) values(@Number, @Client, @Money, @Date) ", ins);
            }
        }

        public void instrument_Edit(Models.instrument ins)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("update instrument set  Number=@Number, Client=@Client, Money=@Money, Date=@Date where Number = @Number", ins);
            }
        }

        public void instrument_Delete(Models.instrument ins)
        {
            using (var cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("delete from instrument where Number = @Number", new { Number = ins.Number });
            }
        }
    }
}
