using Prova.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
	public partial class Form1 : Form
	{
		//Crinado Lista de Cadastros
		private List<Pessoa> ListaCadastros = new List<Pessoa>();
		public Form1()
		{
			InitializeComponent();
			labelTelaCadastro();
		}

		//Botões
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			if (validacaoCamposCadastro())
			{
				if (validacaoData(Convert.ToDateTime(mskNascimento.Text)))
				{
					Pessoa umCadastro = getPessoa();
					ListaCadastros.Add(umCadastro);
					mostrarDataGrid();
					quantidadeCadastros();
					limpaCampos();
				}
				else
				{
					MessageBox.Show("Data invalida");
					
				}
						
			}
			else
			{
				MessageBox.Show("Preencha todos os campos");
			}
			
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			if (validacaoCamposExcluir())
			{
				if (validaUsuarioCampo())
				{
					quantidadeCadastros();
					if (caixaDialogo())
					{
						excluirDados(txbNome.Text);
						mostrarDataGrid();
						txbNomeAlteradoExcluido.Clear();
					}	
				}
				else
				{
					MessageBox.Show("Nenhum usuário com esse nome foi encontrado");
				}
			}
			else
			{
				MessageBox.Show("Preencha todos os campos");
			}
			
			
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (validacaoCamposAlterar())
			{
				if (validacaoData(Convert.ToDateTime(mskNascimento.Text)))
				{
					alterarDados(txbNome.Text);
					mostrarDataGrid();
					quantidadeCadastros();
					limpaCampos();
					txbNomeAlteradoExcluido.Clear();
				}
				else
				{
					MessageBox.Show("Data invalida");
				}
			}
			else
			{
				MessageBox.Show("Preencha todos os campos");
			}
			
			
		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaCadastro();
			limpaCampos();
		}

		private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaAlterar();
			limpaCampos();
			txbNomeAlteradoExcluido.Clear();
		}

		private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaExcluir();
			txbNomeAlteradoExcluido.Clear();
		}
		//Metodos
		private Pessoa getPessoa()
		{
			Pessoa umaPessoa = new Pessoa();
			umaPessoa.Nome = txbNome.Text;
			umaPessoa.DataNasc = Convert.ToDateTime(mskNascimento.Text);
			umaPessoa.Altura = float.Parse(mskAltura.Text);
			umaPessoa.Profissao = txbProfissao.Text;
			return umaPessoa;
		}	

		private void excluirDados(string nome)
		{
			if (ListaCadastros.Count == 0)
			{
				MessageBox.Show("Nenhum usuário foi cadastrado");
			}
			else if (validacaoCamposExcluir()) {
				foreach(var Usuario in ListaCadastros)
				{
					if (Usuario.Nome == txbNomeAlteradoExcluido.Text)
					{
						ListaCadastros.Remove(Usuario);
						break;
					}
				}
			}
			else
			{
				MessageBox.Show("Preencha todos os campos");
			}
		}

		private void alterarDados(string nome)
		{
			if (ListaCadastros.Count == 0)
			{
				MessageBox.Show("Nenhum usuário foi cadastrado");
			}
			else if (!validacaoCamposAlterar())
			{
				MessageBox.Show("Preencha todos os campos");
			}
			else
			{
				foreach (var Usuario in ListaCadastros)
				{
					if (Usuario.Nome == txbNomeAlteradoExcluido.Text)
					{
						Usuario.Nome = txbNome.Text;
						Usuario.DataNasc = Convert.ToDateTime(mskNascimento.Text);
						Usuario.Altura = float.Parse(mskAltura.Text);
						Usuario.Profissao = txbProfissao.Text;
					}
				}
			}
		}

		private void mostrarDataGrid()
		{
			dataGridResultado.DataSource = null;
			dataGridResultado.DataSource = ListaCadastros;
		}

		private void quantidadeCadastros()
		{
			lblQuantidadeCadastros.Text = "O número de usuários cadastrados é: " + ListaCadastros.Count;
		}

		private void limpaCampos()
		{
			txbNome.Clear();
			txbProfissao.Clear();
			mskAltura.Clear();
			mskNascimento.Clear();
		}

		private bool caixaDialogo()
		{
			var Mensagem = MessageBox.Show("Deseja realmente excluir esse cadastro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (Mensagem == DialogResult.Yes)
			{
				MessageBox.Show("Arquivo Deletado", "Sucesso!");
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool validacaoData(DateTime nascimento)
		{
			if (nascimento > DateTime.Now){
				return false;
			}
			else
			{
				return true;
			}
		}

		private bool validacaoCamposCadastro()
		{
			if (!string.IsNullOrEmpty(txbNome.Text) && !string.IsNullOrEmpty(mskNascimento.Text) && !string.IsNullOrEmpty(mskAltura.Text) && !string.IsNullOrEmpty(txbProfissao.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private bool validacaoCamposAlterar()
		{
			if (!string.IsNullOrEmpty(txbNomeAlteradoExcluido.Text) &&!string.IsNullOrEmpty(txbNome.Text) && !string.IsNullOrEmpty(mskNascimento.Text) && !string.IsNullOrEmpty(mskAltura.Text) && !string.IsNullOrEmpty(txbProfissao.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool validacaoCamposExcluir()
		{
			if (!string.IsNullOrEmpty(txbNomeAlteradoExcluido.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool validaUsuarioCampo()
		{
			foreach(var umCadastro in ListaCadastros)
			{
				if (umCadastro.Nome == txbNomeAlteradoExcluido.Text)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			return false;
		}

		private void labelTelaCadastro()
		{
			lblCadastro.Text = "Cadastro";
			lblNome.Visible = true;
			txbNome.Visible = true;
			lblProfissão.Visible = true;
			txbProfissao.Visible = true;
			lblNascimento.Visible = true;
			mskNascimento.Visible = true;
			lblAltura.Visible = true;
			mskAltura.Visible = true;
			lblAlteradoExcluido.Visible = false;
			txbNomeAlteradoExcluido.Visible = false;
			btnExcluir.Visible = false;
			btnAlterar.Visible = false;
			btnCadastrar.Visible = true;
			quantidadeCadastros();
		}
		private void labelTelaAlterar()
		{
			lblCadastro.Text = "Alterar Cadastro";
			lblAlteradoExcluido.Text = "Nome a ser alterado";
			lblAlteradoExcluido.Visible = true;
			txbNomeAlteradoExcluido.Visible = true;
			lblNome.Visible = true;
			txbNome.Visible = true;
			lblProfissão.Visible = true;
			txbProfissao.Visible = true;
			lblNascimento.Visible = true;
			mskNascimento.Visible = true;
			lblAltura.Visible = true;
			mskAltura.Visible = true;
			btnAlterar.Visible = true;
			btnCadastrar.Visible = false;
			btnExcluir.Visible = false;
			quantidadeCadastros();
		}
		private void labelTelaExcluir()
		{
			lblCadastro.Text = "Excluir Cadastro";
			lblAlteradoExcluido.Text = "Nome a ser excluido";
			lblAlteradoExcluido.Visible = true;
			txbNomeAlteradoExcluido.Visible = true;
			btnExcluir.Visible = true;
			lblNome.Visible = false;
			txbNome.Visible = false;
			lblProfissão.Visible = false;
			txbProfissao.Visible = false;
			lblNascimento.Visible = false;
			mskNascimento.Visible = false;
			lblAltura.Visible = false;
			mskAltura.Visible = false;
			btnAlterar.Visible = false;
			btnCadastrar.Visible = false;
			quantidadeCadastros();

		}		
	}
}
