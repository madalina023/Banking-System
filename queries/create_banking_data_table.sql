create table banking_data (
   banking_data_id serial primary key,
   card_number varchar(20),
   card_owner varchar(30),
   expiry_date varchar(5),
   security_code varchar(4),
   user_id int,
   constraint fk_user
      foreign key(user_id) 
	  references users(user_id)
);