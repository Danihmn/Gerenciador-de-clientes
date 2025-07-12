namespace AppBancoDeDados
{
    partial class EscolherConsulta
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
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 35);
            label1.TabIndex = 0;
            label1.Text = "Consultar cliente";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(353, 70);
            button1.Name = "button1";
            button1.Size = new Size(251, 50);
            button1.TabIndex = 1;
            button1.Text = "Consultar cliente por ID";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 2;
            label2.Text = "Digite o ID do cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 4;
            label3.Text = "Digite o nome do cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 27);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(353, 157);
            button2.Name = "button2";
            button2.Size = new Size(251, 50);
            button2.TabIndex = 6;
            button2.Text = "Consultar cliente por nome";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(12, 244);
            button3.Name = "button3";
            button3.Size = new Size(592, 50);
            button3.TabIndex = 7;
            button3.Text = "Consultar todos os clientes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // EscolherConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 306);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EscolherConsulta";
            Text = "Consultar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}