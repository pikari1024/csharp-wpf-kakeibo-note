// 記事02「C#の超基礎①変数・型・if・for」ステップ5：if で予算オーバーを判定する
// 実行：dotnet run s08_if.cs

int budget = 40000;
int spent = 41250;

if (spent > budget)
{
    Console.WriteLine($"予算オーバー：{spent - budget}円");
}
else if (spent == budget)
{
    Console.WriteLine("ちょうど予算どおり");
}
else
{
    Console.WriteLine($"あと{budget - spent}円使えます");
}
