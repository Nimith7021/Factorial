using System;

class Factorial {

	public static void Main(String[] args){

	int inputNumber,factorial;
	Console.WriteLine("Enter the number:");
	inputNumber = Convert.ToInt32(Console.ReadLine());
	factorial = inputNumber;
	for(int i = inputNumber ; i>1;i--){

	factorial*=(i-1);
}


	Console.WriteLine("The factorial of " + inputNumber + " is " +factorial );

}

}