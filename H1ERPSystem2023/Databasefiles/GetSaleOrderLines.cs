using H1ERPSystem2023.DomainModel;
using Microsoft.Data.SqlClient;

namespace H1ERPSystem2023.Databasefiles;

public partial class Database
{
    private List<OrderLineModel> saleOderLines = new();

    private void GetSaleOrderLines(SqlConnection connection)
    {
        try
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.OrderLines", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                OrderLineModel orderLineModel = new()
                {
                    
                };

                saleOderLines.Add(orderLineModel);

            }

            connection.Close();
        }
        catch (Exception e)
        {
            connection.Close();
            Console.WriteLine(
                $"Something went wrong while trying to retrieve Products from the database \n {e.Message}");
        }

        
    }
}