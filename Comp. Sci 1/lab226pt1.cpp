#include <iostream>
#include <fstream>

using namespace std;

ofstream outFile;

int main(){

int numOne, numTwo, division, mod;

// Get the two numbers

cout << "Give me two numbers" << endl;
	cin >> numOne >> numTwo;

cout << " " << endl;

// Do the maths

division = numOne / numTwo;
mod = numOne % numTwo;

outFile.open("modout.txt");

	cout << "Since " << numTwo << " is divided by " << numOne << ", then the answer is " << division << endl;
	cout << "The mod of " << numTwo << " by " << numOne << " is " << mod << endl;

// Writing it to the outfile

	outFile << division << endl;
	outFile << mod;


outFile.close();
return 0;
}
