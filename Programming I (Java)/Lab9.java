// James Chandler - 4/8/16
// Lab 9

import java.util.Scanner;

public class Lab9 {
	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
		double[] array = new double[5];
		
	for(int x=0; x < array.length; x++){
		System.out.println("Enter a number");
			array[x] = input.nextDouble();
	}
	
		System.out.println("Average of the numbers entered in is " + average(array, array.length));
}

	public static double average(double[] array, double length){		
		double x = 0;

	for(int c=0; c < length; c++){
		x = x + array[c];
	}
	
	return x/length;
	
}
}