with managers as 
    (select managerId , count(*) counts from employee  group by managerId having count(*) >= 5 )
    select name from employee e inner join managers ms on ms.managerId = e.id;