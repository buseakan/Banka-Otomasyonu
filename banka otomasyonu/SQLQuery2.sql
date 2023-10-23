/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[adSoyad]
      ,[telefonNumarasi]
      ,[adres]
      ,[cinsiyet]
      ,[email]
      ,[musteriTipi]
      ,[bakiye]
  FROM [banka_otomasyonu].[dbo].[müsteriler]

 INSERT INTO müsteriler
 VALUES 
(3856, 'EbrarG', 546574936, 'İstanbul','kadın', 'ebrarg@email.com','bireysel',569874 ), 
(8747, 'ArzuD', 505898999, 'Ankara','kadın', 'arzud@email.com','ticari',674529 ), 
(5367, 'GökçeN', 505100332, 'Edirne','kadın', 'gökcen@email.com','ticari',823744 ), 
(9787, 'RıdvanS', 535909458, 'Trabzon','erkek', 'ridvans@email.com','bireysel',222390), 
(2435, 'sibelz', 505238114, 'İzmir','kadın', 'sibelz@email.com','bireysel',909939 ), 
(8645, 'CanK', 545574936, 'Malatya','erkek', 'cank@email.com','ticari',239392 ), 
(8966, 'SarpD', 546574961, 'Çanakkale','erkek', 'sarpd@email.com','bireysel',122399 ), 
(3468, 'BerkeT', 505783514, 'Aydın','erkek', 'berket@email.com','ticari',579434 ), 
(8467, 'FerhatL', 537398764, 'Ankara','male', 'ferhatL@email.com','bireysel',703974 ), 
(6846, 'ElisaE', 539574061, 'Bursa','kadın', 'elisaE@email.com','bireysel',778481 ), 
(1233, 'MertA', 537574190, 'İstanbul','erkek', 'mertA@email.com','ticari',848432 ), 
(2124, 'AydınY', 539228658, 'İzmir','erkek', 'aydiny@email.com','ticari',355326);