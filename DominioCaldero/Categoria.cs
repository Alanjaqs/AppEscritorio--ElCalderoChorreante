using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCaldero
{
    public class Categoria
    {
        public int IdCat { get; set; }
        public string NombreCat { get; set; }
        public string ImagenCat { get; set; }

        public override string ToString()
        {
            return NombreCat.ToString();
        }

    }
}
