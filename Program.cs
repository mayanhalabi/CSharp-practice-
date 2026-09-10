// int x, y;
// int max = 0;
// Console.WriteLine("enter the first number:");
// x= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter the first number:");
// y= Convert.ToInt32(Console.ReadLine());

// if (x>y) max = x;
// else if(x<y) max = y;
// else Console.WriteLine("x = y ");
// Console.WriteLine(max);

//factorial 
// int i ,fact =1, number;
// Console.WriteLine("enter number:");
// number = Convert.ToInt32(Console.ReadLine());
// for(i=1; i<= number;i++)
// fact = fact * i;
// Console.WriteLine(fact);

//power 
int i, power =1, baseNo, expoNo;
Console.WriteLine("enter the base no:");
baseNo= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter expo no:");
expoNo= Convert.ToInt32(Console.ReadLine());

for(i=1;i<=expoNo;i++)
power *= baseNo;
Console.WriteLine(power);