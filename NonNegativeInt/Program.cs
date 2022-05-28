// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    static int DescendingOrder(int num)
    {
        // Bust a move right here
        var value = "";
        var numbers = num.ToString().ToCharArray();

        Array.Sort(numbers);
        Array.Reverse(numbers);

        value = string.Join("", numbers);


        return Convert.ToInt32(value);
    }
