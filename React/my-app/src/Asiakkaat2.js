import { useState, useEffect } from 'react';

// Python-versio
export default function Asiakkaat2() {
    const [asiakasLista, setAsiakasLista] = useState([]);

    console.log("Asiakkaat2-komponentti: ennen useEffect-kutsua.");
    useEffect(() => {
        if (asiakasLista.length === 0) {
            fetch('http://localhost:5000/api/asiakkaat')
                .then(response => response.json())
                .then(json => {
                    console.log(json);
                    setAsiakasLista(json);
                });
        }
    });

    console.log("Asiakkaat2-komponentti: render-vaihe.");
    let lista = [];
    for (const indeksi in asiakasLista) {
        // console.log(indeksi);
        lista.push(<p key={asiakasLista[indeksi].customerId}>
            {asiakasLista[indeksi][1]}</p>);
    }

    return <div>
        <h1>Terve! Olen Asiakkaat2-komponentti.</h1>
        {lista}
    </div>
}
