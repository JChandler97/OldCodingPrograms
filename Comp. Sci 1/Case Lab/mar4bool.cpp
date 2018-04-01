#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;



int main()
   {
   
   cout << "Starting main function " << endl;
   
   bool banswer;
   
   // each of the six expressions in ques 2 are solved here
   banswer = 3 * 4 == 15 - 3;
   cout << "a " << banswer << endl;
   banswer = 2 - 15 / 3 >= 7 - 4;
   cout << "b " << banswer << endl;
   banswer = 'd' >= 'F';
   cout << "c " << banswer << endl;
   banswer = 'T' <= 's';
   cout << "d " << banswer << endl;
   banswer = '#' <= '*';
   cout << "e " << banswer << endl;
   banswer = 8.5 / 2 - 1.3 < 4.0 * 0.7 + 1.2;
   cout << "f " << banswer << endl;

   //write the expression in 1.f storing the answer to fbool and then cout the answer
   bool fbool;
   // get in one letter from the users
   char ch;
   cout << "enter a letter please "<< endl;
   cin >> ch;
   
   fbool = (ch >= 'A' && ch <= 'Z');
   
   cout << "testing char " << ch << " result of bool test is " << fbool << endl;
 
   
   return 0;
   }
  
