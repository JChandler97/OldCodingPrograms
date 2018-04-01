public class Craps {
	public static void main (String [] args){
	
		int dieOne = (int)(Math.random()*6+1);
	
		int dieTwo = (int)(Math.random()*6+1);
		
		int dieAns = dieOne + dieTwo;
		
		System.out.println("You threw a " + dieOne + " and a " + dieTwo);
		
		if (dieAns == 7){
			System.out.println("You won!");
			}
		else{
			System.out.println("You lost");
			}
	}
}