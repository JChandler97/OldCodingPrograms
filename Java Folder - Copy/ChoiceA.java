// James Chandler
// IS 1300

import java.util.Scanner;
public class ChoiceA {
	public static void main(String [] args){
	Scanner input = new Scanner(System.in);
	
		int[] numOne = new int [5];
		int[] denOne = new int [5];
		int[] numTwo = new int [5];
		int[] denTwo = new int [5];
		int numCount = 0;
		final int HOLD = 1;
		
	for (int c = 1; c < 6; c++){
		System.out.println("Enter data for problem " + c );
		
		System.out.println("Enter numerator for fraction 1");
			numOne[numCount] = input.nextInt();
	
		System.out.println("Enter denominator for fraction 1");
			denOne[numCount] = input.nextInt();
			
		System.out.println("Enter numerator for fraction 2");
			numTwo[numCount] = input.nextInt();
			
		System.out.println("Enter denominator for fraction 2");
			denTwo[numCount] = input.nextInt();
	
		numCount++;
		System.out.println("**************");
	}
	
	System.out.println("*****ORIGINAL DATA*****");
	System.out.printf("First Fraction  Second Fraction\n");
		
	for (int n = 0; n < 5; n++){
		String sign = "/";
		System.out.printf("%d%s%d \t\t", numOne[n], sign, denOne[n]); 
		System.out.printf("%d%s%d \n", numTwo[n], sign, denTwo[n]);
	}
	System.out.println(" ");
	System.out.println("*******FRACTIONS SHOWING ADDED RESULTS*********");
	System.out.printf("First Fraction  Second Fraction GCD\tResults\n");
		for (int n = 0; n < 5; n++){
		String sign = "/";
		System.out.printf("%d%s%d \t\t", numOne[n], sign, denOne[n]); 
		System.out.printf("%d%s%d \t\t", numTwo[n], sign, denTwo[n]);
		System.out.printf("%d \t", findGCD(denOne[n],denTwo[n]));
		if(numAdd(numOne[n],numTwo[n],denOne[n],denTwo[n]) == denAdd(denOne[n], denTwo[n])){
			System.out.printf("%d \n", HOLD);
		}
		else {
		System.out.printf("%d%s%d \n", numAdd(numOne[n],numTwo[n],denOne[n],denTwo[n]), sign,denAdd(denOne[n], denTwo[n]));
		}
		}
	}

	public static int findGCD(int numOne, int numTwo){
		if(numTwo == 0){
			return numOne;
		}
		return findGCD(numTwo, numOne%numTwo);
	}

	public static int numAdd(int numOne, int numTwo, int denOne, int denTwo){
		int temp = 0;
		if (denOne > denTwo){
			temp = denOne/denTwo;
			return ((temp*numTwo)+numOne);
		}
		else if (denOne < denTwo){
			temp = denTwo/denOne;
			return ((temp*numOne)+numTwo);
		}
		else {
			return numOne + numTwo;
		}
	}
	
	public static int denAdd(int numOne, int numTwo){
		if (numOne > numTwo){
			return numOne;
		}
		else {
			return numTwo;
		}
	}
}