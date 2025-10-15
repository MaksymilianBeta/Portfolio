#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <map>
using namespace std;

int main() {
    map<int, string> DniTygodnia = {
        {1, "poniedziałek"},
        {2, "wtorek"},
        {3, "środa"},
        {4, "czwartek"},
        {5, "piątek"},
        {6, "sobota"},
        {7, "niedziela"}
    };

    cout << "Podaj liczbę, a zwrócę Ci dzień tygodnia: ";
    int dzien;
    cin >> dzien;

    if (DniTygodnia.find(dzien) != DniTygodnia.end()) {
        cout << "Dzień tygodnia: " << DniTygodnia[dzien] << endl;
    }
    else {
        cout << "Nie ma takiego dnia tygodnia!" << endl;
    }

    return 0;
}