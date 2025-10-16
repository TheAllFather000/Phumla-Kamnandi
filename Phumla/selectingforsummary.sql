SELECT  

    hotelid,
   
    SUM(CASE WHEN MONTH(Payment.date) = 1 THEN amount ELSE 0 END) AS Jan, 

    SUM(CASE WHEN MONTH(Payment.date) = 2 THEN amount ELSE 0 END) AS Feb, 

    SUM(CASE WHEN MONTH(Payment.date) = 3 THEN amount ELSE 0 END) AS Mar, 

    SUM(CASE WHEN MONTH(Payment.date) = 4 THEN amount ELSE 0 END) AS Apr, 

    SUM(CASE WHEN MONTH(Payment.date) = 5 THEN amount ELSE 0 END) AS May, 

    SUM(CASE WHEN MONTH(Payment.date) = 6 THEN amount ELSE 0 END) AS Jun, 

    SUM(CASE WHEN MONTH(Payment.date) = 7 THEN amount ELSE 0 END) AS Jul, 

    SUM(CASE WHEN MONTH(Payment.date) = 8 THEN amount ELSE 0 END) AS Aug, 

    SUM(CASE WHEN MONTH(Payment.date) = 9 THEN amount ELSE 0 END) AS Sep, 

    SUM(CASE WHEN MONTH(Payment.date) = 10 THEN amount ELSE 0 END) AS Oct, 

    SUM(CASE WHEN MONTH(Payment.date) = 11 THEN amount ELSE 0 END) AS Nov, 

    SUM(CASE WHEN MONTH(Payment.date) = 12 THEN amount ELSE 0 END) AS 'Dec', 

    SUM(amount) AS Total 

FROM Payment 

WHERE Payment.date < '05/09/2025'
GROUP BY hotelid;