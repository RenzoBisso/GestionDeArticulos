﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Categoria
    {
        public int IdCategoria{ get; set; }
        public string DescripcionCategoria { get; set; }


        public override string ToString()
        {
            return DescripcionCategoria;
        }

    }
}
