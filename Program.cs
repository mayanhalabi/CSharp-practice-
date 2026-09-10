// //writre a c# program to calculate a power of X and N
// int i,j,x,N,exponentx,exponentN, powerx , powerN;
// Console.WriteLine("enter x:");
// x= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter N:");
// N= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("enter the exponent for x: ");
// exponentx= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter the exponent for N: ");
// exponentN= Convert.ToInt32(Console.ReadLine());

// powerx = 1;
// powerN=1;
// for(i=1; i<= exponentx; i++)
// powerx *= x;
// for(j=1; j<= exponentN; j++)
// powerN *= N;

// Console.WriteLine(powerx);
// Console.WriteLine(powerN);


// write a c# program t calculate a factorial of X
// int i, x, fact=1;
// Console.WriteLine("enter x:");
// x= Convert.ToInt32(Console.ReadLine());

// for(i=1; i<=x ; i++)
// fact= fact * x;

// Console.WriteLine(fact);


// write a c# program to print an array(elements of array)

//string[] brands= ["mavi", "LCW", "defacto", "koton"];
//Console.WriteLine(brands[2]);


//sum of elements of an array
// int [] arr = [1,1,2,3,4,6,7];
// arr= Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i =0; i<arr.Length; i++)
// sum += arr[i];
// Console.WriteLine(sum);

// to find max number using do-while 
// int[] arr1= {1,-1,-2,5};
// int i =1;
// int max= arr1[0];
// do
// {
//     if(arr1[i]> max)
//     {
//          max = arr1[i];
//     }
//    i++;
// } while(i<arr1.Length);

// Console.WriteLine(max);

// to find the min number using do-while
int[] arr2= {2,-2,-9,3,6};
int min= arr2[0];
int i =1;

do
{
    if (arr2[i] < min)
    {
        min =arr2[i];
    }
    i++;
}while(i < arr2.Length);

Console.WriteLine(min);


