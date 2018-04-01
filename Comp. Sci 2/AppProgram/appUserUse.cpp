#include <iostream>
#include <iomanip>
#include <string>
#include "appUser.h"

using namespace std;

int menu();

const int MODIFY = 1, SHOW = 2, BUY = 3, QUIT = 4;

int main() {
    
    // Declare things that are needed
    userApp app;
    int memID;
    float appCost = 0.99;
    int appNum = 100;
    int appBought;
    int choice;
    string fname, lname;
    
    //Prompts for name of user for initialization
    cout << "Please print your first and last name" << endl;
    cin >> fname >> lname;
    cout << endl;
    
    //Prompts for ID of user for initialization
    cout << "Please enter your Member ID Number" << endl;
    cin >> memID;
    cout << endl;
    
    //Should end up verifying/checking the name and ID for initialization 
    app.setInfo(fname, lname, memID);
    

    cout << "There are 100 apps available - each cost 99 cents." << endl;
    cout << "What would you like to do?" << endl;
     
     choice = menu();
     
    //
     while(choice != QUIT){
         if (choice == MODIFY){
     app.modifyInfo(fname, lname, memID);
            }
            
    else if (choice == SHOW){
     app.showInfo(fname, lname, memID);
            }
            
    else if (choice == BUY){        
     app.appBuy(appNum, appCost);
     }
     
     choice = menu();
     }
         
	return 0;
}

int menu(){

int choice;

   cout << "1  Modify Personal Information" << endl;
   cout << "2  Show Personal Information" << endl;
   cout << "3  Purchase Apps" << endl;
   cout << "4  Quit" << endl;
   cout << "Enter the number of your choice" << endl;

   cin >> choice;
   return choice;
}
