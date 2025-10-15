#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    int liczbaElementow;
    vector<int> liczby;

    cout << "Podaj liczbę elementów: ";
    cin >> liczbaElementow;

    cout << "Podaj " << liczbaElementow << " liczb:" << endl;
    for (int i = 0; i < liczbaElementow; ++i) {
        int liczba;
        cin >> liczba;
        liczby.push_back(liczba);
    }

    cout << "\nPobrane liczby: ";
    for (int liczba : liczby) {
        cout << liczba << " ";
    }
    cout << endl;

    sort(liczby.begin(), liczby.end());

    cout << "Posortowane liczby: ";
    for (int liczba : liczby) {
        cout << liczba << " ";
    }
    cout << endl;

    if (!liczby.empty()) {
        cout << "Najmniejsza wartość: " << liczby.front() << endl;
        cout << "Największa wartość: " << liczby.back() << endl;
    }
    else {
        cout << "Brak liczb do wyświetlenia." << endl;
    }

    return 0;
}