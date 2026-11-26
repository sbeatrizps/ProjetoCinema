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
            numDuracao = new ReaLTaiizor.Controls.MetroNumeric();
            cboClassificacao = new ReaLTaiizor.Controls.MaterialComboBox();
            cboGenero = new ReaLTaiizor.Controls.MaterialComboBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialLabel1);
            tabPageCadastro.Controls.Add(cboGenero);
            tabPageCadastro.Controls.Add(cboClassificacao);
            tabPageCadastro.Controls.Add(numDuracao);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(639, 595);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(numDuracao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboClassificacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboGenero, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel1, 0);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(647, 628);
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
            txtNome.Location = new Point(116, 21);
            txtNome.Margin = new Padding(3, 4, 3, 4);
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
            txtNome.Size = new Size(504, 60);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // numDuracao
            // 
            numDuracao.BackColor = Color.Transparent;
            numDuracao.BackgroundColor = Color.Empty;
            numDuracao.BorderColor = Color.FromArgb(150, 150, 150);
            numDuracao.Decrement = 1;
            numDuracao.DisabledBackColor = Color.FromArgb(204, 204, 204);
            numDuracao.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            numDuracao.DisabledForeColor = Color.FromArgb(136, 136, 136);
            numDuracao.Font = new Font("Microsoft Sans Serif", 10F);
            numDuracao.HoldInterval = 10;
            numDuracao.Increment = 1;
            numDuracao.IsDerivedStyle = true;
            numDuracao.Location = new Point(499, 123);
            numDuracao.Margin = new Padding(3, 4, 3, 4);
            numDuracao.Maximum = 1000;
            numDuracao.Minimum = 10;
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(121, 26);
            numDuracao.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            numDuracao.StyleManager = null;
            numDuracao.SymbolsColor = Color.FromArgb(128, 128, 128);
            numDuracao.TabIndex = 4;
            numDuracao.Text = "metroNumeric1";
            numDuracao.ThemeAuthor = "Taiizor";
            numDuracao.ThemeName = "MetroLight";
            numDuracao.Value = 10;
            // 
            // cboClassificacao
            // 
            cboClassificacao.AutoResize = false;
            cboClassificacao.BackColor = Color.FromArgb(255, 255, 255);
            cboClassificacao.Depth = 0;
            cboClassificacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboClassificacao.DropDownHeight = 218;
            cboClassificacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClassificacao.DropDownWidth = 121;
            cboClassificacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboClassificacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboClassificacao.FormattingEnabled = true;
            cboClassificacao.Hint = "Classificação";
            cboClassificacao.IntegralHeight = false;
            cboClassificacao.ItemHeight = 54;
            cboClassificacao.Items.AddRange(new object[] { "Livre", "6 anos", "10 anos", "12 anos", "14 anos", "16 anos", "18 anos" });
            cboClassificacao.Location = new Point(21, 89);
            cboClassificacao.Margin = new Padding(3, 4, 3, 4);
            cboClassificacao.MaxDropDownItems = 4;
            cboClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboClassificacao.Name = "cboClassificacao";
            cboClassificacao.Size = new Size(165, 60);
            cboClassificacao.StartIndex = 0;
            cboClassificacao.TabIndex = 1;
            // 
            // cboGenero
            // 
            cboGenero.AutoResize = false;
            cboGenero.BackColor = Color.FromArgb(255, 255, 255);
            cboGenero.Depth = 0;
            cboGenero.DrawMode = DrawMode.OwnerDrawVariable;
            cboGenero.DropDownHeight = 218;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.DropDownWidth = 121;
            cboGenero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboGenero.FormattingEnabled = true;
            cboGenero.Hint = "Genero";
            cboGenero.IntegralHeight = false;
            cboGenero.ItemHeight = 54;
            cboGenero.Location = new Point(192, 89);
            cboGenero.Margin = new Padding(3, 4, 3, 4);
            cboGenero.MaxDropDownItems = 4;
            cboGenero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(299, 60);
            cboGenero.StartIndex = 0;
            cboGenero.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(499, 89);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(75, 24);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Duração";
            // 
            // CadastroFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 711);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(653, 711);
            Name = "CadastroFilme";
            Padding = new Padding(3, 78, 3, 5);
            Text = "CadastroFilme";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboGenero;
        private ReaLTaiizor.Controls.MaterialComboBox cboClassificacao;
        private ReaLTaiizor.Controls.MetroNumeric numDuracao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}