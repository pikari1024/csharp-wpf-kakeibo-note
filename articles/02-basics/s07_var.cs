// 記事02「C#の超基礎①変数・型・if・for」よくある質問Q1：var の型を確かめる
// 実行：dotnet run s07_var.cs

var a = 1200;
var b = 1200.0;
var c = 1200m;
var d = "1200";

Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());
Console.WriteLine(c.GetType());
Console.WriteLine(d.GetType());
