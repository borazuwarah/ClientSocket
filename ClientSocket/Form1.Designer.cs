namespace ClientSocket
{
    partial class ClientSocket
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
            this.txtTextToServer = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextToServer
            // 
            this.txtTextToServer.Location = new System.Drawing.Point(45, 201);
            this.txtTextToServer.Multiline = true;
            this.txtTextToServer.Name = "txtTextToServer";
            this.txtTextToServer.Size = new System.Drawing.Size(405, 66);
            this.txtTextToServer.TabIndex = 0;
            // 
            // btEnviar
            // 
            this.btEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Location = new System.Drawing.Point(130, 84);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(234, 83);
            this.btEnviar.TabIndex = 1;
            this.btEnviar.Text = "Send to Server";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbTitle.Location = new System.Drawing.Point(183, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(128, 46);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Client";
            // 
            // ClientSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 332);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.txtTextToServer);
            this.MaximizeBox = false;
            this.Name = "ClientSocket";
            this.Text = "Client Socket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextToServer;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Label lbTitle;
    }
}

