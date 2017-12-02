select ItemID,ReportName
from (
select 
	ItemID,
	replace(replace(replace(Path,Name,''),'{3c47188a-deb5-4cf7-810b-23f832de2aa8}/DocLib1/',''),'/','') ReportFolder, 
	Name ReportName
from Catalog c
where Type = 2
	and (Path like '/{3c47188a-deb5-4cf7-810b-23f832de2aa8}/DocLib1%' OR @@SERVERNAME != 'AS-MSK-N0203\CONTENT')
	and Path not like '%/WT/%'
	and Path not like '%/test/%'
	) q
where ReportFolder = @Folder
