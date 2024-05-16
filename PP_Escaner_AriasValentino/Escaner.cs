﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Escaner {

        List<Documento> listaDocumentos;
        Departamento location;
        string marca;
        TipoDoc tipo;

        public enum Departamento {
            nulo,
            mapoteca,
            procesosTenicos
        }

        public enum TipoDoc {
            libro,
            mapa
        }

        List<Documento> ListaDocumentos {
            get => listaDocumentos;
        }

        Departamento Location {
            get => location;
        }

        string Marca {
            get => marca;
        }

        TipoDoc Tipo {
            get => tipo;
        }

        public bool CambiarEstadoDocumento(Documento d) {
            if (listaDocumentos.Contains(d)) {
                int index = listaDocumentos.IndexOf(d);
                bool exito = listaDocumentos[index].AvanzarEstado();
                return exito;
            }
            else {
                return false;
            }
        }

        public Escaner(string marca, TipoDoc tipo) {
            this.marca = marca;
            this.tipo = tipo;
            this.listaDocumentos = new List<Documento>();
            this.location = (tipo == TipoDoc.mapa) ? Departamento.mapoteca : Departamento.procesosTenicos;
        }

        public static bool operator ==(Escaner e, Documento d) {
            return e.listaDocumentos.Contains(d);
        }

        public static bool operator !=(Escaner e, Documento d) {
            return !(e == d);
        }

        public static Escaner operator +(Escaner e, Documento d) {
            if (e != d && d.Estado == Documento.Paso.Inicio) {
                d.AvanzarEstado(); 
                e.listaDocumentos.Add(d);
            }
            return e;
        }
    }
}