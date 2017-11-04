DECLARE @a  int=1
DECLARE @b	int=2
DECLARE @c  int = 0
DECLARE @d	int =0

WHILE @c< 40000000
BEGIN

	SET @c = @a+@b

	if((Select @c%2))=0
	BEGIN
		print @d
		SET @d =@d+@c
	END

	SET @a	= @b
	SET @b	= @c
END

	Select @d as RESULT