CREATE PROC usp_FindTotalIncome (@start_date INT,  @end_date INT, @company_name nvarchar(50))
AS
SELECT SUM(od.Quantity*od.UnitPrice) AS TotalIncome
FROM Suppliers s
INNER JOIN Products p
ON s.SupplierID = p.SupplierID
INNER JOIN [ORDER Details] od
ON od.ProductID = p.ProductID
INNER JOIN Orders o
ON od.OrderID = o.OrderID
WHERE s.CompanyName = @company_name AND (YEAR(o.OrderDate) >= @start_date AND YEAR(o.OrderDate) <= @end_date);
GO