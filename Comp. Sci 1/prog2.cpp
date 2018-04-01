// James Chandler
// Program 2 - Files and Formatting and Data Types
// 2/22/16
// Read data from the input file and output information on the output file.



#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

int main (){

        ifstream inFile;
        ofstream outFile;

	// Declare for first line
		string firstName;
		string lastName;
		string department;
	
	// Declare for second line
		double grossSalary;
		double bonus;
		double taxes;
		
		double bonusPer;
		double taxesPer;
		double check;
		double salBonus;
		double salTax;
		double finalSalBonus;

	// Declare for third line	
		double disTravel;
		double travelTime;
		double avgSpeed;		

	// Declare for fourth line	
		double coffeeCups;
		double coffeeCost;
		double saleAmt;
			
	// This is to open the inFile text
		inFile.open("inData.txt");
	// This is to open the outFile text
		outFile.open("outData.txt");

	outFile << fixed << showpoint;
	outFile << setprecision(2);	

    inFile >> firstName >> lastName >> department;
	outFile << "Name: " << firstName << " " << lastName << ", Department: " << department << endl;

    inFile >> grossSalary >> bonus >> taxes;
	outFile << "Monthly Gross Salary: $" << grossSalary << ", Monthly Bonus: " << bonus << "%, Taxes: " << taxes << "%" << endl;
		
	// Changes bonus and taxes to percentage
		bonusPer = bonus * 0.01;
		taxesPer = taxes * 0.01;

	// Gets the bonus amount then add it to the gross salary
		salBonus = grossSalary * bonusPer;
		finalSalBonus = grossSalary + salBonus;
		
	// Gets Paycheck Amount
		salTax = finalSalBonus * taxesPer;
		check = finalSalBonus - salTax;
	outFile << "Paycheck: " << check << endl;

	outFile << " " << endl;

    inFile >> disTravel >> travelTime;
	outFile << "Distance Traveled: " << disTravel << " miles, Traveling Time: " << travelTime << " hours" << endl;

	// Gets the average speed
	avgSpeed = disTravel / travelTime;
	
	outFile << "Average Speed: " << avgSpeed << " mile per hour" << endl;

	outFile << " " << endl;

    inFile >> coffeeCups >> coffeeCost;
	outFile << "Number of Coffee Cups Sold: " << coffeeCups << ", Cost: $" << coffeeCost << " per cup" << endl;

	// Gets the total amount sold for cups
	saleAmt = coffeeCups * coffeeCost;

	outFile << "Sales Amount = $" << saleAmt << endl;

	// This is to close the inFile text
		inFile.close();
	// This is to close the outFile text
		outFile.close();

	cout << "Output is complete! Look in outData.txt for results!" << endl;


	return 0;
}
