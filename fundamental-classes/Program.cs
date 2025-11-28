////string str = "I love you!";

////Console.WriteLine(ReverseString(str));


////static string ReverseString(string str)
////{
////    string result = "";
////    for(int i = str.Length - 1; i >= 0; i--)
////    {
////        result += str[i];
////    }
////    return result;
////}

//Console.Write("Enter first number: ");
//int a;

//while(!int.TryParse(Console.ReadLine(), out a))
//{
//    Console.Write("Enter valid input: ");
//}

//Console.Write("Enter operator (e.g (+, -, *, /): ");
//char op;

//while (!(char.TryParse(Console.ReadLine(), out op) && op != '+' || op != '-' || op != '*' || op != '/'))
//{
//    Console.Write("Enter valid operator: ");
//}

//Console.Write("Enter second number: ");
//int b;

//while (!int.TryParse(Console.ReadLine(), out b))
//{
//    Console.Write("Enter valid input: ");
//}


//switch (op)
//{
//    case '+':
//        Console.WriteLine(Add(a, b)); break;
//    case '-':
//        Console.WriteLine(Sub(a, b)); break;
//    case '*':
//        Console.WriteLine(Mult(a, b)); break;
//    case '/':
//        Console.WriteLine(Div(a, b)); break;
//    default:
//        Console.WriteLine("Invalid operator"); break;
//}

//static double Add(double a, double b)
//{
//    return a + b; 
//}

//static double Mult(double a, double b)
//{
//    return a * b;
//}

//static double Sub(double a, double b)
//{
//    return a - b;
//}

//static double Div(double a, double b)
//{
//    return a / b;
//}

static string CheckPasswordStrength(string password)
{
    string result = "";
    bool isUpper = false;
    bool isLower = false;
    bool isDigit = false;
    bool hasSymbol = false;
    int minimumLength = 8;

    foreach(var c in password)
    {
        if(char.IsUpper(c)) isUpper = true;
        if(char.IsLower(c)) isLower = true;
        if(char.IsDigit(c)) isDigit = true;
        if(!char.IsLetterOrDigit(c)) hasSymbol = true;
    }
    if(password.Length >= minimumLength && isLower && isUpper && isDigit && hasSymbol)
    {
        result = "Strong";
    }
    else if(password.Length >= minimumLength && (isUpper || isLower) && isDigit) result = "Medium";
    else
    {
        result = "Weak";
    }
    return result;
}

string password = "Abass1";
Console.WriteLine(CheckPasswordStrength(password));