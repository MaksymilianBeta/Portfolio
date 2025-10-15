#include <iostream>
#include <string>
using namespace std;

class Samochod {
private:
    string marka;
    string model;
    double pojemnosc;
    double spalanie;
    double koszty; // w złotówkach

public:
    // Konstruktor domyślny
    Samochod() : marka(""), model(""), pojemnosc(0), spalanie(0), koszty(0) {}

    // Metoda dodająca dane samochodu
    void podajDane() {
        cout << "Podaj markę samochodu: ";
        cin.ignore();
        getline(cin, marka);
        cout << "Podaj model samochodu: ";
        getline(cin, model);
        cout << "Podaj pojemność silnika (l): ";
        cin >> pojemnosc;
        cout << "Podaj spalanie (l/100km): ";
        cin >> spalanie;
        koszty = 0;
    }

    // Metoda obliczająca koszty
    void obliczKoszty(double km, double cenaPaliwa) {
        koszty = (km / 100.0) * spalanie * cenaPaliwa;
    }

    // Metoda wyświetlająca dane samochodu
    void wyswietlDane() {
        cout << "Marka: " << marka << endl;
        cout << "Model: " << model << endl;
        cout << "Pojemność: " << pojemnosc << " l" << endl;
        cout << "Spalanie: " << spalanie << " l/100km" << endl;
        cout << "Koszty: " << koszty << " zł" << endl;
        cout << "-----------------------------" << endl;
    }
};

int main() {
    int liczbaAut;
    cout << "Ile samochodów chcesz przechowywać? ";
    cin >> liczbaAut;

    // Tworzenie dynamicznej tablicy samochodów
    Samochod** auta = new Samochod * [liczbaAut];

    // Dodawanie danych do samochodów
    for (int i = 0; i < liczbaAut; ++i) {
        cout << "\nDodawanie samochodu nr " << i + 1 << ":" << endl;
        auta[i] = new Samochod();
        auta[i]->podajDane();
    }

    // Pobieranie danych do wyliczenia kosztów
    double km, cenaPaliwa;
    cout << "\nPodaj ilość przejechanych kilometrów: ";
    cin >> km;
    cout << "Podaj cenę paliwa (1l): ";
    cin >> cenaPaliwa;

    // Wyliczanie kosztu dla każdego auta
    for (int i = 0; i < liczbaAut; ++i) {
        auta[i]->obliczKoszty(km, cenaPaliwa);
    }

    // Wyświetlanie danych o wszystkich samochodach
    cout << "\nDane samochodów:" << endl;
    for (int i = 0; i < liczbaAut; ++i) {
        auta[i]->wyswietlDane();
    }

    // Zwolnienie pamięci
    for (int i = 0; i < liczbaAut; ++i) {
        delete auta[i];
    }
    delete[] auta;

    return 0;
}