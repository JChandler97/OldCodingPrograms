#include "stackqueue.h"

void stackClass::initializeStack(){

      top=-1;

}

void stackClass::isEmptyStack(){
	
		if(top == -1){
         cout << "It is empty" << endl;       	
	   } else {
         cout << "There are values in the stack" << endl;
      }
}

void stackClass::Push(int x){ 
	
   // Checks if it doesn't overflow case
	  if(top == MAX_SIZE - 1){ 
			cout << "Overflowed!" << endl;
		}
		stackArray[++top] = x;
}

void stackClass::Pop(){ 
	
   // If stack is empty, then it prompts error
		if(top == -1){ 
			cout << "Error: No value to pop" << endl;
		}
		top--;
}

int stackClass::Top(){
		return stackArray[top];
}

void stackClass::Print(){
		int i;
	   cout << "Stack: ";
		for(i = 0;i<=top;i++){
			cout << " " << stackArray[i];
   }   
}

void queueClass::initializeQueue(){

      front = -1;
      rear = -1;
}

bool queueClass::isEmptyQueue()
    {
        return front == -1;
    }
bool queueClass::isFullQueue()
    {
        return front == MAX_SIZE-1;
    }

void queueClass::addQueue(int x){
        
        if(!isFullQueue())
        {
            queueArray[++front] = x;
            if(rear == -1)
                rear = 0;
        }
        else
            cout << "Queue is Full!" << endl;

}

void queueClass::deleteQueue(){

       if(!isEmptyQueue())
        {
            if(rear == front)
                rear = front = -1;
            else
                rear++;
        }
        else
            cout << "Queue is Empty!" << endl;
 
}

void queueClass::Print(){

            cout << "Queue: ";
            for(int i = rear;i <= front;i++){
            cout << queueArray[i] << " ";
            }
            
            cout << " " << endl;
}

