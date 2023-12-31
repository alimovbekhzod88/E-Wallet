CREATE TABLE SYS_USER_WALLET_TURNOVOR
(
    ID BIGSERIAL NOT NULL,
    ON_DATE DATE NOT NULL,
    IS_DEBIT boolean,
    AMOUNT DECIMAL,
    USER_ID SERIAL NOT NULL,
    WALLET_ID INT NOT NULL,

    CREATED_AT		TIMESTAMP WITHOUT TIME ZONE DEFAULT NOW() NOT NULL,
	CREATED_BY		INT,
	MODIFIED_AT		TIMESTAMP WITHOUT TIME ZONE,
	MODIFIED_BY		INT,
	
	CONSTRAINT FK_USER_ID
		FOREIGN KEY (USER_ID)
			REFERENCES SYS_USER (ID),
 
	CONSTRAINT FK_WALLET_ID
		FOREIGN KEY (WALLET_ID)
			REFERENCES USER_WALLET (ID)
);