[ExpandedButton]
Meter=Button
MeterStyle=SGlobalImage | SExpandedGroup
X=0
Y=235
ButtonImage=#res#\img\ExpandedL.png
ButtonCommand=[!HideMeterGroup Expanded][!ShowMeter CollapsedButton]

[CollapsedButton]
Meter=Button
MeterStyle=SGlobalImage
X=0
Hidden=1
ButtonImage=#res#\img\CollapsedL.png
ButtonCommand=[!Refresh]