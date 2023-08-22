# Sovelluksen käynnistykomento:
# flask --app .\FlaskWebApiTesti.py run

from flask import Flask
from flask_cors import CORS
import sqlite3

app = Flask(__name__)
CORS(app)

@app.route("/")
def moi_maailma():
    return "<p>Moikka maailma, terveisiä Code Bootcampiltä!</p>"

@app.route("/api/asiakkaat")
def hae_asiakkaat():
    yhteys = sqlite3.connect("..\\Asiakkaat.db")
    kursori = yhteys.cursor()
    vastaus = kursori.execute("SELECT * FROM asiakkaat")
    tulos = vastaus.fetchall()
    yhteys.close()
    return tulos
