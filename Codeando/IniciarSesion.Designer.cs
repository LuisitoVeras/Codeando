namespace Codeando.Presentation
{
    partial class IniciarSesion
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
            label1 = new Label();
            panel1 = new Panel();
            BtnSalir = new Button();
            button1 = new Button();
            txtContraseña = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(152, 28);
            label1.Name = "label1";
            label1.Size = new Size(721, 83);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 578);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(189, 189, 189);
            BtnSalir.BackgroundImageLayout = ImageLayout.None;
            BtnSalir.FlatStyle = FlatStyle.Popup;
            BtnSalir.Font = new Font("OCR A Extended", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = Color.Black;
            BtnSalir.Location = new Point(928, 11);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(65, 59);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "X";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(189, 189, 189);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("OCR A Extended", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(372, 460);
            button1.Name = "button1";
            button1.Size = new Size(299, 59);
            button1.TabIndex = 5;
            button1.Text = "Codificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(197, 354);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(665, 28);
            txtContraseña.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(242, 242, 242);
            label3.Location = new Point(188, 299);
            label3.Name = "label3";
            label3.Size = new Size(268, 41);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(197, 231);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(665, 28);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(188, 176);
            label2.Name = "label2";
            label2.Size = new Size(193, 41);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1038, 602);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IniciarSesion";
            Text = "Codeando";
            Load += IniciarSesion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContraseña;
        private Label label3;
        private Button button1;
        private Button BtnSalir;
    }
}