CREATE DATABASE SHOP;

USE SHOP;


CREATE TABLE customers (
    customer_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE orders (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    customer_id INT,
    total_amount DECIMAL(10,2) NOT NULL,
    order_date DATE NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id) ON DELETE CASCADE
);



INSERT INTO customers (name, email) VALUES
('John Doe', 'john@example.com'),
('Alice Smith', 'alice@example.com'),
('Bob Johnson', 'bob@example.com'),
('Emily Davis', 'emily@example.com'),
('Michael Brown', 'michael@example.com');


INSERT INTO orders (customer_id, total_amount, order_date) VALUES
(1, 150.00, '2024-02-10'),  -- John Doe's order
(2, 200.50, '2024-02-12'),  -- Alice Smith's order
(2, 99.99, '2024-02-15'),   -- Alice Smith's second order
(3, 75.25, '2024-02-18');   -- Bob Johnson's order


-- ANS: 

SELECT * FROM customers;
SELECT * FROM orders;



-- Q1. Retrieve all customers who have placed an order.
-- ANS:

SELECT DISTINCT customers.customer_id, customers.name, customers.email
FROM customers
INNER JOIN orders ON customers.customer_id = orders.customer_id;


-- Q2. List orders along with the customer names.
-- ANS: 

SELECT orders.order_id, customers.name, orders.total_amount, orders.order_date
FROM orders
INNER JOIN customers ON orders.customer_id = customers.customer_id;


-- Q3.  Find customers who haven’t placed any orders
-- ANS: 
SELECT customers.customer_id, customers.name, customers.email
FROM customers
LEFT JOIN orders ON customers.customer_id = orders.customer_id
WHERE orders.customer_id IS NULL;



 



 














