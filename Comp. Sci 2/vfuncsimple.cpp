#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

class A 
{ 
   int a; 
   public: 
       A() 
       {
          a = 1; 
       } 
       virtual void show() 
       { 
          cout << "a is "  << a << endl;
       } 
};

class B: public A 
{ 
   int b; 
   public: 
       B() 
       { 
          b = 2; 
       }
       virtual void show() 
       { 
          cout << "b is = " << b << endl;
       }
};

int main() 
{
	
 // Declaring things from Class A and B
 // Getting pointer A
   A *pA; 
   B oB; 

 // Class A gets the memory address of B
   pA = &oB;

 // Shows the value of show function of class B
   pA->show(); 

//Output is 2 since pA points to object of B and show() is virtual in base class A
   return 0; 
}
