// See https://aka.ms/new-console-template for more information

//Addition Calculator
int num1 = 2;
int num2 = 3;
int sum = num1 + num2;

Console.Write(num1 + " + " + num2);

Console.WriteLine(" = " + sum);


//outputs a sentence corresponding to user input
Console.Write("Are you a true hood beleiver?:");
string name = Console.ReadLine();

if (name == "yes")
{
    Console.WriteLine("No ur not stop lying");

} else if (name == "no") {

    Console.WriteLine("ok");

} else if (name == "bryan") { 

    Console.WriteLine("Black Ugly Nigger");

} else {

    Console.WriteLine("...");

}

//outputs a sentence corresponding to user input
Console.Write("Enter a Cool Name: ");
string coolName = Console.ReadLine();

if (coolName == "Chad-soma Spirit Foster")
{
    Console.WriteLine("10/10 Awesome Name Choice.");

}
else if (coolName == "Dart")
{

    Console.WriteLine("8/10 A little on the short side but it has potential");

}
else if (coolName == "")
{

    Console.WriteLine("Invalid");

} else {
    //random number gen
    Random rnd = new Random();
    int num = rnd.Next(6);
    Console.WriteLine(num+"/10 Not quite what I was looking for. Try a little harder.");

}

//an array to store data for a similar variable
string[] theVoices = {"PookietheRaccoon", "Scorp", "Ozeej", "Kirby", "Hoopie" };
int[] brainCell = new int[10];
brainCell[0] = 100;
brainCell[1] = 0;
brainCell[2] = 15;
brainCell[3] = -1000;

//Variables deifined by varibale type ()
bool isGay = false;
string isPlural = "Braincell";
string gayString = "Gay!?!?!?";
int x;
x = 0;

//if statement to change the plural form when needed
if (brainCell[x] > 1)
{
    isPlural = "Braincells";
}
else if (brainCell[x] == 0)
{

    isPlural = "Braincells";

}
else
{

    isPlural = "Braincell";

}
// if statement to auto change gay value of said individual
if (isGay == true)
{
    gayString = "Gay!?!?!?";

}
else
{

    gayString = "Not Gay.";

}

Console.WriteLine("This fucking bitch named " + theVoices[2] + " has " + brainCell[x] + " " + isPlural + " and is " + gayString);


//Waits to for input/interaction of said line before the debug console closes
Console.ReadLine(); 