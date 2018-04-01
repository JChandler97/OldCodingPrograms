// James Chandler 3/11/16


public class Looplab{
public static void main(String [] args){
	
	int milesOne = 0;
	double milesTwo = 0;
	double kilometerOne;
	int kmCount = 20;
	final double KILO = 1.609;
	String divider = "|";
	
	System.out.println("Miles\t" + "Kilometers\t" + " |" + "Kilometers\t" + "Miles");
	
	for (milesOne = 1; milesOne <= 10;milesOne++){
	kilometerOne = milesOne * KILO;
	milesTwo = kmCount / KILO;
	System.out.printf("%d\t %5.3f\t\t %s%d\t\t%5.3f\n", milesOne, kilometerOne, divider, kmCount, milesTwo); 
	kmCount = kmCount + 5;
		}
	}
}