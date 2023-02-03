
with CTE as
(select d.name 'department', e.name,salary,rank() over(partition by d.id order by salary desc)'r'
from Employee e
join Department d
on e.departmentId = d.id)
select department,name'Employee',salary
from CTE
where r = 1