// 記事02「C#の超基礎①変数・型・if・for」ステップ4：GOOD 先に decimal にしてから割る
// 実行：dotnet run s03_good_average.cs

int lunch1 = 1200;
int lunch2 = 980;
int lunch3 = 1500;

int total = lunch1 + lunch2 + lunch3;
decimal average = (decimal)total / 3;

Console.WriteLine($"合計：{total}円");
Console.WriteLine($"平均：{average}円");
Console.WriteLine($"平均（小数第1位まで）：{Math.Round(average, 1)}円");
