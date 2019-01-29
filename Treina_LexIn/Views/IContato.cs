using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treina_LexIn.Views
{
    public interface IContato
    {
        string nomeContatoPJ { get; set; }
        string representantePF { get; set; }
        int numRepresentante { get; set; }
    }
}
