#include "queue.h"
using namespace std;

int main(){

   // Declaring queue and file I/O
   queue myq;
   ifstream inData;
   ofstream outData;

   // Declaring function variables and counts
   double total;
   double average;
   double data;
   double max;
   double min = 100;
   double range;
   int j;
   
   // This is to open the inFile text
	inData.open("datanums.txt");
   // This is to open the outFile text
	outData.open("outData.txt");

   // Setting up formatting
   cout << showpoint << setprecision(3) << fixed;
   outData << fixed << showpoint << setprecision(3);


   // Loop to keep track of 
   for(int i = 1; i <= 100; i++){

      // The j count counts for every five floats before breaking
      j++;
     
      inData >> data;
      myq.enqueue(data);
      total += data;
      
      // Setting up the column spacing in file
      outData << data << " \t";
   
      myq.dequeue();

      // If statements for functions
      // For the column break
      if(j == 5){
	cout << endl;
        outData << endl;
	j = 0;
      }
     
      // Finds the max number
      if(data > max){
	max = data;
      }

      // Finds the min number
      if(data < min){
        min = data;
       }

      // For the average
      if(i == 100){
	average = total/i;
      }
}   


   // Finds the range
   range = max - min;

   // Breaks from the wall of text to make it easier on the eyes
   cout << endl;
   outData << endl;   
   
   // Calculation outputs
   cout << "Sum: " << total << endl;
   outData << "Sum: " << total << endl;

   cout << "Average: " << average << endl;
   outData << "Average: " << average << endl;
   
   cout << "Max: " << max << endl;
   outData << "Max: " << max << endl; 
   
   cout << "Min: " << min << endl;
   outData << "Min: " << min << endl;   

   cout << "Range: " << range << endl;
   outData << "Range: " << range << endl;

   
   // This is to close files
	inData.close();
	outData.close();

   return 0;
}


