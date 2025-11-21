SELECT ProductName, SUM(Price * Quantaty) AS TotalRevenue
FROM OrderDetail
GROUP BY ProductName
HAVING SUM(Price * Quantaty) > (SELECT AVG(Price * Quantaty) FROM OrderDetail);
