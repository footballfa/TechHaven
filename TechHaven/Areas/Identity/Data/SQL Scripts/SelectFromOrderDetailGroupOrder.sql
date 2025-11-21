SELECT ProductName,
       SUM(Price * Quantaty) AS TotalRevenue
FROM OrderDetail
GROUP BY ProductName
ORDER BY TotalRevenue DESC;
