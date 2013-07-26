using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    /*interface IComponent
    {
        void Add();
    }

    class Composite : IComponent
    {
        List<IComponent> child = new List<IComponent>();

        public void Add(IComponent component)
        {
            child.Add(component);
        }
    }*/

    class CompositePattern
    {
        public CompositePattern()
        {
            Console.WriteLine("CompositePattern");
        }
    }
}
