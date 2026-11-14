// 記事02「C#の超基礎①変数・型・if・for」ステップ6：GOOD foreach で合計する
// 実行：dotnet run s12_foreach.cs

var expenses = new List<int> { 1200, 980, 1500 };
int sum = 0;

foreach (int amount in expenses)
{
    sum += amount;
}

Console.WriteLine($"合計：{sum}円");
