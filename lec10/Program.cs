// mymethod();

// static void mymethod()
// {
//     Console.WriteLine("hello function");
// }

// mymethod1("Mayan", 18);
// mymethod1("sara ", 20);
// mymethod1("talia", 12);

// static void mymethod1(string fname, int age)
// {
//     Console.WriteLine(fname + "is" + age);
// }

int firstNo, secoundNo;

Console.WriteLine("please enter the first number:");
firstNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please enter the secound number:");
secoundNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("the result of sum two values is : " + AddTwoValues( firstNo , secoundNo));

static int AddTwoValues(int a , int y)
{
return a+y;

} 


