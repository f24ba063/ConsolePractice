簡単な在庫管理プログラムを組んでみました。
（DB要素は取り入れていないのでsqlに関わる技術は取り入れていません）

ConsolePractice 在庫管理アプリ

概要

C# コンソールアプリケーションで、商品の在庫を管理するプログラムです。
商品の追加、削除、検索、ソート、在庫の入出庫、履歴の確認が可能です。

ファイル構成

Program.cs … メイン処理とユーザー操作ループ
Product.cs … 商品クラス (Name / Stock と在庫操作メソッド)
Updater.cs … 新商品の追加
Deleter.cs … 商品の削除
Sorter.cs … 商品のソート（名前または在庫数）
Searcher.cs … 商品の検索（名前・在庫範囲・両方）
ProductFiler.cs … ファイルへの保存・読み込み
HistoryLogger.cs … 在庫操作履歴の保存・表示

使い方

アプリを実行すると、カレントディレクトリに products.txt がある場合は読み込みます。
起動ファイルは「Program.cs」になります。VisualStudio上から起動してください。

コンソール上で操作を入力：

add … 在庫追加
remove … 在庫削除
new … 新商品追加
delete … 商品削除
sort … 商品ソート
search … 商品検索
history … 在庫操作履歴表示
exit … アプリ終了（products.txt に保存）

注意点

履歴は history.txt に保存されます。

数値入力が必要な場合、正の整数を入力してください。

名前空間はすべて ConsolePractice に統一しています。