using Trabalho.entity;
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
		List<Pessoa> ListaCadastros = new List<Pessoa>();

		public Form1()
		{
			InitializeComponent();
			labelTelaCadastro();
		}

		//Botões
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			if (verificarCamposNulosTelaCadastro())
			{
				if (verificaData())
				{
					Pessoa umCadastro = getPessoa();
					ListaCadastros.Add(umCadastro);
					mostrarDataGrid();
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
			excluirDados();
			mostrarDataGrid();
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			alterarDados();
			mostrarDataGrid();
		}

		private void btnId_Click(object sender, EventArgs e)
		{
			try
			{
				verificarId(Convert.ToInt32(txbNomeAlteradoExcluido.Text));
			}
			catch (Exception)
			{
				MessageBox.Show("Valor digitado invalido");
			}
			
		}
		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			pesquisarDados();
		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaCadastro();
		}

		private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaAlterar();
			bloquearLabelTelaAlterar();
			
		}

		private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaExcluir();
		}

		private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			labelTelaPesquisar();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fecharForm();
		}
		//Metodos

		private Pessoa getPessoa()
		{
			Pessoa umaPessoa = new Pessoa();
			umaPessoa.Id = incrementarId();
			umaPessoa.Nome = txbNome.Text;
			umaPessoa.DataNasc = Convert.ToDateTime(mskNascimento.Text);
			umaPessoa.Altura = float.Parse(mskAltura.Text);
			umaPessoa.Profissao = txbProfissao.Text;
			return umaPessoa;			
		}

		private int incrementarId()
		{
			int id;
			if(ListaCadastros.Count == 0)
			{
				return 0;
			}
			else
			{
				Pessoa[] pessoaArray = ListaCadastros.ToArray();
				Pessoa pessoa = pessoaArray[pessoaArray.Length - 1];
				id = pessoa.Id;
				return id + 1;
			}

		}

		private void mostrarDataGrid()
		{
			dataGridResultado.DataSource = null;
			dataGridResultado.DataSource = ListaCadastros;
		}

		private void fecharForm()
		{
			var Mensagem = MessageBox.Show("Deseja realmente fechar a aplicação?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (Mensagem == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void verificarId(int id)
		{
			if(ListaCadastros.Count == 0)
			{
				MessageBox.Show("Nenhum usuário foi cadastrado");
			}
			else
			{
				int cont = 1;
				foreach(var Usuarios in ListaCadastros)
				{
					if(Usuarios.Id == Convert.ToInt32(txbNomeAlteradoExcluido.Text))
					{

						liberarLabelTelaAlterar();
						txbNome.Text = Usuarios.Nome.ToString();
						txbProfissao.Text = Usuarios.Profissao.ToString();
						mskNascimento.Text = Usuarios.DataNasc.ToString();
						mskAltura.Text = Usuarios.Altura.ToString();
						cont--;
						if(lblCadastro.Text == "Excluir Cadastro")
						{
							btnAlterar.Visible = false;
							btnExcluir.Visible = true;
						}
						else
						{
							btnAlterar.Visible = true;
							btnExcluir.Visible = false;
						}
					}
				}
				if(cont == 1)
				{
					MessageBox.Show("O ID não existe");
				}
			}
		}

		private bool verificaData()
		{
			try
			{
				Convert.ToDateTime(mskNascimento.Text);
				return true;
			}
			catch
			{
				return false;
			}
		}

		private bool verificarCamposNulosTelaAlterar()
		{
			if(!string.IsNullOrEmpty(txbNome.Text) && !string.IsNullOrEmpty(txbProfissao.Text) && !string.IsNullOrEmpty(txbNomeAlteradoExcluido.Text) && !string.IsNullOrEmpty(mskAltura.Text) && !string.IsNullOrEmpty(mskNascimento.Text))
			{
				return true;
			}
			else{
				return false;
			}
		}
		private bool verificarCamposNulosTelaCadastro()
		{
			if (!string.IsNullOrEmpty(txbNome.Text) && !string.IsNullOrEmpty(txbProfissao.Text) && !string.IsNullOrEmpty(mskAltura.Text) && !string.IsNullOrEmpty(mskNascimento.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void excluirDados()
		{
			foreach (var Usuario in ListaCadastros)
			{
				if (Usuario.Id == Convert.ToInt32(txbNomeAlteradoExcluido.Text))
				{
					ListaCadastros.Remove(Usuario);
					break;
				}
			}
			
		}

		private void alterarDados()
		{
			if(verificarCamposNulosTelaAlterar())
			{
				foreach (var Usuario in ListaCadastros)
				{
					if (Usuario.Id == Convert.ToInt32(txbNomeAlteradoExcluido.Text))
					{
						try
						{
							Usuario.Nome = txbNome.Text;
							Usuario.DataNasc = Convert.ToDateTime(mskNascimento.Text);
							Usuario.Altura = float.Parse(mskAltura.Text);
							Usuario.Profissao = txbProfissao.Text;
							MessageBox.Show("Usuario alterado");
						}
						catch (Exception erro)
						{
							MessageBox.Show("Data invalida");
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Preencha os campos vazios");
			}
		}

		private void pesquisarDados()
		{
			rtbPesquisa.Clear();
			foreach (var Usuario in ListaCadastros)
			{
				if (Usuario.Nome == txbNome.Text)
				{
					rtbPesquisa.AppendText("ID: "+ Usuario.Id + ", Nome: " + Usuario.Nome + ", Profissão: " + Usuario.Profissao + ", Data de Nascimento: " + Usuario.DataNasc + ", Altura: "+ Usuario.Altura + "\n");  
				}
			}
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
			btnPesquisar.Visible = false;
			btnId.Visible = false;
			rtbPesquisa.Visible = false;
			enabledCampo();
			
		}
		private void labelTelaAlterar()
		{
			lblCadastro.Text = "Alterar Cadastro";
			lblAlteradoExcluido.Text = "Procurar Id";
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
			btnAlterar.Visible = false;
			btnCadastrar.Visible = false;
			btnExcluir.Visible = false;
			btnPesquisar.Visible = false;
			btnId.Visible = true;
			rtbPesquisa.Visible = false;
			enabledCampo();
		}
		private void bloquearLabelTelaAlterar()
		{
			lblNome.Visible = false;
			txbNome.Visible = false;
			lblProfissão.Visible = false;
			txbProfissao.Visible = false;
			lblNascimento.Visible = false;
			mskNascimento.Visible = false;
			lblAltura.Visible = false;
			mskAltura.Visible = false;
			btnAlterar.Visible = false;
		}
		private void liberarLabelTelaAlterar()
		{
			lblNome.Visible = true;
			txbNome.Visible = true;
			lblProfissão.Visible = true;
			txbProfissao.Visible = true;
			lblNascimento.Visible = true;
			mskNascimento.Visible = true;
			lblAltura.Visible = true;
			mskAltura.Visible = true;
			btnAlterar.Visible = true;
		}
		private void labelTelaExcluir()
		{
			lblCadastro.Text = "Excluir Cadastro";
			lblAlteradoExcluido.Text = "Procurar Id";
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
			btnAlterar.Visible = false;
			btnCadastrar.Visible = false;
			btnExcluir.Visible = false;
			btnPesquisar.Visible = false;
			btnId.Visible = true;
			rtbPesquisa.Visible = false;
			//Enabled
			lblNome.Enabled = false;
			txbNome.Enabled = false;
			lblProfissão.Enabled= false;
			txbProfissao.Enabled = false;
			lblNascimento.Enabled = false;
			mskNascimento.Enabled = false;
			lblAltura.Enabled = false;
			mskAltura.Enabled = false;
		}
		private void enabledCampo()
		{
			lblNome.Enabled = true;
			txbNome.Enabled = true;
			lblProfissão.Enabled = true;
			txbProfissao.Enabled = true;
			lblNascimento.Enabled = true;
			mskNascimento.Enabled = true;
			lblAltura.Enabled = true;
			mskAltura.Enabled = true;
		}

		private void labelTelaPesquisar()
		{
			lblCadastro.Text = "Pesquisar";
			lblAlteradoExcluido.Visible = false;
			lblAltura.Visible = false;
			lblNascimento.Visible = false;
			lblProfissão.Visible = false;
			lblQuantidadeCadastros.Visible = false;
			txbNomeAlteradoExcluido.Visible = false;
			txbProfissao.Visible = false;
			mskAltura.Visible = false;
			mskNascimento.Visible = false;
			btnAlterar.Visible = false;
			btnCadastrar.Visible = false;
			btnExcluir.Visible = false;
			btnId.Visible = false;
			btnPesquisar.Visible = true;
			rtbPesquisa.Visible = true;
			txbNome.Enabled = true;

		}

	}
}
