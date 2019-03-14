using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treina_LexIn.Services
{
    public interface ILocalizarSubstituirService
    {
        bool LocalizarProxima(bool caseSensitive, string palavraBusca);
        bool Substituir(bool caseSensitive, string palavraBusca, string palavraSubstituir);
        bool SubstituirTodos(bool caseSensitive, string palavraBusca, string palavraSubstituir);
    }
}
