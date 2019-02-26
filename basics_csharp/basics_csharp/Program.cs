using basics_csharp.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      SimpleMath p = new SimpleMath();
      int x = p.Add(2, p.Add(3, p.Add(3, -3 + p.Add(3, 40))));
      Console.WriteLine("Hello World" + x);
      Console.ReadLine();
    }    
  }
}
