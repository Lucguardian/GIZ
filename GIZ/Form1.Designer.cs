namespace GIZ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapBox1 = new SharpMap.Forms.MapBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCamadaRasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovaCamadaVetorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarOprnStreetMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddVector = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddRaster = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddOSM = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMoveVis = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDefVis = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIncVis = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDecVis = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMaxVis = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapBox1
            // 
            this.mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mapBox1.BackColor = System.Drawing.SystemColors.Control;
            this.mapBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapBox1.FineZoomFactor = 10D;
            this.mapBox1.Location = new System.Drawing.Point(127, 59);
            this.mapBox1.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.mapBox1.Name = "mapBox1";
            this.mapBox1.QueryGrowFactor = 5F;
            this.mapBox1.QueryLayerIndex = 0;
            this.mapBox1.SelectionBackColor = System.Drawing.Color.White;
            this.mapBox1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox1.ShowProgressUpdate = false;
            this.mapBox1.Size = new System.Drawing.Size(596, 415);
            this.mapBox1.TabIndex = 0;
            this.mapBox1.Text = "mapBox1";
            this.mapBox1.WheelZoomMagnitude = -2D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCamadaRasterToolStripMenuItem,
            this.adicionarNovaCamadaVetorialToolStripMenuItem,
            this.adicionarOprnStreetMapToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarCamadaRasterToolStripMenuItem
            // 
            this.adicionarCamadaRasterToolStripMenuItem.Name = "adicionarCamadaRasterToolStripMenuItem";
            this.adicionarCamadaRasterToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.adicionarCamadaRasterToolStripMenuItem.Text = "Adicionar Camada Raster";
            this.adicionarCamadaRasterToolStripMenuItem.ToolTipText = "Adiciona uma camada/mapa matricial à visualização atual";
            this.adicionarCamadaRasterToolStripMenuItem.Click += new System.EventHandler(this.adicionarCamadaRasterToolStripMenuItem_Click);
            // 
            // adicionarNovaCamadaVetorialToolStripMenuItem
            // 
            this.adicionarNovaCamadaVetorialToolStripMenuItem.Name = "adicionarNovaCamadaVetorialToolStripMenuItem";
            this.adicionarNovaCamadaVetorialToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.adicionarNovaCamadaVetorialToolStripMenuItem.Text = "Adicionar Camada Vetorial";
            this.adicionarNovaCamadaVetorialToolStripMenuItem.ToolTipText = "Adiciona uma camada/mapa vetorial à visualização atual";
            this.adicionarNovaCamadaVetorialToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovaCamadaVetorialToolStripMenuItem_Click);
            // 
            // adicionarOprnStreetMapToolStripMenuItem
            // 
            this.adicionarOprnStreetMapToolStripMenuItem.Name = "adicionarOprnStreetMapToolStripMenuItem";
            this.adicionarOprnStreetMapToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.adicionarOprnStreetMapToolStripMenuItem.Text = "Adicionar Open Street Map";
            this.adicionarOprnStreetMapToolStripMenuItem.ToolTipText = "Adiciona uma camada/mapa matricial disponível na internet, à visualização atual";
            this.adicionarOprnStreetMapToolStripMenuItem.Click += new System.EventHandler(this.adicionarOprnStreetMapToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddVector,
            this.tsbtnAddRaster,
            this.tsbtnAddOSM,
            this.tsbtnMoveVis,
            this.tsbtnDefVis,
            this.tsbtnIncVis,
            this.tsbtnDecVis,
            this.tsbtnMaxVis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddVector
            // 
            this.tsbtnAddVector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddVector.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddVector.Image")));
            this.tsbtnAddVector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddVector.Name = "tsbtnAddVector";
            this.tsbtnAddVector.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddVector.Text = "Adicionar Camada Vetorial";
            this.tsbtnAddVector.Click += new System.EventHandler(this.tsbtnAddVector_Click);
            // 
            // tsbtnAddRaster
            // 
            this.tsbtnAddRaster.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddRaster.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddRaster.Image")));
            this.tsbtnAddRaster.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddRaster.Name = "tsbtnAddRaster";
            this.tsbtnAddRaster.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddRaster.Text = "Adicionar Camada Raster";
            this.tsbtnAddRaster.Click += new System.EventHandler(this.tsbtnAddRaster_Click);
            // 
            // tsbtnAddOSM
            // 
            this.tsbtnAddOSM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddOSM.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddOSM.Image")));
            this.tsbtnAddOSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddOSM.Name = "tsbtnAddOSM";
            this.tsbtnAddOSM.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddOSM.Text = "Adicionar Open Street Map";
            this.tsbtnAddOSM.Click += new System.EventHandler(this.tsbtnAddOSM_Click);
            // 
            // tsbtnMoveVis
            // 
            this.tsbtnMoveVis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMoveVis.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMoveVis.Image")));
            this.tsbtnMoveVis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMoveVis.Name = "tsbtnMoveVis";
            this.tsbtnMoveVis.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMoveVis.Text = "toolStripButton1";
            this.tsbtnMoveVis.ToolTipText = "Mover Visualização";
            this.tsbtnMoveVis.Click += new System.EventHandler(this.tsbtnMoveVis_Click);
            // 
            // tsbtnDefVis
            // 
            this.tsbtnDefVis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDefVis.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDefVis.Image")));
            this.tsbtnDefVis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDefVis.Name = "tsbtnDefVis";
            this.tsbtnDefVis.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDefVis.Text = "toolStripButton1";
            this.tsbtnDefVis.ToolTipText = "Definir Visualização";
            this.tsbtnDefVis.Click += new System.EventHandler(this.tsbtnDefVis_Click);
            // 
            // tsbtnIncVis
            // 
            this.tsbtnIncVis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIncVis.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIncVis.Image")));
            this.tsbtnIncVis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIncVis.Name = "tsbtnIncVis";
            this.tsbtnIncVis.Size = new System.Drawing.Size(23, 22);
            this.tsbtnIncVis.Text = "toolStripButton1";
            this.tsbtnIncVis.ToolTipText = "Aumentar Visualização";
            this.tsbtnIncVis.Click += new System.EventHandler(this.tsbtnIncVis_Click);
            // 
            // tsbtnDecVis
            // 
            this.tsbtnDecVis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDecVis.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDecVis.Image")));
            this.tsbtnDecVis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDecVis.Name = "tsbtnDecVis";
            this.tsbtnDecVis.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDecVis.Text = "toolStripButton1";
            this.tsbtnDecVis.ToolTipText = "Diminuir Visualização";
            this.tsbtnDecVis.Click += new System.EventHandler(this.tsbtnDecVis_Click);
            // 
            // tsbtnMaxVis
            // 
            this.tsbtnMaxVis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMaxVis.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMaxVis.Image")));
            this.tsbtnMaxVis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMaxVis.Name = "tsbtnMaxVis";
            this.tsbtnMaxVis.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMaxVis.Text = "toolStripButton1";
            this.tsbtnMaxVis.ToolTipText = "Visualizar tudo";
            this.tsbtnMaxVis.Click += new System.EventHandler(this.tsbtnMaxVis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(889, 509);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mapBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GIZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpMap.Forms.MapBox mapBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddVector;
        private System.Windows.Forms.ToolStripButton tsbtnAddRaster;
        private System.Windows.Forms.ToolStripMenuItem adicionarCamadaRasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovaCamadaVetorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnAddOSM;
        private System.Windows.Forms.ToolStripMenuItem adicionarOprnStreetMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnMoveVis;
        private System.Windows.Forms.ToolStripButton tsbtnDefVis;
        private System.Windows.Forms.ToolStripButton tsbtnIncVis;
        private System.Windows.Forms.ToolStripButton tsbtnDecVis;
        private System.Windows.Forms.ToolStripButton tsbtnMaxVis;
    }
}

