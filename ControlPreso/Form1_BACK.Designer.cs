namespace ControlPreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contenedorCeldas = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crimenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverDeCeldaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(611, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // contenedorCeldas
            // 
            this.contenedorCeldas.Location = new System.Drawing.Point(0, 28);
            this.contenedorCeldas.Name = "contenedorCeldas";
            this.contenedorCeldas.Size = new System.Drawing.Size(800, 692);
            this.contenedorCeldas.TabIndex = 6;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.liberarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.moverDeCeldaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem1.Text = "Gestion de Prisioneros";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // liberarToolStripMenuItem
            // 
            this.liberarToolStripMenuItem.Name = "liberarToolStripMenuItem";
            this.liberarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.liberarToolStripMenuItem.Text = "Liberar";
            this.liberarToolStripMenuItem.Click += new System.EventHandler(this.liberarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.apellidoToolStripMenuItem,
            this.añosToolStripMenuItem,
            this.crimenToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // apellidoToolStripMenuItem
            // 
            this.apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            this.apellidoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.apellidoToolStripMenuItem.Text = "Apellido";
            this.apellidoToolStripMenuItem.Click += new System.EventHandler(this.apellidoToolStripMenuItem_Click);
            // 
            // añosToolStripMenuItem
            // 
            this.añosToolStripMenuItem.Name = "añosToolStripMenuItem";
            this.añosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.añosToolStripMenuItem.Text = "Años";
            this.añosToolStripMenuItem.Click += new System.EventHandler(this.añosToolStripMenuItem_Click);
            // 
            // crimenToolStripMenuItem
            // 
            this.crimenToolStripMenuItem.Name = "crimenToolStripMenuItem";
            this.crimenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.crimenToolStripMenuItem.Text = "Crimen";
            this.crimenToolStripMenuItem.Click += new System.EventHandler(this.crimenToolStripMenuItem_Click);
            // 
            // moverDeCeldaToolStripMenuItem
            // 
            this.moverDeCeldaToolStripMenuItem.Name = "moverDeCeldaToolStripMenuItem";
            this.moverDeCeldaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.moverDeCeldaToolStripMenuItem.Text = "Mover de Celda";
            this.moverDeCeldaToolStripMenuItem.Click += new System.EventHandler(this.moverDeCeldaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 719);
            this.Controls.Add(this.contenedorCeldas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Control Preso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog LoadFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liberarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crimenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverDeCeldaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel contenedorCeldas;
    }
}

