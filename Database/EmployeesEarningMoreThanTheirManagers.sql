select e.name as Employee from Employee as e
inner join Employee as d on e.managerId = d.id
where e.salary > d.salary