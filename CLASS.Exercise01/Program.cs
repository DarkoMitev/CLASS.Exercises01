// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//EXERCISE1
//● Declare two double variables
//● Initialize them and divide them in a new variable
//● Declare two integer variables
//● Initialize them and divide them in a new variable
//● Print the results in the console and compare


double doubleVariable = 10;
double doubleVariable1 = 3;

double divideTwoDoubleVariables = doubleVariable / doubleVariable1;

int intVariable = 1500;
int intVariable1 = 500;

int divideIntVariables = intVariable / intVariable1;

Console.WriteLine(divideIntVariables);
Console.WriteLine(divideTwoDoubleVariables);

//EXERCISE2
//● Declare two string variables
//● Initialize them and concatenate them in a new variable
//● Declare two string variables
//● Initialize them with the number 9 and 3
//● Concatenate them in a new variable
//● Print the results in the console


string strVariable = "Darko";
string strVariable1 = " Mitev";

string strConc = strVariable + strVariable1;

Console.WriteLine(strConc);

string numStr = "9";
string numStr1 = "3";

string strConc1 = numStr + numStr1;

Console.WriteLine(strConc1);

//EXERCISE3
//● Declare an integer and a string variable
//● Initialize them and concatenate them in a new variable
//● Print the result in the console


int intVar1 = 100;
string strConc2 = "Bob";

Console.WriteLine(intVar1 + strConc2);

//EXERCISE4
//● You have n credits on your mobile bill. One SMS costs m credits.
//How many SMS messages you can send?
//● n = 102
//● m = 5
//● Result = ?


int n = 102;
int m = 5;

int smsSend = n / m;
Console.WriteLine(smsSend);

///////////////////////////////////////////////////////////////////////////////////

//EXERCISE5
//● Solve the following problem. On one tree there are 12 branches
//with n apples on them. One basket can hold m apples. If a user
//enters number of trees find out how many baskets does it take to
//collect all the apples from the trees?
//● n = 8
//● m = 5
//Result = ?


Console.WriteLine("Enter number of trees: ");
string numberOfTrees = Console.ReadLine();

bool parseTreesNumber = int.TryParse(numberOfTrees, out int value);

int oneTree = 12 * 8;
int basketApples = 5;

int userBusket = value * (oneTree / basketApples);

Console.WriteLine("You gonna need " + userBusket + " buskets.");

////////////////////////////////////////////////////////////////////////////////////

//EXERCISE6
//● Create two variables and initialize them with a keyboard input
//● Write code that can test which number is larger
//● Write code that can test the numbers whether they are even or
//odd
//● Write the larger number from the two in the console
//● After that write if the number is even or odd


Console.WriteLine("Enter numbers: ");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

bool parseInputNumbers = int.TryParse(num1, out int sum);
bool parseInputNumbers1 = int.TryParse(num2, out int sum1);

if (sum > sum1)
{
    Console.WriteLine(sum + " is bigger then " + sum1);
}
else if (sum1 > sum)
{
    Console.WriteLine(sum1 + " is bigger then " + sum);
}
else
{
    sum = sum1;
    Console.WriteLine("They are equal");
}
if (sum != 0)
{
    if (sum % 2 == 0)
    {
        Console.WriteLine("Number is even");
    }
    else
    {
        Console.WriteLine("Number is odd");
    }
}
else
{
    Console.WriteLine("You enterd Zero, That is not even nore odd !");
}

////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCISE7
//● Ask the user to enter a number from 1 to 3
//● If the user enters “1” write “You got a new car!”
//● If the user enters “2” write “You got a new plane!”
//● If the user enter “3” write “You got a new bike!”
//● If the user enters a wrong number or character write an error
//message in the console


Console.WriteLine("Enter a number from 1 to 3: ");
string user = Console.ReadLine();

bool enterdNumber = int.TryParse(user, out int userEnter);

//////////////// with if/else if

if (userEnter == 1)
{
    Console.WriteLine("You got a new car!");
}
else if (userEnter == 2)
{
    Console.WriteLine("You got a new plane!");
}
else if (userEnter == 3)
{
    Console.WriteLine("You got a new bike!");
}
else
{
    Console.WriteLine("You enterd a wrong number!");
}
/////////////////// with SWITCH
switch (userEnter)
{
    case 1:
        Console.WriteLine("you got a new car!");
        break;


    case 2:
        Console.WriteLine("you got a new plane!");
        break;
    case 3:
        Console.WriteLine("you got a new bike!");
        break;

    default:
        Console.WriteLine("you enterd a wrong number!");
        break;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////