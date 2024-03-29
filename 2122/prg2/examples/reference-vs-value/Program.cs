﻿using System.Diagnostics;

int value = 100;
Helper.Add5(value);
Debug.Assert(value == 100);

Helper.Add5(ref value);
Debug.Assert(value == 105);

Helper.Add5Out(out value);
// Debug.Assert(value == 105);

string start = "start";
Helper.AddToStringRef(ref start);
Debug.Assert(start == "start+pes");

start = "start";
Helper.AddToString(start);
Debug.Assert(start == "start");

List<int> listA = new List<int> { 1, 2, 3 };
List<int> listB = new List<int> { 1, 2, 3 };

Helper.Update(listA);
Helper.UpdateRef(ref listB);

Console.WriteLine("listA");
foreach (var val in listA)
    Console.WriteLine(val);

Console.WriteLine("listB");
foreach (var val in listB)
    Console.WriteLine(val);

Console.WriteLine("Done");

int[] arrayA = new int[] { 1, 2, 3, 4 };
int[] arrayB = new int[] { 9, 9 };

Helper.PrintArray(arrayB);

arrayB.CopyTo(arrayA, 0);

Helper.PrintArray(arrayA);

int[] array = new int[] { 100, 200, 300 };
int[][] arrays1 = new int[][] { new int[] {1, 2}, array };
int[][] arrays2 = new int[][] { array, new int[] { 3 ,4} };

Helper.PrintArray(arrays1);

array[0] = -1;

Helper.PrintArray(arrays1);
arrays2.CopyTo(arrays1, 0);
Helper.PrintArray(arrays1);

// var foos = new object[] { new Foo(), new Foo() };
// Array.Sort(foos);

var xxx = new int[] { 1, 2, 3 };
var yyy = (int[])xxx.Clone();
Debug.Assert(xxx != yyy);
Debug.Assert(!xxx.Equals(yyy));

yyy[0] = 111;

Debug.Assert(xxx[0] == 1);
