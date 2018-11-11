# VRMLoaderUI
VRM Loader UI

Languages( [日本語版](README_ja.md) )

## What is this?

UI asset on loading VRM.

## Download

Download UnityPackages from [Release Page](https://github.com/m2wasabi/VRMLoaderUI/releases).

## Usage

Basic usase is below.

```csharp
    // define UI canvas
    [SerializeField]
    Canvas m_canvas;

    // define VRMLoaderUI/Prefabs/LoadConfirmModal
    [SerializeField]
    GameObject m_modalWindowPrefab;


    byte[] bytes = File.ReadAllBytes(path);

    var context = new VRMImporterContext();
    context.ParseGlb(bytes);
    var meta = context.ReadMeta(true);

    // instantinate UI
    GameObject modalObject = Instantiate(m_modalWindowPrefab, m_canvas.transform) as GameObject;

    // determine language
    var modalLocale = modalObject.GetComponentInChildren<VRMPreviewLocale>();
    modalLocale.SetLocale(m_language.captionText.text);

    // input VRM meta information to UI
    var modalUI = modalObject.GetComponentInChildren<VRMPreviewUI>();
    modalUI.setMeta(meta);

    // Permission of file open
    modalUI.setLoadable(true);

    // define callback on load completed
    modalUI.m_ok.onClick.AddListener(ModelLoad);
```

Full source exists Examples package.

### Examples

Click "Load VRM" button and show modal UI.

![LoadingUI](Images/Doc/LoaderUI_ss01.png)

![LoadingUI](Images/Doc/LoaderUI_ss02.png)

#### ExampleLoaderLegacy

Example runs Unity 5.6.3.p1 without UniRx

Depends on

+ [UniVRM](https://github.com/dwango/UniVRM/releases)

#### ExampleLoader

Example with Unity2018.1 .NET4.6 and using UniRx

Depends on

+ [UniVRM](https://github.com/dwango/UniVRM/releases)
+ [UniRx](https://github.com/neuecc/UniRx/releases)

### Internationarization languages

Default language can choose Japanese(ja) and English(en).  
When you add languages, copy and edit `/Assets/StreamingAssets/VRMLoaderUI/i18n/*.json` .  

### Customizing design

This asset uses default UI styles.
Edit and personalize UI for your contents.

[Icon artwork](Images/VRM_permissions.ai) is destributing CC0 and use free.

Cheers!

## Licenses

Source: MIT
Artwork: CC0  
