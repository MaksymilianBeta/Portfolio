#include <iostream>
#include <cmath>
using namespace std;

const int liczba = 2;

int main()
{
    struct Samochody {
        char marka[100];
        char model[100];
        int rocznik;
        double wartosc;
    };

    Samochody tab[liczba];

    for (int i = 0; i < liczba; i++) {
        cout << "Podaj markę: ";
        cin >> tab[i].marka;

        cout << "Podaj model: ";
        cin >> tab[i].model;

        cout << "Podaj rocznik: ";
        cin >> tab[i].rocznik;

        cout << "Podaj wartość: ";
        cin >> tab[i].wartosc;
    }

    cout << "\nDane wprowadzone:\n";
    for (int i = 0; i < liczba; i++) {
        cout << "Samochód " << i + 1 << ":\n";
        cout << "Marka: " << tab[i].marka << endl;
        cout << "Model: " << tab[i].model << endl;
        cout << "Rocznik: " << tab[i].rocznik << endl;
        cout << "Wartość: " << tab[i].wartosc << " zł" << endl;
        cout << "------------------------" << endl;
    }

    return 0;
}