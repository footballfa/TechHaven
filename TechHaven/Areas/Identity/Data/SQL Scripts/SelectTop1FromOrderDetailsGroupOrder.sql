SELECT TOP 1 OD.ProductName, SUM(OD.Price * OD.Quantaty) AS TotalRevenue
FROM OrderDetail OD
GROUP BY OD.ProductName
ORDER BY TotalRevenue DESC;
