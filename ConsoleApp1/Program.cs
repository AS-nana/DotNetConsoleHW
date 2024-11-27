// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

Console.WriteLine("Please input your First name: ");
string fname = Console.ReadLine();
Console.WriteLine("Please input your Last name: ");
string lname = Console.ReadLine();
Console.WriteLine("Please input your age: ");
Int32 age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please input your gender: ");
string gender = Console.ReadLine();

int ageIn20 = age+ 20;



Console.WriteLine("\nYour details are as follows: ");
Console.WriteLine($"- Fist name: " + fname);
Console.WriteLine($"- Last Name: " + lname);
Console.WriteLine($"- Gender: "+ gender);
Console.WriteLine("You will be " + ageIn20 + " years old in 20 years!");
