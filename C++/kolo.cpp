#include <iostream>
using namespace std;

int main()
{
    cout << "Obliczanie obwodu i pola koła" << endl;
    const float pi = 3.14159;
    double promien;

    cout << "Podaj promień: ";
    cin >> promien;

    cout << "Pole koła: " << pi * promien * promien << endl;
    cout << "Obwód koła: " << 2 * pi * promien << endl;

    return 0;
}