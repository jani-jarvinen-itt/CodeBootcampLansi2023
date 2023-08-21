import { useState } from 'react';

export default function Käyttäjät() {
    const [käyttäjäLista, setKäyttäjäLista] = useState([]);

    let lista = [];
    for (const käyttäjä in käyttäjäLista) {
        lista.push(<p>{käyttäjä.name}</p>);
    }

    return <div>
        <h1>Moi! Olen Käyttäjät-komponentti.</h1>
        {lista}
    </div>
}
