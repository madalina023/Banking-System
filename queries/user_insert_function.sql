create or replace function user_insert(
	_firstname varchar(30),
	_lastname varchar(30),
	_username varchar(30),
	_password varchar(30)
) returns int as
$$
begin
	insert into 
		users(first_name, last_name, username, password)
	values(_firstname, _lastname, _username, _password);
	if found then return 1;
	else return 0;
	end if;
end
$$
language plpgsql;