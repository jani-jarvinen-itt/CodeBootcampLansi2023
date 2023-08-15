using Microsoft.Data.SqlClient;

string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;";
SqlConnection yhteys = new(yhteysmerkkijono);
try
{
    yhteys.Open();
    Console.WriteLine("Tietokantayhteys avattu!");

    string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
    SqlCommand komento = new(sql, yhteys);
    try
    {
        SqlDataReader lukija = komento.ExecuteReader();
        try
        {
            while (lukija.Read())
            {
                string yritys = lukija["CompanyName"]?.ToString() ?? "";
                Console.WriteLine(yritys);
            }
        }
        finally
        {
            lukija.Close();
        }
    }
    finally
    {
        komento.Dispose();
    }
}
finally
{
    yhteys.Close();
    Console.WriteLine("Tietokantayhteys suljettu.");
}
