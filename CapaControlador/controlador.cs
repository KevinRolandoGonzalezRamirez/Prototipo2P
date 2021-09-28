﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControlador;
using CapaModelo;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace CapaControlador
{
    public class controlador
    {

        Sentencias sn = new Sentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public DataTable llenarCompras(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarCompras(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarProceso(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarProceso(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public bool ingreso(string nom, string pass)
        {
            return sn.ingreso(nom,pass);
        }

        //ingreso compra
        public bool ingresoCompra(string id, string producto, string precio)
        {
            return sn.ingresoCompra(id, producto, precio);
        }

        public bool ingresoProceso(string id_proc, string fech, string det, string nombre, string dpi)
        {
            return sn.ingresoProceso(id_proc,  fech,  det,  nombre,  dpi);
        }

        public ArrayList busquedaIndividual(string idu)
        {
            return sn.busquedaIndividual(idu);
        }

        public bool actuUsuario(string id, string nom, string pass)
        {
            return sn.actuUsuario(id, nom, pass);
        }

        public bool deleteUser(string id)
        {
            return sn.deleteUser(id);
        }

        public bool deleteCompra(string id)
        {
            return sn.deleteCompra(id);
        }

        //metodo para buscar ciudad
        public ArrayList busquedaCine()
        {
            return sn.busquedaCine();
        }

        //busqueda general tipos privilegios
        /*public DataTable llenarTblPriv()
        {
            OdbcDataAdapter dt = sn.llenarTblPriv();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }*/

        public DataTable llenarTblPrivUser(string id)
        {
            OdbcDataAdapter dt = sn.llenarTblPrivUser(id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table; 
        }

        public bool ingPriv(string idU, string idP)
        {
            return sn.ingPriv(idU,idP);
        }
        public ArrayList privilegios()
        {
            return sn.privilegios();
        }
        public bool modifPriv(string idPriv, string idP)
        {
            return sn.modifPriv(idPriv, idP);
        }

        public bool elPriv( string idPriv)
        {
            return sn.elPriv(idPriv);
        }

        public bool iniciaSesion(string user, string pass)
        {

            return sn.iniciaSesion(user, pass);
        }


        public bool ingresoPeliculas(string nom, string clas, string gen, string sub, string idio, string preci, string sinop)
        {
            return sn.ingresoPeliculas(nom,  clas, gen, sub, idio,  preci, sinop);

        }

        public DataTable llenarTblPeli()
        {
            OdbcDataAdapter dt = sn.llenarTblPeli();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblPeliInd(string id)
        {
            OdbcDataAdapter dt = sn.llenarTblPeliInd(id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }

}
