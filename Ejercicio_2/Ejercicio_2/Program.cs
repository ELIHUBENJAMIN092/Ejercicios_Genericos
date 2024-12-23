public class GenericMethods
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

// Uso
public class Program
{
    public static void Main()
    {
        int x = 5, y = 10;
        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
        GenericMethods.Swap(ref x, ref y);
        Console.WriteLine($"After Swap: x = {x}, y = {y}");

        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
        GenericMethods.Swap(ref str1, ref str2);
        Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
    }
}