import java.util.Scanner;
	public class Hwk4 {
	public static void main (String[] args){
	Scanner input = new Scanner(System.in);
	
	// Declare some variables
	String computerAnswer = " ";
	String userAnswer = " ";
	int userEntry;
	double gamesWon = 0;
	double gamesTotal = 0;
	
	do {
	// Adds an extra space for cluttered output
	System.out.println(" ");
	
	// Randomize PC choice
	int computerChoice = (int)(Math.random()*3+1);
	
	// Ask user for input
	System.out.println("Enter 1 for scissors, 2 for rock, or 3 for paper");
	int userChoice = input.nextInt();
	
	// IF statements for computer
	if (computerChoice == 1) {
		computerAnswer = "scissors"; }
	else if (computerChoice == 2) {
		computerAnswer = "rock"; }
	else {
		computerAnswer = "paper"; }
	
	// IF statements for user
	if (userChoice == 1) {
		userAnswer = "scissors"; }
	else if (userChoice == 2) {
		userAnswer = "rock"; }
	else {
		userAnswer = "paper"; }
	
	// Outputting statements
	
	System.out.println("The computer chose " + computerAnswer);
	System.out.println("You have chose " + userAnswer);
	
	// IF statements for game
	if (computerChoice == 1 && userChoice == 2){
		System.out.println("You won!");
			gamesWon = gamesWon + 1;
			gamesTotal = gamesTotal + 1;}
			
	else if (computerChoice == 3 && userChoice == 1){
		System.out.println("You won!");
			gamesWon = gamesWon + 1;
			gamesTotal = gamesTotal + 1;}
		
	else if (computerChoice == 2 && userChoice == 3){
		System.out.println("You won!");
			gamesWon = gamesWon + 1;
			gamesTotal = gamesTotal + 1;}
		
	else if (computerChoice == userChoice){
		System.out.println("It was a tie!");
			gamesTotal = gamesTotal + 1;}
			
	else {System.out.println("Computer won!");
			gamesTotal = gamesTotal + 1;}
	
	System.out.println("Enter 0 to quit or enter any other number to play again");
		userEntry = input.nextInt();
		}while (userEntry != 0);

	System.out.println(" ");
	System.out.println("You have won " + gamesWon + " out of " + gamesTotal);
	double gamePercent =  (gamesWon / gamesTotal) * 100;
	System.out.printf("which is %3.2f" , gamePercent);
	System.out.println("%");
	}
}