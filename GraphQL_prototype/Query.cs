using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQL_prototype
{
    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return StarWarsDB.GetJedis();
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Hello Query class de Pato";
        }

        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return StarWarsDB.GetJedis().FirstOrDefault(j => j.Id == id);
        }
    }
}
