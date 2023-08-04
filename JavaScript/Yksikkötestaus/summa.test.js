const summa = require('./summa');

test('lukujen 1 ja 2 summa tulee olla 3', () => {
    expect(summa(1, 2)).toBe(3);
});

test('lukujen 10 ja 20 summa tulee olla 30', () => {
    expect(summa(10, 20)).toBe(30);
});

test('lukujen 55 ja 12 summa tulee olla 3', () => {
    expect(summa(55, 12)).toBe(67);
});
