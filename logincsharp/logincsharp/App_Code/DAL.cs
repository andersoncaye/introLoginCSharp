using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Descrição resumida de DAL
/// </summary>
public class DAL
{

    private string server = "localhost";
    private string database = "logincsharp";
    private string user = "root";
    private string password = "";
    private string connectionString = "Server={0};Database={1};Uid={2};Pwd={3};";
    private MySqlConnection connection;

    public DAL()
    {
        connectionString = String.Format(connectionString, server, database, user, password);
        connection = new MySqlConnection(connectionString);
        connection.Open();
    }

    public DataTable RetDataTable(string sql)
    {
        DataTable dataTable = new DataTable();

        //faço a conexão com a tabela
        MySqlCommand command = new MySqlCommand(sql, connection);
        //adapta o resultado do comando para ser interpretado
        MySqlDataAdapter da = new MySqlDataAdapter(command);
        //preencho com o resultado interpretado a minha variavel
        da.Fill(dataTable);

        return dataTable;
    }

    public void ExecutarComandoSQL(string sql)
    {
        MySqlCommand command = new MySqlCommand(sql, connection);
        command.ExecuteNonQuery();
    }
}