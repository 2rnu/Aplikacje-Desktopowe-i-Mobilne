#include <iostream>
#include <string>
#include "Variable.cpp"

using namespace std;

void VariableTask1()
{
	//Napisz program, który wczyta od użytkownika jego wiek a następnie wyświetli go na konsoli.
	cout << "Podaj swój wiek" << endl;
	cin >> wiek;
	cout << wiek;
}

void VariableTask2()
{
	//Stwórz program, który pobiera od użytkownika długość w metrach i przelicza ją na centymetry, milimetry i  kilometry. Wyświetl wynik.

	float metr;
	std << "Podaj ile metrów?"
	cin >> metr;

	float centimetr = metr * 100;
	float milimetr = centimetr * 10;
	float kilometer = metr / 1000

	cout << "Centymetry:" + centimetr << endl;
	cout << "Milimetr:" + milimetr << endl;
	cout << "Kilometry:" + kilometer << endl;
}

void VariableTask3()
{
	//Napisz program, który poprosi użytkownika o podanie długości boku a i b prostokąta, a następnie obliczy i wyświetli pole prostokąta.

	float a;
	float b;

	float Pole = a * b;
	

	cout << "Podaj a" << endl;
	cin >> a;

	cout << "Podaj b" << endl;
	cin >> b;

	cout << "Pole trójkąta wynosi:" + Pole << endl;
}

void VaraibleTask4()
{
	//Napisz program, który poprosi użytkownika o podanie długości podstawy i wysokości trójkąta, a następnie obliczy pole tego trójkąta, wyświetlając wynik.
	float Pole = (a * h) / 2
	float a;
	float h;

	cout << "Podaj długość podstawy a: " << endl;
	cin >> a;

	cout << "Podaj wysokość h: " << endl;
	cin >> h;

	cout << "Pole trójkąta wynosi: " + Pole << endl;
}

void VariableTask5()
{
	//Napisz program, który poprosi użytkownika o podanie promienia koła i obliczy pole tego koła, wyświetlając wynik.

	float AreaOfACircle = 3.14 * (R * R);
	float R;

	cout << "Podaj promień koła: " << endl;
	cin >> R;

	cin << "Pole koła wynosi: " + AreaOfACircle << endl;
}

void VariableTask5()
{
	//Napisz program, który poprosi użytkownika o podanie długości podstawy a, podstawy b i wysokości h trapezu, a następnie obliczy pole tego trapezu, wyświetlając wynik.
	float a;
	float b;
	float h;

	cout << "Podaj długość boku a: " << endl;
	cin >> a;

	cout << "Podaj długość boku b: " << endl;
	cin >> b;

	cout << "Podaj wysokość h: " << endl;
	cin >> h;

	float Pole = ((a + b) * h) / 2;

	cout << "Pole trójkąta wynosi: " + Pole << endl;
}