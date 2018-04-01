// James Chandler jlchandler
// CS1300 Program 1
// 2/5/16
#include <iostream>
	using namespace std;
	
	int main (){
	    
	// Declare all variables used
		const double PI = 3.141593;
		double volume;
		double diameter;
		double radius;
		double height;
		string volumeFormula;
	
	// Get data from user
		cout << "What is the diameter?" << endl;
			cin >> diameter;
		
		cout << "What is the height?" << endl;
			cin >> height;
			
	// Complete the formulas
				radius = diameter/2;
				volume = PI*height*radius*radius;
				volumeFormula = "V = PI * height * radius * radius";
	
	// Output 		
		cout << "The diameter is " << diameter << " and the height is " << height << endl;
		cout << "The volume formula used is " << volumeFormula << endl;
		cout << "The volume is " << volume << endl;
	
	
    	return 0;
	}
