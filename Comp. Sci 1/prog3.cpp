// James Chandler
// Program 3 - Cellular Telephone Company
// 4/12/16
// Use user's input to calculate the total of their phone bill whether if they are regular or premium members.
// - - - - - - - - - - - - - - - - -  - - - -

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    // Declare Variables
    int accountNumber, regularMinutesUsed, premiumDayMins, premiumNightMins;
    char serviceCode;
    double totalBill = 0;
    
    const float REGULAR_FEE = 10.00;
    const float REGULAR_RATE = 0.20;
    const float PREMIUM_FEE = 25.00;
    const float PREMIUM_DAY_RATE = 0.10;
    const float PREMIUM_NIGHT_RATE = 0.05;
    
    // Ask for information
    cout << "Please enter an account number:" << endl;
    cin >> accountNumber;
    
    cout << "Please enter your Service Code (R for Regular, P for Premium):" << endl;
    cin >> serviceCode;
    
    switch (serviceCode) {
        
        // This is for regular members
        case 'r':
        case 'R':
            cout << "Your account number is: " << accountNumber << endl;
            cout << "You are a regular service member." << endl;
            cout << "Please enter the number of minutes used: ";
            cin >> regularMinutesUsed;
                if (regularMinutesUsed > 50) {
                    totalBill = ((regularMinutesUsed - 50) * REGULAR_RATE) + REGULAR_FEE;
                } else {
                    totalBill = REGULAR_FEE;
                }
            break;
            
        // This is for premium members    
        case 'p':
        case 'P':
            cout << "Your account number is: " << accountNumber << endl;
            cout << "You are a premium service member." << endl;
            cout << "Please enter the number of day minutes (6 AM - 6 PM) used: ";
            cin >> premiumDayMins;
            cout << endl;
            
            cout << "Please enter the number of night minutes (6 PM - 6 AM) used: ";
            cin >> premiumNightMins;
            cout << endl;
            
                if (premiumDayMins > 75) {
                    totalBill = (premiumDayMins - 75) * PREMIUM_DAY_RATE;
                }
                if (premiumNightMins > 100) {
                    totalBill = (premiumNightMins - 100) * PREMIUM_NIGHT_RATE;
                }
            totalBill = totalBill + PREMIUM_FEE;
            break;
          
        // Tells the user that their input is wrong    
        default:
            cout << "Wrong Service Code - Try Again." << endl;
            return 1;
            break;
    }
    cout << "Your total bill amount is: $" << totalBill << endl;
    
    return 0;
}
