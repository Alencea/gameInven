using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armadilo
{
    internal class foot
    {
        int toes;
        int shoeSize;
        char side;
        bool isSmelly;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="toes"></param>
    /// <param name="shoeSize"></param>
    /// <param name="side"></param>
    /// <param name="isSmelly"></param>
    public Foot(int toes, int shoeSize, char side, bool isSmelly)
    {
        this.toes = toes;
        this.shoeSize = shoeSize;
        this.side = side;
        this.isSmelly = isSmelly;
    }


}
