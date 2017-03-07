namespace SendSmgWhat
{
    partial class frmSendMensaje
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoDestinatario = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(0, 223);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(43, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Destinatario";
            // 
            // txtNoDestinatario
            // 
            this.txtNoDestinatario.Location = new System.Drawing.Point(46, 42);
            this.txtNoDestinatario.Name = "txtNoDestinatario";
            this.txtNoDestinatario.Size = new System.Drawing.Size(175, 20);
            this.txtNoDestinatario.TabIndex = 2;
            this.txtNoDestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoDestinatario_KeyPress);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(3, 42);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(38, 20);
            this.txtPais.TabIndex = 3;
            this.txtPais.Text = "52";
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoDestinatario_KeyPress);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(3, 86);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(218, 89);
            this.txtMensaje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensaje:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(146, 181);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmSendMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 236);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNoDestinatario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Name = "frmSendMensaje";
            this.Text = "Envio de Mensajes de WhatsApp";
            this.Load += new System.EventHandler(this.frmSendMensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoDestinatario;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
    }
}