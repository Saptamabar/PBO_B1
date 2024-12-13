PGDMP  	    0                |            Patungan    16.2    16.2 9    -           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            .           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            /           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            0           1262    26331    Patungan    DATABASE     �   CREATE DATABASE "Patungan" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "Patungan";
                postgres    false            �            1259    26333    akun    TABLE     �  CREATE TABLE public.akun (
    akun_id integer NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(50) NOT NULL,
    nama character varying(50) NOT NULL,
    jabatan character varying(50) NOT NULL,
    foto_profile text,
    no_hp character varying(50) NOT NULL,
    email character varying(100) DEFAULT 'contoh@email.com'::character varying,
    dihapus boolean DEFAULT false NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false            �            1259    26332    akun_akun_id_seq    SEQUENCE     �   CREATE SEQUENCE public.akun_akun_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.akun_akun_id_seq;
       public          postgres    false    216            1           0    0    akun_akun_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.akun_akun_id_seq OWNED BY public.akun.akun_id;
          public          postgres    false    215            �            1259    26344    barang    TABLE     x  CREATE TABLE public.barang (
    barang_id integer NOT NULL,
    nama_barang character varying(50) NOT NULL,
    harga integer NOT NULL,
    jumlah integer NOT NULL,
    tanggal_pembelian date NOT NULL,
    foto_barang text,
    kategori_nama_kategori character varying(50) NOT NULL,
    merk_merk character varying(50) NOT NULL,
    dihapus boolean DEFAULT false NOT NULL
);
    DROP TABLE public.barang;
       public         heap    postgres    false            �            1259    26343    barang_barang_id_seq    SEQUENCE     �   CREATE SEQUENCE public.barang_barang_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.barang_barang_id_seq;
       public          postgres    false    218            2           0    0    barang_barang_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.barang_barang_id_seq OWNED BY public.barang.barang_id;
          public          postgres    false    217            �            1259    26353    detail_transaksi    TABLE     �   CREATE TABLE public.detail_transaksi (
    detail_transaksi integer NOT NULL,
    harga integer NOT NULL,
    jumlah integer NOT NULL,
    barang_barang_id integer NOT NULL,
    transaksi_transaksi_id integer NOT NULL
);
 $   DROP TABLE public.detail_transaksi;
       public         heap    postgres    false            �            1259    26352 *   detail_transasksi_detail_transasksi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_transasksi_detail_transasksi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 A   DROP SEQUENCE public.detail_transasksi_detail_transasksi_id_seq;
       public          postgres    false    220            3           0    0 *   detail_transasksi_detail_transasksi_id_seq    SEQUENCE OWNED BY     t   ALTER SEQUENCE public.detail_transasksi_detail_transasksi_id_seq OWNED BY public.detail_transaksi.detail_transaksi;
          public          postgres    false    219            �            1259    26360    jabatan    TABLE     m   CREATE TABLE public.jabatan (
    jabatan_id integer NOT NULL,
    jabatan character varying(50) NOT NULL
);
    DROP TABLE public.jabatan;
       public         heap    postgres    false            �            1259    26359    jabatan_jabatan_id_seq    SEQUENCE     �   CREATE SEQUENCE public.jabatan_jabatan_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.jabatan_jabatan_id_seq;
       public          postgres    false    222            4           0    0    jabatan_jabatan_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.jabatan_jabatan_id_seq OWNED BY public.jabatan.jabatan_id;
          public          postgres    false    221            �            1259    26368    kategori    TABLE     S   CREATE TABLE public.kategori (
    nama_kategori character varying(50) NOT NULL
);
    DROP TABLE public.kategori;
       public         heap    postgres    false            �            1259    26374    merk    TABLE     d   CREATE TABLE public.merk (
    merk_id integer NOT NULL,
    merk character varying(50) NOT NULL
);
    DROP TABLE public.merk;
       public         heap    postgres    false            �            1259    26373    merk_merk_id_seq    SEQUENCE     �   CREATE SEQUENCE public.merk_merk_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.merk_merk_id_seq;
       public          postgres    false    225            5           0    0    merk_merk_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.merk_merk_id_seq OWNED BY public.merk.merk_id;
          public          postgres    false    224            �            1259    26383 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    transaksi_id integer NOT NULL,
    tanggal date NOT NULL,
    total integer NOT NULL,
    akun_username character varying(50) NOT NULL
);
    DROP TABLE public.transaksi;
       public         heap    postgres    false            �            1259    26382    transaksi_transaksi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.transaksi_transaksi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transaksi_transaksi_id_seq;
       public          postgres    false    227            6           0    0    transaksi_transaksi_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transaksi_transaksi_id_seq OWNED BY public.transaksi.transaksi_id;
          public          postgres    false    226            m           2604    34687    akun akun_id    DEFAULT     l   ALTER TABLE ONLY public.akun ALTER COLUMN akun_id SET DEFAULT nextval('public.akun_akun_id_seq'::regclass);
 ;   ALTER TABLE public.akun ALTER COLUMN akun_id DROP DEFAULT;
       public          postgres    false    215    216    216            p           2604    34688    barang barang_id    DEFAULT     t   ALTER TABLE ONLY public.barang ALTER COLUMN barang_id SET DEFAULT nextval('public.barang_barang_id_seq'::regclass);
 ?   ALTER TABLE public.barang ALTER COLUMN barang_id DROP DEFAULT;
       public          postgres    false    217    218    218            r           2604    34689 !   detail_transaksi detail_transaksi    DEFAULT     �   ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN detail_transaksi SET DEFAULT nextval('public.detail_transasksi_detail_transasksi_id_seq'::regclass);
 P   ALTER TABLE public.detail_transaksi ALTER COLUMN detail_transaksi DROP DEFAULT;
       public          postgres    false    220    219    220            s           2604    34690    jabatan jabatan_id    DEFAULT     x   ALTER TABLE ONLY public.jabatan ALTER COLUMN jabatan_id SET DEFAULT nextval('public.jabatan_jabatan_id_seq'::regclass);
 A   ALTER TABLE public.jabatan ALTER COLUMN jabatan_id DROP DEFAULT;
       public          postgres    false    222    221    222            t           2604    34691    merk merk_id    DEFAULT     l   ALTER TABLE ONLY public.merk ALTER COLUMN merk_id SET DEFAULT nextval('public.merk_merk_id_seq'::regclass);
 ;   ALTER TABLE public.merk ALTER COLUMN merk_id DROP DEFAULT;
       public          postgres    false    225    224    225            u           2604    34692    transaksi transaksi_id    DEFAULT     �   ALTER TABLE ONLY public.transaksi ALTER COLUMN transaksi_id SET DEFAULT nextval('public.transaksi_transaksi_id_seq'::regclass);
 E   ALTER TABLE public.transaksi ALTER COLUMN transaksi_id DROP DEFAULT;
       public          postgres    false    226    227    227                      0    26333    akun 
   TABLE DATA           o   COPY public.akun (akun_id, username, password, nama, jabatan, foto_profile, no_hp, email, dihapus) FROM stdin;
    public          postgres    false    216   C       !          0    26344    barang 
   TABLE DATA           �   COPY public.barang (barang_id, nama_barang, harga, jumlah, tanggal_pembelian, foto_barang, kategori_nama_kategori, merk_merk, dihapus) FROM stdin;
    public          postgres    false    218   eC       #          0    26353    detail_transaksi 
   TABLE DATA           u   COPY public.detail_transaksi (detail_transaksi, harga, jumlah, barang_barang_id, transaksi_transaksi_id) FROM stdin;
    public          postgres    false    220   �C       %          0    26360    jabatan 
   TABLE DATA           6   COPY public.jabatan (jabatan_id, jabatan) FROM stdin;
    public          postgres    false    222   �C       &          0    26368    kategori 
   TABLE DATA           1   COPY public.kategori (nama_kategori) FROM stdin;
    public          postgres    false    223   �C       (          0    26374    merk 
   TABLE DATA           -   COPY public.merk (merk_id, merk) FROM stdin;
    public          postgres    false    225   �C       *          0    26383 	   transaksi 
   TABLE DATA           P   COPY public.transaksi (transaksi_id, tanggal, total, akun_username) FROM stdin;
    public          postgres    false    227   �C       7           0    0    akun_akun_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.akun_akun_id_seq', 1, true);
          public          postgres    false    215            8           0    0    barang_barang_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.barang_barang_id_seq', 1, false);
          public          postgres    false    217            9           0    0 *   detail_transasksi_detail_transasksi_id_seq    SEQUENCE SET     Y   SELECT pg_catalog.setval('public.detail_transasksi_detail_transasksi_id_seq', 1, false);
          public          postgres    false    219            :           0    0    jabatan_jabatan_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.jabatan_jabatan_id_seq', 1, false);
          public          postgres    false    221            ;           0    0    merk_merk_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.merk_merk_id_seq', 1, false);
          public          postgres    false    224            <           0    0    transaksi_transaksi_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.transaksi_transaksi_id_seq', 1, false);
          public          postgres    false    226            w           2606    26340    akun akun_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_pkey PRIMARY KEY (akun_id);
 8   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_pkey;
       public            postgres    false    216            y           2606    26342    akun akun_username_un 
   CONSTRAINT     T   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_un UNIQUE (username);
 ?   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_username_un;
       public            postgres    false    216            {           2606    26351    barang barang_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.barang
    ADD CONSTRAINT barang_pkey PRIMARY KEY (barang_id);
 <   ALTER TABLE ONLY public.barang DROP CONSTRAINT barang_pkey;
       public            postgres    false    218            }           2606    26358 '   detail_transaksi detail_transasksi_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transasksi_pkey PRIMARY KEY (detail_transaksi);
 Q   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transasksi_pkey;
       public            postgres    false    220                       2606    26367    jabatan jabatan_jabatan_un 
   CONSTRAINT     X   ALTER TABLE ONLY public.jabatan
    ADD CONSTRAINT jabatan_jabatan_un UNIQUE (jabatan);
 D   ALTER TABLE ONLY public.jabatan DROP CONSTRAINT jabatan_jabatan_un;
       public            postgres    false    222            �           2606    26365    jabatan jabatan_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.jabatan
    ADD CONSTRAINT jabatan_pkey PRIMARY KEY (jabatan_id);
 >   ALTER TABLE ONLY public.jabatan DROP CONSTRAINT jabatan_pkey;
       public            postgres    false    222            �           2606    26372    kategori kategori_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (nama_kategori);
 @   ALTER TABLE ONLY public.kategori DROP CONSTRAINT kategori_pkey;
       public            postgres    false    223            �           2606    26381    merk merk_merk_un 
   CONSTRAINT     L   ALTER TABLE ONLY public.merk
    ADD CONSTRAINT merk_merk_un UNIQUE (merk);
 ;   ALTER TABLE ONLY public.merk DROP CONSTRAINT merk_merk_un;
       public            postgres    false    225            �           2606    26379    merk merk_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.merk
    ADD CONSTRAINT merk_pkey PRIMARY KEY (merk_id);
 8   ALTER TABLE ONLY public.merk DROP CONSTRAINT merk_pkey;
       public            postgres    false    225            �           2606    26388    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (transaksi_id);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public            postgres    false    227            �           2606    26394    barang barang_kategori_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.barang
    ADD CONSTRAINT barang_kategori_fk FOREIGN KEY (kategori_nama_kategori) REFERENCES public.kategori(nama_kategori);
 C   ALTER TABLE ONLY public.barang DROP CONSTRAINT barang_kategori_fk;
       public          postgres    false    218    223    4739            �           2606    26399    barang barang_merk_fk    FK CONSTRAINT     w   ALTER TABLE ONLY public.barang
    ADD CONSTRAINT barang_merk_fk FOREIGN KEY (merk_merk) REFERENCES public.merk(merk);
 ?   ALTER TABLE ONLY public.barang DROP CONSTRAINT barang_merk_fk;
       public          postgres    false    225    4741    218            �           2606    26404 ,   detail_transaksi detail_transasksi_barang_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transasksi_barang_fk FOREIGN KEY (barang_barang_id) REFERENCES public.barang(barang_id);
 V   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transasksi_barang_fk;
       public          postgres    false    220    218    4731            �           2606    26409 /   detail_transaksi detail_transasksi_transaksi_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transasksi_transaksi_fk FOREIGN KEY (transaksi_transaksi_id) REFERENCES public.transaksi(transaksi_id);
 Y   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transasksi_transaksi_fk;
       public          postgres    false    220    4745    227            �           2606    26414    transaksi transaksi_akun_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_akun_fk FOREIGN KEY (akun_username) REFERENCES public.akun(username);
 E   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_akun_fk;
       public          postgres    false    4729    216    227               <   x�3��/�K-�,H,.642�H����̆���qX � |��������\�4�=... f�Z      !      x������ � �      #      x������ � �      %      x������ � �      &      x������ � �      (      x������ � �      *      x������ � �     