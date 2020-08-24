//  PrevisaoTempo.cs
//  Aplicação Previsão do Tempo
//  Última modificação: 23 de Agosto de 2020.
//  Codificado por: Natan Colavite Dellagiustina
//  Adaptado de pesquisas online sinalizadas nos comentários em que as mesmas foram utilizadas.
// 
//  Esta é uma aplicação do desafio C# elaborado pela KTI (https://github.com/ktisoftware/csharp-challenge).
//  A missão é criar um sistema para consultar uma API de previsão do tempo, onde é possivel pesquisar por cidade.
//  A cidade deve ser digitada e haverá um botão de pesquisa e outro botão para salvar a previsão do tempo em um arquivo CSV.
// *** Está incompleto, mas será explicada pessoalmente quais as minhas dúvidas, pois é minha primeira vez utilizando consultas de uma API.

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Xml.Serialization;
using OpenQA.Selenium.Remote;
using RestSharp;
//using RestSharp.Serialization.Json;

namespace PrevisaoTempo
{
    public partial class frmPrevisaoTempo : System.Windows.Forms.Form
    {
        public frmPrevisaoTempo()
        {
            InitializeComponent();
            SetDefaults();
        }
        /// <summary>
        /// Padronização de inicilização
        /// </summary>
        private void SetDefaults()
        {
            txtCidade.Clear();
            txtCidade.Focus();

            lblResultadoCidade.Text = "";
            lblResultadoEstado.Text = "";
            lblResultadoAtualizacao.Text = "";
            lblResultadoDia.Text = "";
            lblResultadoTempo.Text = "";
            lblResultadoTemperaturaMaxima.Text = "";
            lblResultadoTemperaturaMinima.Text = "";
            lblResultadoIuv.Text = "";
        }
        /// <summary>
        /// Ao clicar no botão pesquisar, o programa pesquisa através do nome da cidade a previsão do tempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!(txtCidade.Text == string.Empty))
            {
                try
                {
                    //RestClient restClient = new RestClient(string.Format("http://servicos.cptec.inpe.br/XML/listaCidades?city={0}"));
                    //RestClient restClient = new RestClient("http://servicos.cptec.inpe.br/XML/cidade/{0}/previsao.xml");
                    //RestRequest restRequest = new RestRequest(Method.GET);

                    //IRestResponse restResponse = restClient.Execute(restRequest);

                    //DadosCidade dadosCidade = new JsonDeserializer().Deserialize<DadosCidade>(restResponse);

                    HttpWebRequest request = WebRequest.Create("http://servicos.cptec.inpe.br/XML/listaCidades?city={0}") as HttpWebRequest;

                    XmlSerializer ser = new XmlSerializer(typeof(Response));

                    WebResponse response = request.GetResponse();
                    var result = ser.Deserialize(response.GetResponseStream());

                    DadosCidade dadosCidade = new DadosCidade(ser);

                    lblResultadoCidade.Text = dadosCidade.nome;
                    lblResultadoEstado.Text = dadosCidade.uf;
                    lblResultadoAtualizacao.Text = dadosCidade.atualizacao.ToString();
                    lblResultadoDia.Text = dadosCidade.dia.ToString();
                    lblResultadoTempo.Text = dadosCidade.tempo;
                    lblResultadoTemperaturaMaxima.Text = dadosCidade.maxima.ToString();
                    lblResultadoTemperaturaMinima.Text = dadosCidade.minima.ToString();
                    lblResultadoIuv.Text = dadosCidade.iuv;

                    lblErro.Text = "";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message.ToString());
                }
            }
            else
            {
                lblErro.Text = "A cidade não pode estar em branco e deve conter apenas caracteres alfabéticos.";
            }
        }
        /// <summary>
        /// Ao clicar no botão Sair, uma janela abre questionando se realmente deseja sair
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Previsão do Tempo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //Application.Current.Shutdown(); //erro ao executar
                //Environment.Exit(0);
                //Application.Exit Exit não existe/funciona
                this.Close();
            }
            txtCidade.Focus();
        }
        /// <summary>
        /// Salva os dados da tela em um arquivo CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCsv_Click(object sender, EventArgs e)
        //{
        //    StreamReader stream = new StreamReader(@"C:\teste.csv");

        //    string linha = null;
        //    while ((linha = stream.ReadLine()) != null)
        //    {
        //        string[] coluna = linha.Split(',');
        //        Response.Write(coluna[0] + " - " + coluna[1] + ": " + coluna[2] + "<br />");
        //    }

        //    stream.Close()
        //}

        // retirado de https://www.delftstack.com/howto/csharp/how-to-write-data-into-a-csv-file-in-csharp/
        {
            try
            {
                // adaptado de https://social.msdn.microsoft.com/Forums/vstudio/en-US/80fa29cf-a56f-45c4-8694-13db45627f99/how-to-create-a-csv-file-in-c-?forum=netfxbcl

                string localArquivo = @"D:\New folder\PrevisaoTempo.csv";
                string divisor = ",";
                string[][] resultado = new string[][]
                {
                    new string[]{"CIDADE", "UF", "ATUALIZAÇÃO", "DIA","TEMPO", "MÁXIMA", "MÍNIMA", "IUV"},
                    new string[]{"Dados.Cidade.nome", "Dados.Cidade.uf", "Dados.Cidade.atualizacao", "Dados.Cidade.dia", 
                                 "Dados.Cidade.tempo", "Dados.Cidade.maxima", "Dados.Cidade.minima", "Dados.Cidade.iuv"}
                };
                int comprimento = resultado.GetLength(0);

                StringBuilder sb = new StringBuilder();

                for (int index = 0; index < comprimento; index++)
                {
                    sb.AppendLine(string.Join(divisor, resultado[index]));
                }
                File.WriteAllText(localArquivo, sb.ToString());
                MessageBox.Show("CSV criado com sucesso.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message.ToString());
            }
        }
        private void frmPrevisaoTempo_Load(object sender, EventArgs e)
        {
        }
    }
    /// <summary>
    /// Classe para todos os dados da cidade
    /// </summary>
    public class DadosCidade
    {
        private XmlSerializer ser;
        public DadosCidade(XmlSerializer ser)
        {
            this.ser = ser;
        }
        public string nome { get; set; }
        public string uf { get; set; }
        public DateTime atualizacao { get; set; }
        public DateFormat dia { get; set; }
        public string tempo { get; set; }
        public int maxima { get; set; }
        public int minima { get; set; }
        public string iuv { get; set; }
    }
}
