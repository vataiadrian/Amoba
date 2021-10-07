using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoba
{
    class Nevek
    {
        private string jatekosnev1;
        private string jatekosnev2;

        public string Jatekosnev1 { get => jatekosnev1; set => jatekosnev1 = value; }
        public string Jatekosnev2 { get => jatekosnev2; set => jatekosnev2 = value; }
    
    public Nevek(string sor)
        {
            jatekosnev1 = sor.Split(';')[0];
            jatekosnev2 = sor.Split(';')[1];
        }
    
    
    
    }


}
