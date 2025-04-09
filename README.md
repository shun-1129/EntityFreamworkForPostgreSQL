# EntityFreamworkForPostgreSQL

```
dotnet ef migrations add InitializeCreated
```

.csproj ファイルの存在するフォルダで実行
「InitializeCreated」は任意で変更（1 度使用すると 2 回目からは同じものは使えない）

```
dotnet ef database update
```

データベースに反映

```
dotnet ef migrations script 0 InitializeCreated -o DB_Migration_Ver.0.0.1.sql
```

初期状態から InitializeCreated までの差分を sql ファイルで出力

```
dotnet ef migrations script InitializeCreated FixMasterTable -o DB_Migration_Ver.0.0.1.sql
```

これを実行した場合、InitializeCreated と FixMasterTable の差分を sql ファイルで出力してくれる
