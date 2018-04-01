// James Chandler
// 4/20/16
// The purpose of the program is to sort the scores from highest to lowest 

import java.util.Scanner;
public class Hwk6 {
	public static void main(String [] args) throws Exception{
		String[] fName = new String[5];
		String[] lName = new String[5];
		int[] score = new int[5];
		java.io.File file = new java.io.File("info.txt");
		Scanner input=new Scanner(file);
		int c = 0;
		int arrayLength = score.length;
	
	while(input.hasNext()){
		fName[c] = input.next();
		lName[c] = input.next();
		score[c] = input.nextInt();
		c++;
	}
	input.close();
	
	bubbleSort(score,fName,lName);
        for (int x = 4; x >= 0; x--){
            System.out.print(fName[x].substring(0, 1) + lName[x].substring(0, 1) + " " + score[x]);
            System.out.println();
        }
    }
	
public static void bubbleSort(int[] score,String[] fName, String[] lName){
        int temp;
        String tempFirstName,tempLastName;
        for (int i = 0; i < score.length - 1; i++) {
            for (int j = 1; j < score.length - i; j++) {
                if (score[j - 1] > score[j]) {
                    temp = score[j - 1];
                    score[j - 1] = score[j];
                    score[j] = temp;

                    tempFirstName = fName[j -1];
                    fName[j - 1] = fName[j];
                    fName[j] = tempFirstName;

                    tempLastName = lName[j -1];
                    lName[j - 1] = lName[j];
                    lName[j] = tempLastName;
					
                }
            }
        }
    }
}