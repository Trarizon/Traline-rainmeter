[ExpandedButton]
Meter=Button
MeterStyle=SGlobalImage | SExpandedGroup
X=350
Y=235
ButtonImage=#res#\img\ExpandedR.png
ButtonCommand=[!HideMeterGroup Expanded][!ShowMeter CollapsedButton]

[CollapsedButton]
Meter=Button
MeterStyle=SGlobalImage
X=350
Hidden=1
ButtonImage=#res#\img\CollapsedR.png
ButtonCommand=[!Refresh]