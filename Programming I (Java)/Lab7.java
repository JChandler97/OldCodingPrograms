public class Lab7 {
	public static void main(String [] args){
	
	double celsius;
	double fahrenheit;
	
	System.out.println("Celsius " + "Fahrenheit"); 
	
	for(double c = 40; c >= 32; c--){
		celsius = c;
		double y = CtoF(celsius);

		System.out.printf("%2.1f \t%3.1f \n", c ,y);
	}
	
	System.out.println(" ");
	System.out.printf("Fahrenheit\tCelsius\n"); 
	
	for(double c = 120; c >= 30; c=c-10){
		fahrenheit = c;
		double x = FtoC(fahrenheit);
	
		System.out.printf("%2.1f \t\t%4.1f \n", c , x);
	}
}
	// Method One
	public static double CtoF(double c){
		double fahrenheit = (9.0/5)*c + 32;
		return fahrenheit;
	}
	
	//Method Two
	public static double FtoC(double c){
		double celsius = (5.0/9) * (c - 32);
		return celsius;
	}
}