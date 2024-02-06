using KESCHA.Classes;

Animal kescha = new Animal(name: "kescha", age: 3);

kescha.Password();

Console.WriteLine("Hello, Enter your name:");
string userName = Console.ReadLine();
kescha.Greet(userName);

System.Console.WriteLine("Enter your age:");
int userAge = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Your name {userName} and age {userAge} Add list.");

 

kescha.CalculateAgeDifferenseNotReturn(userAge);
kescha.PrintAgeDifference();
kescha.CompareAges(userAge);
kescha.TellAbautFriend(userName,userAge);