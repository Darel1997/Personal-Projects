#include <iostream>
#include <string>
#include <conio.h>
#include <fstream>
using namespace std;
int main() {
	const unsigned short int CHAR_CHECK = 224;
	const unsigned short int KEY_UP = 72;;
	const unsigned short int KEY_DOWN = 80;
	const unsigned short int KEY_LEFT = 75;
	const unsigned short int KEY_RIGHT = 77;
	const unsigned short int KEY_X = 120;
	const unsigned short int COORDINATES[4] = {0, 1 , 2 , 3};
	unsigned short int pos = 0, choice;
	unsigned char char_check, key = 0;
	while (true) {
		do {
			cout << "Welcome to Darel's city\n\n";
			cout << "[1] Enter the city\n";
			cout << "[2] See the map of the city\n";
			cout << "[3] Exit program\n\n";
			cout << "Enter your choice (1, 2 or 3): ";
			cin >> choice;
			cout << "\n";
			if (cin.fail()) {
				cin.clear();
				cin.ignore(UINT_MAX, '\n');
			}
		} while (choice < 1 || choice > 3);
		if (choice == 1) {
			key = 0;
			while (pos <= COORDINATES[3] && key != KEY_X) {
				switch (pos) {
				case 0:
					cout << "You're in your house\n\n";
					break;
				case 1:
					cout << "You're in school\n\n";
					break;
				case 2:
					cout << "You're in the park\n\n";
					break;
				case 3:
					cout << "You're in the restaurant\n\n";
					break;
				}
				if (pos == COORDINATES[0]) {
					cout << "You can travel to school(press up arrow key)\nYou can travel to the restaurant (press right arrow key)\n\n";
					switch (char_check = _getch()) {
					case CHAR_CHECK:
						switch (key = _getch()) {
						case KEY_UP:
							pos = COORDINATES[1];
							break;
						case KEY_RIGHT:
							pos = COORDINATES[3];
							break;
						}
					default:
						key = KEY_X;
					}
				}
				else if (pos == COORDINATES[1]) {
					cout << "You can travel to the park (press right arrow key)\nYou can travel to your house (press down arrow key)\n\n";
					switch (char_check = _getch()) {
					case CHAR_CHECK:
						switch (key = _getch()) {
						case KEY_RIGHT:
							pos = COORDINATES[2];
							break;
						case KEY_DOWN:
							pos = COORDINATES[0];
							break;
						}
					}
					cout << "\n";
				}
				else if (pos == COORDINATES[2]) {
					cout << "You can travel to school (press left arrow key)\nYou can travel to the restaurent (press down arrow key)\n\n";
					switch (char_check = _getch()) {
					case CHAR_CHECK:
						switch (key = _getch()) {
						case KEY_DOWN:
							pos = COORDINATES[3];
							break;
						case KEY_LEFT:
							pos = COORDINATES[1];
							break;
						}
					}
					cout << "\n";
				}
				else {
					cout << "You can travel to the park (press up arrow key)\nYou can travel to your house (press left arrow key)\n\n";
					switch (char_check = _getch()) {
					case CHAR_CHECK:
						switch (key = _getch()) {
						case KEY_UP:
							pos = COORDINATES[2];
							break;
						case KEY_LEFT:
							pos = COORDINATES[0];
							break;
						}
					}
					cout << "\n";
				}
				if (key != KEY_X)
					key = 0;
				else;
			}
		}
		else if (choice == 2) {
			string line;
			ifstream file("map.txt");
			while (getline(file, line)) {
				cout << line << "\n";
			}
			file.close();
			cout << "\n";
		}
		else
			exit(1);
	}
	return 0;
}