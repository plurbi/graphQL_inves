using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQL_prototype
{
    class StarWarsDB
    {
        public static IEnumerable<Jedi> GetJedis()
        {
            return new List<Jedi>() {
        new Jedi(){ Id=1 ,Name ="Luke", Side="Light", Age= 23},
        new Jedi(){ Id=2 ,Name ="Yoda", Side="Light", Age= 22},
        new Jedi(){ Id=3 ,Name ="Darth Vader", Side="Dark", Age= 20}
    };
        }
    }
}
