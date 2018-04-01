//Program: Effect of break statements in a switch structure

#include <iostream>

using namespace std; 
 
int main() 
{
    int num;

    cout << "Enter an integer between 0 and 7: ";      //Line 1
    cin >> num;                                        //Line 2
    cout << endl;                                      //Line 3

    cout << "The number you entered is " << num 
         << endl;                                      //Line 4
	
    switch(num)                                        //Line 5
    {
   
    case 0:                                            //Line 6
   	cout << "Hello?" << endl;
	break;
   
    case 1:                                            //Line 7
        cout << "Learning to use " << endl;                    //Line 8
   	break;
   
    case 2:                                            //Line 9
        cout << "C++'s " << endl;                              //Line 10
   	break;
   
    case 3:                                            //Line 11
        cout << "switch structure." << endl;           //Line 12
        break;                                         //Line 13
   
    case 4:                                            //Line 14
         cout << "Hi again" << endl;
    	 break;                                         //Line 15
   
    case 5:                                            //Line 16
        cout << "This program shows the effect " << endl;      //Line 17
   	break;

    case 6:                                            //Line 18
	cout << "There's something over there" << endl;   
	break;

    case 7:                                            //Line 19
        cout << "of the break statement." << endl;     //Line 20
        break;                                         //Line 21
   
    default:                                           //Line 22
        cout << "The number is out of range." << endl; //Line 23 
    }

    cout << "Out of the switch structure." << endl;    //Line 24

    return 0;                                          //Line 25
}
