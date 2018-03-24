using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class Class1
    {
    }
    public class ClsDataLayer
    {
        SqlConnection sqlconn = new SqlConnection("Data Source=.\\ABRAHAM-PC;Initial Catalog='assSE';Integrated Security='true'");

        public void InsertData(string _name, string _city, string _email)
        {
            SqlDataAdapter SQLadp=new SqlDataAdapter("Insert into  UserMst values (' " +_name +" ', ' " + _city +" ', ' " + _email +" ')", sqlconn);
            DataTable DT=new DataTable();
            SQLadp.Fill(DT);
        }
        public object SelectData()
        {
            SqlDataAdapter SQLadp = new SqlDataAdapter("Select * from UserMst" , sqlconn);
            DataTable DT = new DataTable();
            SQLadp.Fill(DT);
            return DT;

        }
    }
}
