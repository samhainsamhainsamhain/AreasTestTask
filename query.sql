SELECT Products.name, Category.name
FROM Products LEFT JOIN  Category ON Products.id=Category.productId 
ORDER BY Products.name;
