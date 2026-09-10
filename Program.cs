// //find factorial using while loop

// int i =0, fact=1, number=3;
// //Console.Write("please enter any nymber:");
// //number= Convert.ToInt32(Console.ReadLine());

// while(i <= number)
// {
//     fact = fact * i;
//     i++;
// }
// Console.WriteLine(fact);


// int i=1, fact =1, number;

// Console.Write("Please enter any number: ");
// number = Convert.ToInt32(Console.ReadLine());


// while (i<=number)
// {
//     fact *= i;
//     i++;
// }

// Console.WriteLine(fact);


int i=1, fact =1, number;
Console.Write("Please enter any number: ");
number = Convert.ToInt32(Console.ReadLine());

do
{
    fact *= i;
       i++;
}while(i<=number);
Console.WriteLine(fact);