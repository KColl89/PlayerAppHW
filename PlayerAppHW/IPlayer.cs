using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppHW
{
    public interface IPLayer
    {
        Guid Id { get; }

        string name { get; set; }
    }
}