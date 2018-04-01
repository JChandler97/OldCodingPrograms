#include <iostream>
#include <fstream>
#include <iomanip>
#include <cmath>

using namespace std;
// constant to say how many items in our array
const int MAX = 10;
// declaring a variable of type array that will store MAX integers
int newarray[MAX];
// declaring the input stream of data will come from a variable called inFile
ifstream inFile;
// declaring that the output stream will go to a variable called outFile
ofstream outFile;   


int main ()
{
	// next line opens a file named inarray.txt which is in the same directory as the program
	inFile.open("inarray.txt");
	//the line below creates, or opens, a file called outarray.txt same directory as program
	outFile.open("outputtext.txt");

	// read in ten items to the array notice that we start counting at 0 so 0-9 makes 10 items
	inFile >> newarray[0];
	inFile >> newarray[1];
	inFile >> newarray[2];
	inFile >> newarray[3];
	inFile >> newarray[4];
	inFile >> newarray[5];
	inFile >> newarray[6];
	inFile >> newarray[7];
	inFile >> newarray[8];
	inFile >> newarray[9];

	//now put a header on the screen and in your file
	cout << "This is my array of items read from a file and written to the screen and a different file. " << endl;
	outFile << "This is my array of items read from a file and written to the screen and a different file. " << endl;
	// only writing data to the file you will need to use your editor to see if the data went into the file
	outFile << newarray[0] << "    " << newarray [1] << "    " << newarray[2] << "    " << newarray [3] << "    " << newarray[4] << endl;
	outFile << newarray[5] << "    " << newarray [6] << "    " << newarray[7] << "    " << newarray [8] << "    " << newarray[9] << endl;

	// close both of the files you opened
	inFile.close();
	outFile.close();
	// let the user (you) know that you are done
	cout << "The program is finished." << endl;
 
return 0;
      
}
 
  //for loop to read data in from the file
//	for(int i = 0; i < max_array; i++)
//	inFile >> newarray[i];      

