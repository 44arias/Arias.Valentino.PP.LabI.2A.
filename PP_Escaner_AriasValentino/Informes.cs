using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Escaner_AriasValentino {
    public static class Informes {

        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen) {
            MostrarDocumentosPorEstado(e, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);
        }

        private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen) {
            extension = 0;
            cantidad = 0;
            StringBuilder sb = new StringBuilder();

            foreach (Documento doc in e.ListaDocumentos) {
                if (doc.Estado == estado) {
                    cantidad++;
                    if (doc is Libro libro) {
                        extension += libro.NumPaginas;
                        sb.AppendLine(libro.ToString());
                    } else if (doc is Mapa mapa) {
                        extension += (int)mapa.Superficie;
                        sb.AppendLine(mapa.ToString());
                    }
                }
            }

            resumen = sb.ToString();
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen) {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen) {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen) {
            MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }
    }
}
