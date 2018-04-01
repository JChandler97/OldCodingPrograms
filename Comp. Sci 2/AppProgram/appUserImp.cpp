#include <iostream>
#include <iomanip>
#include "appUser.h"
#include <string>

using namespace std;

void userApp::setInfo(string first, string last, int ID){

    while(ID < 0){ 
    cout << "Your ID number is not valid. Please try again." << endl;
        cin >> ID;      
    }
    
    cout << "Hello, " << first << " " << last << endl;
    cout << "Your ID number is " << ID << endl;
}


void userApp::modifyInfo(string& first, string& last, int& ID){
  
    cout << "Please print your first and last name" << endl;
    cin >> first >> last;
    cout << endl;
    
    cout << "Please enter your Member ID Number" << endl;
    cin >> ID;
    cout << endl;
    
    while(ID < 0){ 
    cout << "Your ID number is not valid. Please try again." << endl;
        cin >> ID;
    }
}

void userApp::showInfo(string& first, string& last, int& ID){

   cout << "Your name is " << first << " " << last << endl;
   cout << "Your Member ID Number is: " << ID << endl;
   cout << endl;

}

void userApp::appBuy(int& appToSell, float& cost){

   cout << "How many would you like to buy?" << endl;
      cin >> appSold;
      
      amountSpent = cost * appSold;
      appToSell-=appSold;
      
      
      
   cout << "You've bought " << appSold << " apps and spent $" << amountSpent << " " << endl;
   cout << "There are " << appToSell << " left available." << endl;
   cout << endl;

}

