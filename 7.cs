Console.WriteLine("Введите предложение");
string s = Console.ReadLine();
string[] words = s.Split(' ');
string min= words[0];
foreach (string word in words)
{
    if (min.Length > word.Length)
    {
        min = word;
    }
}
Console.WriteLine(min );



