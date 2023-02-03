select d.Name as Department, e.Name as Employee, e.Salary
from Employee as e
join Department as d on e.DepartmentId = d.Id
where e.Salary in (select distinct top(3) Salary from Employee as em
                   where d.Id = em.DepartmentId
                   order by Salary Desc)
