#include "stackqueue.h"

const int STACK = 1, QUEUE = 2, QUIT = 0;

int main(){

   int firstChoice;
   int secondChoice;
   int userNum;
   stackClass sc;
   queueClass qc;

   cout << "Pick one of the following:" << endl;
   cout << "1  Stack" << endl;
   cout << "2  Queue" << endl; 
      cin >> firstChoice;      
      
      
   switch(firstChoice){
        case 1:
       
       cout << "You've chose Stack" << endl;
       
       while(secondChoice != QUIT){ 
            cout << endl;
            cout << "1  Initialize Stack" << endl;
            cout << "2  Check if Stack is empty" << endl;
            cout << "3  Push the stack" << endl;
            cout << "4  Pop the stack" << endl;
            cout << "5  Top the stack" << endl;
            cout << "0  Quit" << endl;
            
      cin >> secondChoice;
         switch(secondChoice){
                  case 0:
                     return 0;
                     
                  break;
                  
                  case 1:
                     sc.initializeStack();
                     cout << "Stack initialized!" << endl;
                     
                  break;
              
                  case 2:
                     sc.isEmptyStack();
                     
                  break;
                  
                  case 3:
                     cout << "Input a number" << endl;
                     cin >> userNum;
                     sc.Push(userNum);
                     sc.Print();
                  break;
                  
                  case 4:
                     sc.Pop();
                     sc.Print();
                  break;
                  
                  case 5:
                     sc.Top();
                     sc.Print();
                  break;
                  
                  default:
                  
                  cout << "You haven't selected a correct choice. Try again" << endl;
                  cout << endl;  
              }
         }
         break;

        case 2:
            cout << "You've chose Queue" << endl;
            
       while(secondChoice != QUIT){
            cout << endl;
            cout << "1  Initialize Queue" << endl;
            cout << "2  Add element into Queue" << endl;
            cout << "3  Delete element from Queue" << endl;
            cout << "0  Quit" << endl;
            
      cin >> secondChoice;
      
         switch(secondChoice){
                  case 0:
                  return 0;
                  
                  break;
                  
                  case 1:
                     qc.initializeQueue();
                     cout << "Queue is initialized!" << endl;
                     cout << endl;
                  break;
                
                  case 2:
                     cout << "Input a number" << endl;
                     cin >> userNum;
                     qc.addQueue(userNum);
                     qc.Print();
                  break;
                     
                  case 3:
                     qc.deleteQueue();
                     qc.Print();
                  break;
                  
                  default:
                  
                  cout << "You haven't selected a correct choice. Try again" << endl;
                  cout << endl; 
              }
         
       }
         break;

        default:
    cout << "You did not choose the corresponding number for choosing a Stack or Queue" << endl;
    cout << "Please try again" << endl;
    return 0;
    }
   
   return 0;
}
