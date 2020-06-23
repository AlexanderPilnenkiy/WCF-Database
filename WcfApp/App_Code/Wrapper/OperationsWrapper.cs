using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class OperationsWrapper
{
    public static void Execute(string Query, NpgsqlConnection Connection)
    {
        using (var command =
            new NpgsqlCommand(Query, Connection))
        {
            command.ExecuteNonQuery();
        }
    }
}