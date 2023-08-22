import sqlite3

yhteys = sqlite3.connect("Asiakkaat.db")
print("Tietokantayhteys avattu.")

kursori = yhteys.cursor()
# kursori.execute("CREATE TABLE asiakkaat(asiakasid, nimi, maa)")
# print("Taulu 'asiakkaat' lisätty.")

tiedosto = open("Asiakkaat.csv", "r", encoding="utf8")
print("CSV-tiedosto avattu.")

rivinumero = 1
for rivi in tiedosto:
  if rivinumero > 1:
    osat = rivi.split(";")

    asiakasid = osat[0]
    nimi = osat[1]
    maa = osat[2].strip()
    kursori.execute(f"INSERT INTO asiakkaat VALUES ('{asiakasid}', '{nimi}', '{maa}')")
    print(f"Uusi asiakas lisätty tauluun: {nimi}.")

  rivinumero = rivinumero + 1

tiedosto.close()
yhteys.commit()
yhteys.close()
print("Tallennus kantaan tehty ja resurssit suljettu.")
