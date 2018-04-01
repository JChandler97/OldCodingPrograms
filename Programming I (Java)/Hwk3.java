// James Chandler
// 2/29/16
// Homework 3

import java.util.Scanner;

	public class Hwk3 {
		public static void main (String [] args){
			Scanner input = new Scanner(System.in);
			
			// Find out John's information
		System.out.println("Enter the approx width, in decimals, of John's screen");
			double johnWidth = input.nextDouble();
			
		System.out.println("Enter the size of John's screen");
			double johnScreen = input.nextDouble();
			
			// Find out Joe's information
		System.out.println("Enter the approx width, in decimals, of Joe's screen");
			double joeWidth = input.nextDouble();
		
		System.out.println("Enter the size of Joe's screen");
			double joeScreen = input.nextDouble();
		
		// Formulas for the width
		double johnX = Math.sqrt(Math.pow(johnScreen, 2) / (Math.pow(johnWidth, 2) + 1));
		double joeX= Math.sqrt(Math.pow(joeScreen, 2) / (Math.pow(joeWidth, 2) + 1));
		
		// Formulas for the Area
		double johnArea = (johnWidth * johnX) * johnX;
		double joeArea = (joeWidth * joeX) * joeX;
		
		System.out.println("John's screen width = " + johnX);
		System.out.printf("Area of John's screen is %5.2f" , johnArea);
		System.out.println(" ");
		System.out.println("John's screen width = " + joeX);
		System.out.printf("Area of Joe's screen is %5.2f" , joeArea);
		System.out.println(" ");
		
		if (joeArea < (0.5 * johnArea)){
			System.out.println("John is right. Joe's screen is less than half of viewing area"); }
		else {
			System.out.println("Joe is right. John's screen is two thirds of Joe's viewing area"); }
			
	}
}