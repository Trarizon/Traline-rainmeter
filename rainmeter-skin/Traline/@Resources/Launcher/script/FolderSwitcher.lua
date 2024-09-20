function Hide()
	cur = SKIN:GetVariable("curFolder");
	if (cur == "~") then
		return;
	end

	SKIN:Bang("!HideMeterGroup", cur);
	SKIN:Bang("!UpdateMeterGroup", cur);
	SKIN:Bang("!SetVariable", "curFolder","~");
	SKIN:Bang("!HideMeter", "FolderOpenFlag");
	SKIN:Bang("!UpdateMeter", "FolderOpenFlag");
end

function Show(folder)
	cur = SKIN:GetVariable("curFolder");
	if(cur ~= "~") then
		SKIN:Bang("!HideMeterGroup", cur);
		SKIN:Bang("!UpdateMeterGroup", cur);
	end

	SKIN:Bang("!ShowMeterGroup", folder);
	SKIN:Bang("!UpdateMeterGroup", folder);
	SKIN:Bang("!SetVariable", "curFolder", folder);
	SKIN:GetMeter("FolderOpenFlag"):SetY(SKIN:GetMeter(folder):GetY() - 5);
	SKIN:Bang("!ShowMeter", "FolderOpenFlag");
	SKIN:Bang("!UpdateMeter", "FolderOpenFlag");
end
