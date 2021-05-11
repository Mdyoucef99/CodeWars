using System;

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        int c = a + b;
        string binary = Convert.ToString(c, 2);

        return binary;

    }
}