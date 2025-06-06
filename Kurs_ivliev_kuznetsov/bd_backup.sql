--
-- PostgreSQL database dump
--

-- Dumped from database version 17.4
-- Dumped by pg_dump version 17.4

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
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
-- Name: administrators; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.administrators (
    administrator_id integer NOT NULL,
    country_id integer,
    name character varying(100),
    password character varying(100),
    email character varying(100),
    registrationdate date
);


ALTER TABLE public.administrators OWNER TO postgres;

--
-- Name: administrators_administrator_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.administrators ALTER COLUMN administrator_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.administrators_administrator_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: applications; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.applications (
    application_id integer NOT NULL,
    ischecked boolean,
    createddate date,
    developer_id integer,
    administrator_id integer,
    reason text
);


ALTER TABLE public.applications OWNER TO postgres;

--
-- Name: applications_application_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.applications ALTER COLUMN application_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.applications_application_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: countries; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.countries (
    country_id integer NOT NULL,
    name character varying(100),
    iso_code character(3)
);


ALTER TABLE public.countries OWNER TO postgres;

--
-- Name: countries_country_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.countries ALTER COLUMN country_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.countries_country_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: developers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.developers (
    developer_id integer NOT NULL,
    country_id integer,
    name character varying(100),
    email character varying(100),
    password character varying(100),
    registrationdate date
);


ALTER TABLE public.developers OWNER TO postgres;

--
-- Name: developers_developer_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.developers ALTER COLUMN developer_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.developers_developer_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: gamerlibrary; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.gamerlibrary (
    gamerlibrary_id integer NOT NULL,
    game_id integer,
    addeddate date,
    gamer_id integer,
    hoursplayed integer
);


ALTER TABLE public.gamerlibrary OWNER TO postgres;

--
-- Name: gamerlibrary_gamerlibrary_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.gamerlibrary ALTER COLUMN gamerlibrary_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.gamerlibrary_gamerlibrary_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: gamers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.gamers (
    gamer_id integer NOT NULL,
    country_id integer,
    name character varying(100),
    email character varying(100),
    password character varying(100),
    registrationdate date,
    balance numeric(10,2),
    banned boolean DEFAULT false
);


ALTER TABLE public.gamers OWNER TO postgres;

--
-- Name: gamers_gamer_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.gamers ALTER COLUMN gamer_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.gamers_gamer_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: games; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.games (
    game_id integer NOT NULL,
    developer_id integer,
    name character varying(100),
    size numeric(10,2),
    genre character varying(50),
    price numeric(10,2)
);


ALTER TABLE public.games OWNER TO postgres;

--
-- Name: games_game_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.games ALTER COLUMN game_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.games_game_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: reviews; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.reviews (
    review_id integer NOT NULL,
    game_id integer,
    gamer_id integer,
    rating integer,
    comment text,
    reviewdate date,
    CONSTRAINT reviews_rating_check CHECK (((rating >= 1) AND (rating <= 10)))
);


ALTER TABLE public.reviews OWNER TO postgres;

--
-- Name: reviews_review_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.reviews ALTER COLUMN review_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.reviews_review_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Data for Name: administrators; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.administrators (administrator_id, country_id, name, password, email, registrationdate) FROM stdin;
1	1	AdminUSA	adminpass1	admin1@site.com	2021-05-10
2	2	AdminJP	adminpass2	admin2@site.com	2022-07-18
3	3	AdminDE	adminpass3	admin3@site.com	2020-11-03
4	4	AdminFR	adminpass4	admin4@site.com	2023-01-21
5	5	AdminCA	adminpass5	admin5@site.com	2022-03-30
\.


--
-- Data for Name: applications; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.applications (application_id, ischecked, createddate, developer_id, administrator_id, reason) FROM stdin;
1	t	2023-01-01	1	1	Approve
2	t	2023-02-15	2	1	Virus
3	f	2024-04-01	3	1	
4	f	2024-10-20	4	1	
6	f	2025-05-08	5	3	
5	f	2022-12-12	5	1	
\.


--
-- Data for Name: countries; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.countries (country_id, name, iso_code) FROM stdin;
1	United States	USA
2	Japan	JPN
3	Germany	DEU
4	France	FRA
5	Canada	CAN
\.


--
-- Data for Name: developers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.developers (developer_id, country_id, name, email, password, registrationdate) FROM stdin;
1	1	Epic Games	contact@epic.com	epic123	2015-06-01
2	2	Nintendo	support@nintendo.jp	nintendo456	2010-03-12
3	3	Blue Byte	info@bluebyte.de	bluebyte789	2018-09-25
4	4	Ubisoft Paris	ubiparis@ubisoft.fr	ubi456	2012-11-30
5	5	BioWare	contact@bioware.ca	bioware2023	2014-01-15
\.


--
-- Data for Name: gamerlibrary; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.gamerlibrary (gamerlibrary_id, game_id, addeddate, gamer_id, hoursplayed) FROM stdin;
1	1	2023-06-01	1	120
2	2	2023-09-10	2	45
3	3	2023-12-20	3	30
4	4	2024-01-15	4	65
5	4	2024-03-22	5	90
6	1	2024-03-22	5	222
9	1	2025-05-08	7	0
10	2	2025-05-08	7	0
11	1	2025-05-08	7	0
12	3	2025-05-08	8	0
13	1	2025-05-08	10	0
14	1	2025-05-08	11	0
\.


--
-- Data for Name: gamers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.gamers (gamer_id, country_id, name, email, password, registrationdate, balance, banned) FROM stdin;
1	1	JohnDoe	john@example.com	pass123	2023-05-10	100.00	f
2	2	YukiChan	yuki@example.jp	sakura456	2022-08-21	50.00	f
3	3	HansM	hans@example.de	bier789	2021-01-03	20.00	f
4	4	ClaireF	claire@example.fr	bonjour321	2024-02-14	75.00	f
7	3	flex	flex@mail.boba	123	2025-05-08	-59.99	f
8	3	a	a	a	2025-05-08	-29.99	f
9	4	a	a	a	2025-05-08	0.00	f
10	4	s	s	s	2025-05-08	0.00	f
11	3	╨║	╨║	╨║	2025-05-08	0.00	f
5	1	Den	den@mail.ru	123	2023-09-07	90.01	f
\.


--
-- Data for Name: games; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.games (game_id, developer_id, name, size, genre, price) FROM stdin;
1	1	Fortnite	32.50	Battle Royale	0.00
2	2	Zelda: Breath of the Wild	13.20	Adventure	59.99
3	3	The Settlers	4.80	Strategy	29.99
4	4	Assassins Creed	45.70	Action	49.99
5	5	Mass Effect	31.00	RPG	39.99
\.


--
-- Data for Name: reviews; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.reviews (review_id, game_id, gamer_id, rating, comment, reviewdate) FROM stdin;
1	1	1	9	Addictive and fun!	2023-07-15
2	2	2	10	Masterpiece.	2023-10-05
3	3	3	7	Classic strategy, but a bit dated.	2023-12-25
4	4	4	8	Great story and mechanics.	2024-02-01
5	5	5	9	Amazing RPG experience!	2024-04-10
10	4	5	6	╨Т╨░╤Й╨╡ ╨║╤А╤Г╤В╨░! ╨п ╤В╨░╨║╨╛╨╣ ╤Б╨║╤А╤Л╤В╨╜╤Л╨╣ 	2025-05-08
14	1	5	10	╨Р╨▒╨░╨╗╨┤╨╡╤В╤М ╤П ╤В╨░╨║╨╛╨╣ ╨║╤А╤Г╤В╨╛╨╣ ╤Д╨░╤А╤В╨╜╨░╨╣╤В╨╡╤А	2025-05-08
\.


--
-- Name: administrators_administrator_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.administrators_administrator_id_seq', 5, true);


--
-- Name: applications_application_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.applications_application_id_seq', 6, true);


--
-- Name: countries_country_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.countries_country_id_seq', 5, true);


--
-- Name: developers_developer_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.developers_developer_id_seq', 5, true);


--
-- Name: gamerlibrary_gamerlibrary_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.gamerlibrary_gamerlibrary_id_seq', 14, true);


--
-- Name: gamers_gamer_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.gamers_gamer_id_seq', 11, true);


--
-- Name: games_game_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.games_game_id_seq', 5, true);


--
-- Name: reviews_review_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.reviews_review_id_seq', 14, true);


--
-- Name: administrators administrators_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.administrators
    ADD CONSTRAINT administrators_pkey PRIMARY KEY (administrator_id);


--
-- Name: applications applications_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.applications
    ADD CONSTRAINT applications_pkey PRIMARY KEY (application_id);


--
-- Name: countries countries_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.countries
    ADD CONSTRAINT countries_pkey PRIMARY KEY (country_id);


--
-- Name: developers developers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.developers
    ADD CONSTRAINT developers_pkey PRIMARY KEY (developer_id);


--
-- Name: gamerlibrary gamerlibrary_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gamerlibrary
    ADD CONSTRAINT gamerlibrary_pkey PRIMARY KEY (gamerlibrary_id);


--
-- Name: gamers gamers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gamers
    ADD CONSTRAINT gamers_pkey PRIMARY KEY (gamer_id);


--
-- Name: games games_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.games
    ADD CONSTRAINT games_pkey PRIMARY KEY (game_id);


--
-- Name: reviews reviews_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reviews
    ADD CONSTRAINT reviews_pkey PRIMARY KEY (review_id);


--
-- Name: administrators administrators_country_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.administrators
    ADD CONSTRAINT administrators_country_id_fkey FOREIGN KEY (country_id) REFERENCES public.countries(country_id);


--
-- Name: applications applications_developer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.applications
    ADD CONSTRAINT applications_developer_id_fkey FOREIGN KEY (developer_id) REFERENCES public.developers(developer_id);


--
-- Name: developers developers_country_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.developers
    ADD CONSTRAINT developers_country_id_fkey FOREIGN KEY (country_id) REFERENCES public.countries(country_id);


--
-- Name: applications fk_applications_administrator; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.applications
    ADD CONSTRAINT fk_applications_administrator FOREIGN KEY (administrator_id) REFERENCES public.administrators(administrator_id);


--
-- Name: gamerlibrary gamerlibrary_game_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gamerlibrary
    ADD CONSTRAINT gamerlibrary_game_id_fkey FOREIGN KEY (game_id) REFERENCES public.games(game_id);


--
-- Name: gamerlibrary gamerlibrary_gamer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gamerlibrary
    ADD CONSTRAINT gamerlibrary_gamer_id_fkey FOREIGN KEY (gamer_id) REFERENCES public.gamers(gamer_id);


--
-- Name: gamers gamers_country_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gamers
    ADD CONSTRAINT gamers_country_id_fkey FOREIGN KEY (country_id) REFERENCES public.countries(country_id);


--
-- Name: games games_developer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.games
    ADD CONSTRAINT games_developer_id_fkey FOREIGN KEY (developer_id) REFERENCES public.developers(developer_id);


--
-- Name: reviews reviews_game_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reviews
    ADD CONSTRAINT reviews_game_id_fkey FOREIGN KEY (game_id) REFERENCES public.games(game_id);


--
-- Name: reviews reviews_gamer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.reviews
    ADD CONSTRAINT reviews_gamer_id_fkey FOREIGN KEY (gamer_id) REFERENCES public.gamers(gamer_id);


--
-- PostgreSQL database dump complete
--

