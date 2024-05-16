using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    abstract class Documento {
        int anio;
        string autor, barcode, numNormalizado, titulo;
        Paso estado;

        public enum Paso {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        public int Anio {
            get => this.anio;
        }

        public string Autor {
            get => this.autor;
        }

        public string Barcode {
            get => this.barcode;
        }

        public Paso Estado {
            get => this.estado;
        }

        protected string NumNormalizado {
            get => this.numNormalizado;
        }

        public string Titulo {
            get => this.titulo;
        }

        public bool AvanzarEstado() {
            if (this.estado == Paso.Terminado) {
                return false;
            }

            switch (this.estado) {
                case Paso.Inicio:
                    this.estado = Paso.Distribuido;
                    break;
                case Paso.Distribuido:
                    this.estado = Paso.EnEscaner; 
                    break;
                case Paso.EnEscaner:
                    this.estado = Paso.EnRevision;
                    break;
                case Paso.EnRevision:
                    this.estado = Paso.Terminado;
                    break;
            }
            return true;
        }

        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode) {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DOCUMENTO:");
            sb.AppendLine($"Título: {this.titulo}");
            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Año: {this.anio}");
            sb.AppendLine($"NumNormalizado: {this.numNormalizado}");
            sb.AppendLine($"Barcode: {this.barcode}");
            return sb.ToString();
        }
    }
}
