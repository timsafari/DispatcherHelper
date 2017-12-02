select 
	s.SubscriptionID,
	s.Description,
	s.LastRunTime,
	s.LastStatus,
	cast(MatchData as xml),
	rs.ReportAction
from ReportSchedule rs
	join Subscriptions s
		on s.SubscriptionID = rs.SubscriptionID
where /*rs.ReportID = @ReportID
	and*/ rs.ReportAction = 4