create table cards(
	card_id serial primary key,
	card_owner varchar(30),
	card_number varchar(30),
	expiry_date varchar(30),
	security_code varchar(30),
	sold numeric
);