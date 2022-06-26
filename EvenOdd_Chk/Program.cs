////////////Even Or Odd Checker///////////////
m : Console.Write("Enter an Integer:");
int x=Convert.ToInt32(Console.ReadLine());
void isEvenOdd(int m) {
    int y = x;
    if (y < 0)
        Console.WriteLine("Not a Postive Integer!");
    else if (y == 0)
        Console.WriteLine("Neither Odd nor Even,");
    else {
        if (y % 2 == 0)
            Console.WriteLine(y + " is Even.");
        else
            Console.WriteLine(y + " id Odd.");
    }
}
isEvenOdd(x);
