using GraphQL;
using GraphQL.Types;
using System;

namespace GraphQL_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test GraphQL");

            var schema = Schema.For(@"
              type Jedi {
                  name: String,
                  side: String,
                  age: Int,
                  id: ID
              }

              type Query {
                  hello: String,
                  jedis: [Jedi],
                  jedi(id: ID): Jedi
              }
              ", _ =>
            {
                _.Types.Include<Query>();
            });

            var root = new { Hello = "Hello World!" };
            var json = schema.Execute(_ =>
            {
                _.Query = "{ hello, jedis { name }, jedi(id: 2) { name } }";
                //_.Root = root;
            });

            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
