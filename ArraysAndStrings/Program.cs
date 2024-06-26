﻿// See https://aka.ms/new-console-template for more information

using ArraysAndStrings;
CopyingAnArray task1 = new CopyingAnArray();
ManageElements task2 = new ManageElements();
CalculatePrimes task3 = new CalculatePrimes();
RotateSum task4 = new RotateSum();
FindLongestSequence task5 = new FindLongestSequence();
MostFrequentNumber task6 = new MostFrequentNumber();
ReverseString task7 = new ReverseString();
ReverseWords task8 = new ReverseWords();
ExtractPalindromes task9 = new ExtractPalindromes();
ParseURL task10 = new ParseURL();

Console.WriteLine("Copying an Array: ");
task1.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start managing elements: ");
task2.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start calculating prime numbers in range 10-50: ");
task3.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start rotating and summing the input array: ");
task4.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start finding the longest sequence of equal elements in the array: ");
task5.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start finding the most frequent number in the array: ");
task6.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start reversing the string: ");
task7.ExecuteMethodOne();
task7.ExecuteMethodTwo();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start reversing the sentence: ");
task8.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start extracting palindromes from the sentence: ");
task9.Execute();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("Start parsing URL: ");
task10.Execute();
Console.WriteLine("---------------------------------------------------");