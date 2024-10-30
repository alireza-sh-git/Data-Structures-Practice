
public class Aray
{
    int[] numbers;
    int lastInsertedIndex;



    public Aray(int length)
    {
        lastInsertedIndex = -1;
        numbers = new int[length];
        for (int i = 0; i < length; i++) numbers[i] = 0;
    }


    public void displayArray()
    {
        string displayText = "(";
        foreach (int number in numbers) displayText = displayText + Convert.ToInt32(number) + " ";
        displayText += ")";
        Console.WriteLine(displayText);
    }

    public void insert(int input)
    {
        int index = lastInsertedIndex += 1;
        if (lastInsertedIndex == numbers.Length)
        {
            int[] copiedNumbers = numbers;
            numbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length - 1; i++) numbers[i] = copiedNumbers[i];

        }
        numbers[index] = input;
        lastInsertedIndex = index;
    }


}

