シンプルなコンソール在庫管理アプリケーションです。  
C# で作成されており、商品追加・削除・入出庫・検索・ソート・履歴保存などが行えます。

---

## 📦 機能

- **商品追加 / 削除**  
- **在庫の入庫 (add) / 出庫 (remove)**  
- **商品検索**  
  - 名前で検索  
  - 在庫範囲で検索  
  - 名前 + 在庫範囲の両方で検索  
- **ソート**  
  - 商品名順  
  - 在庫数順  
- **履歴の保存と表示**  
  - `history.txt` に操作履歴を自動保存  
- **データ保存**  
  - `products.txt` に商品一覧を保存  

---

## 🚀 実行方法

### Visual Studio から実行
1. 本リポジトリをクローンまたは ZIP ダウンロードして展開  
2. Visual Studio で `ConsolePractice/Program.cs` を開く  
3. `F5` または 「デバッグ開始」で実行  


📂 ファイル構成

ConsolePractice/
├─ Program.cs        # メイン処理
├─ Product.cs        # 商品クラス
├─ Updater.cs        # 商品追加
├─ Deleter.cs        # 商品削除
├─ ProductFiler.cs   # 保存・読み込み
├─ Sorter.cs         # ソート処理
├─ Searcher.cs       # 検索処理
├─ HistoryLogger.cs  # 履歴処理
├─ products.txt      # 在庫データ保存ファイル
└─ history.txt       # 履歴保存ファイル
🛠 開発環境
C# 10 / .NET 6

Visual Studio 2022

✨ 今後の改善アイデア
履歴のフィルタリング（商品ごと / 期間ごと）

在庫数アラート機能（閾値を下回ったら通知）

ユニットテスト追加

GUI 版アプリケーション化（WPF / WinForms）
