delete from Person
where exist(
    select 1 from Person p2
    where p2.email = Person.email ans p2.id < Person.id
)