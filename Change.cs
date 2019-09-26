using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerPAacial
{
    public class Change
    {
        public int BilletesQuinientos { get; }
        public int BilletesDoscientos { get; }
        public int BilletesCien { get; }
        public int BilletesCincuenta { get; }
        public int BilletesVeinte { get; }
        public int MonedaDosPesos { get; }
        public int MonedaCincoPesos { get; }
        public int MonedaPeso { get; }
        public int MonedaCincuentaCents { get; }

        public Change(decimal valor)
        {
            BilletesQuinientos = (int)(valor / 500);
            valor %= 500;

            BilletesDoscientos = (int)(valor / 200);
            valor %= 200;

            BilletesCien = (int)(valor / 100);
            valor %= 100;

            BilletesCincuenta = (int)(valor / 50);
            valor %= 50;

            BilletesVeinte = (int)(valor / 20);
            valor %= 20;

            MonedaCincoPesos = (int)(valor / 5);
            valor %= 5;

            MonedaDosPesos = (int)(valor / 2);
            valor %= 2;

            MonedaPeso = (int)(valor / 1);
            valor %= 1;

            MonedaCincuentaCents = (int)(valor / 0.5m);
            valor %= 0.5m;

        }
    }
}
