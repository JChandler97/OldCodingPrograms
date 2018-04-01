#include <iostream>
#include "queue.h"

using namespace std;

int main(){

	queue myq;

	myq.enqueue(5);
	myq.enqueue(10);
        myq.enqueue(23);
        myq.enqueue(48);

	myq.dequeue();
        myq.dequeue();
        myq.dequeue();
        myq.dequeue();
        myq.dequeue();
}
