using _5;

int a, b, c, d;
try
{
    Console.Write("Введите А:");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите B:");
    b = int.Parse(Console.ReadLine());
    Console.Write("Введите C:");
    c = int.Parse(Console.ReadLine());
    Console.Write("Введите D:");
    d = int.Parse(Console.ReadLine());

    try
    {
        Complex Div = DivComlpex(a, b, c, d);
        Console.WriteLine(Div);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        Complex Div2 = DivComlpex2(a, b, c, d);
        Console.WriteLine(Div2);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        Complex Div3 = DivComplex3(a, b, c, d);
        Console.WriteLine(Div3);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        Complex Div4 = DivComplex4(a, b, c, d);
        Console.WriteLine(Div4);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }



}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}

catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}



Complex DivComlpex(int a, int b, int c, int d)
{
    Complex result = new Complex((a * c + b * d) / (c * c + d * d), (b * c + a * d) / (c * c + d * d));
    return result;
}

Complex DivComlpex2(int a, int b, int c, int d)
{
    if (c==0 && d == 0)
    {
        throw new Exception("Деление на ноль!");
    }
    Complex result = new Complex((a * c + b * d) / (c * c + d * d), (b * c + a * d) / (c * c + d * d));
    return result;
}

Complex DivComplex3(int a, int b, int c, int d)
{
    Complex result = new Complex(0, 0);
    try
    {
        result = new Complex((a * c + b * d) / (c * c + d * d), (b * c + a * d) / (c * c + d * d));
        return result;
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    return result;
}

Complex DivComplex4(int a, int b, int c, int d)
{
    if (c==0 && d==0)
    {
        throw new OurException("Деление на ноль запрещенно!");
    }
    Complex result = new Complex((a * c + b * d) / (c * c + d * d), (b * c + a * d) / (c * c + d * d));
    return result;

}