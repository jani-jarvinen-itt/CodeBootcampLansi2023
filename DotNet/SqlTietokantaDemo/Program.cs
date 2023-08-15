using Microsoft.Data.SqlClient;

string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;";
using (SqlConnection yhteys = new(yhteysmerkkijono))
{
    yhteys.Open();
    Console.WriteLine("Tietokantayhteys avattu!");

    string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
    using (SqlCommand komento = new(sql, yhteys))
    {
        using (SqlDataReader lukija = komento.ExecuteReader())
        {
            while (lukija.Read())
            {
                string yritys = lukija["CompanyName"]?.ToString() ?? "";
                Console.WriteLine(yritys);
            }
        }
    }
}
Console.WriteLine("Tietokantayhteys suljettu.");
