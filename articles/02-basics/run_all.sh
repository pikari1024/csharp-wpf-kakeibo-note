#!/usr/bin/env bash
# 記事02のサンプルを順番に dotnet run して、結果を表示します（.NET 10 SDK が必要）。
# s06・s09 はわざとビルドエラーを出す例、s10 はわざと例外で止まる例です。
cd "$(dirname "$0")"
for f in s*.cs; do
  echo "===== $f ====="
  dotnet run "$f" 2>&1
  echo "[exit code: $?]"
  echo
done
