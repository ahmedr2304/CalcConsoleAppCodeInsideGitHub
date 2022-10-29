// See https://aka.ms/new-console-template for more information
using CalcLibraryCode;
using System.Net.Http;

// Get the result from External Api
var client = new HttpClient();
var resultAPI_AvG = await client.GetStringAsync("https://localhost:7009/Average?nums=10&nums=20&nums=50&nums=100&nums=70");
var resultAPI_Smallest = await client.GetStringAsync("https://localhost:7009/Smallest?nums=10&nums=20&nums=50&nums=100&nums=70");
var resultAPI_Largest = await client.GetStringAsync("https://localhost:7009/Largest?nums=10&nums=20&nums=50&nums=100&nums=70");
Console.WriteLine("Get the result from External Api");
Console.WriteLine("\n");
Console.WriteLine("The Average from Api Result  :" + resultAPI_AvG);
Console.WriteLine("The Samllest from Api Result  :" + resultAPI_Smallest);
Console.WriteLine("The Largest from Api Result  :" + resultAPI_Largest);
Console.WriteLine("\n");
Console.WriteLine("*******************************");
Console.WriteLine("Get the result from Class library");
Console.WriteLine("\n");
// Get the result from ClassLibrary
var nums = new int[] { 2, 5, 8, 22, 33, 24, 12 };
        // get the Average of the array of integer value
        //CalcConsoleAppCodeInside.Calc calc = new  CalcConsoleAppCodeInside.Calc  ();
        Calc calc = new Calc();
        int resultAvG = calc.Average(nums);
        int resultSmall = calc.Smallest(nums);
        int resultLarge = calc.Largest(nums);
        Console.WriteLine("The Average Result  :" + resultAvG);
        Console.WriteLine("The Samllest Result  :" + resultSmall);
        Console.WriteLine("The Largest Result  :" + resultLarge);

Console.WriteLine("*******************************");
Console.WriteLine("Get the result from Nuget");
Console.WriteLine("\n");

// Get the result from nuget (Api.nuget.org) 
//PackageName : NuGet\Install-Package SampleCalcClassLibraryV3 -Version 1.0.0
var numsnuget = new int[] { 2, 5, 8, 22, 33, 24, 12 };
// get the Average of the array of integer value
SampleCalcClassLibraryV3.Calc calcNuget = new SampleCalcClassLibraryV3.Calc();
int result_Nuget_AvG = calcNuget.Average(numsnuget);
int result_Nuget_Small = calcNuget.Smallest(numsnuget);
int result_Nuget_Large = calcNuget.Largest(numsnuget);
Console.WriteLine("The Average Result  :" + result_Nuget_AvG);
Console.WriteLine("The Samllest Result  :" + result_Nuget_Small);
Console.WriteLine("The Largest Result  :" + result_Nuget_Large);






