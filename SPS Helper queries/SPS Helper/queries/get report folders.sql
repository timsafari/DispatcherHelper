select 
	distinct
	reverse(stuff(reverse(stuff(replace(replace(c.Path,c.Name,''),'{3c47188a-deb5-4cf7-810b-23f832de2aa8}/DocLib1/',''),1,1,'')),1,1,'')) ReportFolder
from Catalog c
	join ReportSchedule rs
		on rs.ReportID = c.ItemID
where Type = 2
	and (Path like '/{3c47188a-deb5-4cf7-810b-23f832de2aa8}/DocLib1%' OR @@SERVERNAME != 'AS-MSK-N0203\CONTENT')
	and Path not like '%/WT/%'
	and Path not like '%/test/%'
order by 1


