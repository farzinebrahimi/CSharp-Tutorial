// See https://aka.ms/new-console-template for more information

//Start the program
// Console.WriteLine("Please enter your name:");
// string name = Console.ReadLine();
//
//
// Console.WriteLine("Please enter your last name:");
// string lastName = Console.ReadLine();
//
// Console.WriteLine("Please enter your age:");
// int age = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine($"Your name is {name} {lastName} and your age is {age}");
//
// bool isMale = true;  

// #region Season 2 - a
//
// //Value
// int costPerKilo = 100;
// int totalPrice = 0;
//
// Console.WriteLine("Welcome to the Golden Cargo Ship");
// //User input
// Console.WriteLine("Please enter cargo weight:");
// int cargoWeight = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your cargo weight is:{cargoWeight} Kg.");
//
// //condition
// if (cargoWeight <= 20)
// {
//     totalPrice = cargoWeight * costPerKilo;
// }
// else if (cargoWeight is > 20 and <= 40)
// {
//     costPerKilo +=  5; //costPerKilo = costPerKilo + 5;
//     totalPrice =  cargoWeight * costPerKilo;
// }
// else
// {
//     costPerKilo += 10;
//     totalPrice = cargoWeight * costPerKilo;
// }
//
// //output
// Console.WriteLine("Your bill is ready...");
// Console.WriteLine($"Total price: {totalPrice} $.");
//
// #endregion
//
// #region Season2 -b
//
// switch (cargoWeight)
// {
//     case  <20 :
//         totalPrice = cargoWeight * costPerKilo;
//         break;
//     case >20 and <=40:
//         costPerKilo += 5;
//         totalPrice = cargoWeight * costPerKilo;
//         break;
//     case > 40:
//         costPerKilo += 10;
//         totalPrice = cargoWeight * costPerKilo;
//         break;
//     default:
//         Console.WriteLine("Invalid input");
//         break;
// }
//
//
//
//
// #endregion

// #region Session3
//
// int a = 0;
// int b = 0;
// Console.WriteLine("Please enter two numbers:");
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// sum = a + b;
//
// Console.Write($"The sum is : {sum}");
//
//
// #endregion

// #region Session4
//
// const float maxHealth = 100;
// float currentHealth = 0;
// currentHealth = maxHealth;
//
// bool isAlive = true;
//
// float dmg = Convert.ToSingle(Console.ReadLine());
//
// while (isAlive)
// {
//     
// }
// float TakeDamage(float amount)
// {
//
//     currentHealth -= amount;
//     if (currentHealth <= 0)
//     {
//         Die();
//     }
//     isAlive = true;
//     return currentHealth;
// }
//
// void Die()
// {
//     currentHealth = 0;
//     Console.WriteLine("Player is dead");
//     isAlive = false;
// }
//
//
//
//
//
// Console.WriteLine($"You have {TakeDamage(dmg)} health left");
//
//
//
// #endregion


// int sum = 0;
//
// int Test(int a, int b)
// {
//     return a + b;
// }
//
// int Test3(int a, int b)
// {
//     return a - b;
// }
//
// void Test1(int a, int b)
// {
//     
//     var avg = a + b;
//     Console.WriteLine(avg);
// }

// Test1(Test(19,8), Test3(19, 8));


void Welcome(string name)
{
    Console.WriteLine(name);
}
void Welcome(string name, int age)
{
    Console.WriteLine(name, age);
}

Welcome("AmirReza");
Welcome("AmirReza", 18);