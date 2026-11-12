using System.ComponentModel;
using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;
using FluentValidation;

namespace CinemaApp.Cadastros
{
    public partial class CadastroIngresso : CadastroBase
    {
        private readonly IBaseService<Ingresso> _ingressoService;
        private readonly IBaseService<Sessao> _sessaoService;
        private List<IngressoViewModel> _ingressos;
        private List<SessaoViewModel> _sessoes;
        private readonly BindingList<IngressoItemViewModel> _itens = new();
        private Sessao? _sessaoSelecionada;

        public CadastroIngresso(IBaseService<Ingresso> ingressoService, IBaseService<Sessao> sessaoService)
        {
            _ingressoService = ingressoService;
            _sessaoService = sessaoService;
            InitializeComponent();
            dataGridViewItens.AutoGenerateColumns = false;
            dataGridViewItens.DataSource = _itens;
            CarregaComboSessoes();
            AtualizaValores();
        }

        #region Sessão e assentos

        /// <summary>
        /// Lista apenas sessões que ainda não começaram. Na edição, inclui também
        /// a sessão do ingresso carregado, mesmo que já tenha passado.
        /// </summary>
        private void CarregaComboSessoes(int? sessaoIdAtual = null)
        {
            cboSessao.DataSource = null;
            cboSessao.DisplayMember = nameof(SessaoViewModel.Descricao);
            cboSessao.ValueMember = nameof(SessaoViewModel.Id);
            _sessoes = _sessaoService.ReadAll<SessaoViewModel>()
                .Where(s => s.Data > DateTime.Now || s.Id == sessaoIdAtual)
                .OrderBy(s => s.Data)
                .ToList();
            cboSessao.DataSource = _sessoes;
            cboSessao.SelectedIndex = -1;
        }

        private void cboSessao_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sessaoSelecionada = cboSessao.SelectedValue is int sessaoId
                ? _sessaoService.ReadById<Sessao>(sessaoId)
                : null;

            // Fileira/assento limitados ao tamanho da sala da sessão
            numFileira.Maximum = Math.Max(1, _sessaoSelecionada?.Sala?.Fileiras ?? 1);
            numAssento.Maximum = Math.Max(1, _sessaoSelecionada?.Sala?.Assentos ?? 1);
            AtualizaValores();
        }

        private decimal PrecoInteira => _sessaoSelecionada?.Preco ?? 0;
        private decimal PrecoMeia => Math.Round(PrecoInteira / 2, 2);
        private decimal ValorDoAssento(bool meiaEntrada) => meiaEntrada ? PrecoMeia : PrecoInteira;

        private void AtualizaValores()
        {
            foreach (var item in _itens)
                item.Valor = ValorDoAssento(item.MeiaEntrada);
            _itens.ResetBindings();

            lblPrecos.Text = $"Inteira: {PrecoInteira:C2}  |  Meia: {PrecoMeia:C2}";
            lblTotal.Text = $"Total: {_itens.Sum(i => i.Valor):C2}";
        }

        /// <summary>Assentos já vendidos para a sessão em outros ingressos.</summary>
        private HashSet<(int Fileira, int Assento)> AssentosOcupados(int sessaoId)
        {
            var ingressoAtualId = IsEditMode ? Convert.ToInt32(txtId.Text) : 0;
            return _ingressoService.ReadAll<Ingresso>()
                .Where(i => i.Sessao?.Id == sessaoId && i.Id != ingressoAtualId)
                .SelectMany(i => i.IngressoItens ?? new List<IngressoItem>())
                .Select(i => (i.Fileira, i.Assento))
                .ToHashSet();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (_sessaoSelecionada is null)
            {
                MessageBox.Show("Selecione a sessão antes de adicionar assentos.", "Assento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var fileira = Convert.ToInt32(numFileira.Value);
            var assento = Convert.ToInt32(numAssento.Value);

            if (_itens.Any(i => i.Fileira == fileira && i.Assento == assento))
            {
                MessageBox.Show($"O assento {fileira}-{assento} já está nesta venda.", "Assento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (AssentosOcupados(_sessaoSelecionada.Id).Contains((fileira, assento)))
            {
                MessageBox.Show($"O assento {fileira}-{assento} já foi vendido para esta sessão.", "Assento",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _itens.Add(new IngressoItemViewModel
            {
                Fileira = fileira,
                Assento = assento,
                MeiaEntrada = chkMeia.Checked,
                Valor = ValorDoAssento(chkMeia.Checked)
            });
            AtualizaValores();

            // Já deixa sugerido o assento ao lado
            if (numAssento.Value < numAssento.Maximum)
                numAssento.Value++;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.CurrentRow?.DataBoundItem is IngressoItemViewModel item)
            {
                _itens.Remove(item);
                AtualizaValores();
            }
            else
            {
                MessageBox.Show("Selecione um assento para remover.", "Assento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>Confere se os assentos existem na sala e ainda estão livres.</summary>
        private void VerificaAssentos()
        {
            if (_sessaoSelecionada is null)
                return; // o IngressoValidator avisa que a sessão é obrigatória

            if (!IsEditMode && _sessaoSelecionada.Data.ToUniversalTime() <= DateTime.UtcNow)
                throw new InvalidOperationException("Esta sessão já começou. Não é possível vender ingressos para ela.");

            var sala = _sessaoSelecionada.Sala;
            var inexistente = _itens.FirstOrDefault(i => i.Fileira > sala.Fileiras || i.Assento > sala.Assentos);
            if (inexistente is not null)
                throw new InvalidOperationException($"O assento {inexistente.Fileira}-{inexistente.Assento} não existe na sala {sala.Numero}.");

            var ocupados = AssentosOcupados(_sessaoSelecionada.Id);
            var vendido = _itens.FirstOrDefault(i => ocupados.Contains((i.Fileira, i.Assento)));
            if (vendido is not null)
                throw new InvalidOperationException($"O assento {vendido.Fileira}-{vendido.Assento} já foi vendido para esta sessão.");
        }

        #endregion

        private void PreencheObjeto(Ingresso ingresso)
        {
            ingresso.Sessao = _sessaoSelecionada!; // nula é barrada pelo IngressoValidator
            ingresso.Documento = txtDocumento.Text.Trim();
            ingresso.FormaPagamento = cboFormaPagamento.SelectedItem?.ToString() ?? string.Empty;
            ingresso.IngressoItens ??= new List<IngressoItem>();

            // Remove os assentos que saíram da lista
            foreach (var item in ingresso.IngressoItens
                         .Where(i => !_itens.Any(v => v.Fileira == i.Fileira && v.Assento == i.Assento))
                         .ToList())
                ingresso.IngressoItens.Remove(item);

            // Atualiza os que ficaram e inclui os novos
            foreach (var vm in _itens)
            {
                var item = ingresso.IngressoItens.FirstOrDefault(i => i.Fileira == vm.Fileira && i.Assento == vm.Assento);
                if (item is null)
                {
                    item = new IngressoItem { Ingresso = ingresso, Fileira = vm.Fileira, Assento = vm.Assento };
                    ingresso.IngressoItens.Add(item);
                }
                item.MeiaEntrada = vm.MeiaEntrada;
            }

            ingresso.ValorTotal = _itens.Sum(i => i.Valor);
        }

        private void PreencheTela(Ingresso ingresso)
        {
            CarregaComboSessoes(ingresso.Sessao?.Id);
            cboSessao.SelectedItem = _sessoes.FirstOrDefault(s => s.Id == ingresso.Sessao?.Id);
            txtDocumento.Text = ingresso.Documento;
            cboFormaPagamento.SelectedItem = ingresso.FormaPagamento;
            chkMeia.Checked = false;

            _itens.Clear();
            foreach (var item in (ingresso.IngressoItens ?? new List<IngressoItem>())
                         .OrderBy(i => i.Fileira).ThenBy(i => i.Assento))
            {
                _itens.Add(new IngressoItemViewModel
                {
                    Id = item.Id,
                    Fileira = item.Fileira,
                    Assento = item.Assento,
                    MeiaEntrada = item.MeiaEntrada
                });
            }
            AtualizaValores();
        }

        protected override void LimpaCampos()
        {
            base.LimpaCampos();
            CarregaComboSessoes(); // traz sessões cadastradas depois que a tela abriu
            _itens.Clear();
            AtualizaValores();
        }

        protected override void Salvar()
        {
            try
            {
                VerificaAssentos();

                // Valida um rascunho antes de mexer no ingresso rastreado pelo EF:
                // assim uma edição inválida não fica pendente no contexto.
                var rascunho = new Ingresso { DataCompra = DateTime.UtcNow };
                PreencheObjeto(rascunho);
                new IngressoValidator().ValidateAndThrow(rascunho);

                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var ingresso = _ingressoService.ReadById<Ingresso>(id);
                    PreencheObjeto(ingresso);
                    _ingressoService.Update<Ingresso, Ingresso, IngressoValidator>(ingresso);
                }
                else
                {
                    _ingressoService.Create<Ingresso, Ingresso, IngressoValidator>(rascunho);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _ingressoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _ingressos = _ingressoService.ReadAll<IngressoViewModel>()
                .OrderByDescending(i => i.DataCompra)
                .ToList();
            dataGridViewConsulta.DataSource = _ingressos;

            ConfiguraColuna("SessaoId", visivel: false);
            ConfiguraColuna("FilmeNome", "Filme");
            ConfiguraColuna("SessaoData", "Sessão", "dd/MM/yyyy HH:mm");
            ConfiguraColuna("SalaNumero", "Sala");
            ConfiguraColuna("DataCompra", "Compra", "dd/MM/yyyy HH:mm");
            ConfiguraColuna("FormaPagamento", "Pagamento");
            ConfiguraColuna("Quantidade", "Qtd.");
            ConfiguraColuna("ValorTotal", "Total", "C2");

            if (dataGridViewConsulta.Columns["FilmeNome"] is not null)
                dataGridViewConsulta.Columns["FilmeNome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ConfiguraColuna(string nome, string? titulo = null, string? formato = null, bool visivel = true)
        {
            var coluna = dataGridViewConsulta.Columns[nome];
            if (coluna is null)
                return;
            coluna.Visible = visivel;
            if (titulo is not null)
                coluna.HeaderText = titulo;
            if (formato is not null)
                coluna.DefaultCellStyle.Format = formato;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var ingresso = _ingressoService.ReadById<Ingresso>(id);

            txtId.Text = ingresso.Id.ToString();
            PreencheTela(ingresso);
        }
    }
}
