#показывает дату 
Get-Date 
#Вывод производителя и модели компьютера
Get-CimInstance -ClassName Win32_ComputerSystem 
$systeminfo | fl OS*
#Дата установки windows
$system = Get-WmiObject -Class Win32_OperatingSystem
# Получаем дату установки ОС
$InstallDate = [Management.ManagementDateTimeconverter]::ToDateTime($system.installdate)
# Вычисляем время, прошедшее с момента установки
$AfterInstallDays = ((Get-Date) — $Installdate).Days
$AfterInstallHours = ((Get-Date) — $Installdate).Hours
$AfterInstallMinutes = ((Get-Date) — $Installdate).Minutes
# Переводим дату установки в короткий формат
$ShortInstallDate = "{0:yyyy-MM-dd HH:MM}" -f ($InstallDate)
# Выводим результаты
$InstallDateString = "Система установлена: $ShortInstallDate (Прошло дней:$AfterInstalldays часов:$AfterInstallHours минут:$AfterInstallMinutes)"
$InstallDateString
#ОЗУ ВЫВОД В GB
Get-WmiObject Win32_PhysicalMemory | Select-Object BankLabel, @{Name="Capacity, GB"; Expression={$_.Capacity/1GB}}, Manufacturer 
#Вывод сведений о процессоре
Get-CimInstance -ClassName Win32_Processor | Select-Object -ExcludeProperty "CIM*" 
#Информация о CPU 
$cpuinfo = Get-CimInstance -ClassName CIM_Processor
$cpuinfo | fl Name, Description, Version
#Локальные пользователи 
Get-CimInstance -ClassName Win32_OperatingSystem | Select-Object -Property *user* 
#Сведение о дисках
get-wmiobject -class win32_logicaldisk 