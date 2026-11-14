// 記事02「C#の超基礎①変数・型・if・for」ステップ1：変数と型
// 実行：dotnet run s01_variables.cs

int food = 1200;          // 整数（小数点なし）
double taxRate = 0.1;     // 小数
string category = "食費"; // 文字列
bool isFixedCost = false; // はい／いいえ

Console.WriteLine($"{category}：{food}円");
Console.WriteLine($"税率：{taxRate}");
Console.WriteLine($"固定費？：{isFixedCost}");
