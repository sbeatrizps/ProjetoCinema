namespace CinemaApp.Cadastros
{
    partial class CadastroSala
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
            txtNumero = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblFileiras = new ReaLTaiizor.Controls.MaterialLabel();
            numFileiras = new NumericUpDown();
            lblAssentos = new ReaLTaiizor.Controls.MaterialLabel();
            numAssentos = new NumericUpDown();
            lblCapacidade = new ReaLTaiizor.Controls.MaterialLabel();
            numCapacidade = new NumericUpDown();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFileiras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAssentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidade).BeginInit();
            SuspendLayout();
            //
            // tabPageCadastro
            //
            tabPageCadastro.Controls.Add(numCapacidade);
            tabPageCadastro.Controls.Add(lblCapacidade);
            tabPageCadastro.Controls.Add(numAssentos);
            tabPageCadastro.Controls.Add(lblAssentos);
            tabPageCadastro.Controls.Add(numFileiras);
            tabPageCadastro.Controls.Add(lblFileiras);
            tabPageCadastro.Controls.Add(txtNumero);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNumero, 0);
            tabPageCadastro.Controls.SetChildIndex(lblFileiras, 0);
            tabPageCadastro.Controls.SetChildIndex(numFileiras, 0);
            tabPageCadastro.Controls.SetChildIndex(lblAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(numAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(lblCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(numCapacidade, 0);
            //
            // txtNumero
            //
            txtNumero.AnimateReadOnly = false;
            txtNumero.AutoCompleteMode = AutoCompleteMode.None;
            txtNumero.AutoCompleteSource = AutoCompleteSource.None;
            txtNumero.BackgroundImageLayout = ImageLayout.None;
            txtNumero.CharacterCasing = CharacterCasing.Normal;
            txtNumero.Depth = 0;
            txtNumero.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumero.HideSelection = true;
            txtNumero.Hint = "Número da sala";
            txtNumero.LeadingIcon = null;
            txtNumero.Location = new Point(90, 6);
            txtNumero.MaxLength = 9;
            txtNumero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumero.Name = "txtNumero";
            txtNumero.PasswordChar = '\0';
            txtNumero.PrefixSuffixText = null;
            txtNumero.ReadOnly = false;
            txtNumero.RightToLeft = RightToLeft.No;
            txtNumero.SelectedText = "";
            txtNumero.SelectionLength = 0;
            txtNumero.SelectionStart = 0;
            txtNumero.ShortcutsEnabled = true;
            txtNumero.Size = new Size(489, 48);
            txtNumero.TabIndex = 5;
            txtNumero.TextAlign = HorizontalAlignment.Left;
            txtNumero.TrailingIcon = null;
            txtNumero.UseSystemPasswordChar = false;
            //
            // lblFileiras
            //
            lblFileiras.AutoSize = true;
            lblFileiras.Depth = 0;
            lblFileiras.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFileiras.Location = new Point(6, 61);
            lblFileiras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFileiras.Name = "lblFileiras";
            lblFileiras.Size = new Size(55, 19);
            lblFileiras.TabIndex = 6;
            lblFileiras.Text = "Fileiras";
            //
            // numFileiras
            //
            numFileiras.Location = new Point(6, 87);
            numFileiras.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numFileiras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFileiras.Name = "numFileiras";
            numFileiras.Size = new Size(180, 23);
            numFileiras.TabIndex = 7;
            numFileiras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numFileiras.ValueChanged += numFileirasAssentos_ValueChanged;
            //
            // lblAssentos
            //
            lblAssentos.AutoSize = true;
            lblAssentos.Depth = 0;
            lblAssentos.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAssentos.Location = new Point(192, 61);
            lblAssentos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblAssentos.Name = "lblAssentos";
            lblAssentos.Size = new Size(141, 19);
            lblAssentos.TabIndex = 8;
            lblAssentos.Text = "Assentos por fileira";
            //
            // numAssentos
            //
            numAssentos.Location = new Point(192, 87);
            numAssentos.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numAssentos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAssentos.Name = "numAssentos";
            numAssentos.Size = new Size(180, 23);
            numAssentos.TabIndex = 9;
            numAssentos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numAssentos.ValueChanged += numFileirasAssentos_ValueChanged;
            //
            // lblCapacidade
            //
            lblCapacidade.AutoSize = true;
            lblCapacidade.Depth = 0;
            lblCapacidade.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCapacidade.Location = new Point(378, 61);
            lblCapacidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCapacidade.Name = "lblCapacidade";
            lblCapacidade.Size = new Size(81, 19);
            lblCapacidade.TabIndex = 10;
            lblCapacidade.Text = "Capacidade";
            //
            // numCapacidade
            //
            numCapacidade.Enabled = false;
            numCapacidade.Location = new Point(378, 87);
            numCapacidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCapacidade.Name = "numCapacidade";
            numCapacidade.Size = new Size(201, 23);
            numCapacidade.TabIndex = 11;
            numCapacidade.TabStop = false;
            numCapacidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // CadastroSala
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 500);
            Location = new Point(0, 0);
            Name = "CadastroSala";
            Text = "Cadastro de Sala";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numFileiras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAssentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumero;
        private ReaLTaiizor.Controls.MaterialLabel lblFileiras;
        private NumericUpDown numFileiras;
        private ReaLTaiizor.Controls.MaterialLabel lblAssentos;
        private NumericUpDown numAssentos;
        private ReaLTaiizor.Controls.MaterialLabel lblCapacidade;
        private NumericUpDown numCapacidade;
    }
}
