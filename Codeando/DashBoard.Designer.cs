namespace Codeando.Presentation
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            txtCodigo = new TextBox();
            txtConsola = new TextBox();
            BtnCompilar = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(79, 79, 79);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(12, 12);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(645, 571);
            txtCodigo.TabIndex = 0;
            txtCodigo.Text = resources.GetString("txtCodigo.Text");
            // 
            // txtConsola
            // 
            txtConsola.BackColor = Color.Black;
            txtConsola.BorderStyle = BorderStyle.None;
            txtConsola.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsola.ForeColor = Color.White;
            txtConsola.Location = new Point(680, 12);
            txtConsola.Multiline = true;
            txtConsola.Name = "txtConsola";
            txtConsola.ReadOnly = true;
            txtConsola.Size = new Size(319, 571);
            txtConsola.TabIndex = 1;
            // 
            // BtnCompilar
            // 
            BtnCompilar.BackColor = Color.FromArgb(189, 189, 189);
            BtnCompilar.BackgroundImageLayout = ImageLayout.None;
            BtnCompilar.FlatStyle = FlatStyle.Popup;
            BtnCompilar.Font = new Font("OCR A Extended", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCompilar.ForeColor = Color.Black;
            BtnCompilar.Location = new Point(376, 621);
            BtnCompilar.Name = "BtnCompilar";
            BtnCompilar.Size = new Size(299, 59);
            BtnCompilar.TabIndex = 6;
            BtnCompilar.Text = "Compílar";
            BtnCompilar.UseVisualStyleBackColor = false;
            BtnCompilar.Click += button1_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1026, 728);
            Controls.Add(BtnCompilar);
            Controls.Add(txtConsola);
            Controls.Add(txtCodigo);
            Name = "DashBoard";
            Text = "DashBoard";
            FormClosed += DashBoard_FormClosed;
            Load += DashBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtConsola;
        private Button BtnCompilar;
    }
}