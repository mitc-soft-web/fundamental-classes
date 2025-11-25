//Random random  = new Random();
//int correctGuessNumber = random.Next(1, 10);

//Console.Write("Guess a number between 1 and 10: ");
//int guess = int.Parse(Console.ReadLine()!);

//string guessResult = "";

//if(guess == correctGuessNumber)
//{
//   guessResult = "Correct, You win!";
//}
//else if(correctGuessNumber - guess <= 2 )
//{
//    guessResult = "So close!";
//}
//else
//{
//       guessResult = $"Wrong! The correct number was {correctGuessNumber}. Try again!";

//}

//Console.WriteLine(guessResult);


//for(int i = 1; i <= 50; i++)
//{
//    if(i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if(i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else if(i % (3 * 5) == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if(i % 2 == 0)
//    {
//        Console.WriteLine("Even");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}


//Q.5
//Console.Write("Enter length of rows: ");
//int rows = int.Parse(Console.ReadLine()!);

//Console.Write("Enter length of columns: ");
//int columns = int.Parse(Console.ReadLine()!);

//char[,] battleShip = new char[rows, columns];


//for(int i = 0; i < rows; i++)
//{
//    for(int j = 0; j < columns; j++)
//    {
//        Console.Write($"BattleShip[{i}]: ");
//        battleShip[i, j] = char.Parse(Console.ReadLine()!.ToUpper());
//    }
//}

//for(int i = 0; i < rows; i++)
//{
//    for(int j = 0; j < columns; j++)
//    {
//        if (battleShip[i, j] == 'B') Console.WriteLine("Hit!");
//        Console.WriteLine("Miss!");
//    }
//    Console.WriteLine();
//}

//Q.7
//int[,,] threeDArray = new int[3, 3, 3];


//for(int i = 0; i < threeDArray.GetLength(0); i++)
//{
//    Console.WriteLine($"Layer {i + 1}");
//    for(int j = 0; j < threeDArray.GetLength(1); j++)
//    {
//        for(int k = 0; k < threeDArray.GetLength(2); k++)
//        {
//            Console.Write($"3DArray[{i}, {j}]: ");
//            threeDArray[i, j, k] = int.Parse(Console.ReadLine()!);

//        }
//    }
//}

//int evenCount = 0;
//int oddCount = 0;
//int totalCount = 0;

//for(int i = 0; i < threeDArray.GetLength(0); i++)
//{
//    for(int j = 0; j < threeDArray.GetLength(1); j++)
//    {
//        for (int k = 0;k < threeDArray.GetLength(2); k++)
//        {
//            if (threeDArray[i, j, k] % 2 == 0) evenCount++;
//            if (threeDArray[i, j, k] % 2 != 0) oddCount++;
//            totalCount = evenCount + oddCount;
//        }
//    }
//}

//Console.WriteLine($"We have {evenCount} even numbers\nWe have {oddCount} odd numbers\nand their total is {totalCount}");


//Q.9

double[][] scores =
{
    new double[] { 60, 89.5, 70, 100, 100, 90, 99, 98 },
    new double[] {79, 80, 88.7, 70, 55 },
    new double[] {95, 98.99, 50, 50, 45, 39, 45 }
};

double averageClassAScore = 0;
double averageScoreBScore = 0;
double averageScoreCScore = 0;
double averageOverallScore = averageClassAScore;
double totalScore = 0;
double overallScore = 0;

char bestClass = 'A';


for (int i = 0; i < scores.Length; i++)
{
    for(int j = 0; j < scores[i].Length; j++)
    {
        if(i == 0)
        {
            totalScore += scores[i][j];
            averageClassAScore = Math.Round(totalScore / scores[i].Length);
        }
        if(i == 1)
        {
            totalScore += scores[i][j];
            averageScoreBScore = Math.Round(totalScore / scores[i].Length);
        }
        if(i == 2)
        {
            totalScore += scores[i][j];
            averageScoreCScore = Math.Round(totalScore / scores[i].Length);
        }
        if(averageScoreBScore > averageOverallScore)
        {
            averageOverallScore = averageScoreBScore;
            bestClass = 'B';
        }
        else if(averageScoreCScore > averageOverallScore)
        {
            averageOverallScore = averageScoreCScore;
            bestClass = 'C';
        }
        if (scores[i][j] > overallScore)
        {
            overallScore = scores[i][j];

        }

}
    }

Console.WriteLine($"Class A Average Score: {averageClassAScore}\nClass B Average Score: {averageScoreBScore}\nClass C Average Score: {averageScoreCScore}\nThe Best Class is Class {bestClass}");