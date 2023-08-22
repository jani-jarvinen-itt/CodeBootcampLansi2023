import sqlite3

yhteys = sqlite3.connect("Asiakkaat.db")
print("Tietokantayhteys avattu.")

kursori = yhteys.cursor()
# kursori.execute("CREATE TABLE asiakkaat(asiakasid, nimi, maa)")
# print("Taulu 'asiakkaat' lisätty.")


asiakasid = "1000"
nimi = "Wilman Kala"
maa = "Suomi"
# kursori.execute("INSERT INTO asiakkaat VALUES ('" + asiakasid + "', '" + nimi + "', '" + maa + "')")
kursori.execute(f"INSERT INTO asiakkaat VALUES ('{asiakasid}', '{nimi}', '{maa}')")
print("Uusi asiakas lisätty tauluun.")



yhteys.commit()
yhteys.close()
print("Tallennus kantaan tehty.")
