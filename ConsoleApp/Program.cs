int[][] numbers = [[1,0], [2, 3], [10, 0]];
string[] fruits = ["Apple", "Banana", "Orange", "Grape"];

List<int> numberslist = [2, 5, 6];

//for loop
for (int i = 1; i <= 10; i = i + 2)
{
    Console.Write($"{i} ");
}


//while loop
Console.Write("While loop (countdown): ");
int countdown = 5;
while (countdown > 0)
{
    Console.Write($"{countdown} ");
    countdown--;
}

foreach (var item in numberslist)
{
    Console.WriteLine(item);
}

