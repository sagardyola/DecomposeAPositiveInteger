Console.WriteLine("Enter a number");
try
{
    int num = Convert.ToInt32(Console.ReadLine());

    List<int> decompose = Decompose(num - 1, num * num);
    Console.WriteLine($"Decompose of {num} is");
    foreach (int x in decompose) Console.WriteLine(x);
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine("Invalid INPUT");
}


List<int> Decompose(int i, int total)
{
    if (total == 0) return new List<int>();
    if (i <= 0 || total < 0) return null;

    List<int> _list = Decompose(i - 1, total - i * i);
    if (_list != null)
    {
        _list.Add(i);
        return _list;
    }

    return Decompose(i - 1, total);
}