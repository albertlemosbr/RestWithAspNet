CREATE DATABASE rest_with_asp_net;

USE rest_with_asp_net;

CREATE TABLE IF NOT EXISTS `person` (
	`id` bigint(20) NOT NULL AUTO_INCREMENT,
	`address` VARCHAR(100) NOT NULL,
	`first_name` VARCHAR(80) NOT NULL,
	`last_name` VARCHAR(80) NOT NULL,
	`gender` VARCHAR(6) NOT NULL,
	PRIMARY KEY (`id`)
);

SELECT * FROM rest_with_asp_net.person;