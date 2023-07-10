using iTextSharp.text;
using iTextSharp.text.pdf;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using System;

namespace ListaExerciciosMariana.WinForm.ModuloPdf
{
    public partial class TelaGerarPdfForm : Form
    {
        private Teste _testeSelecionado;
        private Questao _questao;
        private Alternativa _alternativa;
        private IRepositorioQuestao _repositorioQuestao;

        public TelaGerarPdfForm(Teste testeSelecionado, IRepositorioQuestao repositorioQuestao)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this._testeSelecionado = testeSelecionado;
            _repositorioQuestao = repositorioQuestao;
        }

        private string DefinirNomeArquivo()
        {
            if (rbQuestoes.Checked)
                return $"{_testeSelecionado.Titulo} - Questões";

            else return $"{_testeSelecionado.Titulo} - Gabarito";
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fbd.SelectedPath;
            }

            DialogResult = DialogResult.None;
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha um diretório para guardar seu PDF");
                DialogResult = DialogResult.None;
                return false;
            }

            if (!rbQuestoes.Checked && !rbGabarito.Checked)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha qual opção de PDF à ser gerado");
                DialogResult = DialogResult.None;
                return false;
            }

            return true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                EscreverPdf();
                MessageBox.Show($"PDF gerado com sucesso! Confira no caminho: \n{txtDiretorio.Text}");
            }
        }

        private void EscreverPdf()
        {
            string nomePdf = DefinirNomeArquivo();

            string caminho = Path.Combine(txtDiretorio.Text, nomePdf + ".pdf");

            Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
            FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            //-------------------------------------------------------------------------------------------------------------------------------------------
            doc.Open();

            BaseColor corPadrao = BaseColor.BLACK;
            BaseColor corGabarito = new BaseColor(34, 139, 34);

            iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, corPadrao);
            iTextSharp.text.Font fonteInfo = FontFactory.GetFont(FontFactory.HELVETICA, 13, corPadrao);
            iTextSharp.text.Font fonteQuestao = FontFactory.GetFont(FontFactory.HELVETICA, 12, corPadrao);
            iTextSharp.text.Font fonteGabarito = FontFactory.GetFont(FontFactory.HELVETICA, 12, corGabarito);

            Paragraph data = new Paragraph(string.Format($"Data: {DateTime.Today.ToString("dd/MM/yyyy")}"), fonteInfo);
            doc.Add(data);

            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                Paragraph nomeEstudante = new Paragraph(string.Format($"Nome: {txtNome.Text}"), fonteInfo);
                doc.Add(nomeEstudante);
            }

            Paragraph disciplina = new Paragraph(string.Format($"Disciplina: {_testeSelecionado.Disciplina}"), fonteInfo);
            doc.Add(disciplina);

            Paragraph materia = new Paragraph(string.Format($"Matéria: {_testeSelecionado.Materia}, {_testeSelecionado.Materia.Ano}"), fonteInfo);
            doc.Add(materia);

            if (_testeSelecionado.ProvaRecuperacao)
            {
                Paragraph recuperacao = new Paragraph(string.Format($"Prova de recuperação"), fonteInfo);
                doc.Add(recuperacao);
            }

            doc.Add(new Paragraph(" "));

            Paragraph titulo = new Paragraph(string.Format($"{_testeSelecionado.Titulo.ToUpper()}"), fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));                    

            _testeSelecionado.ListQuestoes.ForEach(q =>
            {
                char letra = 'A';
                _repositorioQuestao.CarregarAlternativas(q);

                Paragraph questao = new Paragraph(string.Format($"{q}"), fonteQuestao);
                doc.Add(questao);
                doc.Add(new Paragraph(" "));

                q.ListAlternativas.ForEach(a =>
                {
                    Paragraph alternativa = new Paragraph(string.Format($"{letra}) {a}"), fonteQuestao);
                    doc.Add(alternativa);
                    doc.Add(new Paragraph(""));
                    letra++;
                });

                if (rbGabarito.Checked)
                {
                    Paragraph respostaCerta = new Paragraph(string.Format($"Gabarito: {q.RespostaCerta}"), fonteGabarito);
                    doc.Add(respostaCerta);
                }

                doc.Add(new Paragraph(" "));
            });

            doc.Close();
            //-------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
