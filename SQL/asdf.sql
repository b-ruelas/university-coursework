select f.FFirstName + ' ' + f.FLastName as FighterName, fg.Name as GYM
from fighter f 
join Fighter_Gym as fg on f.FGID = fg.FGID




SELECT *
FROM FightEvent
WHERE FDate >= GETDATE();

select * 
from FightEvent


select count(*) as totalfighters
from Fighter


select 
f1.FFirstName + ' '+ f1.FLastName +' ' + f1.FNickName as Fighter_1,
f2.FFirstName + ' '+ f2.FLastName +' ' + f2.FNickName as Fighter_2
from Fight ft
join Fighter f1 on ft.FID_1 = f1.FID
join Fighter f2 on ft.FID_2 = f2.FID


select avg(f.FAge)
from fighter f

select wc.WeightClass, count(*) as Fightercount
from Fighter f
join WeightClass as wc on f.WCID = wc.WCID
group by wc.WeightClass

select 
f.FFirstName, 
f.FLastName, 
fr.Win, 
fr.Losses, 
(fr.Win * 100/ (fr.Win + fr.Losses)) as WinPercenrtage
from Fighter f
join Fighter_Record as fr on f.FRID = fr.FRID


select 
f.FFirstName, 
f.FLastName
from Fighter f 
join Fighter_Record as fr on f.FRID = fr.FRID
where fr.Win > (select avg(win) from Fighter_Record)

insert into Fighter ( FFirstName, FLastName, FAge, FNickName, FGID, WCID, TID, FRID) 
values
('Josh','Jacobson', 27, 'The mower', 3, 3, 1, 16)


update Fighter_Record
set Win= win+1
where frid = 1

delete from FightEvent
where FEID = 8 





CREATE TABLE FightEvent (
    FEID INT PRIMARY KEY IDENTITY,
    FName VARCHAR(100),
    FCountry VARCHAR(50),
    FDate DATE
);

CREATE TABLE FighterGym (
    FGID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100)
);

CREATE TABLE WeightClass (
    WCID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(50)
);

CREATE TABLE FighterRecord (
    FRID INT PRIMARY KEY IDENTITY,
    Wins INT,
    Losses INT
);

CREATE TABLE Titles (
    TID INT PRIMARY KEY IDENTITY,
    TitleName VARCHAR(100)
);

CREATE TABLE Fighter (
    FID INT PRIMARY KEY IDENTITY,
    FFirstName VARCHAR(50),
    FLastName VARCHAR(50),
    FAge INT,
    FNickName VARCHAR(50),
    FCountry VARCHAR(50),
    FGID INT,
    WCID INT,
    TID INT,
    FRID INT,
    FOREIGN KEY (FGID) REFERENCES FighterGym(FGID),
    FOREIGN KEY (WCID) REFERENCES WeightClass(WCID),
    FOREIGN KEY (TID) REFERENCES Titles(TID),
    FOREIGN KEY (FRID) REFERENCES FighterRecord(FRID)
);

CREATE TABLE Fight (
    FightID INT PRIMARY KEY IDENTITY,
    FID1 INT,
    FID2 INT,
    WCID INT,
    Rounds INT,
    FEID INT,
    FOREIGN KEY (FID1) REFERENCES Fighter(FID),
    FOREIGN KEY (FID2) REFERENCES Fighter(FID),
    FOREIGN KEY (WCID) REFERENCES WeightClass(WCID),
    FOREIGN KEY (FEID) REFERENCES FightEvent(FEID)
);

CREATE TABLE FightResult (
    ResultID INT PRIMARY KEY IDENTITY,
    FightID INT,
    WinnerID INT,
    LoserID INT,
    FOREIGN KEY (FightID) REFERENCES Fight(FightID),
    FOREIGN KEY (WinnerID) REFERENCES Fighter(FID),
    FOREIGN KEY (LoserID) REFERENCES Fighter(FID)
);

CREATE TABLE FightStats (
    FSID INT PRIMARY KEY IDENTITY,
    FEID INT,
    FID INT,
    ResultID INT,
    StrikesLanded INT,
    Takedowns INT,
    Submissions INT,
    FOREIGN KEY (FID) REFERENCES Fighter(FID),
    FOREIGN KEY (FEID) REFERENCES FightEvent(FEID),
    FOREIGN KEY (ResultID) REFERENCES FightResult(ResultID)
);




CREATE VIEW FighterOverview AS
SELECT 
    F.FID,
    F.FFirstName,
    F.FLastName,
    F.FNickName,
    G.Name AS Gym,
    WC.WeightClass AS WeightClass,
    FR.Win,
    FR.Losses
FROM Fighter F
JOIN Fighter_Gym G ON F.FGID = G.FGID
JOIN WeightClass WC ON F.WCID = WC.WCID
JOIN Fighter_Record FR ON F.FRID = FR.FRID;


SELECT * FROM FighterOverview


CREATE VIEW FightResultsView AS
SELECT 
    FR.ResultID,
    FE.FName AS EventName,
    W.FFirstName + ' ' + W.FLastName AS Winner,
    L.FFirstName + ' ' + L.FLastName AS Loser
FROM Fight_Results FR
JOIN FightEvent FE ON FR.FightID = FE.FEID
JOIN Fighter W ON FR.FID_Winner = W.FID
JOIN Fighter L ON FR.FID_Loser = L.FID;


select * from FightResultsView


CREATE PROCEDURE AddFightEventResults
    @FightID INT,
    @WinnerID INT,
    @LoserID INT,
	@FEID INT
AS
BEGIN

    INSERT INTO Fight_Results(FightID, FID_Winner, FID_Loser, FEID)
    VALUES (@FightID, @WinnerID, @LoserID, @FEID);

    UPDATE Fighter_Record
    SET Win = Win + 1
    WHERE FRID = (SELECT FRID FROM Fighter WHERE FID = @WinnerID);

 
    UPDATE Fighter_Record
    SET Losses = Losses + 1
    WHERE FRID = (SELECT FRID FROM Fighter WHERE FID = @LoserID);
END

EXEC AddFightEventResults 1, 8, 10, 5;


CREATE TRIGGER trg_FightResultSimple
ON Fight_Results
AFTER INSERT
AS
BEGIN
    -- update winner
    UPDATE Fighter_Record
    SET Win = Win + 1
    WHERE FRID = (SELECT FID_Winner FROM inserted);

    -- update loser
    UPDATE Fighter_Record
    SET Losses = Losses + 1
    WHERE FRID = (SELECT FID_Loser FROM inserted);
END;