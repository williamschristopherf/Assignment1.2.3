// See https://aka.ms/new-console-template for more information
//Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division. 
//Call them appropriately when user selects the option. Give the user the option to continue or exit the program.

//Declare variables
double answer = 0;
double num1 = 0;
double num2 = 0;
bool exit = false;
char mathOperator = 'a';
char toContinue = 'y';
//While loop to keep the program going 
while (exit == false)
{
    //Get user input for 2 numbers and the mathmatical operator
    Console.WriteLine("Enter your first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your second value: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Do you want to add, subtract, mutiply, or divide? \"a, s, m, d\"");
    mathOperator = Convert.ToChar(Console.ReadLine());

    //Switch statements to handle the different math operations. Default to catch inavlid charachter inputs
    switch (mathOperator)
    {
        case 'a':
            answer = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {answer}");
            break;

        case 's':
            answer = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {answer}");
            break;

        case 'm':
            answer = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {answer}");
            break;

        case 'd':
            answer = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {answer}");
            break;

        default:
            Console.WriteLine("Invalid Entry");
            break;
    }

    //User input to continue or break the while loop based on comparing toContinue char in the if statement
    Console.WriteLine("Do you have another input? y or n");
    toContinue = Convert.ToChar(Console.ReadLine());
    if (toContinue == 'n')
    {
        exit = true;
    }

}