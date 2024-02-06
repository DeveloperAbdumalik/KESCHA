Console.WriteLine("Hello, Enter your name:");
string name = Console.ReadLine();
System.Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Your name {name} and age {age} Add list.");
int agek = 3;
int intdifferense = age - agek;
System.Console.WriteLine($"KESCHA's age is {intdifferense} years different from yours");

if(age>agek)
{
    System.Console.WriteLine("You are old:");
}
else if(age==agek)
{
    System.Console.WriteLine("You are the same age:");
}
else
{
System.Console.WriteLine("You are young:");
}