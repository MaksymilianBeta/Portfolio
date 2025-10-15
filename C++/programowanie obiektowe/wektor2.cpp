#include <iostream>
#include <vector>
using namespace std;

int main()
{
    cout << "Podaj liczbę elementów: ";
    int n;
    cin >> n;

    vector<int> liczby(n);
    vector<int> parzyste;

    cout << "Podaj " << n << " liczb całkowitych:" << endl;
    for (int i = 0; i < n; i++) {
        cin >> liczby[i];
        if (liczby[i] % 2 == 0) {
            parzyste.push_back(liczby[i]);
        }
    }

    cout << "\nPodane liczby (" << liczby.size() << " elementów): ";
    for (int liczba : liczby) {
        cout << liczba << " ";
    }

    cout << "\nLiczby parzyste (" << parzyste.size() << " elementów): ";
    for (int liczba : parzyste) {
        cout << liczba << " ";
    }

    cout << endl;
    return 0;
}