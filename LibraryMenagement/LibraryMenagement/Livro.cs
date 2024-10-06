using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenagement
{
    public  class Livro : Base
    {
        public string Nome { get; set; }

        public Autor autor = new Autor();
    }
}
