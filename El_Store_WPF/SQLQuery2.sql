DROP DATABASE EL_STORE_DB
CREATE DATABASE EL_STORE_DB

drop table phones_tb
drop table earphones_tb
drop table all_products_tb


CREATE TABLE all_products_tb(
id int PRIMARY KEY  NOT NULL,
name_product varchar(70) NOT NULL,
price money NOT NULL,
manufacturer varchar(60) NOT NULL,
count_Product numeric NOT NULL,
[type] varchar(60) NOT NULL
);

SELECT * FROM all_products_tb;
SELECT * FROM phones_tb;
SELECT * FROM earphones_tb;

--DELETE earphones_tb where earphone_id = 3;

insert into all_products_tb
(name_product, price, manufacturer, count_Product, [type])
values
('Iphone 13', '100000', 'Apple', '13', 'Phone');
GO
insert into phones_tb
(name_phone, diagonal, color)
values
('Iphone 13', '6', 'Black');
GO

insert into all_products_tb values('1', 'Iphone 13', '100000', 'Apple', '13', 'смартфон');

delete from earphones_tb where earphone_id = 4;
delete from all_products_tb where id = 2;

update phones_tb set name_phone = 'Iphone 13', diagonal = '6,2"', color = 'Black' where id = 1;update all_products_tb set [type] = 'Phone' where id = 1;



CREATE TABLE tblCountries(
id int NOT NULL IDENTITY,
country varchar(70) NOT NULL,
ondate DateTime NOT NULL
);

CREATE TABLE phones_tb(
phone_id int NOT NULL,
name_phone varchar(70) NOT NULL,
diagonal float NOT NULL,
color varchar(60) NOT NULL,

FOREIGN KEY(phone_id) REFERENCES all_products_tb(id) ,
)

ALTER TABLE phones_tb
DROP CONSTRAINT FK__phones_tb__phone__1CF15040

CREATE TABLE earphones_tb(
earphone_id int FOREIGN KEY REFERENCES all_products_tb (id),
name_earphone varchar(70) NOT NULL,
minHZ int NOT NULL,
maxHZ int NOT NULL,
wireless bit NOT NULL,
);

SET lc_monetary "ru_RU.UTF-8";
DROP TABLE all_products_tb


ALTER DATABASE EL_STORE_DB SET EMERGENCY;
GO

ALTER DATABASE EL_STORE_DB SET EMERGENCY;
GO