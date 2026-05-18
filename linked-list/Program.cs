global using static System.Console;
using Csharp;

var stringList = new MyLinkedList<string>();

stringList.Append("Hello ");
stringList.Append("world");
stringList.Append("!");

stringList.PrintAllValues();

var numberList = new MyLinkedList<int>();

numberList.Append(1);
numberList.Append(2);
numberList.Append(3);
numberList.Append(4);
numberList.Append(5);

numberList.PrintAllValues();
