// 記事02「C#の超基礎①変数・型・if・for」ステップ4おまけ：Math.Round のちょうど半分
// 実行：dotnet run s18_round.cs

Console.WriteLine(Math.Round(2.5m, 0));
Console.WriteLine(Math.Round(3.5m, 0));
Console.WriteLine(Math.Round(2.5m, 0, MidpointRounding.AwayFromZero));
