using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Arvore
    {
        public int Id { get; set; }
        public Arvore[] Filhos { get; set; }
    }
}