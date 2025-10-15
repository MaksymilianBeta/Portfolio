#include <iostream>
#include <string>
using namespace std;

class Sala {
private:
    string numerSali;
    double dlugosc;
    double szerokosc;
    int liczbaMiejsc;
    bool posiadaProjektor;

public:
    // Konstruktor
    Sala(string nr, double dl, double sz, int miejsca, bool projektor) {
        numerSali = nr;
        dlugosc = dl;
        szerokosc = sz;
        liczbaMiejsc = miejsca;
        posiadaProjektor = projektor;
    }

    // Metoda wyświetlająca informacje o sali
    void wyswietlInformacje() {
        cout << "Numer sali: " << numerSali << endl;
        cout << "Długość sali: " << dlugosc << " m" << endl;
        cout << "Szerokość sali: " << szerokosc << " m" << endl;
        cout << "Liczba miejsc: " << liczbaMiejsc << endl;
        cout << "Czy posiada projektor: " << (posiadaProjektor ? "Tak" : "Nie") << endl;
        cout << "-----------------------------" << endl;
    }
};

int main() {
    // Tworzenie obiektu sali
    Sala sala1("A12", 10, 5.5, 25, false);

    // Wyświetlanie informacji o salach
    cout << "Informacje o salach:" << endl;
    sala1.wyswietlInformacje();

    return 0;
}
