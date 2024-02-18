partial class Program
{
    static int ReadNumber()
    {
        Console.WriteLine("Introduceti un numar pentru a i se afisa semnul");
        if(!int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumber();
        }
        return number;
    }
    static void ShowSign(int number)
    {
        switch (number)
        {
            case >0: 
                Console.WriteLine("+");
                break;
            case 0:
                Console.WriteLine("0");
                break;
            default:
                Console.WriteLine("-");
                break;
        }
    }
}