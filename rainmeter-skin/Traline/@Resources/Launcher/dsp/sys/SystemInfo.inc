[SystemInfoCpu]
Meter=String
MeasureName=MCpuAverage
MeterStyle=SSystemText | SSystemHeadLocate | SSystemUpdate | SSystemFont | SExpandedGroup
Text=AvgCPU: %1%

[SystemInfoMemory]
Meter=String
MeasureName=MMemoryUsed
MeasureName2=MMemoryTotal
MeterStyle=SSystemText | SSystemTextLocate | SSystemUpdate | SSystemFont | SExpandedGroup
Text=Memory: #MemoryDisplayFormat#

[SystemInfoDiskC]
Meter=String
MeasureName=MDiskCUsed
MeasureName2=MDiskCTotal
MeterStyle=SSystemText | SSystemTextLocate | SSystemUpdate | SSystemFont | SExpandedGroup
Text=C: #DiskDisplayFormat#
LeftMouseUpAction=["C:\"]

[SystemInfoDiskD]
Meter=String
MeasureName=MDiskDUsed
MeasureName2=MDiskDTotal
MeterStyle=SSystemText | SSystemTextLocate | SSystemUpdate | SSystemFont | SExpandedGroup
Text=D: #DiskDisplayFormat#
LeftMouseUpAction=["D:\"]
