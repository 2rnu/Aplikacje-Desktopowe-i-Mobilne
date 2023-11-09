#include <iostream>
using namespace std;

int main() {
	//Zadanie 1
	
	void Zad1(); {
		int a;
		cout << "Podaj pierwsza wartosc a. Uwaga, podaj wartosc liczbowa wieksza od 1\n";
		cin >> a;
		int b;
		cout << "Podaj pierwsza wartosc b. Uwaga, podaj wartosc liczbowa wieksza od 1 oraz wieksza od pierwszej liczby.\n";
		cin >> b;

		int P_prostokata;

		if(a > 1 && b > 1 && b > a)
		{
			P_prostokata = a * b;
			cout << "Pole prostokata wynosi:\n";
			cout << P_prostokata << endl;
		}
		else
		{
			cout << "Podane wartości są nieprawidłowe. Upewnij się, że wartości są dodatnie oraz, że wartość b jest większa od a.";
		}
	}

	//Zadanie 2

	void Zad2(); {
		int a;
		int b;

		cout << "Podaj pierwszą liczbe do sprawdzenia.\n";
		cin >> a;

		cout << "Podaj druga liczbę do sprawdzenia.\n";
		cin >> b;

		if (a == b)
		{
			cout << "Podane przez Ciebie liczbą są rowne.\n";
		}
		else
		{
			cout << "Podane przez Ciebie liczby nie są rowne.\n";
		}
	}

	//Zadanie 3

	void Zad3(); {
		float a = 3.45;

		if (a >= -5 && a < 7)
		{
			cout << "Podane wartość należy do przedziału <-5,7).";
		}
		else
		{
			cout << "Podana wartość nie należy do przedziału.";
		}
	}

	//Zadanie 4

	void Zad4(); {
		int ilosc;

		cout << "Ile liczb chcesz dodać?";
		cin >> ilosc;
	}

	//Zadanie 5

	void Zad5(); {
		int liczba;
		string liczba_binarna;

		cout << "Podaj liczbę w systemie dziesiętnym. Np.: 46\n";
		cin >> liczba;

		while (liczba == 0)
		{
			liczba_binarna = liczba % 2;
		}

		cout << "Podana wartość w systemie binarnym wynosi.";
		cout << liczba_binarna;
	}
}