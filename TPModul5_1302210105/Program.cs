// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<R>(R user)
    {
        Console.WriteLine("Hallo User " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric haloR = new HaloGeneric();
        haloR.SapaUser("Onesiforus Rade Putra");
    }
}