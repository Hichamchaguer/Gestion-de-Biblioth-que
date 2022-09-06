drop database projetliv
go

use projetliv
go

create table livre
(
code int primary key,
titre varchar(60),
auteur varchar(60),
dateAchat date,
prix money
)
go

 create table users
(
logine varchar(20),
motdepasse varchar(20),
)
go

  