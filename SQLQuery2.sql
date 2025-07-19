SELECT 
    S.SaleID,
    S.SaleDate,
    PM.Name AS ProductName,
    SH.Quantity,
    SH.Price,
    SH.Total AS [Item Total],
    S.TotalAmount AS [Grand Total]
FROM 
    Sales S
INNER JOIN 
    SalesHistory SH ON S.SaleID = SH.SaleID
INNER JOIN 
    ProductManager PM ON SH.ProductID = PM.ProductID
ORDER BY 
    S.SaleDate DESC;
