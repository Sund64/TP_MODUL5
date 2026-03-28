
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}