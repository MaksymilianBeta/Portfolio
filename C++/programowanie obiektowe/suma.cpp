#include <iostream>
#include <string>
using namespace std;

double obliczSume(float* tablica, int liczba_elementow) {
    double suma = 0.0;
    for (int i = 0; i < liczba_elementow; i++) {
        suma += tablica[i];
    }
    return suma;
}

int main() {
    int liczba_elementow;
    cout << "Podaj liczbę elementów: ";
    cin >> liczba_elementow;

    float* tablica = new float[liczba_elementow];
    cout << "Podaj " << liczba_elementow << " elementów:" << endl;

    for (int i = 0; i < liczba_elementow; i++) {
        cin >> tablica[i];
    }

    float* wskaznik = tablica;
    for (int i = 0; i < liczba_elementow; i++) {
        cout << *(wskaznik + i) << endl;
    }

    double suma = obliczSume(tablica, liczba_elementow);
    double srednia = suma / liczba_elementow;

    cout << "Suma: " << suma << endl;
    cout << "Średnia: " << srednia << endl;

    delete[] tablica;
    return 0;
}