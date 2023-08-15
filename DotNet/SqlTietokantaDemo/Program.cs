using Microsoft.Data.SqlClient;

string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;";
SqlConnection yhteys = new(yhteysmerkkijono);
yhteys.Open();
Console.WriteLine("Tietokantayhteys avattu!");

string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
SqlCommand komento = new(sql, yhteys);

SqlDataReader lukija = komento.ExecuteReader();
while (lukija.Read())
{
    string yritys = lukija["CompanyName"].ToString();
    Console.WriteLine(yritys);
}

lukija.Close();
komento.Dispose();
yhteys.Close();
Console.WriteLine("Tietokantayhteys suljettu.");
