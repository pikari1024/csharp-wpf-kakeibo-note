// 記事02「C#の超基礎①変数・型・if・for」ステップ3：double と decimal の 0.1 + 0.2
// 実行：dotnet run s05_double_vs_decimal.cs

double a = 0.1 + 0.2;
Console.WriteLine(a);
Console.WriteLine(a == 0.3);

decimal b = 0.1m + 0.2m;
Console.WriteLine(b);
Console.WriteLine(b == 0.3m);
