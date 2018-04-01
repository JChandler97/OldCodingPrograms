// James Chandler - 3/29/16
// Lab 8 

import java.util.Scanner;

public class Lab8 {
	public static void main(String [] args){
	Scanner input = new Scanner(System.in);

	System.out.println("Enter a decimal number");
		int decimal = input.nextInt();

		System.out.println("Base 10 number " + decimal + " is = to Base 2 number " + math(decimal) + ".");
}

	public static String math(int decimal){
		int binValue;
		String binary="";
		
		while (decimal !=0){
		binValue = decimal % 2;
		decimal = decimal/2;
		binary = binValue + binary;
		}
		
		return binary;
}









}