#include "queue.h"

queue::queue(){
	first = NULL;
	last = NULL;
	//cout << "Queue created" << endl;
}

void queue::enqueue(double stuff){
	node *temporary = new node;
	temporary -> num = stuff;
	temporary -> link = NULL;
	if(first == NULL){
		first = temporary;
		last = temporary;
	} else {
		last -> link = temporary;
		last = temporary;
	}
}

void queue::dequeue(){
	if(first == NULL){
		cout << "Bruh you gotta have stuffs to dequeue" << endl;
	} else {
		node *temporary;
		print();
		temporary = first;
		first = first -> link;
		delete temporary;
	}
}

void queue::print(){
	 cout << first -> num<< " \t";
}

