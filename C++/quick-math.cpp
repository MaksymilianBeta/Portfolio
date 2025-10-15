#include <iostream>
using namespace std;

int wybor;
float bok, bok1, bok2, promien;

int main()
{
    do {
        cout << "1. Kwadrat" << endl;
        cout << "2. Prostokąt" << endl;
        cout << "3. Koło" << endl;
        cout << "4. Koniec programu" << endl;
        cin >> wybor;

        float wynik;

        switch (wybor) {
        case 1:
            cout << "Podaj długość boku: ";
            cin >> bok;
            wynik = bok * bok;
            cout << "Pole kwadratu to: " << wynik << endl;
            break;

        case 2:
            cout << "Podaj długość boku 1: ";
            cin >> bok1;
            cout << "Podaj długość boku 2: ";
            cin >> bok2;
            wynik = bok1 * bok2;
            cout << "Pole prostokąta to: " << wynik << endl;
            break;

        case 3:
            cout << "Podaj promień: ";
            cin >> promien;
            const float pi = 3.14159;
            wynik = pi * promien * promien;
            cout << "Pole koła to: " << wynik << endl;
            break;
        }

    } while (wybor != 4);

    return 0;
}