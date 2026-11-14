// 記事02「C#の超基礎①変数・型・if・for」練習問題3（答えの例）
// 実行：dotnet run s17_ex3.cs

var expenses = new List<int> { 1200, 980, 1500, 3200 };
int max = 0;
foreach (int amount in expenses)
{
    if (amount > max)
    {
        max = amount;
    }
}
Console.WriteLine($"いちばん高い買い物：{max}円");
