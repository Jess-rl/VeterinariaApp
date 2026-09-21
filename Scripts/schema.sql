--
-- PostgreSQL database dump
--

\restrict YBBcPJF1YXRCDBbNZLMEDNUV24una73Dh78k5YYJmOCx0FbTuyag2wlmB0l3rFu

-- Dumped from database version 18.4 (Debian 18.4-1.pgdg13+1)
-- Dumped by pg_dump version 18.4

-- Started on 2026-09-20 17:15:24

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
-- TOC entry 225 (class 1259 OID 16429)
-- Name: cita; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cita (
    id_cita integer NOT NULL,
    id_mascota integer NOT NULL,
    id_empleado integer NOT NULL,
    fecha_hora timestamp without time zone NOT NULL,
    motivo character varying(255) NOT NULL,
    estado character varying(20) DEFAULT 'PENDIENTE'::character varying,
    CONSTRAINT cita_estado_check CHECK (((estado)::text = ANY ((ARRAY['PENDIENTE'::character varying, 'ATENDIDA'::character varying, 'CANCELADA'::character varying])::text[])))
);


ALTER TABLE public.cita OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 16428)
-- Name: cita_id_cita_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.cita_id_cita_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.cita_id_cita_seq OWNER TO postgres;

--
-- TOC entry 3484 (class 0 OID 0)
-- Dependencies: 224
-- Name: cita_id_cita_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.cita_id_cita_seq OWNED BY public.cita.id_cita;


--
-- TOC entry 221 (class 1259 OID 16401)
-- Name: cliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cliente (
    cedula character varying(15) NOT NULL,
    nombres character varying(100) NOT NULL,
    apellidos character varying(100) NOT NULL,
    telefono character varying(20),
    direccion text
);


ALTER TABLE public.cliente OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16390)
-- Name: empleado; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.empleado (
    id_empleado integer NOT NULL,
    nombre character varying(100) NOT NULL,
    rol character varying(20) NOT NULL,
    clave_pin character varying(10) NOT NULL,
    CONSTRAINT empleado_rol_check CHECK (((rol)::text = ANY ((ARRAY['ADMIN'::character varying, 'PERSONAL'::character varying])::text[])))
);


ALTER TABLE public.empleado OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16389)
-- Name: empleado_id_empleado_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.empleado_id_empleado_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.empleado_id_empleado_seq OWNER TO postgres;

--
-- TOC entry 3485 (class 0 OID 0)
-- Dependencies: 219
-- Name: empleado_id_empleado_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.empleado_id_empleado_seq OWNED BY public.empleado.id_empleado;


--
-- TOC entry 227 (class 1259 OID 16453)
-- Name: historial_clinico; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.historial_clinico (
    id_historial integer NOT NULL,
    id_mascota integer NOT NULL,
    id_empleado integer NOT NULL,
    fecha timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    peso_actual numeric(5,2),
    diagnostico text NOT NULL,
    tratamiento text NOT NULL
);


ALTER TABLE public.historial_clinico OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16452)
-- Name: historial_clinico_id_historial_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.historial_clinico_id_historial_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.historial_clinico_id_historial_seq OWNER TO postgres;

--
-- TOC entry 3486 (class 0 OID 0)
-- Dependencies: 226
-- Name: historial_clinico_id_historial_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.historial_clinico_id_historial_seq OWNED BY public.historial_clinico.id_historial;


--
-- TOC entry 223 (class 1259 OID 16412)
-- Name: mascota; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.mascota (
    id_mascota integer NOT NULL,
    cedula_dueno character varying(15) NOT NULL,
    nombre character varying(50) NOT NULL,
    especie character varying(50) NOT NULL,
    raza character varying(50),
    sexo character(1),
    fecha_nacimiento date,
    CONSTRAINT mascota_sexo_check CHECK ((sexo = ANY (ARRAY['M'::bpchar, 'H'::bpchar])))
);


ALTER TABLE public.mascota OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 16411)
-- Name: mascota_id_mascota_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.mascota_id_mascota_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.mascota_id_mascota_seq OWNER TO postgres;

--
-- TOC entry 3487 (class 0 OID 0)
-- Dependencies: 222
-- Name: mascota_id_mascota_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.mascota_id_mascota_seq OWNED BY public.mascota.id_mascota;


--
-- TOC entry 3310 (class 2604 OID 16432)
-- Name: cita id_cita; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cita ALTER COLUMN id_cita SET DEFAULT nextval('public.cita_id_cita_seq'::regclass);


--
-- TOC entry 3308 (class 2604 OID 16393)
-- Name: empleado id_empleado; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.empleado ALTER COLUMN id_empleado SET DEFAULT nextval('public.empleado_id_empleado_seq'::regclass);


--
-- TOC entry 3312 (class 2604 OID 16456)
-- Name: historial_clinico id_historial; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historial_clinico ALTER COLUMN id_historial SET DEFAULT nextval('public.historial_clinico_id_historial_seq'::regclass);


--
-- TOC entry 3309 (class 2604 OID 16415)
-- Name: mascota id_mascota; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.mascota ALTER COLUMN id_mascota SET DEFAULT nextval('public.mascota_id_mascota_seq'::regclass);


--
-- TOC entry 3324 (class 2606 OID 16441)
-- Name: cita cita_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cita
    ADD CONSTRAINT cita_pkey PRIMARY KEY (id_cita);


--
-- TOC entry 3320 (class 2606 OID 16410)
-- Name: cliente cliente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (cedula);


--
-- TOC entry 3318 (class 2606 OID 16400)
-- Name: empleado empleado_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_pkey PRIMARY KEY (id_empleado);


--
-- TOC entry 3326 (class 2606 OID 16466)
-- Name: historial_clinico historial_clinico_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historial_clinico
    ADD CONSTRAINT historial_clinico_pkey PRIMARY KEY (id_historial);


--
-- TOC entry 3322 (class 2606 OID 16422)
-- Name: mascota mascota_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.mascota
    ADD CONSTRAINT mascota_pkey PRIMARY KEY (id_mascota);


--
-- TOC entry 3328 (class 2606 OID 16447)
-- Name: cita cita_id_empleado_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cita
    ADD CONSTRAINT cita_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleado(id_empleado);


--
-- TOC entry 3329 (class 2606 OID 16442)
-- Name: cita cita_id_mascota_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cita
    ADD CONSTRAINT cita_id_mascota_fkey FOREIGN KEY (id_mascota) REFERENCES public.mascota(id_mascota) ON DELETE CASCADE;


--
-- TOC entry 3330 (class 2606 OID 16472)
-- Name: historial_clinico historial_clinico_id_empleado_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historial_clinico
    ADD CONSTRAINT historial_clinico_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleado(id_empleado);


--
-- TOC entry 3331 (class 2606 OID 16467)
-- Name: historial_clinico historial_clinico_id_mascota_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historial_clinico
    ADD CONSTRAINT historial_clinico_id_mascota_fkey FOREIGN KEY (id_mascota) REFERENCES public.mascota(id_mascota) ON DELETE CASCADE;


--
-- TOC entry 3327 (class 2606 OID 16423)
-- Name: mascota mascota_cedula_dueno_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.mascota
    ADD CONSTRAINT mascota_cedula_dueno_fkey FOREIGN KEY (cedula_dueno) REFERENCES public.cliente(cedula) ON DELETE CASCADE;


-- Completed on 2026-09-20 17:15:24

--
-- PostgreSQL database dump complete
--

\unrestrict YBBcPJF1YXRCDBbNZLMEDNUV24una73Dh78k5YYJmOCx0FbTuyag2wlmB0l3rFu

