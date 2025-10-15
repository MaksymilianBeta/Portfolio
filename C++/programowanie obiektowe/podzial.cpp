#include <iostream>
#include <string>
using namespace std;

struct Osoba {
    string imie;
    string nazwisko;
};

int main() {
    int liczbaOsob;
    cout << "Podaj liczbę osób: ";
    cin >> liczbaOsob;
    cin.ignore(); // żeby pozbyć się znaku nowej linii po cin

    string* daneWejsciowe = new string[liczbaOsob];
    Osoba* osoby = new Osoba[liczbaOsob];

    for (int i = 0; i < liczbaOsob; ++i) {
        cout << "Dane osoby " << i + 1 << ": ";
        getline(cin, daneWejsciowe[i]);
    }

    // Podział na imię i nazwisko
    for (int i = 0; i < liczbaOsob; ++i) {
        int spacja = daneWejsciowe[i].find(' ');
        osoby[i].imie = daneWejsciowe[i].substr(0, spacja);
        osoby[i].nazwisko = daneWejsciowe[i].substr(spacja + 1);
    }

    cout << "\nLista osób:\n";
    for (int i = 0; i < liczbaOsob; ++i) {
        cout << "Imię: " << osoby[i].imie
            << ", Nazwisko: " << osoby[i].nazwisko << endl;
    }

    delete[] daneWejsciowe;
    delete[] osoby;

    return 0;
}
