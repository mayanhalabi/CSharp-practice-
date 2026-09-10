// // find max 
// int[] arr = [1,7,-2,5,-1,9];
// int maxNo = arr[0];

// for (int i =0; i<arr.Length; i++)
// if(maxNo > arr[i])
// maxNo = arr[i];
// Console.WriteLine(maxNo);

// assing and desassinding 
// int i,j,temp,no;
// int[] arr1= new int [5];
// Console.WriteLine("please enter no of elements of arryes");
// no = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("please enter the values:");
// for(i=0; i<no; i++)
// arr1[i]= Convert.ToInt32(Console.ReadLine());

// for(i=0; i<no; i++)
// for(j=i+1; j<no; j++)
// if(arr1[i] > arr1[j])
//         {
//             temp = arr1[i];
//             arr1[i] = arr1[j];
//             arr1[j] = temp;
//         }
//         Console.WriteLine(" the final result is:");
//         for(i=0; i<no; i++)
//     Console.Write($"{arr1[i]}");

// odd and even 
using System.Diagnostics.CodeAnalysis;

int[] arr = [1,2,5,8,13,21,34];
int sum =0;

for( int i =0; i<arr.Length; i++)
if(arr[i]%2 == 1)
sum += arr[i];

Console.WriteLine(sum);



