using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Class1
    {
    }
    public class CLSBussLayer
    {
        ClsDataLayer objDAL = new ClsDataLayer();
        public void InsertUser(string _name,string _city,string _email)
        {
            objDAL.InsertData(_name, _city, _email);
        }
        public object SelectUser()
        {
            return objDAL.SelectData();
        }
    }
}
