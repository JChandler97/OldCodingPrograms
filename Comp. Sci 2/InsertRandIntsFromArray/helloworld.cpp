#include <iostream>
#include <fstream>

using namespace std;

void firstFunct(int myArray[]);
void secFunct(int myArray[]);
void thirdFunct(int myArray[]);

int main() {

	ifstream inFile;
	inFile.open("randomints.txt");
 	int myArray[100]; 
   	
	for(int i = 0; i <= 99; i++){
		inFile >> myArray[i];
	}

 
    firstFunct(myArray);
    cout << endl;
    
    secFunct(myArray);
    cout << endl;
    
    thirdFunct(myArray);
    
	inFile.close();
	return 0;
}

void firstFunct (int myArray[]){
    int sum = 0;
    int average, i;
    
    for(i = 0; i <= 99; i++){

       sum+=myArray[i];
        
    }
    average = sum / i;
    cout << "The sum of the values is " << sum << endl;
    cout << "The average of the value is " << average << endl;
    cout << "The control structure used for this was a for loop." << endl;
}

void secFunct(int myArray[]){
    int sum = 0;
    int average;
    int i = 0;
    
    while (i <= 99){
    
        sum+=myArray[i];
        i++;
        
    }
    average = sum / i;
    cout << "The sum of the values is " << sum << endl;
    cout << "The average of the value is " << average << endl;
    cout << "The control structure used for this was a while loop." << endl;
}

void thirdFunct(int myArray[]){
    int sum = 0;
    int average;
    int i = 0;
    
    do{
        
        sum+=myArray[i];
        i++;
        
    }while (i <= 99);
    
    average = sum / i;
    cout << "The sum of the values is " << sum << endl;
    cout << "The average of the value is " << average << endl;
    cout << "The control structure used for this was a do while loop." << endl;
}
