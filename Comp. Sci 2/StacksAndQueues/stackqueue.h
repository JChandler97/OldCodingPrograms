#include <iostream>
#include <iomanip>

using namespace std;
#define MAX_SIZE 25

class baseClass {
   public:
      int stackArray[MAX_SIZE];
      int queueArray[MAX_SIZE];
  
};

class stackClass: public baseClass{
   public:
      int stackArray[MAX_SIZE];
      void initializeStack();
      void isEmptyStack();
      void Push(int x);
      void Print();
      void Pop();
      int Top();
   private:
      int top;
      
};

class queueClass: public baseClass{
   public:
      int queueArray[MAX_SIZE];
      void initializeQueue();
      bool isEmptyQueue();
      bool isFullQueue();
      void addQueue(int x);
      void deleteQueue();
      void Print();
   private:
      int front;
      int rear;

};

