create or replace function banking_data_insert(
	_cardnumber varchar(20),
	_cardowner varchar(30),
	_expirydate varchar(5),
	_securitycode varchar(4),
	_userid int
) returns int as
$$
begin
	insert into 
		banking_data(card_number, card_owner, expiry_date, security_code, user_id)
	values(_cardnumber, _cardowner, _expirydate, _securitycode, _userid);
	if found  return 1;
	else return 0;
	end if;
end
$$
language plpgsql;