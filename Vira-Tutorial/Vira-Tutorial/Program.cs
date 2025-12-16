// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your name is {name} {lastName} and your age is {age}");
Console.WriteLine("Your name is" + name + " " + lastName +  " " + "and your age is" + " " + age);





