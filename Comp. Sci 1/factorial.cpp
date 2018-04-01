// James Chandler
// Program 4 - Factorial
// 4/15/16
// This program is made to calculate the factorial of the number that the user puts in.
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

#include <iostream>

using namespace std;

int main(){

	int c = 0;
	int num;
	int total = 1;
	
	// User input
	cout << "Enter a nonnegative integer." << endl;
		cin >> num;
	cout << endl;

    // If Statement 
    if (num >= 0){
		for(c=1; c <= num; c++){
			total = total * c;
		}
		
	cout << num << "! = " << total << endl;
	}	else{
		cout << "You did not enter a nonnegative number. Try again." << endl;
	}

	return 0;
}
