using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DALC;

namespace Aplicacion.Controlador
{
    public class Alumno
    {
        private int _idAlumno;
        private string _rut;
        private string _primerNombre;
        private string _segundoNombre;
        private DateTime _fechaNacimiento; 
        private DateTime _fechaIngreso;
        private string _primerApellido;
        private string _segundoApellido;


        public string segundoApellido
        {
            get { return _segundoApellido; }
            set { _segundoApellido = value; }
        }


        public string primerApellido
        {
            get { return _primerApellido; }
            set { _primerApellido = value; }
        }



        public DateTime fechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }


        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }



        public string segundoNombre
        {
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }



        public string primerNombre
        {
            get { return _primerNombre; }
            set { _primerNombre = value; }
        }



        public string rut
        {
            get { return _rut; }
            set { _rut = value; }
        }



        public int idAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        public bool Create()
        {
            try
            {
                ALUMNO al = new ALUMNO();
                al.ID_ALUMNO = this._idAlumno;
                al.RUT = this.rut;
                al.PRIMER_NOMBRE = this.primerNombre;
                al.SEGUNDO_NOMBRE = this.segundoNombre;
                al.PRIMER_APELLIDO = this._primerApellido;
                al.SEGUNDO_APELLIDO = this._segundoApellido;
                al.FECHA_INGRESO = this._fechaIngreso;
                al.FECHA_NACIMIEMTO = this._fechaNacimiento;

                Conector.EntidadAlmunos.ALUMNOes.Add(al);
                Conector.EntidadAlmunos.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }







    }
}
