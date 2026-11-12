using CinemaApp.Base;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;

namespace CinemaApp.Cadastros
{
    public partial class CadastroSala : CadastroBase
    {
        private readonly IBaseService<Sala> _salaService;
        private List<Sala> _salas;

        public CadastroSala(IBaseService<Sala> salaService)
        {
            _salaService = salaService;
            InitializeComponent();
            AtualizaCapacidade();
        }

        private void PreencheObjeto(Sala sala)
        {
            // Número inválido vira 0 e o SalaValidator devolve a mensagem adequada
            sala.Numero = int.TryParse(txtNumero.Text, out var numero) ? numero : 0;
            sala.Fileiras = Convert.ToInt32(numFileiras.Value);
            sala.Assentos = Convert.ToInt32(numAssentos.Value);
            sala.Capacidade = sala.Fileiras * sala.Assentos;
        }

        private void PreencheTela(Sala sala)
        {
            txtNumero.Text = sala.Numero.ToString();
            numFileiras.Value = Math.Clamp(sala.Fileiras, numFileiras.Minimum, numFileiras.Maximum);
            numAssentos.Value = Math.Clamp(sala.Assentos, numAssentos.Minimum, numAssentos.Maximum);
            AtualizaCapacidade();
        }

        private void AtualizaCapacidade()
        {
            numCapacidade.Value = Math.Min(numFileiras.Value * numAssentos.Value, numCapacidade.Maximum);
        }

        private void numFileirasAssentos_ValueChanged(object sender, EventArgs e)
        {
            AtualizaCapacidade();
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var sala = _salaService.ReadById<Sala>(id);
                    PreencheObjeto(sala);
                    _salaService.Update<Sala, Sala, SalaValidator>(sala);
                }
                else
                {
                    var sala = new Sala();
                    PreencheObjeto(sala);
                    _salaService.Create<Sala, Sala, SalaValidator>(sala);
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
                _salaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _salas = _salaService.ReadAll<Sala>().OrderBy(s => s.Numero).ToList();
            dataGridViewConsulta.DataSource = _salas;

            if (dataGridViewConsulta.Columns["Numero"] is not null)
            {
                dataGridViewConsulta.Columns["Numero"].HeaderText = "Número";
                dataGridViewConsulta.Columns["Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dataGridViewConsulta.Columns["Assentos"] is not null)
                dataGridViewConsulta.Columns["Assentos"].HeaderText = "Assentos por fileira";
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var sala = _salaService.ReadById<Sala>(id);

            txtId.Text = sala.Id.ToString();
            PreencheTela(sala);
        }
    }
}
