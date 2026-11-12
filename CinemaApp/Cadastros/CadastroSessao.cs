using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;

namespace CinemaApp.Cadastros
{
    public partial class CadastroSessao : CadastroBase
    {
        private readonly IBaseService<Sessao> _sessaoService;
        private readonly IBaseService<Filme> _filmeService;
        private readonly IBaseService<Sala> _salaService;
        private List<SessaoViewModel> _sessoes;
        private List<FilmeViewModel> _filmes;
        private List<SalaViewModel> _salas;

        public CadastroSessao(IBaseService<Sessao> sessaoService,
                              IBaseService<Filme> filmeService,
                              IBaseService<Sala> salaService)
        {
            _sessaoService = sessaoService;
            _filmeService = filmeService;
            _salaService = salaService;
            InitializeComponent();
            CarregaComboFilmes();
            CarregaComboSalas();
            dtpData.Value = ProximaHoraCheia();
        }

        private void CarregaComboFilmes()
        {
            cboFilme.DisplayMember = nameof(FilmeViewModel.Nome);
            cboFilme.ValueMember = nameof(FilmeViewModel.Id);
            _filmes = _filmeService.ReadAll<FilmeViewModel>().OrderBy(f => f.Nome).ToList();
            cboFilme.DataSource = null;
            cboFilme.DataSource = _filmes;
            cboFilme.SelectedIndex = -1;
        }

        private void CarregaComboSalas()
        {
            cboSala.DisplayMember = nameof(SalaViewModel.Descricao);
            cboSala.ValueMember = nameof(SalaViewModel.Id);
            _salas = _salaService.ReadAll<SalaViewModel>().OrderBy(s => s.Numero).ToList();
            cboSala.DataSource = null;
            cboSala.DataSource = _salas;
            cboSala.SelectedIndex = -1;
        }

        private static DateTime ProximaHoraCheia()
        {
            var agora = DateTime.Now;
            return new DateTime(agora.Year, agora.Month, agora.Day, agora.Hour, 0, 0).AddHours(1);
        }

        private void PreencheObjeto(Sessao sessao)
        {
            // Filme/Sala nulos são barrados pelo SessaoValidator com a mensagem adequada
            sessao.Filme = cboFilme.SelectedValue is int filmeId ? _filmeService.ReadById<Filme>(filmeId) : null!;
            sessao.Sala = cboSala.SelectedValue is int salaId ? _salaService.ReadById<Sala>(salaId) : null!;
            // A coluna é "timestamp with time zone": o Npgsql só aceita DateTime em UTC
            sessao.Data = dtpData.Value.ToUniversalTime();
            sessao.Preco = numPreco.Value;
        }

        private void PreencheTela(Sessao sessao)
        {
            cboFilme.SelectedItem = _filmes.FirstOrDefault(f => f.Id == sessao.Filme?.Id);
            cboSala.SelectedItem = _salas.FirstOrDefault(s => s.Id == sessao.Sala?.Id);
            dtpData.Value = sessao.Data.ToLocalTime();
            numPreco.Value = Math.Clamp(sessao.Preco, numPreco.Minimum, numPreco.Maximum);
        }

        protected override void LimpaCampos()
        {
            base.LimpaCampos();
            dtpData.Value = ProximaHoraCheia();
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var sessao = _sessaoService.ReadById<Sessao>(id);
                    PreencheObjeto(sessao);
                    _sessaoService.Update<Sessao, Sessao, SessaoValidator>(sessao);
                }
                else
                {
                    var sessao = new Sessao();
                    PreencheObjeto(sessao);
                    _sessaoService.Create<Sessao, Sessao, SessaoValidator>(sessao);
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
                _sessaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _sessoes = _sessaoService.ReadAll<SessaoViewModel>().OrderBy(s => s.Data).ToList();
            dataGridViewConsulta.DataSource = _sessoes;

            if (dataGridViewConsulta.Columns["FilmeId"] is not null)
                dataGridViewConsulta.Columns["FilmeId"].Visible = false;
            if (dataGridViewConsulta.Columns["SalaId"] is not null)
                dataGridViewConsulta.Columns["SalaId"].Visible = false;
            if (dataGridViewConsulta.Columns["Descricao"] is not null)
                dataGridViewConsulta.Columns["Descricao"].Visible = false;
            if (dataGridViewConsulta.Columns["FilmeNome"] is not null)
            {
                dataGridViewConsulta.Columns["FilmeNome"].HeaderText = "Filme";
                dataGridViewConsulta.Columns["FilmeNome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dataGridViewConsulta.Columns["SalaNumero"] is not null)
                dataGridViewConsulta.Columns["SalaNumero"].HeaderText = "Sala";
            if (dataGridViewConsulta.Columns["Data"] is not null)
            {
                dataGridViewConsulta.Columns["Data"].HeaderText = "Data e hora";
                dataGridViewConsulta.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dataGridViewConsulta.Columns["Preco"] is not null)
            {
                dataGridViewConsulta.Columns["Preco"].HeaderText = "Preço";
                dataGridViewConsulta.Columns["Preco"].DefaultCellStyle.Format = "C2";
            }
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var sessao = _sessaoService.ReadById<Sessao>(id);

            txtId.Text = sessao.Id.ToString();
            PreencheTela(sessao);
        }
    }
}
