// James Chandler
// Program 3 - Unordered Linked List
// 11/18/16
// Implement a program that produces an unordered linked list of
// 100 float values and perform additional tasks on them

#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;

class queue{

	public:
	queue();
	void enqueue(double stuff);
	void dequeue();
	void print();

	private:
	string nodeValue;
	struct node{
        double num;
	node *link;
	};

	node *first, *last;

};

