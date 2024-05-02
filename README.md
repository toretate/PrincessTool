# PrincessTool
プリンセスコネクト！Re:Dive のリソース抽出ツール

## これはなに？

プリンセスコネクト！Re:Dive のリソースを抽出するツールです。

DMM版のリソースを特定のフォルダにコピーして、そこから自動的にファイルをリネームしたり、音声をWAVEフォーマットに変換したりします。

## 注意事項

すべてのリソースをコピー&変換すると30GB程度の容量になるので、ストレージに余裕があることを確認した後、実行してください。

## fork元からの変更点

* コピー済処理を省いたExtract実行用ボタンの設置
* .Net 8 化 (System.IO.Hashingを使いたいので)
* 2024年にあった ファイル名 Hash値 計算の方式変更