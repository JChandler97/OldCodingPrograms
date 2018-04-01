#include <iostream>
using namespace std;

class queue{

	public:
	queue();
	void enqueue(int stuff);
	void dequeue();
	void print();

	private:
	struct node{
	int num;
	node *link;
	};

	node *first, *last;

};
