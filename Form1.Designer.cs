namespace WinFormsApp2
{
    partial class Janela
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
        private void InitializeComponent()
        {
            numero9 = new Button();
            numero7 = new Button();
            numero8 = new Button();
            numero6 = new Button();
            numero5 = new Button();
            numero4 = new Button();
            numero2 = new Button();
            numero1 = new Button();
            numero0 = new Button();
            numero3 = new Button();
            virgula = new Button();
            delete = new Button();
            resultado = new Button();
            mais = new Button();
            menos = new Button();
            multiplica = new Button();
            dividir = new Button();
            Texto1 = new Label();
            porcento = new Button();
            cochetes = new Button();
            ac = new Button();
            SuspendLayout();
            // 
            // numero9
            // 
            numero9.Font = new Font("Segoe UI", 15F);
            numero9.Location = new Point(109, 151);
            numero9.Name = "numero9";
            numero9.Size = new Size(48, 48);
            numero9.TabIndex = 0;
            numero9.Text = "9";
            numero9.UseVisualStyleBackColor = true;
            numero9.Click += numero9_Click;
            // 
            // numero7
            // 
            numero7.Font = new Font("Segoe UI", 15F);
            numero7.Location = new Point(1, 151);
            numero7.Name = "numero7";
            numero7.Size = new Size(48, 48);
            numero7.TabIndex = 2;
            numero7.Text = "7";
            numero7.UseVisualStyleBackColor = true;
            numero7.Click += numero7_Click;
            // 
            // numero8
            // 
            numero8.Font = new Font("Segoe UI", 15F);
            numero8.Location = new Point(55, 151);
            numero8.Name = "numero8";
            numero8.Size = new Size(48, 48);
            numero8.TabIndex = 3;
            numero8.Text = "8";
            numero8.UseVisualStyleBackColor = true;
            numero8.Click += numero8_Click;
            // 
            // numero6
            // 
            numero6.Font = new Font("Segoe UI", 15F);
            numero6.ImeMode = ImeMode.NoControl;
            numero6.Location = new Point(109, 205);
            numero6.Name = "numero6";
            numero6.Size = new Size(48, 49);
            numero6.TabIndex = 4;
            numero6.Text = "6";
            numero6.UseVisualStyleBackColor = true;
            numero6.Click += numero6_Click;
            // 
            // numero5
            // 
            numero5.Font = new Font("Segoe UI", 15F);
            numero5.Location = new Point(55, 205);
            numero5.Name = "numero5";
            numero5.Size = new Size(48, 49);
            numero5.TabIndex = 5;
            numero5.Text = "5";
            numero5.UseVisualStyleBackColor = true;
            numero5.Click += numero5_Click;
            // 
            // numero4
            // 
            numero4.Font = new Font("Segoe UI", 15F);
            numero4.Location = new Point(1, 205);
            numero4.Name = "numero4";
            numero4.Size = new Size(48, 49);
            numero4.TabIndex = 6;
            numero4.Text = "4";
            numero4.UseVisualStyleBackColor = true;
            numero4.Click += numero4_Click;
            // 
            // numero2
            // 
            numero2.Font = new Font("Segoe UI", 15F);
            numero2.Location = new Point(55, 260);
            numero2.Name = "numero2";
            numero2.Size = new Size(48, 49);
            numero2.TabIndex = 7;
            numero2.Text = "2";
            numero2.UseVisualStyleBackColor = true;
            numero2.Click += numero2_Click;
            // 
            // numero1
            // 
            numero1.Font = new Font("Segoe UI", 15F);
            numero1.Location = new Point(1, 260);
            numero1.Name = "numero1";
            numero1.Size = new Size(48, 49);
            numero1.TabIndex = 8;
            numero1.Text = "1";
            numero1.UseVisualStyleBackColor = true;
            numero1.Click += numero1_Click;
            // 
            // numero0
            // 
            numero0.Font = new Font("Segoe UI", 15F);
            numero0.Location = new Point(1, 315);
            numero0.Name = "numero0";
            numero0.Size = new Size(48, 49);
            numero0.TabIndex = 9;
            numero0.Text = "0";
            numero0.UseVisualStyleBackColor = true;
            numero0.Click += numero0_Click;
            // 
            // numero3
            // 
            numero3.Font = new Font("Segoe UI", 15F);
            numero3.Location = new Point(109, 260);
            numero3.Name = "numero3";
            numero3.Size = new Size(48, 49);
            numero3.TabIndex = 10;
            numero3.Text = "3";
            numero3.UseVisualStyleBackColor = true;
            numero3.Click += numero3_Click;
            // 
            // virgula
            // 
            virgula.Font = new Font("Segoe UI Historic", 23.25F, FontStyle.Bold);
            virgula.Location = new Point(55, 315);
            virgula.Name = "virgula";
            virgula.Size = new Size(48, 49);
            virgula.TabIndex = 11;
            virgula.Text = ",";
            virgula.UseVisualStyleBackColor = true;
            virgula.Click += virgula_Click;
            // 
            // delete
            // 
            delete.Location = new Point(109, 315);
            delete.Name = "delete";
            delete.Size = new Size(48, 49);
            delete.TabIndex = 12;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // resultado
            // 
            resultado.Font = new Font("Segoe UI", 15F);
            resultado.Location = new Point(187, 315);
            resultado.Name = "resultado";
            resultado.Size = new Size(48, 49);
            resultado.TabIndex = 13;
            resultado.Text = "=";
            resultado.UseVisualStyleBackColor = true;
            resultado.Click += resultado_Click;
            // 
            // mais
            // 
            mais.Font = new Font("Segoe UI", 15F);
            mais.Location = new Point(187, 260);
            mais.Name = "mais";
            mais.Size = new Size(48, 49);
            mais.TabIndex = 14;
            mais.Text = "+";
            mais.UseVisualStyleBackColor = true;
            mais.Click += mais_Click;
            // 
            // menos
            // 
            menos.Font = new Font("Segoe UI", 15F);
            menos.ForeColor = SystemColors.ControlText;
            menos.Location = new Point(187, 205);
            menos.Name = "menos";
            menos.Size = new Size(48, 49);
            menos.TabIndex = 15;
            menos.Text = "-";
            menos.UseVisualStyleBackColor = true;
            menos.Click += menos_Click;
            // 
            // multiplica
            // 
            multiplica.Font = new Font("Segoe UI", 15F);
            multiplica.Location = new Point(187, 151);
            multiplica.Name = "multiplica";
            multiplica.Size = new Size(48, 49);
            multiplica.TabIndex = 16;
            multiplica.Text = "x";
            multiplica.UseVisualStyleBackColor = true;
            multiplica.Click += multi_Click;
            // 
            // dividir
            // 
            dividir.Font = new Font("Segoe UI", 20F);
            dividir.Location = new Point(187, 96);
            dividir.Name = "dividir";
            dividir.Size = new Size(48, 49);
            dividir.TabIndex = 17;
            dividir.Text = "÷";
            dividir.UseVisualStyleBackColor = true;
            dividir.Click += dividir_Click;
            // 
            // Texto1
            // 
            Texto1.AutoSize = true;
            Texto1.Font = new Font("Segoe UI", 30F);
            Texto1.Location = new Point(29, 24);
            Texto1.Name = "Texto1";
            Texto1.Size = new Size(0, 54);
            Texto1.TabIndex = 21;
            Texto1.Click += label1_Click_1;
            // 
            // porcento
            // 
            porcento.Font = new Font("Segoe UI", 15F);
            porcento.Location = new Point(109, 96);
            porcento.Name = "porcento";
            porcento.Size = new Size(48, 49);
            porcento.TabIndex = 18;
            porcento.Text = "%";
            porcento.UseVisualStyleBackColor = true;
            porcento.Click += porcento_Click;
            // 
            // cochetes
            // 
            cochetes.Font = new Font("Segoe UI", 15F);
            cochetes.Location = new Point(55, 96);
            cochetes.Name = "cochetes";
            cochetes.Size = new Size(48, 49);
            cochetes.TabIndex = 19;
            cochetes.Text = "( )";
            cochetes.UseVisualStyleBackColor = true;
            cochetes.Click += aspas_Click;
            // 
            // ac
            // 
            ac.Font = new Font("Segoe UI", 15F);
            ac.Location = new Point(1, 96);
            ac.Name = "ac";
            ac.Size = new Size(48, 49);
            ac.TabIndex = 20;
            ac.Text = "AC";
            ac.UseVisualStyleBackColor = true;
            ac.Click += ac_Click;
            // 
            // Janela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(237, 368);
            Controls.Add(Texto1);
            Controls.Add(ac);
            Controls.Add(cochetes);
            Controls.Add(porcento);
            Controls.Add(dividir);
            Controls.Add(multiplica);
            Controls.Add(menos);
            Controls.Add(mais);
            Controls.Add(resultado);
            Controls.Add(delete);
            Controls.Add(virgula);
            Controls.Add(numero3);
            Controls.Add(numero0);
            Controls.Add(numero1);
            Controls.Add(numero2);
            Controls.Add(numero4);
            Controls.Add(numero5);
            Controls.Add(numero6);
            Controls.Add(numero8);
            Controls.Add(numero7);
            Controls.Add(numero9);
            Font = new Font("Segoe UI", 9F);
            MaximizeBox = false;
            Name = "Janela";
            Tag = "Uma calculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        private Button numero9;
        private Button numero7;
        private Button numero8;
        private Button numero6;
        private Button numero5;
        private Button numero4;
        private Button numero2;
        private Button numero1;
        private Button numero0;
        private Button numero3;
        private Button virgula;
        private Button delete;
        private Button resultado;
        private Button mais;
        private Button menos;
        private Button multiplica;
        private Button dividir;
        private Button porcento;
        private Button cochetes;
        private Button ac;
        private Label Texto1;
    }
}
