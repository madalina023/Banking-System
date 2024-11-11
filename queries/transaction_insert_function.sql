create or replace function transaction_insert(
	_transaction_type varchar(200),
	_amount numeric,
	_card_owner varchar(30),
	_card_number varchar(30),
	_username varchar(30),
	_date varchar(100)
) returns int as
$$
begin
	insert into 
		transactions(transaction_type, amount, card_owner, card_number, username, date)
	values(_transaction_type, _amount, _card_owner, _card_number, _username, _date);
	if found then return 1;
	else return 0;
	end if;
end
$$
language plpgsql;