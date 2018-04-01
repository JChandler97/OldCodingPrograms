import java.util.Scanner;

public class Rps {
	public static void main (String[] args){
	Scanner input = new Scanner(System.in);
	
	string computerAnswer " ";
	string userAnswer = " ";
	
	// Randomize PC choice
	int computerChoice = (int)(Math.random()*3+1);
	
	// Ask user for input
	System.out.println("Enter a value of 1, 2, or 3");
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
		computerAnswer = "scissors"; }
	else if (userChoice == 2) {
		computerAnswer = "rock"; }
	else {
		computerAnswer = "paper"; }
	
	// Outputting statements
	
	System.out.println("The computer chose " + computerAnswer);
	System.out.println("You have chose " + userAnswer;
	
	if (computerChoice == 1 && userChoice == 2){
		System.out.println("You won!"); }
	else if (computerChoice == 3 && userChoice == 1){
		System.out.println("You won!"); }
	else if (computerChoice == 2 && userChoice == 3){
		System.out.println("You won!"); }
	else if (computerChoice == userChoice){
		System.out.println("It was a tie!"); }
	else {System.out.println("Computer won!"); }
	
	
	
	
	
	
	
	
	
	
	}
}