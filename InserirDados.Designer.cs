namespace AppBancoDeDados
{
    partial class InserirDados
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefone (com DDD)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(12, 324);
            button1.Name = "button1";
            button1.Size = new Size(381, 44);
            button1.TabIndex = 6;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 35);
            label4.TabIndex = 7;
            label4.Text = "Cadastrar cliente";
            // 
            // InserirDados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 379);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InserirDados";
            Text = "Inserir cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
    }
}