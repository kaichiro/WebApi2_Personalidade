using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ConsumindoWebAPI_Personalidade
{
    public partial class Form1 : Form
    {

        string URI = "";
        long codigoPersonalidade = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private async void GetAllPersonalidade()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var PersonalidadeJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Personalidade[]>(PersonalidadeJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter Personalidade(s): " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetPersonalidadeById(long id)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + id.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var PersonalidadeJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<Personalidade>(PersonalidadeJsonString);
                    dgvDados.DataSource = bsDados;
                }
                else
                {
                    string x = $"Falha ao obter a Persoanlidade (id: {id}): {response.StatusCode}";
                    MessageBox.Show(x);
                }
            }
        }

        private async void AddPersonalidade()
        {
            URI = txtURI.Text;
            Personalidade personalidade = new Personalidade { Nome = "testando inclusão", Nascimento = new DateTime(1990, 01, 01), Sexo = "M" };
            using (var client = new HttpClient())
            {
                var serializedPersonalidade = JsonConvert.SerializeObject(personalidade);
                var content = new StringContent(serializedPersonalidade, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

        private async void UpdatePersonalidade(long id)
        {
            URI = txtURI.Text;
            Personalidade personalidade = new Personalidade { Id = id, Nome = "atualizando teste", Nascimento = new DateTime(1980, 1, 1), Sexo = "F" };

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + personalidade.Id, personalidade);
                if (responseMessage.IsSuccessStatusCode) { MessageBox.Show("Personalidade atualizada com sucesso!"); }
                else { MessageBox.Show($"Falha ao atualizar personalidade ({personalidade.AsString()}): {responseMessage.StatusCode}"); }
            }
        }

        private async void DeletePersonalidade(long id)
        {
            URI = txtURI.Text;
            long PersID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync($"{URI}/{PersID}");
                if (responseMessage.IsSuccessStatusCode) { MessageBox.Show("Personalidade excluída com sucesso!"); }
                else { MessageBox.Show($"Falha ao excluir Personalidade ({id}): {responseMessage.StatusCode}"); }
            }
        }

        private void InputBox()
        {
            string Prompt = "Informe o código da Personalidade.";
            string Titulo = "ww.omnia.inf.br";
            string Resultado = Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
            if ("" != Resultado) { codigoPersonalidade = long.Parse(Resultado); }
            else { codigoPersonalidade = -1; }
        }

        private void btnOterPersonalidades_Click(object sender, EventArgs e)
        {
            GetAllPersonalidade();
        }

        private void btnPersonalidadePorId_Click(object sender, EventArgs e)
        {
            InputBox();
            if (-1 != codigoPersonalidade) { GetPersonalidadeById(codigoPersonalidade); }
        }

        private void btnIncluirPersonalidade_Click(object sender, EventArgs e)
        {
            AddPersonalidade();
            GetAllPersonalidade();
        }

        private void btnAtualizaPersonalidade_Click(object sender, EventArgs e)
        {
            InputBox();
            if (-1 != codigoPersonalidade) { UpdatePersonalidade(codigoPersonalidade); }
            GetAllPersonalidade();
        }

        private void btnDeletarPersonalidade_Click(object sender, EventArgs e)
        {
            InputBox();
            if (-1 != codigoPersonalidade) { DeletePersonalidade(codigoPersonalidade); }
            GetAllPersonalidade();
        }

        private void btnGetBySexo_Click(object sender, EventArgs e)
        {

        }
    }

    public class Personalidade
    {
        private long _id;
        private string _nome;
        private DateTime _nascimento;
        private string _sexo;

        public long Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public DateTime Nascimento { get => _nascimento; set => _nascimento = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }

        public string AsString()
            => "Personalidade: [Id: " + Id.ToString() + ", Nome: " + Nome + ", Nascimento: " + Nascimento.ToString() + ", Sexo: " + Sexo + "]";
    }
}
