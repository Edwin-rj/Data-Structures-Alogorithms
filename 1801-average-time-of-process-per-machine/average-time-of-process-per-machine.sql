-- Write your PostgreSQL query statement below
select machine_id ,  Round(sum(
        CASE
            WHEN activity_type = 'start' THEN -timestamp
            WHEN activity_type = 'end' THEN +timestamp
        END::numeric
    )/count(distinct process_id) ,3)AS processing_time from activity group by machine_id