using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace OperadorCRUD
{
    public partial class OperadorCRUD : Form
    {
        private Evaluation.Framework.Logic.Operador operadorBusiness;

        private int codOperacao;
        public OperadorCRUD()
        {
            InitializeComponent();
        }
        private void RdbSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            codOperacao = 0;
            txtNomeOperador.Enabled = true;
            txtPercentual.Enabled = true;
            txtCodOperador.Enabled = false;
            txtLimite.Enabled = false;
            txtPraca.Enabled = false;
            txtCodPraca.Visible = false;
            txtCodPraca.Enabled = false;
            cboStatus.Enabled = false;
        }

        private void RdbAtualizar_CheckedChanged(object sender, EventArgs e)
        {
            codOperacao = 2;
            txtNomeOperador.Enabled = true;
            txtPercentual.Enabled = true;
            txtCodOperador.Enabled = false;
            txtLimite.Enabled = true;
            txtPraca.Enabled = true;
            txtCodPraca.Visible = true;
            txtCodPraca.Enabled = true;
            txtPraca.Visible = false;
            txtPraca.Enabled = false;
            cboStatus.Enabled = true;
        }

        private void RdbExcluir_CheckedChanged(object sender, EventArgs e)
        {
            codOperacao = 3;
            txtNomeOperador.Enabled = false;
            txtPercentual.Enabled = false;
            txtCodOperador.Enabled = true;
            txtLimite.Enabled = false;
            txtPraca.Enabled = false;
            txtCodPraca.Visible = false;
            txtCodPraca.Enabled = false;
            txtPraca.Visible = true;
            txtPraca.Enabled = false;
            cboStatus.Enabled = false;
        }

        private void RdbInserir_CheckedChanged(object sender, EventArgs e)
        {
            codOperacao = 1;
            txtPraca.Visible = false;
            txtPraca.Enabled = false;

            lblCodPraca.Text = "Cod. Praça:";
            txtCodOperador.Enabled = false;
            txtLimite.Enabled = true;
            txtNomeOperador.Enabled = true;
            txtPercentual.Enabled = true;
            txtCodPraca.Visible = true;
            txtCodPraca.Enabled = true;
            cboStatus.Enabled = false;
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            switch (codOperacao)
            {
                case (int)Operador.Selecionar:
                    lblCodPraca.Text = "Praça:";
                    SelecionarOperador();
                    break;
                case (int)Operador.Inserir:
                    InserirOperador();
                    break;
                case (int)Operador.Atualizar:
                    AtualizarOperador();
                    break;
                case (int)Operador.Excluir:
                    ExcluirOperador();
                    break;
            }
        }

        private void InserirOperador()
        {
            int operadorCadastrado;

            try
            {
                if (ValidarCamposVazios())
                {
                    if (VerificarRegrasCampos())
                    {
                        Evaluation.Framework.Entity.Operador operador = new Evaluation.Framework.Entity.Operador()
                        {
                            Nome = txtNomeOperador.Text,
                            Ativo = true,
                            Percentual = decimal.Parse(txtPercentual.Text),
                            Limite = decimal.Parse(txtLimite.Text),
                            Praca = txtCodPraca.Text
                        };

                        operadorBusiness = new Evaluation.Framework.Logic.Operador();
                        operadorCadastrado = operadorBusiness.IncluirOperador(operador);

                        if (operadorCadastrado > 0)
                            ExibirMensagem($"Operador {operadorCadastrado}-{operador.Nome} inserido com sucesso!");

                    }
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"O seguinte erro foi apresentado ao inserir novo operador: {ex}");
            }
        }

        private void SelecionarOperador()
        {
            int? percentual = null;
            txtLimite.Enabled = false;
            txtCodPraca.Visible = false;
            txtCodPraca.Enabled = false;
            txtCodOperador.Enabled = false;
            cboStatus.Enabled = false;

            try
            {
                if (!string.IsNullOrEmpty(txtPercentual.Text))
                    percentual = int.Parse(txtPercentual.Text);

                string nome = txtNomeOperador.Text;

                operadorBusiness = new Evaluation.Framework.Logic.Operador();
                var listaOperadores = operadorBusiness.ConsultarOperadores(nome, percentual);

                if (listaOperadores?.Count > 0)
                    FillDataGrid(listaOperadores);
                else
                    ExibirMensagem("Nenhum Operador Encontrado!");
            }
            catch (Exception ex)
            {
                ExibirMensagem($"O seguinte erro foi apresentado ao consultar operador: {ex}");
            }
        }

        private void AtualizarOperador()
        {
            txtCodOperador.Enabled = false;
            txtPraca.Enabled = false;
            txtPraca.Visible = false;

            txtCodPraca.Enabled = true;
            txtCodPraca.Visible = true;
            txtLimite.Enabled = true;
            txtNomeOperador.Enabled = true;
            txtPercentual.Enabled = true;
            cboStatus.Enabled = true;

            try
            {
                if (ValidarCamposVazios())
                {
                    if (VerificarRegrasCampos())
                    {
                        if (ValidarCodPraca())
                        {
                            Evaluation.Framework.Entity.Operador operador = new Evaluation.Framework.Entity.Operador()
                            {
                                Nome = txtNomeOperador.Text,
                                Ativo = cboStatus.SelectedIndex == 0 ? true : false,
                                Percentual = decimal.Parse(txtPercentual.Text),
                                Limite = decimal.Parse(txtLimite.Text),
                                Praca = txtCodPraca.Text
                            };

                            operadorBusiness = new Evaluation.Framework.Logic.Operador();
                            operadorBusiness.AlterarOperador(operador);

                            ExibirMensagem($"Operador {operador.Nome} atualizado com sucesso!");
                        }
                        else
                        {
                            ExibirMensagem("Praça inexistente!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"O seguinte erro foi apresentado ao atualizar o operador: {ex}");
            }
        }

        private void ExcluirOperador()
        {
            txtCodPraca.Visible = false;
            txtPraca.Enabled = false;
            txtLimite.Enabled = false;
            txtPercentual.Enabled = false;
            txtNomeOperador.Enabled = false;

            try
            {
                if (ValidarCodOperador())
                {
                    operadorBusiness = new Evaluation.Framework.Logic.Operador();
                    operadorBusiness.ExcluirOperador(int.Parse(txtCodOperador.Text));

                    ExibirMensagem($"Operador código {txtCodOperador.Text} excluído com sucesso!");
                }
                else
                {
                    ExibirMensagem("Operador inexistente!");
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"O seguinte erro foi apresentado ao excluído o operador: {ex}");
            }
        }

        private bool ValidarCamposVazios()
        {
            StringBuilder camposVerificar = new StringBuilder();

            if (string.IsNullOrEmpty(txtNomeOperador.Text) || string.IsNullOrWhiteSpace(txtNomeOperador.Text))
                camposVerificar.Append("Nome Operador");

            if (string.IsNullOrEmpty(txtPercentual.Text) || string.IsNullOrWhiteSpace(txtPercentual.Text))
                camposVerificar.Append("Percentual");

            if (string.IsNullOrEmpty(txtLimite.Text) || string.IsNullOrWhiteSpace(txtLimite.Text))
                camposVerificar.Append("Limite");


            if ((string.IsNullOrEmpty(txtPraca.Text) || string.IsNullOrWhiteSpace(txtPraca.Text)) &&
                (string.IsNullOrEmpty(txtCodPraca.Text) || string.IsNullOrWhiteSpace(txtCodPraca.Text)))
                camposVerificar.Append("Praça");

            if (camposVerificar.Length > 0)
            {
                ExibirMensagem($"Favor validar o(s) seguinte(s) campo(s): ${camposVerificar}");
                return false;
            }

            return true;
        }

        private bool VerificarRegrasCampos()
        {
            IDictionary<string, string> camposVerificar = new Dictionary<string, string>();

            if (!(decimal.Parse(txtPercentual.Text) >= 0 && decimal.Parse(txtPercentual.Text) <= 100))
                camposVerificar.Add("Percentual", "Valor inválido. Favor inserir valor entre 0 e 100");

            if (!(decimal.Parse(txtLimite.Text) > 0))
                camposVerificar.Add("Limite", "Valor fora da faixa de range");

            if (camposVerificar.Count > 0)
            {
                StringBuilder campos = new StringBuilder();
                foreach (var item in camposVerificar)
                {
                    campos.AppendLine(item.Key + " - " + item.Value);
                }
                ExibirMensagem($"Favor verificar o(s) seguinte(s) campo(s): ${campos}");

                return false;
            }
            return true;
        }

        private bool ValidarCodPraca()
        {
            bool existePraca;
            Evaluation.Framework.Logic.Praca pracaBusiness = new Evaluation.Framework.Logic.Praca();
            existePraca = pracaBusiness.ConsultarPracaPorId(int.Parse(txtCodPraca.Text));

            if (!existePraca)
            {
                return false;
            }

            return true;
        }

        private bool ValidarCodOperador()
        {
            bool existeOperador;
            Evaluation.Framework.Logic.Operador operadorLogic = new Evaluation.Framework.Logic.Operador();
            existeOperador = operadorLogic.ConsultarOperadorPorId(int.Parse(txtCodOperador.Text));

            if (!existeOperador)
            {
                return false;
            }

            return true;
        }

        private void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void FillDataGrid(List<Evaluation.Framework.Entity.Operador> listaOperadores)
        {
            gvOperadores.Visible = true;

            gvOperadores.DataSource = listaOperadores;
        }

        private enum Operador
        {
            Selecionar,
            Inserir,
            Atualizar,
            Excluir
        }

        private void TxtPercentual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
        }

        private void TxtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
        }
    }
}
