[RecycleBinFullImage]
Meter=Image
MeterStyle=SRecycleImage | SRecycleImageLocate | SSystemUpdate | SExpandedGroup
ImageName=#res#img\FullBin.png
Hidden=([MRecycleCount] > 0 ? 0 : 1)
DynamicVariables=1

[RecycleBinEmptyText]
Meter=String
MeasureName=MRecycleCount
MeterStyle=SRecycleText | SRecycleTextLocate | SSystemUpdate | SSystemFont | SExpandedGroup
Text=#BinEmptyText#
Hidden=([MRecycleCount] > 0 ? 1 : 0)
DynamicVariables=1

[RecycleBinFullText]
Meter=String
MeasureName=MRecycleCount
MeterStyle=SRecycleText | SRecycleTextLocate | SSystemUpdate | SSystemFont | SExpandedGroup
Text=#BinFullText#
Hidden=([MRecycleCount] > 0 ? 0 : 1)
RightMouseUpAction=!CommandMeasure MRecycleCount EmptyBin
DynamicVariables=1
