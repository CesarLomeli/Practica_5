namespace Practica_5
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
            fileBox = new ListBox();
            fifoBox = new ListBox();
            sjfBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            prioridadesBox = new ListBox();
            label4 = new Label();
            rrBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            nombreBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tiempoBox = new TextBox();
            prioridadBox = new TextBox();
            posicionBox = new ComboBox();
            procesoBox = new ComboBox();
            label11 = new Label();
            procesar = new Button();
            procesosNuevosBox = new ListBox();
            SuspendLayout();
            // 
            // fileBox
            // 
            fileBox.FormattingEnabled = true;
            fileBox.Location = new Point(14, 45);
            fileBox.Name = "fileBox";
            fileBox.Size = new Size(416, 464);
            fileBox.TabIndex = 0;
            // 
            // fifoBox
            // 
            fifoBox.FormattingEnabled = true;
            fifoBox.Location = new Point(436, 45);
            fifoBox.Name = "fifoBox";
            fifoBox.Size = new Size(416, 464);
            fifoBox.TabIndex = 1;
            // 
            // sjfBox
            // 
            sjfBox.FormattingEnabled = true;
            sjfBox.Location = new Point(860, 45);
            sjfBox.Name = "sjfBox";
            sjfBox.Size = new Size(414, 464);
            sjfBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Procesos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 22);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "First in first out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(860, 22);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Shortest Job First";
            // 
            // prioridadesBox
            // 
            prioridadesBox.FormattingEnabled = true;
            prioridadesBox.Location = new Point(14, 552);
            prioridadesBox.Name = "prioridadesBox";
            prioridadesBox.Size = new Size(416, 464);
            prioridadesBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 529);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "Prioridades";
            // 
            // rrBox
            // 
            rrBox.FormattingEnabled = true;
            rrBox.Location = new Point(436, 552);
            rrBox.Name = "rrBox";
            rrBox.Size = new Size(416, 464);
            rrBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 529);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 9;
            label5.Text = "Round robin con fifo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(860, 529);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 10;
            label6.Text = "Nuevo proceso";
            // 
            // nombreBox
            // 
            nombreBox.Location = new Point(1040, 548);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(234, 27);
            nombreBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(861, 555);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 12;
            label7.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(861, 595);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 13;
            label8.Text = "Tiempo de duración";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(861, 638);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 14;
            label9.Text = "Prioridad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(861, 685);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 15;
            label10.Text = "Posición";
            // 
            // tiempoBox
            // 
            tiempoBox.Location = new Point(1040, 588);
            tiempoBox.Name = "tiempoBox";
            tiempoBox.Size = new Size(234, 27);
            tiempoBox.TabIndex = 16;
            // 
            // prioridadBox
            // 
            prioridadBox.Location = new Point(1040, 631);
            prioridadBox.Name = "prioridadBox";
            prioridadBox.Size = new Size(234, 27);
            prioridadBox.TabIndex = 17;
            // 
            // posicionBox
            // 
            posicionBox.FormattingEnabled = true;
            posicionBox.Items.AddRange(new object[] { "Inicio", "Final" });
            posicionBox.Location = new Point(1040, 677);
            posicionBox.Name = "posicionBox";
            posicionBox.Size = new Size(234, 28);
            posicionBox.TabIndex = 18;
            // 
            // procesoBox
            // 
            procesoBox.FormattingEnabled = true;
            procesoBox.Items.AddRange(new object[] { "Fifo", "Sjf", "Prioridades", "Round robin" });
            procesoBox.Location = new Point(1040, 726);
            procesoBox.Name = "procesoBox";
            procesoBox.Size = new Size(234, 28);
            procesoBox.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(866, 734);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 20;
            label11.Text = "Proceso";
            // 
            // procesar
            // 
            procesar.Location = new Point(866, 774);
            procesar.Name = "procesar";
            procesar.Size = new Size(408, 29);
            procesar.TabIndex = 21;
            procesar.Text = "Procesar";
            procesar.UseVisualStyleBackColor = true;
            procesar.Click += procesar_Click;
            // 
            // procesosNuevosBox
            // 
            procesosNuevosBox.FormattingEnabled = true;
            procesosNuevosBox.Location = new Point(866, 812);
            procesosNuevosBox.Name = "procesosNuevosBox";
            procesosNuevosBox.Size = new Size(408, 204);
            procesosNuevosBox.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 1053);
            Controls.Add(procesosNuevosBox);
            Controls.Add(procesar);
            Controls.Add(label11);
            Controls.Add(procesoBox);
            Controls.Add(posicionBox);
            Controls.Add(prioridadBox);
            Controls.Add(tiempoBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(nombreBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rrBox);
            Controls.Add(label4);
            Controls.Add(prioridadesBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sjfBox);
            Controls.Add(fifoBox);
            Controls.Add(fileBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fileBox;
        private ListBox fifoBox;
        private ListBox sjfBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox prioridadesBox;
        private Label label4;
        private ListBox rrBox;
        private Label label5;
        private Label label6;
        private TextBox nombreBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tiempoBox;
        private TextBox prioridadBox;
        private ComboBox posicionBox;
        private ComboBox procesoBox;
        private Label label11;
        private Button procesar;
        private ListBox procesosNuevosBox;
    }
}
