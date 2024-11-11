create table transactions(
	transaction_id serial primary key,
	transaction_type varchar(200),
	amount numeric,
	card_owner varchar(30),
	card_number varchar(30),
	username varchar(30),
	date varchar(100)
);