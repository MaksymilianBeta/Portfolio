#include <iostream>
using namespace std;

class Uczestnik {
private:
    int nrUczestnika;
    int konkurencja1_pkt;
    int konkurencja2_pkt;
    int konkurencja3_pkt;

public:
    Uczestnik() : nrUczestnika(0), konkurencja1_pkt(0), konkurencja2_pkt(0), konkurencja3_pkt(0) {}

    Uczestnik(int nr, int k1 = 0, int k2 = 0, int k3 = 0) :
        nrUczestnika(nr), konkurencja1_pkt(k1), konkurencja2_pkt(k2), konkurencja3_pkt(k3) {
    }
    ~Uczestnik() {
        cout << "Destruktor obiektu nr uczestnika: " << nrUczestnika << endl;
    }

    void wyswietlDane() {
        cout << "Nr uczestnika: " << nrUczestnika << endl;
        cout << "Konkurencja 1 - pkt: " << konkurencja1_pkt << endl;
        cout << "Konkurencja 2 - pkt: " << konkurencja2_pkt << endl;
        cout << "Konkurencja 3 - pkt: " << konkurencja3_pkt << endl;
        cout << "-----------------------------" << endl;
    }
};

int main() {
    Uczestnik* uczestnik1 = new Uczestnik(12333);
    Uczestnik* uczestnik2 = new Uczestnik(12334, 10);
    Uczestnik* uczestnik3 = new Uczestnik(12335, 10, 20);
    Uczestnik* uczestnik4 = new Uczestnik(12336, 10, 20, 30);

    cout << "Dane uczestników konkursu:" << endl;
    uczestnik1->wyswietlDane();
    uczestnik2->wyswietlDane();
    uczestnik3->wyswietlDane();
    uczestnik4->wyswietlDane();

    delete uczestnik1;
    delete uczestnik2;
    delete uczestnik3;
    delete uczestnik4;

    return 0;
}

