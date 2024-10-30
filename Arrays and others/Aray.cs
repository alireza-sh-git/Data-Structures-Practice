
public class Aray
{
    int[] numbers;
    int lastInsertedIndex;

    public Aray(int length)
    {
        lastInsertedIndex = 0;
        numbers = new int[length];
        for (int i = 0; i < length; i++) numbers[i] = 0;
    }

    public void displayArray()
    {
        string displayText = "(";
        foreach (int number in numbers) displayText = displayText + Convert.ToInt32(number) + " ";
        displayText += ")";
        System.Console.WriteLine(displayText);
    }


}

