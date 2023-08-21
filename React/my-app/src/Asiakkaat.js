import { useState, useEffect } from 'react';

export default function Asiakkaat() {
    const [asiakasLista, setAsiakasLista] = useState([]);

    console.log("Asiakkaat-komponentti: ennen useEffect-kutsua.");
    useEffect(() => {
        if (asiakasLista.length === 0) {
            fetch('https://localhost:7023/api/asiakkaat')
                .then(response => response.json())
                .then(json => {
                    console.log(json);
                    setAsiakasLista(json);
                });
        }
    });

    console.log("Asiakkaat-komponentti: render-vaihe.");
    let lista = [];
    for (const indeksi in asiakasLista) {
        // console.log(indeksi);
        lista.push(<p>{asiakasLista[indeksi].companyName}</p>);
    }

    return <div>
        <h1>Terve! Olen Asiakkaat-komponentti.</h1>
        {lista}
    </div>
}
