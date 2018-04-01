// James Chandler
// IS1300 Lab 3
// 2/11/2016

import java.util.Scanner;

public class Lab3 {
	public static void main(String [] args){
	Scanner input = new Scanner(System.in);
	
	// Enter Investment Amount
		System.out.println("What is the investment amount?");
		double investment = input.nextDouble();
		
	// Enter 1st percent investment
		System.out.println("What is the 1st investment amount?");
		double firstPer = input.nextDouble();
			
			double investOne = firstPer * .01;
			
	// Enter 2nd percent investment
		System.out.println("What is the 2nd investment amount?");
		double secPer = input.nextDouble();
		
			double investTwo = secPer * .01;
	
	// Enter amount per year
		System.out.println("What is the amount made per year?");
		double yearInv = input.nextDouble();
	
	// Formula for amount invested
		double amount = (firstPer * investment - yearInv)/(-secPer + firstPer);
	
	// If statement for amount
		if ( amount >= 8501){
			System.out.println("Good!");
		}
		else if ( amount >= 7000) {
			System.out.println("Pretty good!");
		}
		else if ( amount >= 5001 ) {
			System.out.println("Not bad!");
		}
		else {
			System.out.println("So little!");
		}
	
	}
}