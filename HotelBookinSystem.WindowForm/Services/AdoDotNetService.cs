using HotelBookinSystem.WindowForm.Config;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookinSystem.WindowForm.Services;

public class AdoDotNetService
{
    private SqlConnection GetSqlConnection() => new(DbConfig._connectionString);

    //public async Task<List<T>> QueryAsync<T>(string query, SqlParameter[]? parameters = null, CommandType commandType = CommandType.Text)
    //{
    //    try
    //    {
    //        SqlConnection connection = GetSqlConnection();
    //        await connection.OpenAsync();

    //        SqlCommand command = new(query, connection)
    //        {
    //            CommandType = commandType
    //        };
    //        if (parameters is not null)
    //        {
    //            command.Parameters.AddRange(parameters);
    //        }

    //        SqlDataAdapter adapter = new(command);
    //        DataTable dt = new();
    //        adapter.Fill(dt);

    //        await connection.CloseAsync();

    //        string jsonStr = JsonConvert.SerializeObject(dt);
    //        return JsonConvert.DeserializeObject<List<T>>(jsonStr)!;
    //    }
    //    catch (Exception ex)
    //    {
    //        throw;
    //    }
    //}

    public async Task<List<T>> QueryAsync<T>(string query, SqlParameter[]? parameters = null, CommandType commandType = CommandType.Text)
    {
        try
        {
            SqlConnection connection = GetSqlConnection();
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand(query, connection)
            {
                CommandType = commandType
            };
            if(parameters is not null)
            {
                command.Parameters.AddRange(parameters);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            await connection.CloseAsync();

            string jsonStr = JsonConvert.SerializeObject(dt);
            return JsonConvert.DeserializeObject<List<T>>(jsonStr)!;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<DataTable> QueryFirstOrDefaultAsync(string query, SqlParameter[]? parameters = null, CommandType commandType = CommandType.Text)
    {
        try
        {
            SqlConnection connection = GetSqlConnection();
            await connection.OpenAsync();

            SqlCommand command = new(query, connection)
            {
                CommandType = commandType
            };
            if (parameters is not null)
            {
                command.Parameters.AddRange(parameters);
            }

            SqlDataAdapter adapter = new(command);
            DataTable dt = new();
            adapter.Fill(dt);

            await connection.CloseAsync();

            return dt;
        }
        catch (Exception ex)
        {
            throw;
        }
    }


    public async Task<int> ExecuteAsync(string query, SqlParameter[] parameters)
    {
        try
        {
            SqlConnection connection = GetSqlConnection();
            await connection.OpenAsync();

            SqlCommand command = new(query, connection);
            command.Parameters.AddRange(parameters);

            int result = await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();

            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
