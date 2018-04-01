#include <iostream>
#include "queue.h"

queue::queue(){
	first = nullptr;
	last = nullptr;
	cout << "Queue created" << endl;
}

void queue::enqueue(int stuff){
	node *temporary = new node;
	temporary -> num = stuff;
	temporary -> link = nullptr;
	if(first == nullptr){
		first = temporary;
		last = temporary;
	} else {
		last -> link = temporary;
		last = temporary;
	}
}

void queue::dequeue(){
	if(first == nullptr){
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
	 cout << first -> num << endl;
}
