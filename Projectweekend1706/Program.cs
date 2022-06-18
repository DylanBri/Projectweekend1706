using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projectweekend1706
{
    class Program
    {
        static void Main(string[] args)
        {
            Proprio props = new Proprio();
            OrderedNumbers numbers = new OrderedNumbers();
            ParcAuto parc = new ParcAuto();

            props.CreateProprio("Galo Doido", "Rue Pancetite", "Doing", "LAAS", "0110");
            props.CreateProprio("Clover Dis", "Avenue Brazil", "Bololand", "CACHURALAND", "4500");
            props.CreateProprio("Gaitano Blake", "Rue Derrier", "Saint Tonyu", "BOLOLOIA", "2542");
            props.CreateProprio("Johnny True", "Rue Charlotte Spil", "Kokri", "CRATIA", "6801");
            props.CreateProprio("Chalata Lora", "Passage de vache", "Tioyu", "LAAS", "0340");
            props.CreateProprio("Blovers Borges", "Impasse Inclementine", "Bramestov", "LAAS", "0240");
            props.CreateProprio("Cristiano Banaldo", "Avenue Solidays", "Cololos Pole", "LAAS", "0522");


            props.GetByPays("LAAS");

           props.AllVoitures();


        }
    }
}
