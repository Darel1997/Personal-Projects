#include <iostream>
#include <string>
#include <algorithm>
using namespace std;
class Game
{
public:
	void Guess() {
		while (true) {
			string hidden_word, choice, word;
			char guess[1];
			unsigned short int lives = 10;
			bool bad_string = false;
			cout << "Guess the Word Game\n\n";
			do {
				cout << "Enter a word to be guess: ";
				getline(cin, word);
				cout << "\n";
				bad_string = false;
				for (unsigned short int i = 0; i < word.length(); i++) {				
					if (isdigit(word[i]) || !isalpha(word[i])) {
						bad_string = true;
						cout << "Your string can't contains numbers or/and specila characters\n\n";
						break;
					}
				}
			} while (bad_string == true);
			system("cls");
			hidden_word = word;
			for (unsigned short int i = 0; i < word.length(); i++) {
				if (hidden_word[i] != ' ')
					hidden_word[i] = '_';
				if (i != 0)
					cout << ' ';
				cout << hidden_word[i];
			}
			cout << "\n\n";
			do {
				while (true) {
					cout << "Type one letter (Lives " << lives << "): ";
					cin >> guess;
					cout << endl;
					if (strlen(guess) <= 1)
						break;
					else
						cin.ignore(UINT_MAX, '\n');
				}
				for (unsigned short int i = 0; i < word.length(); i++) {
					if (guess[0] != toupper(guess[0]) && word[i] == toupper(word[i]) && toupper(guess[0]) == toupper(word[i]) && hidden_word[i] == '_'){
						hidden_word[i] = toupper(guess[0]);
					}
					else if (guess[0] == word[i])
						hidden_word[i] = guess[0];
					if (i != 0)
						cout << ' ';
					cout << hidden_word[i];
				}
				cout << "\n\n";
				if (hidden_word == word) {
					cout << "Congratulations! The hidden word is " << word;
					break;
				}
				else
					lives--;
			} while (lives > 0);
			if (lives == 0)
				cout << "Game Over. The correct word was " << word;
			cout << "\n\n";
			do {
				cout << "Want to play again? ";
				cin >> choice;
				cout << endl;
				transform(choice.begin(), choice.end(), choice.begin(), toupper);
				if (choice == "YES");
				else if (choice == "NO")
					exit(1);
				else
					cout << "Please type yes or no\n\n";
			} while (choice != "YES" && choice != "NO");
			cin.ignore(INT_MAX, '\n');
			system("cls");
		}
	}
};