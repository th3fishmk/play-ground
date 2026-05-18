global using static System.Console;
using Csharp;

var stringList = new MyLinkedList<string>();

stringList.Append("Hello ");
stringList.Append("world");
stringList.Append("!");

var numberList = new MyLinkedList<int>();

numberList.Append(1);
numberList.Append(2);
numberList.Append(3);
numberList.Append(4);
numberList.Append(5);

WriteLine($"The head value is: {numberList.Head()}");
numberList.Prepend(0);
WriteLine($"The head value is: {numberList.Head()}");

WriteLine($"Total size of {nameof(numberList)} is: {numberList.Size()}");

WriteLine($"The tail for {nameof(numberList)} is {numberList.Tail()}");

var nullList = new MyLinkedList<int>();

try
{
    WriteLine($"The tail for {nameof(nullList)} is {nullList.Tail()}");
}
catch (System.Exception e)
{
    WriteLine(e.Message);
}

var index = stringList.Size() - 1;

try
{
    WriteLine($"index: {index} of {nameof(stringList)}: {stringList.AtIndex(index)}");
}
catch (Exception e)
{
    WriteLine(e.Message);
}

WriteLine($"{nameof(stringList)} before pop:");
stringList.PrintAllValues();
stringList.Pop();
WriteLine($"{nameof(stringList)} after pop:");
stringList.PrintAllValues();

WriteLine($"Is 5 in {nameof(nullList)}? {nullList.Contains(5)}");
nullList.PrintAllValues();
