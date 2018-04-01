// James Chandler
// IS1300 Homework 2A 
// This program is to use the user's input to find out how many miles they would have to drive to be the same at both firms.

import java.util.Scanner;

public class Hwk2A {
	public static void main (String[] args){
		Scanner input = new Scanner(System.in);
		
		// Print for price of unlimited mileage
	System.out.println("What is the price of the unlimited mileage?");
	double unMile = input.nextDouble();
	
		// Print for price of discount store
	System.out.println("What is the price of the car from the discount store?");
	double disPrice = input.nextDouble();
	
		// Print for the cost per mile
	System.out.println("What is the cost per mile?");
	double disCost = input.nextDouble();
	
	double miles = (unMile - disPrice) / disCost;
	
	System.out.println("You must drive " + miles + " a day for the costs to be the same at both firms.");
	}
}