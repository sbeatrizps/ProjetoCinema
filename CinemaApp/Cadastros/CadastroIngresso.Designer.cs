namespace CinemaApp.Cadastros
{
    partial class CadastroIngresso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cboSessao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDocumento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboFormaPagamento = new ReaLTaiizor.Controls.MaterialComboBox();
            lblFileira = new ReaLTaiizor.Controls.MaterialLabel();
            numFileira = new NumericUpDown();
            lblAssento = new ReaLTaiizor.Controls.MaterialLabel();
            numAssento = new NumericUpDown();
            chkMeia = new ReaLTaiizor.Controls.MaterialCheckBox();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            lblPrecos = new ReaLTaiizor.Controls.MaterialLabel();
            dataGridViewItens = new DataGridView();
            colFileira = new DataGridViewTextBoxColumn();
            colAssento = new DataGridViewTextBoxColumn();
            colMeia = new DataGridViewCheckBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            btnRemover = new ReaLTaiizor.Controls.MaterialButton();
            lblTotal = new ReaLTaiizor.Controls.MaterialLabel();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFileira).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAssento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            //
            // tabPageCadastro
            //
            tabPageCadastro.Controls.Add(lblTotal);
            tabPageCadastro.Controls.Add(btnRemover);
            tabPageCadastro.Controls.Add(dataGridViewItens);
            tabPageCadastro.Controls.Add(lblPrecos);
            tabPageCadastro.Controls.Add(btnAdicionar);
            tabPageCadastro.Controls.Add(chkMeia);
            tabPageCadastro.Controls.Add(numAssento);
            tabPageCadastro.Controls.Add(lblAssento);
            tabPageCadastro.Controls.Add(numFileira);
            tabPageCadastro.Controls.Add(lblFileira);
            tabPageCadastro.Controls.Add(cboFormaPagamento);
            tabPageCadastro.Controls.Add(txtDocumento);
            tabPageCadastro.Controls.Add(cboSessao);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSessao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDocumento, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFormaPagamento, 0);
            tabPageCadastro.Controls.SetChildIndex(lblFileira, 0);
            tabPageCadastro.Controls.SetChildIndex(numFileira, 0);
            tabPageCadastro.Controls.SetChildIndex(lblAssento, 0);
            tabPageCadastro.Controls.SetChildIndex(numAssento, 0);
            tabPageCadastro.Controls.SetChildIndex(chkMeia, 0);
            tabPageCadastro.Controls.SetChildIndex(btnAdicionar, 0);
            tabPageCadastro.Controls.SetChildIndex(lblPrecos, 0);
            tabPageCadastro.Controls.SetChildIndex(dataGridViewItens, 0);
            tabPageCadastro.Controls.SetChildIndex(btnRemover, 0);
            tabPageCadastro.Controls.SetChildIndex(lblTotal, 0);
            //
            // cboSessao
            //
            cboSessao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboSessao.AutoResize = false;
            cboSessao.BackColor = Color.FromArgb(255, 255, 255);
            cboSessao.Depth = 0;
            cboSessao.DrawMode = DrawMode.OwnerDrawVariable;
            cboSessao.DropDownHeight = 174;
            cboSessao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSessao.DropDownWidth = 121;
            cboSessao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSessao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSessao.FormattingEnabled = true;
            cboSessao.Hint = "Sessão";
            cboSessao.IntegralHeight = false;
            cboSessao.ItemHeight = 43;
            cboSessao.Location = new Point(90, 6);
            cboSessao.MaxDropDownItems = 4;
            cboSessao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSessao.Name = "cboSessao";
            cboSessao.Size = new Size(489, 49);
            cboSessao.StartIndex = 0;
            cboSessao.TabIndex = 5;
            cboSessao.SelectedIndexChanged += cboSessao_SelectedIndexChanged;
            //
            // txtDocumento
            //
            txtDocumento.AnimateReadOnly = false;
            txtDocumento.AutoCompleteMode = AutoCompleteMode.None;
            txtDocumento.AutoCompleteSource = AutoCompleteSource.None;
            txtDocumento.BackgroundImageLayout = ImageLayout.None;
            txtDocumento.CharacterCasing = CharacterCasing.Normal;
            txtDocumento.Depth = 0;
            txtDocumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocumento.HideSelection = true;
            txtDocumento.Hint = "Documento (CPF)";
            txtDocumento.LeadingIcon = null;
            txtDocumento.Location = new Point(6, 61);
            txtDocumento.MaxLength = 20;
            txtDocumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PasswordChar = '\0';
            txtDocumento.PrefixSuffixText = null;
            txtDocumento.ReadOnly = false;
            txtDocumento.RightToLeft = RightToLeft.No;
            txtDocumento.SelectedText = "";
            txtDocumento.SelectionLength = 0;
            txtDocumento.SelectionStart = 0;
            txtDocumento.ShortcutsEnabled = true;
            txtDocumento.Size = new Size(240, 48);
            txtDocumento.TabIndex = 6;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.TrailingIcon = null;
            txtDocumento.UseSystemPasswordChar = false;
            //
            // cboFormaPagamento
            //
            cboFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboFormaPagamento.AutoResize = false;
            cboFormaPagamento.BackColor = Color.FromArgb(255, 255, 255);
            cboFormaPagamento.Depth = 0;
            cboFormaPagamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboFormaPagamento.DropDownHeight = 174;
            cboFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPagamento.DropDownWidth = 121;
            cboFormaPagamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFormaPagamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Hint = "Forma de pagamento";
            cboFormaPagamento.IntegralHeight = false;
            cboFormaPagamento.ItemHeight = 43;
            cboFormaPagamento.Items.AddRange(new object[] { "Dinheiro", "Cartão de crédito", "Cartão de débito", "PIX" });
            cboFormaPagamento.Location = new Point(252, 61);
            cboFormaPagamento.MaxDropDownItems = 4;
            cboFormaPagamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(327, 49);
            cboFormaPagamento.StartIndex = 0;
            cboFormaPagamento.TabIndex = 7;
            //
            // lblFileira
            //
            lblFileira.AutoSize = true;
            lblFileira.Depth = 0;
            lblFileira.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFileira.Location = new Point(6, 116);
            lblFileira.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFileira.Name = "lblFileira";
            lblFileira.Size = new Size(46, 19);
            lblFileira.TabIndex = 8;
            lblFileira.Text = "Fileira";
            //
            // numFileira
            //
            numFileira.Location = new Point(6, 142);
            numFileira.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numFileira.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFileira.Name = "numFileira";
            numFileira.Size = new Size(100, 23);
            numFileira.TabIndex = 9;
            numFileira.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblAssento
            //
            lblAssento.AutoSize = true;
            lblAssento.Depth = 0;
            lblAssento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAssento.Location = new Point(112, 116);
            lblAssento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblAssento.Name = "lblAssento";
            lblAssento.Size = new Size(58, 19);
            lblAssento.TabIndex = 10;
            lblAssento.Text = "Assento";
            //
            // numAssento
            //
            numAssento.Location = new Point(112, 142);
            numAssento.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numAssento.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAssento.Name = "numAssento";
            numAssento.Size = new Size(100, 23);
            numAssento.TabIndex = 11;
            numAssento.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // chkMeia
            //
            chkMeia.AutoSize = true;
            chkMeia.Depth = 0;
            chkMeia.Location = new Point(218, 132);
            chkMeia.Margin = new Padding(0);
            chkMeia.MouseLocation = new Point(-1, -1);
            chkMeia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkMeia.Name = "chkMeia";
            chkMeia.ReadOnly = false;
            chkMeia.Ripple = true;
            chkMeia.Size = new Size(131, 37);
            chkMeia.TabIndex = 12;
            chkMeia.Text = "Meia-entrada";
            chkMeia.UseAccentColor = false;
            chkMeia.UseVisualStyleBackColor = true;
            //
            // btnAdicionar
            //
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(360, 132);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(104, 36);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            //
            // lblPrecos
            //
            lblPrecos.AutoSize = true;
            lblPrecos.Depth = 0;
            lblPrecos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPrecos.Location = new Point(6, 172);
            lblPrecos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblPrecos.Name = "lblPrecos";
            lblPrecos.Size = new Size(220, 19);
            lblPrecos.TabIndex = 14;
            lblPrecos.Text = "Inteira: R$ 0,00  |  Meia: R$ 0,00";
            //
            // dataGridViewItens
            //
            dataGridViewItens.AllowUserToAddRows = false;
            dataGridViewItens.AllowUserToDeleteRows = false;
            dataGridViewItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Columns.AddRange(new DataGridViewColumn[] { colFileira, colAssento, colMeia, colValor });
            dataGridViewItens.Location = new Point(6, 196);
            dataGridViewItens.MultiSelect = false;
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.ReadOnly = true;
            dataGridViewItens.RowHeadersVisible = false;
            dataGridViewItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItens.Size = new Size(573, 155);
            dataGridViewItens.TabIndex = 15;
            //
            // colFileira
            //
            colFileira.DataPropertyName = "Fileira";
            colFileira.HeaderText = "Fileira";
            colFileira.Name = "colFileira";
            colFileira.ReadOnly = true;
            //
            // colAssento
            //
            colAssento.DataPropertyName = "Assento";
            colAssento.HeaderText = "Assento";
            colAssento.Name = "colAssento";
            colAssento.ReadOnly = true;
            //
            // colMeia
            //
            colMeia.DataPropertyName = "MeiaEntrada";
            colMeia.HeaderText = "Meia-entrada";
            colMeia.Name = "colMeia";
            colMeia.ReadOnly = true;
            //
            // colValor
            //
            colValor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            colValor.DefaultCellStyle = dataGridViewCellStyle1;
            colValor.HeaderText = "Valor";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            //
            // btnRemover
            //
            btnRemover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemover.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemover.Depth = 0;
            btnRemover.HighEmphasis = true;
            btnRemover.Icon = null;
            btnRemover.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRemover.Location = new Point(6, 360);
            btnRemover.Margin = new Padding(4, 6, 4, 6);
            btnRemover.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRemover.Name = "btnRemover";
            btnRemover.NoAccentTextColor = Color.Empty;
            btnRemover.Size = new Size(176, 36);
            btnRemover.TabIndex = 16;
            btnRemover.Text = "Remover assento";
            btnRemover.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnRemover.UseAccentColor = false;
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            //
            // lblTotal
            //
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Font = new Font("Roboto", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotal.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            lblTotal.Location = new Point(175, 368);
            lblTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 24);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total: R$ 0,00";
            //
            // CadastroIngresso
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 500);
            Location = new Point(0, 0);
            Name = "CadastroIngresso";
            Text = "Venda de Ingresso";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numFileira).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAssento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboSessao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDocumento;
        private ReaLTaiizor.Controls.MaterialComboBox cboFormaPagamento;
        private ReaLTaiizor.Controls.MaterialLabel lblFileira;
        private NumericUpDown numFileira;
        private ReaLTaiizor.Controls.MaterialLabel lblAssento;
        private NumericUpDown numAssento;
        private ReaLTaiizor.Controls.MaterialCheckBox chkMeia;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private ReaLTaiizor.Controls.MaterialLabel lblPrecos;
        private DataGridView dataGridViewItens;
        private DataGridViewTextBoxColumn colFileira;
        private DataGridViewTextBoxColumn colAssento;
        private DataGridViewCheckBoxColumn colMeia;
        private DataGridViewTextBoxColumn colValor;
        private ReaLTaiizor.Controls.MaterialButton btnRemover;
        private ReaLTaiizor.Controls.MaterialLabel lblTotal;
    }
}
