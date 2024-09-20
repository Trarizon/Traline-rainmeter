[Variables]
;PREDEFINE
res=#@#Launcher\
;indicate displaying folder
curFolder=~
;count of system meter(except recycle bin), use for measure pos of sys meter
SystemMeterCount=4

;;VARIABLES
;Color:Color of skin, except strings
GeneralColor=ffffff
;Color:Color of strings
GeneralFontColor=#GeneralColor#
;String:Disk display format, %1 means used storage, %2 means total storage
DiskDisplayFormat=%1 / %2
;String:Memory display format, %1 means used memory, %2 means total memory
MemoryDisplayFormat=#DiskDisplayFormat#
;String:System panel refresh frequency, (100ms)
SystemRefresh=5
;String:Strings indicating condition of recycle bin,you can use %1 on behalf of count of file in recycle bin
BinEmptyText=Empty
;String:
BinFullText=%1 Files

;;FOLDERS
Fdr0Text=Default
Fdr0_0Text=Skin Folder
Fdr0_0Path=#ROOTCONFIGPATH#
Fdr0_1Text=Editor
Fdr0_1Path=#ROOTCONFIGPATH#Tra.Traline.Launcher.exe
Fdr0_2Text=Desktop Files
Fdr0_2Path=C:\Users\Lenovo\Desktop\Files

Fdr1Text=MuG Charts
Fdr1_0Text=Deenote
Fdr1_0Path=D:\Project Charts\Deenote\Deenote-0.7.2.exe
Fdr1_1Text=Deemo's Note Memory
Fdr1_1Path=D:\Project Charts\Deemo's Note Memory\Deemo's Note Memory.exe
Fdr1_2Text=DemooPlayer
Fdr1_2Path=D:\Project Charts\DemooPlayer0.30\demooplayer.exe
Fdr1_3Text=PaintChart
Fdr1_3Path=D:\Project Charts\Toolkit\Paint.lnk
Fdr1_4Text=RearrangePiano
Fdr1_4Path=D:\Project Charts\Toolkit\Piano.lnk
Fdr1_5Text=RandomNotes
Fdr1_5Path=D:\Project Charts\Toolkit\Rnd.lnk
Fdr1_6Text=InfoFileGenerator
Fdr1_6Path=D:\Project Charts\Toolkit\InfoFileGenerator.lnk
Fdr1_7Text=Arkythm Charter
Fdr1_7Path=D:\Project Charts\ArkythmCharter\√˜»’–˝¬…÷∆∆◊∆˜.exe
Fdr1_8Text=ToAllClick
Fdr1_8Path=D:\Project Charts\Toolkit\Black.lnk

Fdr2Text=Professional
Fdr2_0Text=Visual Studio 2022
Fdr2_0Path=D:\Softwares\Microsoft\Visual Studio\2022\Community\Common7\IDE\devenv.exe
Fdr2_1Text=Visual Studio Installer
Fdr2_1Path=C:\Program Files (x86)\Microsoft Visual Studio\Installer\vs_installer.exe
Fdr2_2Text=Visual Studio Code
Fdr2_2Path=D:\Softwares\Microsoft\VS Code\Code.exe
Fdr2_3Text=Unity Hub
Fdr2_3Path=D:\Softwares\Unity\Unity Hub\Unity Hub.exe
Fdr2_4Text=Adobe Audition 2020
Fdr2_4Path=D:\Softwares\Adobe\Adobe Audition 2020\Adobe Audition.exe
Fdr2_5Text=Adobe Photoshop 2020
Fdr2_5Path=D:\Softwares\Adobe\Adobe Photoshop 2020\Photoshop.exe
Fdr2_6Text=Adobe Premiere Pro 2020
Fdr2_6Path=D:\Softwares\Adobe\Adobe Premiere Pro 2020\Adobe Premiere Pro.exe
Fdr2_7Text=SQL Server Management Studio 19
Fdr2_7Path=D:\Softwares\Microsoft\Microsoft SQL Server Management Studio 19\Common7\IDE\Ssms.exe
Fdr2_8Text=HuionTablet
Fdr2_8Path=C:\Program Files\HuionTablet\HuionTablet.exe
Fdr2_9Text=SAI2
Fdr2_9Path=D:\Softwares\SYSTEMAX\[Saier]SAI Ver.2\sai2.exe

Fdr3Text=Softwares
Fdr3_0Text=Steam
Fdr3_0Path=D:\Softwares\Steam\steam.exe
Fdr3_1Text=Hikari Field Client
Fdr3_1Path=D:\Softwares\HIKARI FIELD CLIENT\HIKARI FIELD CLIENT.exe
Fdr3_2Text=QQ
Fdr3_2Path=D:\Softwares\Tencent\QQ\Bin\QQ.exe
Fdr3_3Text=WeChat
Fdr3_3Path=D:\Softwares\Tencent\WeChat\WeChat.exe
Fdr3_4Text=Bilibili
Fdr3_4Path=D:\Softwares\Bilibili\Bilibili\ﬂŸ¡®ﬂŸ¡®.exe
Fdr3_5Text=Microsoft Edge
Fdr3_5Path=C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
Fdr3_6Text=Cloud Music
Fdr3_6Path=D:\Softwares\NetEase\CloudMusic\cloudmusic.exe
Fdr3_7Text=foobar2000
Fdr3_7Path=D:\Softwares\foobar2000\foobar2000.exe
Fdr3_8Text=ADrive
Fdr3_8Path=D:\Softwares\Alibaba\aDrive\aDrive.exe
Fdr3_9Text=Baidu Netdisk
Fdr3_9Path=D:\Softwares\Baidu\BaiduNetdisk\baidunetdisk.exe
Fdr3_10Text=MuMu Player 12.0
Fdr3_10Path=D:\Softwares\NetEase\MuMuPlayer-12.0\shell\MuMuPlayer.exe
Fdr3_11Text=WeMeet
Fdr3_11Path=D:\Softwares\Tencent\WeMeet\wemeetapp.exe
Fdr3_12Text=DingDing
Fdr3_12Path=D:\Softwares\Alibaba\DingDing\DingtalkLauncher.exe
Fdr3_13Text=Obsidian
Fdr3_13Path=C:\Users\Lenovo\AppData\Local\Obsidian\Obsidian.exe
Fdr3_14Text=Emby
Fdr3_14Path=D:\Softwares\Emby Theater\Emby.Theater.exe
Fdr3_15Text=Playnite
Fdr3_15Path=D:\Softwares\Playnite\Playnite.DesktopApp.exe
Fdr3_16Text=QuarkCloudDrive
Fdr3_16Path=D:\Softwares\Quark\quark-cloud-drive\QuarkCloudDrive.exe
Fdr3_17Text=Rnote
Fdr3_17Path=D:\Softwares\Rnote\bin\rnote.exe

Fdr4Text=Games
Fdr4_0Text=Welcome to the Timestop Island
Fdr4_0Path=D:\Games\Games\ög”≠ÅÌµΩïrÈgÕ£÷πµƒçuéZver2.65.1\Game.exe
Fdr4_1Text=Christmas Tina
Fdr4_1Path=D:\Games\Games\Christmas Tina\ChristmasTina.exe
Fdr4_2Text=Stella of the End
Fdr4_2Path=D:\Games\Games\ΩK§Œ•π•∆•È\SiglusEngine_cn.exe

Fdr5Text=Tools
Fdr5_0Text=Asset Studio
Fdr5_0Path=D:\Tools\AssetStudio\AssetStudioGUI.exe
Fdr5_1Text=Bpm Analyzer
Fdr5_1Path=D:\Tools\BpmAnalyzer\BpmAnalyzer.exe
Fdr5_2Text=Bandicam
Fdr5_2Path=D:\Softwares\Bandi\Bandicam\bdcam.exe
Fdr5_3Text=Aegisub
Fdr5_3Path=D:\Tools\Aegisub\aegisub64.exe
Fdr5_4Text=qBittorrent
Fdr5_4Path=D:\Tools\qBittorrent\qbittorrent.exe
Fdr5_5Text=Draw.io
Fdr5_5Path=C:\Program Files\draw.io\draw.io.exe
Fdr5_6Text=OBS Studio
Fdr5_6Path=D:\Softwares\obs-studio\bin\64bit\obs64.exe
Fdr5_7Text=Everything
Fdr5_7Path=D:\Tools\Everything\Everything.exe
Fdr5_8Text=Bilibili Uploader
Fdr5_8Path=D:\Softwares\Bilibili\ugc_assistant\ugc_assistant.exe
Fdr5_9Text=Bilibili Livehime
Fdr5_9Path=D:\Softwares\Bilibili\livehime\livehime.exe
Fdr5_10Text=Core Temp
Fdr5_10Path=D:\Tools\Core Temp\Core Temp.exe
Fdr5_11Text=UsbEAm Hosts Editor
Fdr5_11Path=D:\Tools\UsbEAm Hosts Editor\UsbEAm Hosts Editor v3.63.exe
Fdr5_12Text=Material Design XAML Demo
Fdr5_12Path=D:\Dev\Material Design In XAML DemoApp\demo-app\Release\net6.0-windows\MaterialDesignDemo.exe
Fdr5_13Text=v2rayN
Fdr5_13Path=D:\Tools\v2rayN-With-Core\v2rayN.exe
Fdr5_14Text=DevToys
Fdr5_14Path=C:\Program Files\WindowsApps\64360VelerSoftware.DevToys_1.0.13.0_x64__j80j2txgjg9dj\DevToys.exe
Fdr5_15Text=WinMemoryCleaner
Fdr5_15Path=D:\Tools\WinMemoryCleaner.exe
Fdr5_16Text=ScreenToGif
Fdr5_16Path=D:\Tools\ScreenToGif.exe
Fdr5_17Text=Resilio Sync
Fdr5_17Path=C:\Users\Lenovo\AppData\Roaming\Resilio Sync\Resilio Sync.exe
Fdr5_18Text=IDA Pro 7.0
Fdr5_18Path=D:\Tools\IDA_Pro_v7.0_Portable\ida64.exe

Fdr6Text=Folders
Fdr6_0Text=School Files
Fdr6_0Path=D:\Files\School
Fdr6_1Text=Visual Studio Projects
Fdr6_1Path=D:\Projects\VisualStudio
Fdr6_2Text=QQ FileRecv
Fdr6_2Path=D:\Softwares\_Data\QQ\2223998963\FileRecv
Fdr6_3Text=Code
Fdr6_3Path=D:\Code
Fdr6_4Text=Deemo Charts
Fdr6_4Path=D:\Project Charts\Collection
Fdr6_5Text=DesktopFolder
Fdr6_5Path=C:\Users\Lenovo\Desktop\Files
Fdr6_6Text=Memo
Fdr6_6Path=D:\Files\Memo
Fdr6_7Text=QQChannelFolder
Fdr6_7Path=C:\Users\Lenovo\Documents\Tencent Files\2223998963\QQGuild\nt_data\File\Ori

Fdr7Text=Programs
Fdr7_0Text=Lapluma
Fdr7_0Path=D:\Projects\VisualStudio\Lapluma\Lapluma.Konata\bin\Release\netcoreapp3.1\Lapluma.Konata.exe
Fdr7_1Text=CheckRegex
Fdr7_1Path=D:\Tools\MyTools\Tra.ConsoleWidget.CheckRegex.lnk
Fdr7_2Text=DownloadCloudMusic
Fdr7_2Path=D:\Tools\MyTools\Tra.ConsoleWidget.DownloadCloudMusic.lnk
Fdr7_3Text=DownloadYoutube
Fdr7_3Path=D:\Tools\MyTools\Tra.ConsoleWidget.DownloadYoutube.lnk
Fdr7_4Text=ConvertDeemoChart
Fdr7_4Path=D:\Tools\MyTools\Tra.ConsoleWidget.ConvertDeemoChart.lnk
Fdr7_5Text=NcmDecrypter
Fdr7_5Path=D:\Tools\_my\NcmDecrypter.Light.lnk

Fdr8Text=Files
Fdr8_0Text=Memo
Fdr8_0Path=D:\Files\MarkdownNotes\memo.md
Fdr8_1Text=TODO
Fdr8_1Path=D:\Files\MarkdownNotes\todo.md
Fdr8_2Text=Notes
Fdr8_2Path=D:\Files\MarkdownNotes\OpenByVSCode.lnk

