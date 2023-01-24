# Minecraft-Item_texture.json-assist
大量のアイテムファイルをitem_textureに登録する作業を少し楽にできます

## ●使い方
VisualStudioで新しいプロジェクトを作成しC#コンソールアプリを選択します  
プロジェクト名は任意  
フレームワークを.NET6.0にして作成します。  

作成したプロジェクトに２つのファイルを追加します  

デスクトップにフォルダを作成します。名前はなんでもいいですがFileにすると■の作業は不要です  

Program.csの15行目に作成したフォルダの絶対パスを指定します  

■フォルダ名をFile以外にした場合Program.csの30行目を作成したフォルダ名に変更します。  

■Program.csの34行目のSubstring(5)の部分をフォルダ名+1の数値に書き換える必要があります。  

作成したフォルダの中にテクスチャファイルを入れてビルドする事でコンソール画面に出力されます。  

デフォルトだと  
"テクスチャ名":{"textures":"textures/items/テクスチャ名"},  
が出力されます  

出力された文字はitem_texture.jsonに自動で加えられないため手動で書き込む必要があります。  

出力されるテクスチャパスを変える場合Program.csの58行目を変える事でパスを変える事ができます  
