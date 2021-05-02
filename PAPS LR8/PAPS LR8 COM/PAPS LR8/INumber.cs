using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PAPS_LR8
{
    [Guid("364C5E66-4412-48E3-8BD8-7B2BF09E8922")]
    [ComVisible(true)]
    public interface INumber
    {
        List<int> fibon_n(int x);
        int factor_n(int x);
        List<int> prost_n(int x);
    }
}
