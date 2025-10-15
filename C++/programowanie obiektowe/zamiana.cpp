#include <iostream>
#include <string>
using namespace std;

int main() {
    string przyslowie = "kwiecień-plecień, bo przeplata — trochę zimy, trochę lata";

    cout << przyslowie.length() << endl;
    cout << przyslowie.capacity() << endl;

    int pozycja1 = przyslowie.find("przeplata");
    cout << "Pozycja dla frazy 'przeplata': " << pozycja1 << endl;

    int pozycja2 = przyslowie.find("trochę");
    cout << "Pozycja dla frazy 'trochę': " << pozycja2 << endl;

    int pozycjaTroche = przyslowie.find("trochę", pozycja2 + 1);
    cout << "Pozycja dla drugiego 'trochę': " << pozycjaTroche << endl;

    string nowy = przyslowie.substr(pozycja2, 13); // "trochę zimy,"
    cout << "Nowy string to: " << nowy << endl;

    int pozycja4 = nowy.find("lata");
    if (pozycja4 != string::npos) {
        nowy.erase(pozycja4, 4);
    }
    cout << nowy << endl;

    return 0;
}