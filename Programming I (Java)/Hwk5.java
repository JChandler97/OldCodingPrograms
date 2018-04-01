import java.util.Scanner;
public class Hwk5{
	public static void main(String [] args){
	Scanner input = new Scanner(System.in);

	//Declare variables
	int studentNum;
	String name = " ";
	double studentScore;
	int count;
	double totalScore=0;
	double highScore=0;
	String highScoreName = " ";
	
	System.out.println("Enter the number of students");
		studentNum = input.nextInt();

	for(count=1; count <= studentNum; count++){
		System.out.println("Enter student " + count + " name");
			name=input.next();
		
		System.out.println("Enter " + name + "'s score");
			studentScore=input.nextDouble();
			
		totalScore = totalScore + studentScore;

		if (studentScore > highScore){
				highScore = studentScore; 
				highScoreName = name;}
		else { studentScore = studentScore;}
	}

	System.out.println("High Score is for " + highScoreName + " at " + highScore); 
	double average = totalScore/studentNum;
	System.out.println("Average is " + average);
}
}