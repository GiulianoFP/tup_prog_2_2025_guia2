using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregación.Models
{
    public class Servicio
    {
        Persona[] personas = new Persona[100];
        int contador=0;
        //composición  public bool AgregarPersona(int dni,string nombre) 
        public bool AgregarPersona(Persona p)
        {
            if(BuscarPersona(p.DNI)!=-1)
            {
                personas[contador] = p;
                contador++;
                return true;
            }
            return false;
        }
        public int BuscarPersona(int dni) 
        {
            return -1;
        }
    }
}
