//Console.Write("Enter value for x: ");
//int x = int.Parse(Console.ReadLine()!);

//Console.Write("Enter value for y: ");
//int y = int.Parse(Console.ReadLine()!);

//Console.WriteLine(AddNumbers(x, y));


//static int AddNumbers(int a, int b)
//{
//    return a + b;
//}

//string firstName = "John";
//string lastName = "Doe";
//string middleName = "Michael";

//DisplayFullName(firstName, lastName, middleName);

//static void DisplayFullName(string firstName, string lastName, string middleName)
//{
//    Console.WriteLine($"{firstName} {middleName} {lastName}");
//}

//int[] numbers = new int[7];

//AddValuesToArray(numbers);
//Console.WriteLine($"The sum of the array values is: {CalculateSum(numbers)}");

//static int[] AddValuesToArray(int[] arrayNumbers)
//{
//    for (int i = 0; i < arrayNumbers.Length; i++)
//    {
//        Console.Write($"ArrayNumber[{i}]: ");
//        arrayNumbers[i] = int.Parse(Console.ReadLine()!);
//    }

//    return arrayNumbers;
//}

//static int CalculateSum(int[] numbers)
//{
//    int sum = 0;
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    return sum;
//}

using fundamental_classes;

//string word = "mummy";

//Palindrome palindrome = new Palindrome();

//Console.WriteLine($"Is the word '{word}' a palindrome? {palindrome.isPalindrome(word)}");

PrintDigit printDigit = new PrintDigit();
int digits = 7896590;
Console.WriteLine(printDigit.PrintLastDigitInWords(digits));

