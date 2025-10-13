function piramida(znak, wiersze, dogorynogami) {
  let wynik = "\n";
  for (let i = 0; i < wiersze; i++) {
    let level;
    if (dogorynogami==true) {
      level = wiersze - i - 1;
    } else {
      level = i;
    }
    const numChars = 2 * level + 1;
    const numSpaces = wiersze - level ;
    wynik = wynik+ " ".repeat(numSpaces) + znak.repeat(numChars) + "\n";
  }
  return wynik;
}
console.log(piramida("o", 5, false));