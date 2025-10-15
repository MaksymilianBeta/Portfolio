#include <iostream>
#include <string>
using namespace std;

int main()
{
    int liczba_elementow;
    cout << "Podaj liczbę elementów:" << endl;
    cin >> liczba_elementow;

    float* tablica = new float[liczba_elementow];
    cout << "Podaj " << liczba_elementow << " liczby:" << endl;

    float* wskaznik = tablica;
    for (int i = 0; i < liczba_elementow; i++) {
        cin >> *(wskaznik + i);
    }

    double suma = 0.0;
    for (int i = 0; i < liczba_elementow; i++) {
        suma += *(wskaznik + i);
    }

    double srednia = suma / liczba_elementow;

    cout << "Suma: " << suma << endl;
    cout << "Średnia: " << srednia << endl;

    delete[] tablica;
    return 0;
}