# かけいぼノート（C#×WPF 連載のサンプルコード）

biliotech の連載「C#×WPFでリッチなデスクトップアプリを作る」で使うサンプルコードです。
連載では、家計簿アプリ「かけいぼノート」を1つ作りながら、C# の超基礎から WPF・MVVM・非同期・配布までを順番に学びます。

- 連載の入口（学習ロードマップ）：https://biliotech.com/posts/csharp-wpf-roadmap/
  - ※この記事が公開されると開けるようになります。

## 必要なもの

- .NET 10 SDK（公式のダウンロードページ：https://dotnet.microsoft.com/ja-jp/download/dotnet/10.0 ）
- ターミナル（Windows Terminal、macOS のターミナル、Linux の端末など）

インストールできたか、次のコマンドで確かめます。`10.0.` から始まる番号が出れば準備完了です。

```bash
dotnet --version
```

リポジトリ直下の `global.json` で、.NET 10 の SDK を使うように指定しています。

## 動かし方

記事ごとのフォルダに、記事で使ったコードがそのまま入っています。

```bash
git clone https://github.com/pikari1024/csharp-wpf-kakeibo-note.git
cd csharp-wpf-kakeibo-note/articles/02-basics
dotnet run s14_kakeibo.cs
```

.NET 10 では、`dotnet run ファイル名.cs` で、プロジェクトを作らずに1つの .cs ファイルを動かせます。
記事のとおり `dotnet new console` で作ったプロジェクトの `Program.cs` に、中身を貼り付けて `dotnet run` しても同じ結果になります。

フォルダの中のサンプルを全部まとめて動かすときは（macOS・Linux・WSL などの bash で）：

```bash
./run_all.sh
```

## フォルダの中身

| フォルダ | 記事 | 内容 |
| --- | --- | --- |
| `articles/02-basics/` | C#の超基礎①変数・型・if・for｜平均がなぜか1226円になる理由を1行ずつ確かめる | 変数・型・割り算・if・for/foreach と、かけいぼノートの1か月の集計（s00〜s18） |

記事が増えるたびに、フォルダを追加していきます。

## どこまで確かめているか

- このリポジトリのコードは、**Linux（Debian 13 / .NET SDK 10.0.404）で実行・ビルドして確かめたもの**です。
- 記事02のサンプルの実行結果は `articles/02-basics/expected_output.txt` にあります。
- Windows と macOS では動かしていません。
- WPF の画面（ウィンドウを表示して動かす部分）は Windows でしか実行できません。この連載のWPFのコードは、Linux でビルドが通ることまでを確かめ、画面の動きは公式ドキュメントに基づいて説明しています。

## わざと失敗するサンプルについて

記事では「よくある失敗」をあえて動かして見せています。次のファイルは、わざとエラーになります。

- `s06_type_error.cs`・`s09_if_assign_error.cs`：ビルドエラー（CS0029）になります
- `s10_bad_for.cs`：実行すると `ArgumentOutOfRangeException` で止まります

## データについて

サンプルの金額やカテゴリは、すべてダミーです。実在の家計・口座・明細は含まれていません。

## ライセンス

[MIT License](LICENSE)
