select * from RSS_Goster

create view RSS_Goster
as
select
(select Title title, Notes description, BirthDate pubDate, PhotoPath link from Employees item where Title is not null for xml auto, elements, root('channel')) as sonuc


