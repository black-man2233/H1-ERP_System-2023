#pragma warning disable
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles;

public partial class Database
{
    private static List<AddressModel> Addresses = new();

    private static void GetAddressesFromDB(SqlConnection connection)
    {
        using (connection)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Addres", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                AddressModel address = new AddressModel();
                address.AddressId = (int)reader["AddressId"];
                address.Street = reader["Street"].ToString();
                address.StreetNumber = reader["StreetNumber"].ToString();
                address.City = reader["City"].ToString();
                address.PostalCode = reader["PostalCode"].ToString();
                address.Country = reader["Country"].ToString();

                Addresses.Add(address);
            }

            connection.Close();
        }
    }

    public AddressModel GetAddress(string ID)
    {
        foreach (AddressModel address in Addresses)
        {
            if (address.AddressId == int.Parse(ID))
            {
                return address;
            }
        }

        //If the ID given doesn't exist, the return is "ID doesn't exist" and null, otherwise it would give issues 
        Console.WriteLine("Id findes Ikke");
        return null!;
    }

    public void AddCAddress(AddressModel address)
    {
        Addresses.Add(address);
        _addAddressToDB(address.Street, address.StreetNumber,address.City,address.PostalCode,address.Country);
    }
    private void _addAddressToDB(string street, string streetNumber,string city, string postalCode, string country)
    {
        using (SqlConnection connection = GetConnection())
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Addres (Street,StreetNumber, City, PostalCode, Country) VALUES (@Street,@StreetNumber, @City, @PostalCode, @Country)", connection);
            command.Parameters.AddWithValue("@Street", street);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@StreetNumber", streetNumber);
            command.Parameters.AddWithValue("@PostalCode", postalCode);
            command.Parameters.AddWithValue("@Country", country);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
    }
    

    //UpdateCompany uses foreach and if to Identity the company, then updates it, 
    //Void is used to avoid method wanting a return
    public void UpdateAdress(string ID, string street, string streetNumber, string postalCode,
        string city, string country)
    {
        foreach (AddressModel address in Addresses)
        {
            if (address.AddressId == int.Parse(ID))
            {
                address.Street = street;
                address.StreetNumber = streetNumber;
                address.City = city;
                address.PostalCode = postalCode;
                address.Country = country;
            }
        }
    }

    //RemoveCompany uses the if and foreach to identify the right company, then uses remove company
    //RemoveCompany break is used due to the Company going back to company afterwards and
    //crashes due to ID not existing anymore.
    public void RemoveAddress(string ID)
    {
        foreach (AddressModel address in Addresses)
        {
            if (address.AddressId == int.Parse(ID))
            {
                Addresses.Remove(address);
                RemoveAddress(Int32.Parse(ID));
                break;
            }
        }
    }

    private static void RemoveAddress(int addressId)
    {
        try
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM dbo.Addres WHERE AddressId = @AddressId", connection);
                command.Parameters.AddWithValue("@AddressId", addressId);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Something Went Wrong trying to delete this address");
        }
    }
}