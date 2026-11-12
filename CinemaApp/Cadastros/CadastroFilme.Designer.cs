namespace CinemaApp.Cadastros
{
    partial class CadastroFilme
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboGenero = new ReaLTaiizor.Controls.MaterialComboBox();
            cboClassificacao = new ReaLTaiizor.Controls.MaterialComboBox();
            numDuracao = new NumericUpDown();
            lblDuracao = new ReaLTaiizor.Controls.MaterialLabel();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(lblDuracao);
            tabPageCadastro.Controls.Add(numDuracao);
            tabPageCadastro.Controls.Add(cboClassificacao);
            tabPageCadastro.Controls.Add(this.cboGenero);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(this.cboGenero, 0);
            tabPageCadastro.Controls.SetChildIndex(cboClassificacao, 0);
            tabPageCadastro.Controls.SetChildIndex(numDuracao, 0);
            tabPageCadastro.Controls.SetChildIndex(lblDuracao, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(90, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(489, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // cboGenero
            // 
            this.cboGenero.AutoResize = false;
            this.cboGenero.BackColor = Color.FromArgb(255, 255, 255);
            this.cboGenero.Depth = 0;
            this.cboGenero.DrawMode = DrawMode.OwnerDrawVariable;
            this.cboGenero.DropDownHeight = 174;
            this.cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboGenero.DropDownWidth = 121;
            this.cboGenero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.cboGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Hint = "Gênero";
            this.cboGenero.IntegralHeight = false;
            this.cboGenero.ItemHeight = 43;
            this.cboGenero.Location = new Point(158, 61);
            this.cboGenero.MaxDropDownItems = 4;
            this.cboGenero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new Size(293, 49);
            this.cboGenero.StartIndex = 0;
            this.cboGenero.TabIndex = 5;
            // 
            // cboClassificacao
            // 
            cboClassificacao.AutoResize = false;
            cboClassificacao.BackColor = Color.FromArgb(255, 255, 255);
            cboClassificacao.Depth = 0;
            cboClassificacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboClassificacao.DropDownHeight = 174;
            cboClassificacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClassificacao.DropDownWidth = 121;
            cboClassificacao.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboClassificacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboClassificacao.FormattingEnabled = true;
            cboClassificacao.Hint = "Classificação";
            cboClassificacao.IntegralHeight = false;
            cboClassificacao.ItemHeight = 43;
            cboClassificacao.Items.AddRange(new object[] { "L", "6", "10", "12", "14", "16", "18" });
            cboClassificacao.Location = new Point(6, 61);
            cboClassificacao.MaxDropDownItems = 4;
            cboClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboClassificacao.Name = "cboClassificacao";
            cboClassificacao.Size = new Size(146, 49);
            cboClassificacao.StartIndex = 0;
            cboClassificacao.TabIndex = 6;
            // 
            // numerDuracao
            // 
            numDuracao.Location = new Point(457, 87);
            numDuracao.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(120, 23);
            numDuracao.TabIndex = 7;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Depth = 0;
            lblDuracao.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDuracao.Location = new Point(457, 61);
            lblDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(61, 19);
            lblDuracao.TabIndex = 8;
            lblDuracao.Text = "Duração";
            // 
            // CadastroFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 500);
            Location = new Point(0, 0);
            Name = "CadastroFilme";
            Text = "Cadastro de Filme";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboGenero;
        private ReaLTaiizor.Controls.MaterialComboBox cboClassificacao;
        private NumericUpDown numDuracao;
        private ReaLTaiizor.Controls.MaterialLabel lblDuracao;
    }
}