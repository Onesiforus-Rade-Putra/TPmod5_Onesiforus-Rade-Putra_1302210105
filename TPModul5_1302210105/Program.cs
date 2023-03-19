// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<R>(R user)
    {
        Console.WriteLine("Hallo User " + user);
    }
}

public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData_1302210105()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
class Program
{
    static void Main(string[] args)
    {
        HaloGeneric haloR = new HaloGeneric();
        haloR.SapaUser("Onesiforus Rade Putra");
        DataGeneric<string> dataA = new DataGeneric<string>("1302210105");
        dataA.PrintData_1302210105();
    }
}
