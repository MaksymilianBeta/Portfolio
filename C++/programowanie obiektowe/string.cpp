#include <iostream>
#include <string>
using namespace std;

int main() {
    string tekst = "Ala ma kota, a kotek pije mleczko";
    string szukane;

    cout << "Podaj słowo do wyszukania: ";
    cin >> szukane;

    size_t pozycja = tekst.find(szukane);

    if (pozycja == string::npos) {
        cout << "Nie znaleziono" << endl;
    }
    else {
        cout << "Znaleziono na pozycjach: ";
        while (pozycja != string::npos) {
            cout << pozycja << " ";
            pozycja = tekst.find(szukane, pozycja + 1);
        }
        cout << endl;
    }

    return 0;
}