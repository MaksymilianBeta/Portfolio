#include <iostream>
#include <string>
using namespace std;

class Sala {
private:
    double dlugosc;
    double szerokosc;
    int liczbaMiejsc;
    bool posiadaProjektor;

public:
    Sala(double dl, double sz, int miejsca, bool projektor) {
        dlugosc = dl;
        szerokosc = sz;
        liczbaMiejsc = miejsca;
        posiadaProjektor = projektor;

        cout << "Informacje o sali:" << endl;
        cout << "Długość sali: " << dlugosc << " m" << endl;
        cout << "Szerokość sali: " << szerokosc << " m" << endl;
        cout << "Liczba miejsc: " << liczbaMiejsc << endl;
        cout << "Czy sala posiada projektor? ";
        if (posiadaProjektor) {
            cout << "Tak" << endl;
        }
        else {
            cout << "Nie" << endl;
        }
    }

    double getDlugosc() const {
        return dlugosc;
    }

    double getSzerokosc() const {
        return szerokosc;
    }

    // Funkcja zaprzyjaźniona z klasą
    friend void obliczPowierzchnie(const Sala& sala) {
        double powierzchnia = sala.getDlugosc() * sala.getSzerokosc();
        cout << "Powierzchnia sali: " << powierzchnia << " m^2" << endl;
    }
};

int main() {
    Sala sala1(10.5, 7.2, 60, true);
    cout << "\nInformacje o salach:" << endl;
    obliczPowierzchnie(sala1);
    return 0;
}