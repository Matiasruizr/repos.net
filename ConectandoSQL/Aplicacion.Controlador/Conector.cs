using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DALC;


namespace Aplicacion.Controlador
{
     public class Conector
    {
        private static BASE_ALUMNOSEntities _entidadesAlumnos;

        //Accesador 
        public static BASE_ALUMNOSEntities EntidadAlmunos
        {
            get
            {
                if(_entidadesAlumnos == null)
                {
                    _entidadesAlumnos = new BASE_ALUMNOSEntities();
                }
                return _entidadesAlumnos;
            }
        }
    }
}
