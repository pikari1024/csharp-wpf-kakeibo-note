// 記事02「C#の超基礎①変数・型・if・for」ステップ6：GOOD for の < Count
// 実行：dotnet run s11_good_for.cs

var expenses = new List<int> { 1200, 980, 1500 };
int sum = 0;

for (int i = 0; i < expenses.Count; i++)
{
    sum += expenses[i];
}

Console.WriteLine($"合計：{sum}円");
