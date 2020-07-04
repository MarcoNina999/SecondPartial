CREATE TABLE buy (
    id_buy           INTEGER NOT NULL,
    date_buy         DATE,
    total_buy        VARCHAR2(30),
    observation_buy  VARCHAR2(50),
    state_buy        VARCHAR2(50)
);

ALTER TABLE buy ADD CONSTRAINT buy_pk PRIMARY KEY ( id_buy );

CREATE TABLE buy_detail (
    id_bd            INTEGER NOT NULL,
    amount_bd        VARCHAR2(30),
    price            VARCHAR2(30),
    sub_total        VARCHAR2(30),
    product_id_prod  INTEGER NOT NULL,
    buy_id_buy       INTEGER NOT NULL
);

ALTER TABLE buy_detail ADD CONSTRAINT buy_detail_pk PRIMARY KEY ( id_bd );

CREATE TABLE paydetail (
    id_pd       INTEGER NOT NULL,
    date_pd     DATE,
    pay_pd      VARCHAR2(30),
    bank_pd     VARCHAR2(50),
    buy_id_buy  INTEGER NOT NULL
);

ALTER TABLE paydetail ADD CONSTRAINT paydetail_pk PRIMARY KEY ( id_pd );

CREATE TABLE product (
    id_prod           INTEGER NOT NULL,
    nom_prod          VARCHAR2(30),
    desc_prod         VARCHAR2(50),
    provider_id_prov  INTEGER NOT NULL
);

ALTER TABLE product ADD CONSTRAINT product_pk PRIMARY KEY ( id_prod );

CREATE TABLE provider (
    id_prov       INTEGER NOT NULL,
    name_prov     VARCHAR2(30),
    country_prov  VARCHAR2(30),
    swift_prov    VARCHAR2(30)
);

ALTER TABLE provider ADD CONSTRAINT provider_pk PRIMARY KEY ( id_prov );

ALTER TABLE buy_detail
    ADD CONSTRAINT buy_detail_buy_fk FOREIGN KEY ( buy_id_buy )
        REFERENCES buy ( id_buy );

ALTER TABLE buy_detail
    ADD CONSTRAINT buy_detail_product_fk FOREIGN KEY ( product_id_prod )
        REFERENCES product ( id_prod );

ALTER TABLE paydetail
    ADD CONSTRAINT paydetail_buy_fk FOREIGN KEY ( buy_id_buy )
        REFERENCES buy ( id_buy );

ALTER TABLE product
    ADD CONSTRAINT product_provider_fk FOREIGN KEY ( provider_id_prov )
        REFERENCES provider ( id_prov );
