#include <iostream>

using namespace std;

class Lokata {
private:
    int nrLokaty;
    float kwota;
    int liczbaDni;
    float oprocentowanie;

public:
    Lokata(int nr, float kw, int dni, float proc)
        : nrLokaty(nr), kwota(kw), liczbaDni(dni), oprocentowanie(proc) {
    }

    Lokata(int nr, float kw, int dni)
        : nrLokaty(nr), kwota(kw), liczbaDni(dni), oprocentowanie(0.05f) {
    }

    float obliczZysk() const {
        return kwota * oprocentowanie * liczbaDni / 365.0;
    }

    void wyswietlInformacje() const {
        cout << "Nr lokaty: " << nrLokaty << endl;
        cout << "Kwota lokaty: " << kwota << " zl" << endl;
        cout << "Liczba dni: " << liczbaDni << endl;
        cout << "Oprocentowanie: " << oprocentowanie * 100 << "%" << endl;
        cout << "Zysk: " << obliczZysk() << " zl" << endl;
        cout << "-------------------------" << endl;
    }
};

int main() {
    // Tworzenie Lokat
    Lokata lokata1(12345, 10000, 180);
    Lokata lokata2(67890, 15000, 90, 0.065);

    // Wyświetlanie danych o Lokatach
    cout << "Informacje o lokatach:" << endl;
    lokata1.wyswietlInformacje();
    lokata2.wyswietlInformacje();

    return 0;
}