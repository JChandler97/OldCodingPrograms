// James Chandler 4/15/16
// Lab 10

import java.util.Scanner;

public class Lab10 {
	public static void main(String [] args) throws Exception{
		String[] names = new String[5];
		java.io.File file = new java.io.File("output.txt");
		Scanner input=new Scanner(file);
		
	//Original Data
	System.out.println("***Original Data***");

	int c = 0;
	while(input.hasNext()){
		names[c]=input.next();
		System.out.println(names[c]);
		c++;
	}
	System.out.println("");

	// Replace O's
	System.out.println("***Replaced o's***");
	
		for(c = 0; c < 5; c++){
			System.out.println(names[c].replace("o","a"));
		}
	System.out.println("");
	
	// Uppercase Words
	System.out.println("***Uppercase Words***");
	
		for(c = 0; c < 5; c++){
			System.out.println(names[c].toUpperCase());
		}
	System.out.println("");

	// Substring of Words
	System.out.println("***Substring of Words***");
	
		for(c = 0; c < 5; c++){
			System.out.println(names[c].substring(0,2));
		}
	System.out.println("");
	}
}