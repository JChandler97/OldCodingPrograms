// James Chandler
// 4/27/16

import java.util.Scanner;
public class Benford {
	public static void main(String[] args) throws Exception{
	
		java.io.File file=new java.io.File("sunspots.txt");
		Scanner input = new Scanner(file);
		
		int[] count = countDigits(input);
		reportResults(count);
	}
	
	public static int[] countDigits(Scanner input){
		int[] count = new int[10];
		
		while(input.hasNext()){
			int n = input.nextInt();
			
			// Call method firstDigit - done
			firstDigit(n);
			count[firstDigit(n)]++;
		}
			
		return count;	
	}
	
	public static void reportResults(int[] count){
		System.out.println();
		if (count[0] > 0){
		
		}
		
		int total = sum(count) - count[0];
		System.out.println();
		System.out.println("Digit Count Percent");
		
		for(int i=1; i < count.length; i++){
	
			double pct = count[i] * 100.0 / total;
			System.out.printf("%5d %5d %8.2f \n", i , count[i], pct);
		}
		
		System.out.println();
		System.out.printf("Total %5d %8.2f \n", total, 100.0);
	
	}
	
	public static int sum(int[] data){
		int sum=0;
		for(int n : data){
			sum += n;
		}
		
		return sum;
	}
	
	public static int firstDigit(int n){
		int result = Math.abs(n);
		while (result >= 10){
			result = result / 10;
		}
		
		return result;
	}
}