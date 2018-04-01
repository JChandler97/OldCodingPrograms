// James Chandler
// IS1300
// Lab2B

import java.util.Scanner;

public class Lab2B {
	public static void main (String[] args) {
	Scanner input = new Scanner(System.in);

	// Prompt user for age
	System.out.println("What is the age you want to find the probability of?");
	double age = input.nextDouble();
	
	double probConv = age - 65;
	
	double formula = 1 - .0058*probConv - .00076*Math.pow(probConv, 2);

	System.out.println("The probability is " + formula);

	}
}