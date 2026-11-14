// 記事02「C#の超基礎①変数・型・if・for」ステップ6：i の値を表示して確かめる
// 実行：dotnet run s13_for_trace.cs

var expenses = new List<int> { 1200, 980, 1500 };
Console.WriteLine($"Count = {expenses.Count}");

for (int i = 0; i <= expenses.Count; i++)
{
    Console.WriteLine($"i = {i}");
}
