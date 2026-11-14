# 記事02：C#の超基礎①変数・型・if・for

| ファイル | 記事の場所 | 内容 |
| --- | --- | --- |
| s00_hello.cs | ステップ0 | `dotnet new console` で作られる最初の1行 |
| s01_variables.cs | ステップ1 | 変数と型 |
| s02_bad_average.cs | ステップ2 | よくある失敗（BAD）：平均が1226円になる |
| s03_good_average.cs | ステップ4 | GOOD：先に decimal にしてから割る |
| s04_division.cs | ステップ3 | 割り算の型を確かめる |
| s05_double_vs_decimal.cs | ステップ3 | double と decimal の 0.1 + 0.2 |
| s06_type_error.cs | ステップ1 | わざとビルドエラー（CS0029） |
| s07_var.cs | よくある質問Q1 | var の型を確かめる |
| s08_if.cs | ステップ5 | if で予算オーバーを判定する |
| s09_if_assign_error.cs | ステップ5 | `=` と `==` の打ち間違い（CS0029） |
| s10_bad_for.cs | ステップ6 | よくある失敗（BAD）：for の `<= Count` で例外 |
| s11_good_for.cs | ステップ6 | GOOD：for の `< Count` |
| s12_foreach.cs | ステップ6 | GOOD：foreach で合計する |
| s13_for_trace.cs | ステップ6 | i の値を表示して確かめる |
| s14_kakeibo.cs | ステップ7 | かけいぼノートの1か月の集計（ダミーデータ） |
| s15_ex1.cs〜s17_ex3.cs | 練習問題 | 練習問題1〜3 |
| s18_round.cs | ステップ4おまけ | Math.Round のちょうど半分 |

1つずつ動かすとき：

```bash
dotnet run s02_bad_average.cs
```

全部まとめて動かすとき（bash）：

```bash
./run_all.sh
```

実行結果は `expected_output.txt` にあります（Debian 13 / .NET SDK 10.0.404 で確認）。
