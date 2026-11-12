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
            lblData = new ReaLTaiizor.Controls.MaterialLabel();
            dtpData = new DateTimePicker();
            lblPreco = new ReaLTaiizor.Controls.MaterialLabel();
            numPreco = new NumericUpDown();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            //
            // tabPageCadastro
            //
            tabPageCadastro.Controls.Add(numPreco);
            tabPageCadastro.Controls.Add(lblPreco);
            tabPageCadastro.Controls.Add(dtpData);
            tabPageCadastro.Controls.Add(lblData);
            tabPageCadastro.Controls.Add(cboSala);
            tabPageCadastro.Controls.Add(cboFilme);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFilme, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSala, 0);
            tabPageCadastro.Controls.SetChildIndex(lblData, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpData, 0);
            tabPageCadastro.Controls.SetChildIndex(lblPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(numPreco, 0);
            //
            // cboFilme
            //
            cboFilme.AutoResize = false;
            cboFilme.BackColor = Color.FromArgb(255, 255, 255);
            cboFilme.Depth = 0;
            cboFilme.DrawMode = DrawMode.OwnerDrawVariable;
            cboFilme.DropDownHeight = 174;
            cboFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilme.DropDownWidth = 121;
            cboFilme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFilme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFilme.FormattingEnabled = true;
            cboFilme.Hint = "Filme";
            cboFilme.IntegralHeight = false;
            cboFilme.ItemHeight = 43;
            cboFilme.Location = new Point(90, 6);
            cboFilme.MaxDropDownItems = 4;
            cboFilme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(489, 49);
            cboFilme.StartIndex = 0;
            cboFilme.TabIndex = 5;
            //
            // cboSala
            //
            cboSala.AutoResize = false;
            cboSala.BackColor = Color.FromArgb(255, 255, 255);
            cboSala.Depth = 0;
            cboSala.DrawMode = DrawMode.OwnerDrawVariable;
            cboSala.DropDownHeight = 174;
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.DropDownWidth = 121;
            cboSala.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSala.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSala.FormattingEnabled = true;
            cboSala.Hint = "Sala";
            cboSala.IntegralHeight = false;
            cboSala.ItemHeight = 43;
            cboSala.Location = new Point(6, 61);
            cboSala.MaxDropDownItems = 4;
            cboSala.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(240, 49);
            cboSala.StartIndex = 0;
            cboSala.TabIndex = 6;
            //
            // lblData
            //
            lblData.AutoSize = true;
            lblData.Depth = 0;
            lblData.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblData.Location = new Point(252, 61);
            lblData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblData.Name = "lblData";
            lblData.Size = new Size(84, 19);
            lblData.TabIndex = 7;
            lblData.Text = "Data e hora";
            //
            // dtpData
            //
            dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.Location = new Point(252, 87);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(180, 23);
            dtpData.TabIndex = 8;
            //
            // lblPreco
            //
            lblPreco.AutoSize = true;
            lblPreco.Depth = 0;
            lblPreco.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPreco.Location = new Point(438, 61);
            lblPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(77, 19);
            lblPreco.TabIndex = 9;
            lblPreco.Text = "Preço (R$)";
            //
            // numPreco
            //
            numPreco.DecimalPlaces = 2;
            numPreco.Increment = new decimal(new int[] { 50, 0, 0, 131072 });
            numPreco.Location = new Point(438, 87);
            numPreco.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(141, 23);
            numPreco.TabIndex = 10;
            numPreco.ThousandsSeparator = true;
            //
            // CadastroSessao
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 500);
            Location = new Point(0, 0);
            Name = "CadastroSessao";
            Text = "Cadastro de Sessão";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboFilme;
        private ReaLTaiizor.Controls.MaterialComboBox cboSala;
        private ReaLTaiizor.Controls.MaterialLabel lblData;
        private DateTimePicker dtpData;
        private ReaLTaiizor.Controls.MaterialLabel lblPreco;
        private NumericUpDown numPreco;
    }
}
