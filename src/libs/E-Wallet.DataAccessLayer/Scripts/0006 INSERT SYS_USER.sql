
INSERT INTO SYS_USER 
(FIRST_NAME, LAST_NAME, MIDDLE_NAME,DOCUMENT_TYPE_ID,DOC_SERIA_NUMBER,PASSWORD_HASH,PASSWORD_SALT,EMAIL_ADDRESS, state_id)
VALUES(
	N'BKEHZOD', 
	N'ALIMOV', 
	N'JOLOLITDINOVICH',
	(SELECT ID FROM ENUM_DOCUMENT_TYPE WHERE ID=2), 
	N'AA123456',
	'',
	'',
	N'admin@gmail.com',
	(SELECT ID FROM ENUM_STATE WHERE ID=1)
);
