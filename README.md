# VRMLoaderUI
VRM Loader UI

## What is this?

VRMをロードする時のUIアセットです

## Usage

基本的な呼び出し方は以下です。

```csharp
    byte[] bytes = File.ReadAllBytes(path);

    var context = new VRMImporterContext();
    context.ParseGlb(bytes);
    var meta = context.ReadMeta(true);

    // ファイル読み込みモーダルウィンドウの呼び出し
    GameObject modalObject = Instantiate(m_modalWindowPrefab, m_canvas.transform) as GameObject;
    var modalUI = modalObject.GetComponent<VRMPreviewUI>();
    modalUI.setMeta(meta);

    // ファイルを開くことの許可
    // ToDo: ファイルの読み込み許可を制御する場合はここで
    modalUI.setLoadable(true);

    // ロードイベントの追加
    modalUI.m_ok.onClick.AddListener(ModelLoad);
```

詳しい使い方はExampleを参照してください。

### Exampleの説明

画面中央下部のボタンをクリックするとVRMをロードする。

![LoadingUI](images/Doc/LoaderUI_ss01.png)

![LoadingUI](images/Doc/LoaderUI_ss02.png)

#### ExampleLoaderLegacy

Unity 5.6.3.p1 のUniRx無しで動くサンプル

必要ライブラリ

+ [UniVRM](https://github.com/dwango/UniVRM/releases)

#### ExampleLoader

Unity2018.1 .NET4.6 のUniRx使用で動くサンプル

必要ライブラリ

+ [UniVRM](https://github.com/dwango/UniVRM/releases)
+ [UniRx](https://github.com/neuecc/UniRx/releases)

### デザインのカスタマイズ

ウィンドウの背景や文字色など、心理的にカスタマイズしやすいように、デフォルトUIになっています。
自由に調整して自分アプリに合ったUIにしましょう。

アイコンのアートワークもIllustrator形式で添付しているので、自由に変更して頂いて構いません。

## ライセンス

ソースコード: MITライセンス  
アートワーク: CC0  

## 今後の予定

+ 国際化対応
+ テーマサンプルの作成(優先度低)
