# Xamarin.Updater
Xamarin.Android 应用更新模块

更新的apk默认下载到Download文件夹，要添加权限
```xml

<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />

```

下载应用，应用下载完成后自动安装，可以指定DownloadMode

```C#

var updater = UpdateAgent.GetInstance (this);
				updater.DownloadMode = DownloadMode.Overwrite;
				updater.Start ("http://filelx.liqucn.com/upload/2015/shipin/360Video_ys4873.apk", "ys4873.apk");

```
