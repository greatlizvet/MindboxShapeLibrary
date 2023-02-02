SELECT p.name, c.name 
FROM products p
LEFT JOIN categories_products cp ON cp.product_id = p.id 
LEFT JOIN categories c ON c.id = cp.category_id