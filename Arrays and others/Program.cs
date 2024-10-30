
internal class Program
{
    private static void Main(string[] args)
    {

        Aray array = new Aray(3);

        array.insert(10);
        array.insert(20);
        array.insert(30);
        array.displayArray();
        array.insert(40);
        array.displayArray();
    }
}