namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            porcento = new Button();
            aspas = new Button();
            ac = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // numero9
            // 
            resources.ApplyResources(numero9, "numero9");
            numero9.Name = "numero9";
            numero9.UseVisualStyleBackColor = true;
            numero9.Click += numero9_Click;
            // 
            // numero7
            // 
            resources.ApplyResources(numero7, "numero7");
            numero7.Name = "numero7";
            numero7.UseVisualStyleBackColor = true;
            numero7.Click += numero7_Click;
            // 
            // numero8
            // 
            resources.ApplyResources(numero8, "numero8");
            numero8.Name = "numero8";
            numero8.UseVisualStyleBackColor = true;
            numero8.Click += numero8_Click;
            // 
            // numero6
            // 
            resources.ApplyResources(numero6, "numero6");
            numero6.Name = "numero6";
            numero6.UseVisualStyleBackColor = true;
            numero6.Click += numero6_Click;
            // 
            // numero5
            // 
            resources.ApplyResources(numero5, "numero5");
            numero5.Name = "numero5";
            numero5.UseVisualStyleBackColor = true;
            numero5.Click += numero5_Click;
            // 
            // numero4
            // 
            resources.ApplyResources(numero4, "numero4");
            numero4.Name = "numero4";
            numero4.UseVisualStyleBackColor = true;
            numero4.Click += numero4_Click;
            // 
            // numero2
            // 
            resources.ApplyResources(numero2, "numero2");
            numero2.Name = "numero2";
            numero2.UseVisualStyleBackColor = true;
            numero2.Click += numero2_Click;
            // 
            // numero1
            // 
            resources.ApplyResources(numero1, "numero1");
            numero1.Name = "numero1";
            numero1.UseVisualStyleBackColor = true;
            numero1.Click += numero1_Click;
            // 
            // numero0
            // 
            resources.ApplyResources(numero0, "numero0");
            numero0.Name = "numero0";
            numero0.UseVisualStyleBackColor = true;
            numero0.Click += numero0_Click;
            // 
            // numero3
            // 
            resources.ApplyResources(numero3, "numero3");
            numero3.Name = "numero3";
            numero3.UseVisualStyleBackColor = true;
            numero3.Click += numero3_Click;
            // 
            // virgula
            // 
            resources.ApplyResources(virgula, "virgula");
            virgula.Name = "virgula";
            virgula.UseVisualStyleBackColor = true;
            virgula.Click += virgula_Click;
            // 
            // delete
            // 
            resources.ApplyResources(delete, "delete");
            delete.Name = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // resultado
            // 
            resources.ApplyResources(resultado, "resultado");
            resultado.Name = "resultado";
            resultado.UseVisualStyleBackColor = true;
            resultado.Click += resultado_Click;
            // 
            // mais
            // 
            resources.ApplyResources(mais, "mais");
            mais.Name = "mais";
            mais.UseVisualStyleBackColor = true;
            mais.Click += mais_Click;
            // 
            // menos
            // 
            resources.ApplyResources(menos, "menos");
            menos.ForeColor = SystemColors.ControlText;
            menos.Name = "menos";
            menos.UseVisualStyleBackColor = true;
            menos.Click += menos_Click;
            // 
            // multiplica
            // 
            resources.ApplyResources(multiplica, "multiplica");
            multiplica.Name = "multiplica";
            multiplica.UseVisualStyleBackColor = true;
            multiplica.Click += multi_Click;
            // 
            // dividir
            // 
            resources.ApplyResources(dividir, "dividir");
            dividir.Name = "dividir";
            dividir.UseVisualStyleBackColor = true;
            dividir.Click += dividir_Click;
            // 
            // porcento
            // 
            resources.ApplyResources(porcento, "porcento");
            porcento.Name = "porcento";
            porcento.UseVisualStyleBackColor = true;
            porcento.Click += porcento_Click;
            // 
            // aspas
            // 
            resources.ApplyResources(aspas, "aspas");
            aspas.Name = "aspas";
            aspas.UseVisualStyleBackColor = true;
            aspas.Click += aspas_Click;
            // 
            // ac
            // 
            resources.ApplyResources(ac, "ac");
            ac.Name = "ac";
            ac.UseVisualStyleBackColor = true;
            ac.Click += ac_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(label1);
            Controls.Add(ac);
            Controls.Add(aspas);
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
            MaximizeBox = false;
            Name = "Form1";
            Tag = "oi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button aspas;
        private Button ac;
        private Label label1;
    }
}
