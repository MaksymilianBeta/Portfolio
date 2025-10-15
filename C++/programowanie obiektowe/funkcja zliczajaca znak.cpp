#include <iostream>
#include <string>
using namespace std;

int zliczZnak(string ciag, char znak) {
    int licznik = 0;
    for (char c : ciag) {
        if (c == znak) {
            licznik++;
        }
    }
    return licznik;
}

int main() {
    string ciag;
    char szukanyZnak;

    cout << "Podaj ciąg znaków: ";
    cin >> ciag;

    cout << "Podaj znak do zliczenia: ";
    cin >> szukanyZnak;

    int ile = zliczZnak(ciag, szukanyZnak);

    cout << "Znak '" << szukanyZnak << "' występuje " << ile << " razy." << endl;

    return 0;
}