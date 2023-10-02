//One Dimensional Array

Console.WriteLine("1-D Array");
Console.WriteLine("\n");
Console.WriteLine("Integer Value of One Dimensional Array::");

 int[] intArray;
 intArray= new int[10];
/*int [] intArray = { 20, 25, 30, 50, 60, 70, 80, 90, 100, 0 };*/
intArray[0] = 1;
intArray[1] = 2;
intArray[2] = 3;
intArray[3] = 4;
intArray[4] = 5;
intArray[5] = 6;
intArray[6] = 7;
intArray[7] = 8;
intArray[8] = 9;
intArray[9] = 10;

Console.WriteLine("For Loop Apply :");

for(int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("Array Of Length By For Loop :"+intArray[i]);

}
Console.WriteLine("\n");
Console.WriteLine("While Loop Apply:");
int j=0;

while (j < intArray.Length)
{
    Console.WriteLine("Array of Length By While Loop:" +intArray[j]);
    j++;
}
Console.WriteLine("\n");
Console.WriteLine("Do-While Loop:");

int k = 0;
do
{
    Console.WriteLine("Array of Length By Do-While Loop:" + intArray[k]);
    k++;

}
while (k < intArray.Length);

Console.WriteLine("\n");
Console.WriteLine("For Each Loop:");

foreach(int m in intArray)
{
    Console.WriteLine("Array of Length by For Each Loop:" + m); 

}
{

}
Console.WriteLine("\n");
Console.WriteLine("String Type Value of Array:");
Console.WriteLine("\n");

string[] books;
books = new string[6];
books[0] = "Physics";
books[1] = "mathematics";
books[2] = "Biology";
books[3] = "information Technology";
books[4] = "Chemistry";
books[5] = "history";

Console.WriteLine("For Each Loop Apply:");
foreach(string book in books)
{
    Console.WriteLine("String Array Length:" + book);

}


Console.WriteLine("\n");
Console.WriteLine("Another Procedure of Declare One Dimensional Array:");

int[] intData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("For Each Loop:");

foreach(int data in intData)
{
    Console.WriteLine("For each Loop Array:" + data);
}


