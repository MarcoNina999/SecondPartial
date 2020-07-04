namespace sistemacompra.vista.frmPadres
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.pbxrecorrer = new System.Windows.Forms.PictureBox();
            this.PanelMenuVertical = new System.Windows.Forms.Panel();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnProvedores = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            this.PanelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxrecorrer)).BeginInit();
            this.PanelMenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.ColumnCount = 1;
            this.PanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(227, 32);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.RowCount = 1;
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.PanelPrincipal.Size = new System.Drawing.Size(709, 556);
            this.PanelPrincipal.TabIndex = 17;
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelEncabezado.Controls.Add(this.btnRestaurar);
            this.PanelEncabezado.Controls.Add(this.btnMinimizar);
            this.PanelEncabezado.Controls.Add(this.btnCerrar);
            this.PanelEncabezado.Controls.Add(this.btnMaximizar);
            this.PanelEncabezado.Controls.Add(this.pbxrecorrer);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.Location = new System.Drawing.Point(227, 0);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(709, 32);
            this.PanelEncabezado.TabIndex = 16;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRestaurar.Location = new System.Drawing.Point(655, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.TabIndex = 51;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMinimizar.Location = new System.Drawing.Point(631, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 50;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnCerrar.Location = new System.Drawing.Point(681, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 50;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMaximizar.Location = new System.Drawing.Point(657, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.TabIndex = 50;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // pbxrecorrer
            // 
            this.pbxrecorrer.BackColor = System.Drawing.Color.Transparent;
            this.pbxrecorrer.Image = ((System.Drawing.Image)(resources.GetObject("pbxrecorrer.Image")));
            this.pbxrecorrer.Location = new System.Drawing.Point(0, 0);
            this.pbxrecorrer.Name = "pbxrecorrer";
            this.pbxrecorrer.Size = new System.Drawing.Size(32, 32);
            this.pbxrecorrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxrecorrer.TabIndex = 0;
            this.pbxrecorrer.TabStop = false;
            this.pbxrecorrer.Click += new System.EventHandler(this.Pbxrecorrer_Click);
            // 
            // PanelMenuVertical
            // 
            this.PanelMenuVertical.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelMenuVertical.Controls.Add(this.btnCompra);
            this.PanelMenuVertical.Controls.Add(this.btnProvedores);
            this.PanelMenuVertical.Controls.Add(this.btnReportes);
            this.PanelMenuVertical.Controls.Add(this.btnProductos);
            this.PanelMenuVertical.Controls.Add(this.label1);
            this.PanelMenuVertical.Controls.Add(this.btnUsuario);
            this.PanelMenuVertical.Controls.Add(this.btnCambiarUsuario);
            this.PanelMenuVertical.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuVertical.Name = "PanelMenuVertical";
            this.PanelMenuVertical.Size = new System.Drawing.Size(227, 588);
            this.PanelMenuVertical.TabIndex = 15;
            this.PanelMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuVertical_Paint);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(21, 221);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(200, 43);
            this.btnCompra.TabIndex = 14;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnProvedores
            // 
            this.btnProvedores.FlatAppearance.BorderSize = 0;
            this.btnProvedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProvedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvedores.ForeColor = System.Drawing.Color.Black;
            this.btnProvedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProvedores.Image")));
            this.btnProvedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvedores.Location = new System.Drawing.Point(21, 172);
            this.btnProvedores.Name = "btnProvedores";
            this.btnProvedores.Size = new System.Drawing.Size(200, 43);
            this.btnProvedores.TabIndex = 13;
            this.btnProvedores.Text = "Provedores";
            this.btnProvedores.UseVisualStyleBackColor = true;
            this.btnProvedores.Click += new System.EventHandler(this.btnProvedores_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(21, 270);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 43);
            this.btnReportes.TabIndex = 12;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(21, 123);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 43);
            this.btnProductos.TabIndex = 8;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "CLOT SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(21, 74);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(200, 43);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCambiarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnCambiarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarUsuario.Image")));
            this.btnCambiarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(21, 532);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(200, 43);
            this.btnCambiarUsuario.TabIndex = 10;
            this.btnCambiarUsuario.Text = "Cambiar usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 588);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelEncabezado);
            this.Controls.Add(this.PanelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.PanelEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxrecorrer)).EndInit();
            this.PanelMenuVertical.ResumeLayout(false);
            this.PanelMenuVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.TableLayoutPanel PanelPrincipal;
        public System.Windows.Forms.Panel PanelEncabezado;
        public System.Windows.Forms.Button btnRestaurar;
        public System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnMaximizar;
        public System.Windows.Forms.Panel PanelMenuVertical;
        public System.Windows.Forms.Button btnProvedores;
        public System.Windows.Forms.Button btnReportes;
        public System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbxrecorrer;
        public System.Windows.Forms.Button btnUsuario;
        public System.Windows.Forms.Button btnCambiarUsuario;
        public System.Windows.Forms.Button btnCompra;
    }
}