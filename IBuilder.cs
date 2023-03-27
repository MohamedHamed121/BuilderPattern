using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 interface Builder is
    method reset()
    method setSeats(...)
    method setEngine(...)
    method setTripComputer(...)
    method setGPS(...)
 */
namespace BuilderPattern
{
    internal interface IBuilder
    {
       // void Make();
        void SetVegetables();
        void SetNuts();
        void SetHerbs();
        void SetSpices();
        void SetMeats();
        void SetExotic();
        void SetSeaFood();
        void SetSouce();
        void SetChese();
    }
}
