[SFolderImage]
ImageName=#res#img\FolderR.png
ImageTint=#GeneralColor#

[SFolderText]
Text=[#[#CURRENTSECTION]Text]
LeftMouseUpAction=[!CommandMeasure MScriptFolderSwitch "Show('#CURRENTSECTION#')"]
LeftMouseDoubleClickAction=["#res#dsp\fdr\#CURRENTSECTION#.inc"]
RightMouseUpAction=[!CommandMeasure MScriptFolderSwitch "Hide()"]

[SItemImage]
Hidden=1
ImageName=#res#img\ItemR.png
ImageTint=#GeneraColor#

[SItemText]
Hidden=1
Text=[#[#CURRENTSECTION]Text]
LeftMouseUpAction=["[#[#CURRENTSECTION]Path]"]
RightMouseUpAction=["[#[#CURRENTSECTION]Path]\..\"]
