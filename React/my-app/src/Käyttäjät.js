import { useState, useEffect } from 'react';

export default function Käyttäjät() {
    const [käyttäjäLista, setKäyttäjäLista] = useState([]);

    console.log("Käyttäjät-komponentti: ennen useEffect-kutsua.");
    useEffect(() => {
        if (käyttäjäLista.length === 0) {
            fetch('https://jsonplaceholder.typicode.com/users')
                .then(response => response.json())
                .then(json => {
                    console.log(json);
                    setKäyttäjäLista(json);
                });
        }
    });

    console.log("Käyttäjät-komponentti: render-vaihe.");
    let lista = [];
    for (const indeksi in käyttäjäLista) {
        // console.log(indeksi);
        lista.push(<p>{käyttäjäLista[indeksi].name}</p>);
    }

    return <div>
        <h1>Moi! Olen Käyttäjät-komponentti.</h1>
        {lista}
    </div>
}
