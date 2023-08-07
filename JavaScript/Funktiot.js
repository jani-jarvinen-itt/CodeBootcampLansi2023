// klassinen/perinteinen funktion määritys
function laskeSumma(a, b) {
    return a + b;
}

let summa = laskeSumma(1, 2);
console.log(summa);

// -----------------------

let summafunktio = function(a, b) {
    return a + b;
}

summa = summafunktio(11, 22);
console.log(summa);

// -----------------------
// nuolifunktio

let summafunktio2 = (a, b) => {
    return a + b;
}
summa = summafunktio2(111, 222);
console.log(summa);

let summafunktio3 = (a, b) => a + b;
summa = summafunktio3(1111, 2222);
console.log(summa);
