int[] numbers = {  };

string result = "";
if (!numbers.Any())
{
    result = "Array is empty";
}
else
{
    Console.Write("Enter index: ");
    int index;

    while (!(int.TryParse(Console.ReadLine(), out index) && index <= numbers.Length - 1))
    {
        Console.WriteLine($"Enter valid index (<= {numbers.Length - 1})");
    }

    if (index == 0)
    {
        if (numbers.Length > 1)
        {
            result = numbers[index] > numbers[index + 1] ? "The element is greater than its neighbor" : "The element is not greater than its neighbor";
        }
        else
        {
            result = "No neighbor(s) to check";
        }
    }
    else if (index == numbers.Length - 1)
    {
        result = numbers[index] > numbers[index - 1] ? "The element is greater than its neighbor" : "The element is not greater than its neighbor";
    }
    else
    {
        result = numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1] ? "The element is greater than its neighbor" : "The element is not greater than its neighbor";
    }

}


Console.WriteLine(result);