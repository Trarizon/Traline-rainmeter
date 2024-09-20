function Update()
    local timestamp = os.time()
    local hour = tonumber(os.date('%H', timestamp))
    if hour < 6 then
        hour = hour + 24
        timestamp = timestamp - 86400
    end
    return os.date('%A\n', timestamp) .. hour .. os.date(':%M:%S')
end