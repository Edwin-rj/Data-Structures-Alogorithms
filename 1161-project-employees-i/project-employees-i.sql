with employee_exp as (select employee_id , experience_years from employee)
select project_id , Round(sum(experience_years::numeric)/count(*),2) average_years from project p left join employee  ee on ee.employee_id = p.employee_id group by project_id  order by project_id
