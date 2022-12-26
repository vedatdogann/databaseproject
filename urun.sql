--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2022-12-26 21:24:58

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 228 (class 1259 OID 24791)
-- Name: bolge; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bolge (
    bolge_no integer NOT NULL,
    bolge_adi character varying NOT NULL
);


ALTER TABLE public.bolge OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 24748)
-- Name: fatura; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.fatura (
    fatura_no integer NOT NULL,
    faturatarih character varying NOT NULL
);


ALTER TABLE public.fatura OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 24784)
-- Name: il; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.il (
    il_no integer NOT NULL,
    il_adi character varying NOT NULL
);


ALTER TABLE public.il OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 24777)
-- Name: ilce; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ilce (
    ilce_no integer NOT NULL,
    ilce_adi character varying NOT NULL
);


ALTER TABLE public.ilce OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 24734)
-- Name: iletisim; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.iletisim (
    iletisim_id integer NOT NULL,
    telefon integer NOT NULL,
    adres character varying NOT NULL,
    ilce character varying NOT NULL,
    musteriid character varying NOT NULL
);


ALTER TABLE public.iletisim OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 24741)
-- Name: kargofirma; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kargofirma (
    firma_id integer NOT NULL,
    "firma_adı" character varying
);


ALTER TABLE public.kargofirma OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 24689)
-- Name: kategori; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kategori (
    kategoriid integer NOT NULL,
    kategoriad character varying(20)
);


ALTER TABLE public.kategori OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 24727)
-- Name: malzemeler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.malzemeler (
    malzemeler_id integer NOT NULL,
    malzeme_ad character varying NOT NULL
);


ALTER TABLE public.malzemeler OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 24772)
-- Name: musteri_kategori; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.musteri_kategori (
    mkategori_id integer NOT NULL
);


ALTER TABLE public.musteri_kategori OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 24713)
-- Name: musteriler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.musteriler (
    musteriadsoyad character varying,
    musteritelefon integer NOT NULL,
    musterieposta character varying,
    musteriadres character varying
);


ALTER TABLE public.musteriler OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 24767)
-- Name: satis_temsilcisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.satis_temsilcisi (
    temsilci_id integer NOT NULL
);


ALTER TABLE public.satis_temsilcisi OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 24760)
-- Name: siparis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.siparis (
    siparis_id integer NOT NULL,
    siparis_tarihi character varying NOT NULL,
    toplam_tutar integer NOT NULL
);


ALTER TABLE public.siparis OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 24755)
-- Name: siparisurun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.siparisurun (
    siparis_no integer NOT NULL,
    siparis_fiyat integer NOT NULL
);


ALTER TABLE public.siparisurun OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 24720)
-- Name: tedarikci; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tedarikci (
    tedarikci_id integer NOT NULL,
    tedarikci_adi character varying NOT NULL,
    tedarikci_iletisim character varying NOT NULL
);


ALTER TABLE public.tedarikci OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 24684)
-- Name: urunler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.urunler (
    urunid integer NOT NULL,
    urunad character varying(30),
    alisfiyat double precision,
    satisfiyat double precision,
    kategori integer,
    stok integer
);


ALTER TABLE public.urunler OWNER TO postgres;

--
-- TOC entry 3416 (class 0 OID 24791)
-- Dependencies: 228
-- Data for Name: bolge; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.bolge (bolge_no, bolge_adi) FROM stdin;
\.


--
-- TOC entry 3409 (class 0 OID 24748)
-- Dependencies: 221
-- Data for Name: fatura; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.fatura (fatura_no, faturatarih) FROM stdin;
\.


--
-- TOC entry 3415 (class 0 OID 24784)
-- Dependencies: 227
-- Data for Name: il; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.il (il_no, il_adi) FROM stdin;
\.


--
-- TOC entry 3414 (class 0 OID 24777)
-- Dependencies: 226
-- Data for Name: ilce; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ilce (ilce_no, ilce_adi) FROM stdin;
\.


--
-- TOC entry 3407 (class 0 OID 24734)
-- Dependencies: 219
-- Data for Name: iletisim; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.iletisim (iletisim_id, telefon, adres, ilce, musteriid) FROM stdin;
\.


--
-- TOC entry 3408 (class 0 OID 24741)
-- Dependencies: 220
-- Data for Name: kargofirma; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kargofirma (firma_id, "firma_adı") FROM stdin;
\.


--
-- TOC entry 3403 (class 0 OID 24689)
-- Dependencies: 215
-- Data for Name: kategori; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kategori (kategoriid, kategoriad) FROM stdin;
1	Kadin Sirt Canta
2	Erkek Sirt Canta
3	Kadin Laptop Canta
4	Erkek lapto Canta
5	capraz canta
6	sdsf
\.


--
-- TOC entry 3406 (class 0 OID 24727)
-- Dependencies: 218
-- Data for Name: malzemeler; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.malzemeler (malzemeler_id, malzeme_ad) FROM stdin;
\.


--
-- TOC entry 3413 (class 0 OID 24772)
-- Dependencies: 225
-- Data for Name: musteri_kategori; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.musteri_kategori (mkategori_id) FROM stdin;
\.


--
-- TOC entry 3404 (class 0 OID 24713)
-- Dependencies: 216
-- Data for Name: musteriler; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.musteriler (musteriadsoyad, musteritelefon, musterieposta, musteriadres) FROM stdin;
fd	11	dss	dsfsfd
vedat	5	vedat	vedat
\.


--
-- TOC entry 3412 (class 0 OID 24767)
-- Dependencies: 224
-- Data for Name: satis_temsilcisi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.satis_temsilcisi (temsilci_id) FROM stdin;
\.


--
-- TOC entry 3411 (class 0 OID 24760)
-- Dependencies: 223
-- Data for Name: siparis; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.siparis (siparis_id, siparis_tarihi, toplam_tutar) FROM stdin;
\.


--
-- TOC entry 3410 (class 0 OID 24755)
-- Dependencies: 222
-- Data for Name: siparisurun; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.siparisurun (siparis_no, siparis_fiyat) FROM stdin;
\.


--
-- TOC entry 3405 (class 0 OID 24720)
-- Dependencies: 217
-- Data for Name: tedarikci; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tedarikci (tedarikci_id, tedarikci_adi, tedarikci_iletisim) FROM stdin;
\.


--
-- TOC entry 3402 (class 0 OID 24684)
-- Dependencies: 214
-- Data for Name: urunler; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.urunler (urunid, urunad, alisfiyat, satisfiyat, kategori, stok) FROM stdin;
1	Guess	500	1200	1	\N
2	fgdd	424	51464	3	100
3	uyj	2425	727	3	0
\.


--
-- TOC entry 3258 (class 2606 OID 24797)
-- Name: bolge bolge_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bolge
    ADD CONSTRAINT bolge_pkey PRIMARY KEY (bolge_no);


--
-- TOC entry 3244 (class 2606 OID 24754)
-- Name: fatura fatura_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT fatura_pkey PRIMARY KEY (fatura_no);


--
-- TOC entry 3256 (class 2606 OID 24790)
-- Name: il il_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.il
    ADD CONSTRAINT il_pkey PRIMARY KEY (il_no);


--
-- TOC entry 3254 (class 2606 OID 24783)
-- Name: ilce ilce_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilce
    ADD CONSTRAINT ilce_pkey PRIMARY KEY (ilce_no);


--
-- TOC entry 3240 (class 2606 OID 24740)
-- Name: iletisim iletisim_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iletisim
    ADD CONSTRAINT iletisim_pkey PRIMARY KEY (iletisim_id, telefon);


--
-- TOC entry 3242 (class 2606 OID 24747)
-- Name: kargofirma kargofirma_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kargofirma
    ADD CONSTRAINT kargofirma_pkey PRIMARY KEY (firma_id);


--
-- TOC entry 3232 (class 2606 OID 24693)
-- Name: kategori kategori_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (kategoriid);


--
-- TOC entry 3238 (class 2606 OID 24733)
-- Name: malzemeler malzemeler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.malzemeler
    ADD CONSTRAINT malzemeler_pkey PRIMARY KEY (malzemeler_id);


--
-- TOC entry 3252 (class 2606 OID 24776)
-- Name: musteri_kategori musteri_kategori_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteri_kategori
    ADD CONSTRAINT musteri_kategori_pkey PRIMARY KEY (mkategori_id);


--
-- TOC entry 3234 (class 2606 OID 24719)
-- Name: musteriler musteriler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT musteriler_pkey PRIMARY KEY (musteritelefon);


--
-- TOC entry 3250 (class 2606 OID 24771)
-- Name: satis_temsilcisi satis_temsilcisi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.satis_temsilcisi
    ADD CONSTRAINT satis_temsilcisi_pkey PRIMARY KEY (temsilci_id);


--
-- TOC entry 3248 (class 2606 OID 24766)
-- Name: siparis siparis_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT siparis_pkey PRIMARY KEY (siparis_id);


--
-- TOC entry 3246 (class 2606 OID 24759)
-- Name: siparisurun siparisurun_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparisurun
    ADD CONSTRAINT siparisurun_pkey PRIMARY KEY (siparis_no);


--
-- TOC entry 3236 (class 2606 OID 24726)
-- Name: tedarikci tedarikci_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedarikci
    ADD CONSTRAINT tedarikci_pkey PRIMARY KEY (tedarikci_id);


--
-- TOC entry 3230 (class 2606 OID 24688)
-- Name: urunler urunler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT urunler_pkey PRIMARY KEY (urunid);


--
-- TOC entry 3228 (class 1259 OID 24699)
-- Name: fki_urunler_foreign; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_urunler_foreign ON public.urunler USING btree (kategori);


--
-- TOC entry 3259 (class 2606 OID 24694)
-- Name: urunler urunler_foreign; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunler
    ADD CONSTRAINT urunler_foreign FOREIGN KEY (kategori) REFERENCES public.kategori(kategoriid) NOT VALID;


-- Completed on 2022-12-26 21:24:59

--
-- PostgreSQL database dump complete
--

