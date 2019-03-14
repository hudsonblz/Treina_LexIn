using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using WinFormsMvp.Unity;
using WinFormsMvp.Binder;
using Microsoft.Practices.Unity;

namespace Treina_LexIn
{
    public partial class ThisAddIn
    {
        private static IUnityContainer unityContainer;
        public IUnityContainer UnityContainer
        {
            get
            {
                return unityContainer;
            }
        }
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            unityContainer = new UnityContainer();
            PresenterBinder.Factory = new UnityPresenterFactory(unityContainer);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Código gerado por VSTO

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
