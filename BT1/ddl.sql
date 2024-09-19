drop table DongVat;
create table DongVat (
                         id text PRIMARY KEY NOT NULL,
                         type integer
);

drop table LichSuLaySua;
create table LichSuLaySua (
                              id integer PRIMARY KEY autoincrement NOT NULL ,
                              so_lit_sua integer,
                              ngay_lay TIMESTAMP DEFAULT CURRENT_TIMESTAMP
)

