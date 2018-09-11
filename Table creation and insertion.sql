CREATE TABLE States(
StateId int Identity(1,1),
StateName varchar (50),
PRIMARY KEY (StateId)
);

CREATE TABLE City(
CityId int Identity(1,1),
CityName varchar (50),
StateId int
PRIMARY KEY (CityId),
FOREIGN KEY(StateId) REFERENCES States(StateId)
);

CREATE TABLE Constituency (
ConstituencyId int Identity(1,1),
ConstituencyName varchar (50),
CityId int
PRIMARY KEY (ConstituencyId),
FOREIGN KEY(CityId) REFERENCES City(CityId)
);

CREATE TABLE WardNo (
WardNumberId int Identity (1,1),
WardNumber varchar(50),
ConstituencyId int
PRIMARY KEY (WardNumberId),
FOREIGN KEY(ConstituencyId) REFERENCES Constituency(ConstituencyId)
);

--Saving in MyDotnetDataBase