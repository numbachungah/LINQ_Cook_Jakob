using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Cook_Jakob
{
    internal class Game
    {
        //properties with automatic getters, one called Title of string type, one called Esrb of char type, one called Genre of string type.
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        //a constructor that passes 3 parameters, title, esrb, and genre.
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            //Assigns each parameter to the corresponding property.
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }

    }
}