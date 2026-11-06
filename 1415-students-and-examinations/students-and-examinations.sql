with exm_count as (select student_id ,subject_name ,count(*) attented_exams from examinations group by student_id ,subject_name )
select s.student_id ,s.student_name , sb.subject_name ,coalesce(e.attented_exams,0) attended_exams 
 -- ,case when e.student_id is null then 0 else count(*) end as attented_exams 
from students s Cross join subjects sb left join exm_count e on e.student_id = s.student_id   and e.subject_name = sb.subject_name
--group by s.student_id ,e.student_id,s.student_name , sb.subject_name , e.subject_name 
order by s.student_id , s.student_name ,sb.subject_name