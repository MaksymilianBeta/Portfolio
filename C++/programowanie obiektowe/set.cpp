#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <set>
using namespace std;

int main()
{
    set<string> miasta;
    int ile;

    cout << "Podaj z ilu miast będzie składał się słownik: ";
    cin >> ile;
    cin.ignore(); // żeby pozbyć się znaku nowej linii po cin

    for (int i = 0; i < ile;) {
        string miasto;
        cout << "Podaj miejscowość " << i + 1 << ": ";
        getline(cin, miasto);

        if (miasta.find(miasto) != miasta.end()) {
            cout << miasto << " już istnieje w słowniku." << endl;
            continue;
        }

        miasta.insert(miasto);
        i++;
    }

    cout << "\nSłownik miast:" << endl;
    for (const auto& x : miasta) {
        cout << x << endl;
    }

    return 0;
}