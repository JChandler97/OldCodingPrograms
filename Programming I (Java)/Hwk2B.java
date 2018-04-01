// James Chandler
//  IS1300 Homework 2B
/*  This program is to find the discriminant(s) of the given numbers
	and to find the roots for them if they have any 	*/

import java.util.Scanner;

public class Hwk2B{
	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
	
	// Prompt user for A
		System.out.println("What is the value for A?");
		double a = input.nextDouble();
		
	// Prompt user for B	
		System.out.println("What is the value for B?");
		double b = input.nextDouble();

	// Prompt user for C
		System.out.println("What is the value for C?");
		double c = input.nextDouble();
	
		double discriminant = Math.pow(b, 2) - 4 * a * c;
		double rootOne = (-b + Math.pow(Math.pow(b, 2) - 4*a*c, .5))/ 2*a;
		double rootTwo = (-b - Math.pow(Math.pow(b, 2) - 4*a*c, .5))/ 2*a;
		
			if (discriminant > 0){
				System.out.println("The equation has two roots! " + rootOne + " and " + rootTwo);
			}
			else if (discriminant == 0){
				System.out.println("The equation has one root! " + rootOne);
			}
			else{
				System.out.println("The equation has no roots!");
			}

	}
}