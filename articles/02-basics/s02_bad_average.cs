// 記事02「C#の超基礎①変数・型・if・for」ステップ2：よくある失敗コード（BAD）平均が1226円になる
// 実行：dotnet run s02_bad_average.cs

int lunch1 = 1200;
int lunch2 = 980;
int lunch3 = 1500;

int total = lunch1 + lunch2 + lunch3;
double average = total / 3;

Console.WriteLine($"合計：{total}円");
Console.WriteLine($"平均：{average}円");
