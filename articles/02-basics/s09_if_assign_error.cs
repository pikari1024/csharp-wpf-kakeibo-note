// 記事02「C#の超基礎①変数・型・if・for」ステップ5：= と == の打ち間違い（CS0029）。このファイルはビルドに失敗します
// 実行：dotnet run s09_if_assign_error.cs

int budget = 40000;
int spent = 40000;

if (spent = budget)
{
    Console.WriteLine("ちょうど予算どおり");
}
