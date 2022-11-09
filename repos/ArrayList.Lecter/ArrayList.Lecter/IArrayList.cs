using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Lecter
{
    internal interface IArrayList : ICollection<string>,IList<string>
    {
        void Resize(int newSize);

    }
}
