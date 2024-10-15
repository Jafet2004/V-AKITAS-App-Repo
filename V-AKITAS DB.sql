Create database [V-AKITAS];
Use [V-AKITAS];

create login [V-AkitasPremium]  with Password = 'V-AKITAS2024';
CREATE USER [V-AkitasPremium] FOR LOGIN [V-AkitasPremium];
EXEC sp_addrolemember 'db_datareader', 'V-AkitasPremium';  -- Permisos de lectura
EXEC sp_addrolemember 'db_datawriter', 'V-AkitasPremium';  -- Permisos de escritura


create table [Tipos de Harinas] 
(
    [Muestra de Grano] VARCHAR(50),
    [% Humedad] DECIMAL(10,4),
    [% Materia seca] DECIMAL(10,4),
    [% Ceniza] DECIMAL(10,4),
    [% Proteina] DECIMAL(10,4),
    [% Fibra] DECIMAL(10,4),
    [% Grasa] DECIMAL(10,4),
	[% Carbohidratos] Decimal (10,4)
);

Create table [Aumento de 1Kg por día]
(
	[Peso (Kg)] Decimal(10,2) not null,
    [Consumo de MS* (% del peso vivo)] Decimal(10,2) not null,
	[Energía de mantenimiento (Mcal/día)] Decimal(10,2) not null,
	[Energía de aumento de peso (Mcal/día)] Decimal(10,2) not null,
	[Total de energía metabolizable (Mcal/día)] Decimal(10,2) not null,
	[Concentración energética (Mcal/kg MS)] Decimal(10,2) not null,
	[Proteína metabolizable para mantenimiento (g/día)] Decimal(10,2) not null,
	[Proteína metabolizable para crecimiento (g/día)] Decimal(10,2) not null,
	[Total de proteína metabolizable (g/día)] Decimal(10,2) not null,
	[Proteína degradable en el rumen (% de la PT)] Decimal(10,2) not null,
	[Proteína no degradable en el Rumen (% de la PT)] Decimal(10,2) not null,
	[Proteína total PT (g/día)] Decimal(10,2) not null
);

INSERT INTO [Tipos de Harinas] VALUES
('Maiz', 14.8543, 85.1457, 3.3298, 7.3244, 10.6150, 6.8582, 67.6333),
('Sorgo forrajero', 13.8243, 85.1457, 1.8449, 6.4456, 91.4250, 3.3693, 74.5159),
('Sorgo forrajero blanco', 7.8292, 92.1708, 6.3244, 7.3974, 76.5950, 0.9285, 77.5205),
('Sorgo millon', 14.8193, 85.1807, 1.6599, 5.8291, 10.2450, 3.5904, 74.1013),
('Mani', 13.060, 86.9400, 6.58, 14.9601, 33.7550, 12.0448, 53.3551),
('Cascarilla de mani', 14.570, 85.4300, 4.35, 10.8785, 72.7852, 10.277, 59.9245),
('Yuca', 9.5050, 90.4950, 3.71, 3.9509, 5.6839, 0.6165, 82.2176),
('Soya', 16.7783, 83.2217, 5.3495, 36.0316, 59.0432, 147701, 27.0705),
('Coquito', 14.370, 85.6300, 3.205, 16.1633, 63.4250, 5.3552, 60.9065),
('Semolina', 18.045,81.9550, 10.715, 13.4933, 25.8250, 0.8120, 56.9347);

INSERT INTO [Aumento de 1Kg por día] VALUES
	(500, 2.5, 11.31, 15.65, 26.97, 2.16, 401.8, 206.4, 608.2, 49, 51, 845),
    (510, 2.5, 11.58, 15.89, 27.37, 2.14, 410.5, 206.3, 617.4, 48, 52, 853),
    (520, 2.5, 11.62, 16.12, 27.77, 2.14, 413.8, 206.2, 620.0, 48, 53, 869),
    (530, 2.5, 11.65, 16.35, 28.17, 2.13, 419.7, 206.2, 626.8, 47, 53, 881),
    (540, 2.5, 11.91, 16.58, 28.57, 2.12, 426.5, 206.2, 632.6, 47, 53, 892),
    (550, 2.5, 12.15, 16.81, 28.97, 2.11, 431.6, 206.4, 637.8, 46, 53, 903),
    (560, 2.5, 12.29, 17.04, 29.36, 2.10, 438.1, 206.6, 644.3, 45, 54, 904),
    (570, 2.5, 12.48, 17.27, 29.75, 2.09, 443.3, 206.4, 649.8, 45, 55, 903),
    (580, 2.5, 12.67, 17.50, 30.14, 2.08, 449.6, 207.4, 656.2, 45, 56, 915),
    (590, 2.5, 12.81, 17.72, 30.53, 2.07, 454.9, 207.4, 662.0, 44, 56, 928),
    (600, 2.5, 12.96, 17.95, 30.92, 2.06, 460.5, 207.6, 667.9, 43, 57, 936),
    (610, 2.5, 13.13, 18.17, 31.31, 2.05, 466.4, 207.8, 674.2, 43, 57, 944),
    (620, 2.5, 13.29, 18.40, 31.69, 2.04, 471.3, 208.3, 679.6, 42, 58, 953),
    (630, 2.5, 13.46, 18.62, 32.07, 2.04, 477.3, 208.4, 686.2, 42, 58, 964),
    (640, 2.5, 13.62, 18.85, 32.45, 2.03, 483.2, 208.8, 693.4, 42, 58, 975),
    (650, 2.5, 13.77, 19.08, 32.83, 2.02, 489.2, 209.9, 699.1, 42, 58, 979),
    (660, 2.5, 13.94, 19.30, 33.21, 2.01, 494.9, 210.6, 704.7, 41, 59, 987),
    (670, 2.5, 14.09, 19.53, 33.59, 2.01, 500.4, 211.3, 711.3, 41, 59, 992),
    (680, 2.5, 14.24, 19.71, 33.96, 2.00, 506.0, 211.3, 718.1, 41, 60, 997),
    (690, 2.5, 14.41, 19.94, 34.34, 1.99, 511.6, 212.9, 723.6, 40, 60, 1001),
    (700, 2.5, 14.56, 20.13, 34.71, 1.98, 517.7, 213.6, 730.9, 40, 60, 1015),
    (710, 2.5, 14.72, 20.36, 35.08, 1.97, 522.7, 214.7, 736.3, 40, 61, 1024),
    (720, 2.5, 14.87, 20.58, 35.45, 1.97, 528.2, 215.7, 743.9, 39, 61, 1033),
    (730, 2.5, 15.03, 20.81, 35.81, 1.96, 533.9, 216.7, 750.6, 39, 61, 1041),
    (740, 2.5, 15.18, 21.01, 36.19, 1.96, 539.1, 217.9, 757.0, 39, 61, 1051),
    (750, 2.5, 15.33, 21.23, 36.56, 1.95, 544.4, 218.7, 763.6, 38, 62, 1060),
    (760, 2.5, 15.49, 21.43, 36.92, 1.94, 550.0, 220.4, 770.2, 38, 62, 1078),
    (770, 2.5, 15.64, 21.64, 37.29, 1.94, 555.0, 221.0, 776.9, 38, 62, 1086),
    (780, 2.5, 15.79, 21.85, 37.64, 1.93, 560.9, 222.8, 783.6, 38, 62, 1098),
    (790, 2.5, 15.94, 22.06, 38.01, 1.92, 566.2, 224.4, 790.4, 38, 62, 1098);

Create proc Sugerencias
 @BODY nvarchar(250)
as
Exec msdb.dbo.sp_send_dbmail
@Profile_name = 'ADMIN',
@Recipients = 'VAKitasDiBo@gmail.com',
@Subject = 'Sugerencias',
@Body =@BODY

exec Sugerencias


