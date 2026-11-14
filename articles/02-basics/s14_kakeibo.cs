// 記事02「C#の超基礎①変数・型・if・for」ステップ7：かけいぼノートに組み込む（1か月の集計・ダミーデータ）
// 実行：dotnet run s14_kakeibo.cs

// かけいぼノート：1か月の支出をまとめる（ダミーデータ）
int budget = 40000;   // 今月の食費の予算（円）
int days = 30;        // 今月の日数

var foodExpenses = new List<int> { 3200, 1850, 4600, 980, 2750, 5100, 1500, 3980, 2200, 4400, 1290, 3600, 2980, 1760 };

int total = 0;
foreach (int amount in foodExpenses)
{
    total += amount;
}

decimal perDay = Math.Round((decimal)total / days, 0);
int count = foodExpenses.Count;

Console.WriteLine($"記録した件数：{count}件");
Console.WriteLine($"食費の合計：{total}円");
Console.WriteLine($"1日あたり：{perDay}円");

if (total > budget)
{
    Console.WriteLine($"予算オーバー：{total - budget}円");
}
else
{
    Console.WriteLine($"予算の残り：{budget - total}円");
}

int bigCount = 0;
for (int i = 0; i < foodExpenses.Count; i++)
{
    if (foodExpenses[i] >= 4000)
    {
        bigCount++;
    }
}
Console.WriteLine($"4000円以上の買い物：{bigCount}回");
