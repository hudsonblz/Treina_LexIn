using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treina_LexIn.Models;
using Treina_LexIn.Views;
using Word = Microsoft.Office.Interop.Word;

namespace Treina_LexIn.Presenters
{
    public class Ribbon1Presenter
    {
        ITabela tabelaView;
        private static readonly Lazy<Ribbon1Presenter> instance =
           new Lazy<Ribbon1Presenter>(() => new Ribbon1Presenter());

        public static Ribbon1Presenter Instance { get { return instance.Value; } }

        public Ribbon1Presenter(ITabela view)
        {
            tabelaView = view;
        }
        public Ribbon1Presenter()
        {

        }

        public void InserirTabela()
        {
            TabelaModel tabela = new TabelaModel();
            tabela.numLinhas = int.Parse(tabelaView.numLinhas);
            tabela.numColunas = int.Parse(tabelaView.numColunas);
            tabela.InserirTabela();
        }

        public void InserirImagem()
        {
            OpenFileDialog imagemInserida = new OpenFileDialog();
            imagemInserida.Filter = "Imagens (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (imagemInserida.ShowDialog() == DialogResult.OK)
            {
                Globals.ThisAddIn.Application.Selection.InlineShapes.AddPicture(imagemInserida.FileName);
            }
        }

        public void InverterCase()
        {
            String texto = Globals.ThisAddIn.Application.Selection.Range.Text;
            if (texto != "" && texto != null)
            {
                char[] textoOriginal = texto.ToCharArray();

                for (int i = 0; i < textoOriginal.Length; i++)
                {
                    if (Char.IsLower(textoOriginal[i]))
                    {
                        textoOriginal[i] = Char.ToUpper(textoOriginal[i]);
                    }
                    else if (Char.IsUpper(textoOriginal[i]))
                    {
                        textoOriginal[i] = Char.ToLower(textoOriginal[i]);
                    }
                }
                Globals.ThisAddIn.Application.Selection.Range.Text = new string(textoOriginal);
            }
        }

        public void SalvarComoPDF()
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            string sfileName_Document = doc.Name;
            string sPath = desktopFolder;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
        }
    }
}
