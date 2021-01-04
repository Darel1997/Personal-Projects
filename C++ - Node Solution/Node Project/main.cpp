#include <iostream>
#include <string>
using namespace std;
class Node{
public:	
	Node(char newID){
		north = south = east = west = NULL; visited = false; ID = newID; 
	}
	char getID(){ 
		return ID; 
	}
	void setConnections(Node *n, Node *s, Node *e, Node *w)
	{
		north = n; south = s; west = w; east = e;
	}
	Node* getNorth(){ 
		return north; 
	}
	Node* getSouth(){ 
		return south; 
	}
	Node* getEast(){ 
		return east; 
	}
	Node* getWest(){ 
		return west; 
	}
	void setVisited(){
		visited = true;
	}
	bool getVisited(){ 
		return visited; 
	}
private:
	char ID;
	bool visited;
	Node *north, *south, *east, *west;
};
int main(){
	Node *A = new Node('A');
	Node *B = new Node('B');
	Node *C = new Node('C');
	Node *D = new Node('D');
	Node *E = new Node('E');
	Node *F = new Node('F');
	Node *G = new Node('G');
	Node *H = new Node('H');
	Node *I = new Node('I');
	Node *J = new Node('J');
	Node *K = new Node('K');
	Node *L = new Node('L');

	A->setConnections(NULL, E, B, NULL);
	B->setConnections(NULL, F, NULL, A);
	C->setConnections(NULL, G, D, NULL);
	D->setConnections(NULL, NULL, NULL, C);
	E->setConnections(A, I, NULL, NULL);
	F->setConnections(B, NULL, G, NULL);
	G->setConnections(C, K, H, F);
	H->setConnections(NULL, L, NULL, G);
	I->setConnections(E, NULL, J, NULL);
	J->setConnections(NULL, NULL, NULL, I);
	K->setConnections(G, NULL, NULL, NULL);
	L->setConnections(H, NULL, NULL, NULL);

	Node *current = A;
		cout << "You are in room " << current->getID() << " of a maze of twisty little passages, all alike. You can go: " << endl;
		if (current->getNorth())
			cout << "north (n) | ";
		if (current->getSouth())
			cout << "south (s) | ";
		if (current->getEast())
			cout << "east (e) | ";
		if (current->getWest())
			cout << "west (w) | ";
	while (current->getID() != 'L'){
		char go;			
		cin >> go;
		cout << endl;
		if (go == 'n') {
			current = current->getNorth();
		}
		else if (go == 's') {
			current = current->getSouth();
		}
		else if (go == 'e') {
			current = current->getEast();
		}
		else {
			current = current->getWest();
		}
		if (current->getID() == 'L')
			break;
		cout << "You are in room " << current->getID() << " of a maze of twisty little passages, all alike. You can go: " << endl;
		if (current->getNorth()) {
			cout << "north (n) | ";
		}
		if (current->getSouth()) {
			cout << "south (s) | ";
		}
		if (current->getEast()) {
			cout << "east (e) | ";
		}
		if (current->getWest()) {
			cout << "west (w) | ";
		}			
	}	
	cout << "Congratulations! You made it." << endl << endl;
	system("pause");
	return 0;
}