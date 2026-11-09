with exm_count as (select student_id ,subject_name ,count(*) attented_exams from examinations group by student_id ,subject_name )
select s.student_id ,s.student_name , sb.subject_name ,coalesce(e.attented_exams,0) attended_exams 
from students s Cross join subjects sb left join exm_count e on e.student_id = s.student_id   and e.subject_name = sb.subject_name
order by s.student_id , s.student_name ,sb.subject_name