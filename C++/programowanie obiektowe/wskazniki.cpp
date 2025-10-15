#include <iostream>
#include <string>
using namespace std;

int main()
{
    int owoc = 6;
    float warzywo = 12.6;
    string zwierze = "kot";

    int* wskaznik_owoc = &owoc;
    float* wskaznik_warzywo = &warzywo;
    string* wskaznik_zwierze = &zwierze;

    
    cout << "Adres owoc: " << wskaznik_owoc << endl;
    cout << "Adres warzywo: " << wskaznik_warzywo << endl;
    cout << "Adres zwierze: " << wskaznik_zwierze << endl;

   
    cout << "Wartość owoc: " << *wskaznik_owoc << endl;
    cout << "Wartość warzywo: " << *wskaznik_warzywo << endl;
    cout << "Wartość zwierze: " << *wskaznik_zwierze << endl;

    return 0;
}