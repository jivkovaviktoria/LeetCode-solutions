select s.name
from SalesPerson s
where sales_id not in (select distinct sales_id from Orders o join Company c on o.com_id=c.com_id where c.name='RED')