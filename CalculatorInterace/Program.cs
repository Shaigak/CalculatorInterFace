
using CalculatorInterace;
using CalculatorInterace.Service;


////Calculate();




static void Calculate()
{

    Calculator calculator = new Calculator();

    Console.WriteLine("Add First Number");

number1: string number1 = (Console.ReadLine());

    int checkednumber1;

    bool isParseNum1 = int.TryParse(number1, out checkednumber1);

    if (!isParseNum1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please add correct number 1");
        Console.ResetColor();
        goto number1;
    }

    Console.WriteLine("Add Operation");
    string operation = Console.ReadLine();

    Console.WriteLine("Second First Number");

number2: string number2 = (Console.ReadLine());

    int checkednumber2;

    bool isParseNum2 = int.TryParse(number2, out checkednumber2);

    if (!isParseNum2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please add correct number 2");
        Console.ResetColor();
        goto number2;
    }


    var result = calculator.Calculate(checkednumber1, checkednumber2, operation);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(result);
    Console.ResetColor();
}

AccountService accountService = new AccountService("Cavid", "1995");

accountService.Sign();