ALTER TABLE customer
ADD CONSTRAINT chk_customer_type CHECK (customer_type IN ('Premium', 'Standard'));

INSERT INTO customer ( name, location, customer_type)
VALUES ( 'Minu', 'Trivandrum', 'Premium');

INSERT INTO customer ( name, location, customer_type)
VALUES ( 'Minu', 'Trivandrum', 'Standard');

INSERT INTO customer (name, location, customer_type)
VALUES ('Maya', 'Chennai', 'Basic');