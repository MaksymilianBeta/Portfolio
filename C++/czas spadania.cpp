#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    cout << "Program do obliczania czasu spadania swobodnego" << endl;

    double wysokosc;
    const float przyspieszenie = 9.81;

    cout << "Podaj wysokość: ";
    cin >> wysokosc;

    double czas = sqrt(2 * wysokosc / przyspieszenie);
    cout << "Czas swobodnego spadania to: " << czas << " sekundy" << endl;

    return 0;
}