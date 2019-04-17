using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de LoginBLL
/// </summary>
public class LoginBLL
{

    private string user { get; set; }
    private string password { get; set; }

    private DAL dal = new DAL();

    public LoginBLL()
    {
    }

    public DataTable RetListaUser()
    {
        return dal.RetDataTable("select * from login");
    }

    public void InsertUser()
    {
        string sql = "insert into login (user, pass) values ('{0}','{1}')";
        sql = String.Format(sql, user, password);
        dal.ExecutarComandoSQL(sql);
    }
}