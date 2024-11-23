namespace WinFormsTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labelTitulo = new Label();
            labelnombre = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.Cyan;
            panelprincipal.Controls.Add(labelnombre);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labelTitulo);
            panelprincipal.Location = new Point(5, 0);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(796, 454);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panel1_Paint;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(307, 56);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(150, 297);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.MediumSpringGreen;
            buttonver.Location = new Point(70, 220);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(112, 34);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla ";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(70, 174);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(150, 31);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(80, 135);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(165, 21);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(70, 56);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(160, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multipicar";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.BackColor = Color.PaleTurquoise;
            labelnombre.Font = new Font("ROG Fonts", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnombre.Location = new Point(7, 9);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(798, 38);
            labelnombre.TabIndex = 6;
            labelnombre.Text = "Elseo Villalobos Reveles 308187";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labelTitulo;
        private Label labelnumero;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label labelnombre;
    }
}
