namespace sistemacompra.vista.frmPadres
{
    partial class frmGestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionar));
            this.btnBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(260, 18);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Icon")));
            this.btnBuscar.Location = new System.Drawing.Point(12, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(515, 33);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.text = "BUSCAR";
            // 
            // btnNuevo
            // 
            this.btnNuevo.ActiveBorderThickness = 1;
            this.btnNuevo.ActiveCornerRadius = 20;
            this.btnNuevo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.ButtonText = "(+) NUEVO";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.IdleBorderThickness = 1;
            this.btnNuevo.IdleCornerRadius = 20;
            this.btnNuevo.IdleFillColor = System.Drawing.Color.White;
            this.btnNuevo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.Location = new System.Drawing.Point(552, 82);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(138, 49);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 533);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmGestionar";
            this.Text = "frmGestionar";
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuTextbox btnBuscar;
        public Bunifu.Framework.UI.BunifuThinButton2 btnNuevo;
    }
}