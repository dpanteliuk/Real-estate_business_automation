USE [DB_Real_Estate_Strorage];
GO

INSERT INTO dbo.District ([Name])
VALUES ('Suhiv'), 
		('Galyzkyj'), 
		('Frankivskyj'), 
		('Shevchenkivskyj'), 
		('Zaliznuchnyj'), 
		('Luchakivskyj');
GO

INSERT INTO dbo.Person (FirstName, LastName, Phone, Mail)
VALUES ('Yuriy', 'Shevchuk', '+380327630764', 'yuriyshev@gmail.com'),
		('Ihor', 'Kolodiy', '+380637395746', 'ikolodiy@gmail.com'),
		('Iryna', 'Biletska', '+380679048351', 'irabiletska@gmail.com'),
		('Andriy', 'Martynenko', '+380933325807', 'martynenko@gmail.com'), 
		('Anna', 'Kovalyk', '+380967134444', 'ankovalyk@gmail.com'), 
		('Oleksandr', 'Khomych', '+380672541273', 'oleksandr80@mail.ru'), 
		('Oleh', 'Ruban', '+380985237417', 'o_ruban@gmail.com'), 
		('Denys', 'Kosenko', '+380980585609', 'denkosenko@gmail.com'), 
		('Mykhaylo', 'Kachmar', '+380990550898', 'kachmar_lviv@ukr.net'), 
		('Maksym', 'Kokhan', '+380639928828', 'mkokhan@gmail.com'), 
		('Mariya', 'Batrak', '+380676758193', 'batrakmasha@ya.ru'), 
		('Inna', 'Polishchuk', '+380688868374', 'polinna@gmail.com'), 
		('Oleh', 'Vasyuk', '+380322445829', 'vasyuk3876@gmail.com'),
		('Olya', 'Rodych', '+380631748392', 'orodych@gmail.com'),
		('Ivan', 'Struk', '+380981546379', 'struk9143@gmail.com'),
		('Volodymyr', 'Pidluzhnyy', '+380993721875', 'vopidluzhnyy@gmail.com'),
		('Taras', 'Perepelytsya', '+380931726589', 't_perepelyt@gmail.com'),
		('Serhiy', 'Sluchak', '+380683649106', 'sysluchak@gmail.com'),
		('Nazar', 'Hnativ', '+380327381098', 'nzhnativ@mail.ru'),
		('Serhiy', 'Mandebura', '+380998190473', 'serhiyman@gmail.com'),
		('Vlad', 'Velychko', '+380674910286', 'v_velychko@gmail.com'),
		('Ostap', 'Simchuk', '+380974619255', 'osimchuk@gmail.com'),
		('Orysya', 'Marushko', '+380937281910', 'marushko12@mail.ru');
GO

INSERT INTO dbo.Estate (EstOwner, Area, Rooms, District, Address, Price, Rent, Sale)
VALUES (4, 141.5, 4, 5, 'Starodubska, 6', 1939000, 'false', 'true' ), 
		(5, 74, 3, 1, 'Enerhetychna, 48', 1422000, 'false', 'true' ), 
		(6, 32, 2, 6, 'Zelena, 115a', 646300, 'false', 'true' ), 
		(7, 45, 2, 3, 'V. Velykoho, 70', 859300, 'false', 'true' ), 
		(8, 24.7, 1, 2, 'Sakharova, 17', 469000, 'false', 'true' ), 
		(9, 33, 1, 1, 'Dzh. Vashynhtona, 13', 2870, 'true', 'false' ), 
		(10, 36.5, 1, 5, 'Horodotska, 151', 4300, 'true', 'false' ), 
		(11, 60, 2, 5, 'Patona, 35', 5730, 'true', 'false' ), 
		(12, 54, 2, 4, 'Shevchenka, 21b', 7100, 'true', 'false' ), 
		(13, 90, 3, 2, 'Zamarstynivska, 270', 9600, 'true', 'false' ),
		(14, 101, 5, 5, 'Dozvilna, 47', 2065000, 'false', 'true' ),
		(15, 190, 6, 3, 'Stryyska, 69c', 2555000, 'false', 'true' ), 
		(16, 120, 5, 6, 'Kotsylovskoho, 3', 20700, 'true', 'false' ),
		(17, 38.7, 1, 4, 'Khmelnytskoho, 52', 696800, 'false', 'true' ),
		(18, 45, 2, 2, 'Franka, 11', 1239000, 'false', 'true' ),
		(19, 93, 3, 4, 'Lemkivska, 61', 1923000, 'false', 'true' ),
		(20, 33, 1, 3, 'Stryyska, 180', 3500, 'true', 'false' ), 
		(21, 60, 2, 1, 'Chervonoyi Kalyny, 145', 6300, 'true', 'false' ), 
		(22, 80, 3, 6, 'Kryvonosa, 18a', 9000, 'true', 'false' ), 
		(23, 133, 4, 5, 'Levandivska, 94', 15500, 'true', 'false' );
GO

INSERT INTO dbo.DBUser (PersId, Login, Password)
VALUES (1, 'user', '62c8ad0a15d9d1ca38d5dee762a16e01'),
		(2, 'koloda', '804cc1d5a6ae13e4e566106fb6c97967'),
		(3, 'bilka', '8f1f03135ac0e17a9d48542110ee570d');
GO

