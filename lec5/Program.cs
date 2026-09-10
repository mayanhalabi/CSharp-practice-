int no1, no2, resultAdd=0, resultMulti=1;

Console.Write("please enter the first number:");
no1 = Convert.ToInt32(Console.ReadLine());


Console.Write("please enter the secound number:");
no2 = Convert.ToInt32(Console.ReadLine());

resultAdd = no1 + no2;
resultMulti = no1 * no2;

//Console.WriteLine("The result of adding operation is: ",resultAdd );
//Console.WriteLine("The result of multi operation is: ",resultMulti );
Console.WriteLine(resultAdd);
Console.WriteLine(resultMulti);

