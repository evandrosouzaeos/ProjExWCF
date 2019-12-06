using Entidade;
using ServicoHostWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjExWCF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void gdvListagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            string endereco = txtEndereco.Text;
            string nome = txtNome.Text;
            int qtdFuncionarios = int.Parse(txtQtdFunc.Text);

            SendMessage(servico.inserir(nome, endereco, qtdFuncionarios));
            LoadGrid();
            CleanFields();
        }

        private void SendMessage(string text)
        {
            lblMsg.Text = text;
        }

        private void CleanFields()
        {
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtQtdFunc.Text = "";
        }

        private void LoadGrid()
        {
            gdvListagem.DataSource = new Servico().listarEmpresas();
            gdvListagem.DataBind();
        }

    }
}