with deliverys as (  SELECT *,
           ROW_NUMBER() OVER (
               PARTITION BY customer_id
               ORDER BY order_date
           ) AS rn
    FROM Delivery
)
select Round((count(case when order_date = customer_pref_delivery_date then 1 end)::numeric / count(*))* 100 ,2) immediate_percentage from deliverys d  where rn = 1
