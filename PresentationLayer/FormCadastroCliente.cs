using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class FormCadastroCliente : Form
    {

        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Bairro = txtBairro.Text;
            c.CEP = txtCEP.Text;
            c.Complemento = txtComplemento.Text;
            c.CPF = txtCPF.Text;
            c.DataNascimento = dtpDataDeNascimento.Value;
            c.Email = txtEmail.Text;
            c.EstadoCivil = cmbEstadoCivil.Text;
            c.Genero = cmbGenero.Text;
            c.Nome = txtNome.Text;
            c.Numero = txtNumero.Text;
            c.Rua = txtRua.Text;
            c.Telefone = txtTelefone.Text;
        }
    }
}
