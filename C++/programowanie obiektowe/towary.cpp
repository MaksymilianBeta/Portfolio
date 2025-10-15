#include <iostream>
#include <string>
using namespace std;

class Towar {
private:
    string nazwa;
    int ilosc;
    double cenaNetto;
    double VAT;

public:
    void pobierzDane() {
        cout << "Podaj nazwę towaru: ";
        cin >> nazwa;
        cout << "Podaj ilość: ";
        cin >> ilosc;
        cout << "Podaj cenę netto: ";
        cin >> cenaNetto;
        cout << "Podaj VAT (np. 23 dla 23%): ";
        cin >> VAT;
    }

    double obliczBrutto() const {
        return cenaNetto * (1 + VAT / 100);
    }

    void wyswietlInformacje() const {
        cout << "Nazwa towaru: " << nazwa << endl;
        cout << "Ilość: " << ilosc << endl;
        cout << "Cena netto: " << cenaNetto << " zł" << endl;
        cout << "VAT: " << VAT << "%" << endl;
        cout << "Wartość brutto: " << obliczBrutto() << " zł" << endl;
        cout << "-----------------------------" << endl;
    }
};

int main() {
    const int ROZMIAR = 3;
    Towar towary[ROZMIAR];

    for (int i = 0; i < ROZMIAR; i++) {
        cout << "\nTowar #" << (i + 1) << endl;
        towary[i].pobierzDane();
    }

    cout << "\nDane wszystkich towarów:\n";
    for (int i = 0; i < ROZMIAR; i++) {
        cout << "Towar #" << (i + 1) << endl;
        towary[i].wyswietlInformacje();
    }

    return 0;
}
