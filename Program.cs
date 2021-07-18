using System;

namespace OOP
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         double myDouble = 4.52;
    //         int myInt = (int) myDouble;
    //         Console.WriteLine(myDouble);
    //         Console.WriteLine(myInt);
    //         Console.WriteLine("Hey I'm new in C#. let Print 'Hello World!'");
    //     }
    // }

    // addition
    // class Add{
    //     static void Main(string[] args){
    //         int a, b, c;
    //         Console.WriteLine("1st value: ");
    //         a=Convert.ToInt32(Console.ReadLine());
    //         Console.WriteLine("2nd value: ");
    //         b=Convert.ToInt32(Console.ReadLine());
    //         c = a + b;
    //         Console.WriteLine("Result: {0} ", c);
    //     }
    // }

    // area
    // class Area{
    //     static void Main(string[] args){
    //         double area, radius;
    //         const double pi = 3.1416;
    //         Console.WriteLine("Enter the radius value: ");
    //         radius = Convert.ToDouble(Console.ReadLine());
    //         area = pi * radius * radius;
    //         Console.WriteLine("Area of Circle: {0}", area);
    //         Console.ReadKey();
    //     }
    // }

    // condition

    // // even odd
    //     class Condition{
    //         static void Main(string[] args){
    //             int num  = 99;
    //             if(num % 2 == 0){
    //                 Console.WriteLine("Even Number!");
    //             }else{
    //                 Console.WriteLine("Odd");
    //             }
    //         }
    //     }

    // while do while for
    // class WhileLoop{
    //     static void Main(string[] args){
    //         int i = 5;
    //         while( i < 11){
    //             Console.WriteLine(i);
    //             i++;
    //         }
    //     }
    // }

    // do while
    // class DoWhileLoop
    // {
    //     static void Main(string[] args)
    //     {
    //         int i = 5;

    //         do{
    //             Console.WriteLine(i);
    //             i++;
    //         }while (i < 11);
    //     }
    // }


    // for loop
    // class ForLoop{
    //     public static void Main(string[] args){
    //         for(int i = 0; i < 10; i++){
    //             Console.WriteLine(i);
    //         }
    //     }
    // }

    // nested loop
    // nested while

    // class NestedWhileLoop{
    //     static void Main(string[] args){
    //         int i = 0;
    //         while(i < 5){
    //             Console.WriteLine("Value of i: {0}", i);
    //             int j = 1;
    //             i++; 
    //             while(j < 2){
    //                 Console.WriteLine("Value of j: {0}", j);
    //                 j++;
    //             }
    //         }
    //     }
    // }

    // do while nested

    // class NestedDoWhileLoop
    // {
    //     static void Main(string[] args)
    //     {
    //         int i = 0;

    //         do{
    //             Console.WriteLine("Value of i: {0}", i);
    //             int j = i;
    //             i++;
    //             do{
    //                 Console.WriteLine("Value of j: {0}", j);
    //                 j++;
    //             }while (j < 2);
    //         }while (i < 2);
    //     }
    // }

    // nested forloop
    // class ForLoop{
    //     public static void Main(string[] args){
    //         for(int i = 1; i <= 3; i++){
    //             for(int j = 1; j <= 3; j++){
    //                 Console.WriteLine(i + " " + j);
    //             }
    //         }
    //     }
    // }

// infinite loop with

    // class InfiniteLoop{
    //     static void Main(string[] args){
    //         for(;;){
    //             Console.WriteLine("Running...............");
    //         }
    //     }
    // }


    // array
    // class ArrayInCsharp{
    //     static void Main(string[] args){
    //         int[] arr = new int[10];
    //         int i;
    //         Console.WriteLine("\n\n Read and Print element of array.");
    //         Console.Write("Input 10 Element of Array: \n");
    //         for(i = 0; i < 10; i++){
    //             Console.Write("element[{0}]: ",i);
    //             arr[i]=Convert.ToInt32(Console.ReadLine());
    //         }
    //         Console.Write("\n Element in array are: ");
    //         for(i = 0; i < 10; i++){
    //             Console.Write("{0} ",arr[i]);
    //         }
    //     }
    // }

    // method

// //    class MethodExample{
//         static void myMethod()
//         {
//             Console.WriteLine("method");
//         }
//         static void Main(string[] args){
//             myMethod();
//         }
//    }

    // //    factorial
    // class FactorialExample
    // {
    //     static void Factorial(){
    //         int i, fact = 1, number;
    //         Console.Write("Enter any Number: ");
    //         number = int.Parse(Console.ReadLine());
    //         for (i = 1; i <= number; i++)
    //         {
    //             fact = fact * i;
    //         }
    //         Console.Write("Factorial of " + number + " is: " + fact);
    //     }
    //     public static void Main(string[] args)
    //     {
    //         Factorial();
    //     }
    // }


    // swapping

    // class SwappingNumber{
    //     static void Main(string[] args){
    //         int a = 10, b = 23;
    //         Console.WriteLine("before swap -");
    //         Console.WriteLine(a.ToString());
    //         Console.WriteLine(b.ToString());
    //         a = a + b;
    //         b = a - b;
    //         a = a - b;
    //         Console.WriteLine("After - ");
    //         Console.WriteLine(a.ToString());
    //         Console.WriteLine(b.ToString());
    //         Console.ReadLine();
    //     }
    // }

    // // find max min value
    // class MaxMin{
    //     static void Main(string[] args){
    //         int []arr = new int[5]{33,44,23,54,64};
    //         int i, max, min, n;
    //         n = 5;
    //         max = arr[0];
    //         min = arr[0];
    //         for(i = 1; i < n; i++){
    //             if(arr[i] > max){
    //                 max = arr[i];
    //             }
    //             if(arr[i] < min){
    //                 min = arr[i];
    //             }
    //         }
    //         Console.Write("Maximum element = {0}\n", max);
    //         Console.Write("Minimum element = {0}\n\n", min);
    //     }
    // }

    // inheritance

    // class Shape{
    //     public void setWidth(int w){
    //         width = w;
    //     }
    //     public void setHeight(int h){
    //         height = h;
    //     }
    //     protected int width;
    //     protected int height;
        
    // }
    // class Rectangle : Shape{
    //     public int getArea(){
    //         return (width * height);
    //     }
    // }
    // class RectangleTest {
    //     static void Main(string[] args){
    //         Rectangle rect = new Rectangle();
    //         rect.setWidth(5);
    //         rect.setHeight(7);
    //         Console.WriteLine("area: {0}", rect.getArea());
    //     }
    // }





    // ----------------------
}

