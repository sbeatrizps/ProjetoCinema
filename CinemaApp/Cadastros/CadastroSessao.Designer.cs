namespace CinemaApp.Cadastros
{
    partial class CadastroSessao
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
            cboFilme = new ReaLTaiizor.Controls.MaterialComboBox();
            cboSala = new ReaLTaiizor.Controls.MaterialComboBox();
            dtpData = new DateTimePicker();
            dtpHora = new DateTimePicker();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            txtPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(materialLabel2);
            tabPageCadastro.Controls.Add(materialLabel1);
            tabPageCadastro.Controls.Add(cboFilme);
            tabPageCadastro.Controls.Add(cboSala);
            tabPageCadastro.Controls.Add(dtpData);
            tabPageCadastro.Controls.Add(dtpHora);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(639, 595);
            tabPageCadastro.Controls.SetChildIndex(dtpHora, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpData, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSala, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFilme, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel1, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel2, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(647, 628);
            // 
            // cboFilme
            // 
            cboFilme.AutoResize = false;
            cboFilme.BackColor = Color.FromArgb(255, 255, 255);
            cboFilme.Depth = 0;
            cboFilme.DrawMode = DrawMode.OwnerDrawVariable;
            cboFilme.DropDownHeight = 218;
            cboFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilme.DropDownWidth = 121;
            cboFilme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFilme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFilme.Hint = "Filme";
            cboFilme.IntegralHeight = false;
            cboFilme.ItemHeight = 54;
            cboFilme.Location = new Point(21, 89);
            cboFilme.Margin = new Padding(3, 4, 3, 4);
            cboFilme.MaxDropDownItems = 4;
            cboFilme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(599, 60);
            cboFilme.StartIndex = 0;
            cboFilme.TabIndex = 4;
            // 
            // cboSala
            // 
            cboSala.AutoResize = false;
            cboSala.BackColor = Color.FromArgb(255, 255, 255);
            cboSala.Depth = 0;
            cboSala.DrawMode = DrawMode.OwnerDrawVariable;
            cboSala.DropDownHeight = 218;
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.DropDownWidth = 121;
            cboSala.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSala.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSala.Hint = "Sala";
            cboSala.IntegralHeight = false;
            cboSala.ItemHeight = 54;
            cboSala.Location = new Point(116, 21);
            cboSala.Margin = new Padding(3, 4, 3, 4);
            cboSala.MaxDropDownItems = 4;
            cboSala.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(504, 60);
            cboSala.StartIndex = 0;
            cboSala.TabIndex = 5;
            // 
            // dtpData
            // 
            dtpData.Font = new Font("Segoe UI", 14F);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(275, 186);
            dtpData.Margin = new Padding(3, 4, 3, 4);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(139, 39);
            dtpData.TabIndex = 6;
            // 
            // dtpHora
            // 
            dtpHora.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpHora.Font = new Font("Segoe UI", 14F);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(436, 186);
            dtpHora.Margin = new Padding(3, 4, 3, 4);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(159, 39);
            dtpHora.TabIndex = 7;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(276, 158);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(43, 24);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Data";
            // 
            // txtPreco
            // 
            txtPreco.AllowPromptAsInput = true;
            txtPreco.AnimateReadOnly = false;
            txtPreco.AsciiOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.BeepOnError = false;
            txtPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HidePromptOnLeave = false;
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.InsertKeyMode = InsertKeyMode.Default;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(21, 165);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Mask = "$ 009.99";
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.PromptChar = ' ';
            txtPreco.ReadOnly = false;
            txtPreco.RejectInputOnFirstFailure = false;
            txtPreco.ResetOnPrompt = true;
            txtPreco.ResetOnSpace = true;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 9;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(239, 60);
            txtPreco.SkipLiterals = true;
            txtPreco.TabIndex = 9;
            txtPreco.TabStop = false;
            txtPreco.Text = "  100";
            txtPreco.TextAlign = HorizontalAlignment.Right;
            txtPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.ValidatingType = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(436, 158);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(44, 24);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Hora";
            // 
            // CadastroSessao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 711);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(653, 711);
            Name = "CadastroSessao";
            Padding = new Padding(3, 78, 3, 5);
            Text = "CadastroSessao";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboFilme;
        private ReaLTaiizor.Controls.MaterialComboBox cboSala;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPreco;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}