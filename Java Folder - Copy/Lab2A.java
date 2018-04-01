// James Chandler
// IS1300
// Lab2A
// It works this time! :)

import java.util.Scanner;

public class Lab2A {
	public static void main (String[] args) {
		Scanner input = new Scanner(System.in);

	// Prompt Speed
		System.out.println("What is the speed?");
		double speed = input.nextDouble();

	// Prompt for acceleration
		System.out.println("What is the acceleration?");
		double acceleration = input.nextDouble();
		
	double length = Math.pow(speed, 2) / (2*acceleration);
	
	System.out.println("The minimum runway length for this airplane is " + length);

	}
}