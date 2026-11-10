with single_number as (select num from MyNumbers group by num having count(*) = 1)
select max(num) num from single_number