#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    float waga, wzrost;
    cout << "Podaj wagę w kg: ";
    cin >> waga;

    cout << "Podaj wzrost w metrach (np. 1.85): ";
    cin >> wzrost;

    if (wzrost <= 0 || wzrost >= 2.15) {
        cout << "Podano nieprawidłowy wzrost." << endl;
        return 0;
    }

    float bmi = waga / (wzrost * wzrost);

    cout << "Twój BMI: " << bmi << endl;

    if (bmi < 18.5) {
        cout << "Niedowaga" << endl;
    }
    else if (bmi < 24.9) {
        cout << "Waga prawidłowa" << endl;
    }
    else if (bmi < 29.9) {
        cout << "Nadwaga" << endl;
    }
    else {
        cout << "Otyłość" << endl;
    }

    return 0;
}