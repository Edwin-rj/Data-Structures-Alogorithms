
with confirmation as (select user_id , count(*) total_count from Confirmations group by user_id)
, confitmed_action as (select user_id , count(*) confirmed_count from Confirmations where action = 'confirmed' group by user_id)
select u.user_id , ROUND(COALESCE(COALESCE(ca.confirmed_count, 0)::NUMERIC /c.total_count,0),2) confirmation_rate from Signups u left join confirmation c on c.user_id = u.user_id left join confitmed_action ca on ca.
user_id  = u.user_id