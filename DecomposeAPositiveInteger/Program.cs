int num = 11;
List<int> decompose = Decompose(num - 1, num * num);
Console.WriteLine();

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