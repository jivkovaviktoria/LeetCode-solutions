select distinct w1.Id from Weather w1, Weather w2
where w1.RecordDate=DATEADD(day, 1, w2.RecordDate) and w1.Temperature>w2.Temperature