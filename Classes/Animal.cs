using System.Data;

namespace KESCHA.Classes
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int AgeDifferense { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifferense = 0;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int userAge, int animalAge)
        {
            Name = name;
            Age = animalAge;
            //AgeDifferense = CalculateAgeDifferense(userAge,animalAge);
            CalculateAgeDifferenseNotReturn(userAge,animalAge);
        }

        public void Password()
        {
            string password;
            do
            {
                System.Console.Write("Enter your password: ");
                password = Console.ReadLine();
            } while(password !="ps");
        }

        public void PrintAgeDifference()
        {
            System.Console.WriteLine($"{Name}'s age is {AgeDifferense} years different from yours");
        }

        public void CompareAges(int userAge)
        {
            string massage =
            (userAge>Age) 
            ? "You are old"
            : (userAge==Age)
                ? "equal"
                : "You are young";
            System.Console.WriteLine(massage);
        }

        public void TellAbautFriend(string userName,int userAge)
        {
            System.Console.WriteLine("Let me tell you about my frinds. ");
            string[] friendName = new string[3];
            friendName[0] = "Vatika";
            friendName[1] = "Endo";
            friendName[2] = userName;
            int[] friendAge = { 3,2,userAge};
            for(int i = 0; i < friendName.Length; i++ )
            {
                System.Console.WriteLine($"{friendName[i]} is {friendAge[i]} year old. ");
            }
        }

        public void CalculateAgeDifferenseNotReturn(int userAge)
        {
            AgeDifferense = userAge - Age;
        }

        public void Greet(string userName)
        {
            if(userName =="")
            {
                userName="Noname";
            }
            System.Console.WriteLine($"Hello! {userName}");
        }

        private void CalculateAgeDifferenseNotReturn(int userAge, int animalAge)
        {
            AgeDifferense = userAge - animalAge;
        }
    }
}