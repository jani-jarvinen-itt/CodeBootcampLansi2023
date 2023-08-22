tiedosto = open("Asiakkaat.csv", "r")
for rivi in tiedosto:
  print(rivi)


tiedosto.close()
print("Suoritus päättyy.")
