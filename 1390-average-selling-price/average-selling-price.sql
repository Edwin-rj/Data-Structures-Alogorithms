select product_id , COALESCE(Round(sum(average_price)/nullif(sum(units),0),2),0) average_price from (
    select p.product_id, sum(price * units)  average_price ,  sum(units)  units from Prices p  left join  UnitsSold us on p.product_id =  us.product_id and purchase_date between  start_date and end_date group by p.product_id , start_date , end_date
    ) t group by product_id order by product_id