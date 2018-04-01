// James Chandler
// IS1300 Homework 1B
// This program is to implement Cramer's Rule

import java.util.Scanner;

public class Cramer {
	public static void main (String [] args){
	
		Scanner input = new Scanner(System.in);		
		
			System.out.println("Enter Value for A");
			double a = input.nextDouble();
			
			System.out.println("Enter value for B");
			double b = input.nextDouble();
			
			System.out.println("Enter value for C");
			double c = input.nextDouble();
			
			System.out.println("Enter value for D");
			double d = input.nextDouble();
			
			System.out.println("Enter value for E");
			double e = input.nextDouble();
			
			System.out.println("Enter value for F");
			double f = input.nextDouble();
		
			double x = (e*d - b*f) / (a*d - b*c);
			double y = (a*f - e*c) / (a*d - b*c);
			
		System.out.println("The value of X is " + x);
		System.out.println("The value of Y is " + y);
	
	}
}