
namespace BuscadorDeArchivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.RutaFolderBusqueda = new System.Windows.Forms.TextBox();
            this.RutaFolderResultado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoPatronBusqueda = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroFolderRevisados = new System.Windows.Forms.Label();
            this.numeroCoincidenciasEncontradas = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numeroArchivosRevisados = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cambiar Carpeta de Búsqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RutaFolderBusqueda
            // 
            this.RutaFolderBusqueda.Location = new System.Drawing.Point(46, 55);
            this.RutaFolderBusqueda.Name = "RutaFolderBusqueda";
            this.RutaFolderBusqueda.Size = new System.Drawing.Size(553, 22);
            this.RutaFolderBusqueda.TabIndex = 1;
            this.RutaFolderBusqueda.Click += new System.EventHandler(this.button1_Click);
            this.RutaFolderBusqueda.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // RutaFolderResultado
            // 
            this.RutaFolderResultado.Location = new System.Drawing.Point(46, 122);
            this.RutaFolderResultado.Name = "RutaFolderResultado";
            this.RutaFolderResultado.Size = new System.Drawing.Size(553, 22);
            this.RutaFolderResultado.TabIndex = 2;
            this.RutaFolderResultado.Click += new System.EventHandler(this.button2_Click);
            this.RutaFolderResultado.DoubleClick += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cambiar Carpeta de Resultados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carpeta donde se buscarán los archivos (Búsqueda)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carpeta donde se copiarán los archivos encontrados (Resultados)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patrón de búsqueda";
            // 
            // textoPatronBusqueda
            // 
            this.textoPatronBusqueda.Location = new System.Drawing.Point(46, 207);
            this.textoPatronBusqueda.Name = "textoPatronBusqueda";
            this.textoPatronBusqueda.Size = new System.Drawing.Size(341, 22);
            this.textoPatronBusqueda.TabIndex = 7;
            this.textoPatronBusqueda.Text = "(fisico|físico|financiero|\\.\\.\\.|60|fin|fis)";
            this.textoPatronBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textoPatronBusqueda.Leave += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(49, 281);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(550, 266);
            this.logBox.TabIndex = 8;
            this.logBox.DoubleClick += new System.EventHandler(this.logBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Información (Solo lectura)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Folders revisados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(654, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Coincidencias encontradas";
            // 
            // numeroFolderRevisados
            // 
            this.numeroFolderRevisados.AutoSize = true;
            this.numeroFolderRevisados.Location = new System.Drawing.Point(654, 301);
            this.numeroFolderRevisados.Name = "numeroFolderRevisados";
            this.numeroFolderRevisados.Size = new System.Drawing.Size(18, 17);
            this.numeroFolderRevisados.TabIndex = 13;
            this.numeroFolderRevisados.Text = "--";
            // 
            // numeroCoincidenciasEncontradas
            // 
            this.numeroCoincidenciasEncontradas.AutoSize = true;
            this.numeroCoincidenciasEncontradas.Location = new System.Drawing.Point(654, 488);
            this.numeroCoincidenciasEncontradas.Name = "numeroCoincidenciasEncontradas";
            this.numeroCoincidenciasEncontradas.Size = new System.Drawing.Size(18, 17);
            this.numeroCoincidenciasEncontradas.TabIndex = 14;
            this.numeroCoincidenciasEncontradas.Text = "--";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 63);
            this.button3.TabIndex = 16;
            this.button3.Text = "Iniciar Búsqueda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(654, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Archivos revisados";
            // 
            // numeroArchivosRevisados
            // 
            this.numeroArchivosRevisados.AutoSize = true;
            this.numeroArchivosRevisados.Location = new System.Drawing.Point(654, 359);
            this.numeroArchivosRevisados.Name = "numeroArchivosRevisados";
            this.numeroArchivosRevisados.Size = new System.Drawing.Size(18, 17);
            this.numeroArchivosRevisados.TabIndex = 18;
            this.numeroArchivosRevisados.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Por favor primero vaciar carpeta de resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 559);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numeroArchivosRevisados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numeroCoincidenciasEncontradas);
            this.Controls.Add(this.numeroFolderRevisados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.textoPatronBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RutaFolderResultado);
            this.Controls.Add(this.RutaFolderBusqueda);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RutaFolderBusqueda;
        private System.Windows.Forms.TextBox RutaFolderResultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoPatronBusqueda;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numeroFolderRevisados;
        private System.Windows.Forms.Label numeroCoincidenciasEncontradas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label numeroArchivosRevisados;
        private System.Windows.Forms.Label label9;
    }
}

