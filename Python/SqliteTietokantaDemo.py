import sqlite3

yhteys = sqlite3.connect("Asiakkaat.db")
print("Tietokantayhteys avattu.")

kursori = yhteys.cursor()
kursori.execute("CREATE TABLE asiakkaat(asiakasid, nimi, maa)")
print("Taulu 'asiakkaat' lisätty.")

# ???

yhteys.commit()
yhteys.close()
print("Tallennus kantaan tehty.")
