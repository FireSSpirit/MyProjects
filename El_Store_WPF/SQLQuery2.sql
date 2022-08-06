DROP DATABASE EL_STORE_DB
CREATE DATABASE EL_STORE_DB

CREATE TABLE all_products_tb(
id int PRIMARY KEY NOT NULL IDENTITY,
name_product varchar(70) NOT NULL,
price varchar(15) NOT NULL,
manufacturer varchar(60) NOT NULL,
count_Product numeric NOT NULL
);

USE Country_DB
SELECT * FROM all_products_tb;

CREATE TABLE tblCountries(
id int NOT NULL IDENTITY,
country varchar(70) NOT NULL,
ondate DateTime NOT NULL
);

CREATE TABLE phones_tb(
phone_id int FOREIGN KEY REFERENCES all_products_tb (id) NOT NULL,
name_phone varchar(70) NOT NULL,
diagonal varchar(15) NOT NULL,
color varchar(60) NOT NULL,
);

CREATE TABLE earphones_tb(
phone_id int FOREIGN KEY REFERENCES all_products_tb (id) NOT NULL,
name_earphone varchar(70) NOT NULL,
minHZ varchar(10) NOT NULL,
maxHZ varchar(10) NOT NULL,
wireless bit NOT NULL,
);

SET lc_monetary "ru_RU.UTF-8";
DROP TABLE all_products_tb


ALTER DATABASE EL_STORE_DB SET EMERGENCY;
GO

ALTER DATABASE EL_STORE_DB SET EMERGENCY;
GO