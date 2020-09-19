- IT Repair Manager -

MySQL DB has to be already configured, table structre compatible with the committed settings can be created automagically by using the following queries:

CREATE TABLE `customers` (
  `id_customers` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `type` int DEFAULT NULL,
  `business_name` varchar(45) DEFAULT NULL,
  `vat_id_1` varchar(45) DEFAULT NULL,
  `vat_id_2` varchar(45) DEFAULT NULL,
  `vat_id_3` varchar(45) DEFAULT NULL,
  `address_street` varchar(45) DEFAULT NULL,
  `address_number` varchar(45) DEFAULT NULL,
  `address_city` varchar(45) DEFAULT NULL,
  `address_region` varchar(45) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `mail_address` varchar(45) DEFAULT NULL,
  `date_created` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_customers`),
  UNIQUE KEY `id_customers_UNIQUE` (`id_customers`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;




and:

CREATE TABLE `repairslist` (
  `id_repair` int NOT NULL AUTO_INCREMENT,
  `repair_type` varchar(15) DEFAULT '0',
  `device_model` varchar(25) DEFAULT NULL,
  `objective` mediumtext,
  `notes` mediumtext,
  `price` varchar(6) DEFAULT '0',
  `date_start` datetime DEFAULT CURRENT_TIMESTAMP,
  `date_end` datetime DEFAULT NULL,
  `id_customer` int DEFAULT NULL,
  PRIMARY KEY (`id_repair`),
  UNIQUE KEY `id_repair_UNIQUE` (`id_repair`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


Feel free to use and customize, don't resell without my written authorization.

PS: Yes, i made some menus in IT and some in EN, i'm sorry, feel free to change them, i rushed them.
