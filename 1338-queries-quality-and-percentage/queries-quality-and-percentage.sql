-- Write your PostgreSQL query statement below
with q_count as (select count(*) qq_count, query_name from queries q group by query_name),
p_count as (select count(position) pp_count, query_name from queries q2 where rating < 3  group by query_name)
select qq.query_name , Round(sum( rating::numeric/position)/qq_count,2) quality , Coalesce(Round((pp_count::numeric/qq_count) *100,2),0) poor_query_percentage from queries qq inner join q_count q on qq.query_name = q.query_name
left join p_count p on qq.query_name = p.query_name group by qq.query_name , pp_count , qq_count
--select * from p_count