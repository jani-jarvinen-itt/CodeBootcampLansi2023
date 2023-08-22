tiedosto = open("Asiakkaat.csv", "r", encoding="utf8")

rivinumero = 1
for rivi in tiedosto:
  # print(rivi)
  if rivinumero > 1:
    osat = rivi.split(";")
    # print(osat)
    print(osat[1])
  rivinumero = rivinumero + 1

tiedosto.close()
print("-------------")
print("Suoritus päättyy.")
