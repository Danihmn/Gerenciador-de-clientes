namespace AppBancoDeDados
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(134, 102);
            button1.Name = "button1";
            button1.Size = new Size(172, 52);
            button1.TabIndex = 1;
            button1.Text = "Inserir clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(134, 169);
            button2.Name = "button2";
            button2.Size = new Size(172, 52);
            button2.TabIndex = 2;
            button2.Text = "Consultar clientes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(84, 22);
            label1.Name = "label1";
            label1.Size = new Size(276, 35);
            label1.TabIndex = 3;
            label1.Text = "Gerenciador de clientes";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(134, 237);
            button3.Name = "button3";
            button3.Size = new Size(172, 52);
            button3.TabIndex = 4;
            button3.Text = "Remover clientes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 323);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Gerenciador de clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}
