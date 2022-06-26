/////////////DigitRepCounter//////////////
Console.Write("Enter an Integer:");
int i=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the digit:");
int digit=Convert.ToInt32(Console.ReadLine());
void repcounter(int i,int digit)//Function To check Number of rep of digit in an Integer
{
    int k=i,count = 0, rem=0,rep=0;
    if (k < 0 || digit < 0)
        Console.WriteLine("-1");
    else {
        while (k != 0) {
            rem = k % 10;
            k=k/10;
            if (rem == digit) {
                count++;
            }
        }
    }
    Console.WriteLine("The Number of times " + digit + " is Found in " + i + " is: " + count);
}
repcounter(i,digit);
