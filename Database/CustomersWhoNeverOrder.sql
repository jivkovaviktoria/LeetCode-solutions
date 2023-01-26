Select name as Customers
from Customers
where id Not IN
(Select c.id from Customers C JOIN Orders o on c.id = o.customerId);