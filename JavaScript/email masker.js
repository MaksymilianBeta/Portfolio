function maskEmail(email) {
    let miejsce = email.indexOf('@');
    let pierwsza = email[0];
    let ostatnia = email[miejsce - 1];
    let gwiazdki = '*'.repeat(miejsce - 2);
    let domena = email.slice(miejsce);
    return pierwsza + gwiazdki + ostatnia + domena;
}
let email = "apple.pie@example.com";

console.log(maskEmail(email));
console.log(maskEmail("freecodecamp@example.com"));