namespace Library.Views
{
    partial class InfractionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionForm));
            this.lbAutores = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtReceive1 = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAutores
            // 
            this.lbAutores.BackColor = System.Drawing.Color.Transparent;
            this.lbAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbAutores.Location = new System.Drawing.Point(12, 29);
            this.lbAutores.Name = "lbAutores";
            this.lbAutores.Size = new System.Drawing.Size(1138, 52);
            this.lbAutores.TabIndex = 69;
            this.lbAutores.Text = "Emails";
            this.lbAutores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(62, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 37);
            this.label4.TabIndex = 78;
            this.label4.Text = "Destinatario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(62, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 80;
            this.label5.Text = "Asunto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(57, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 37);
            this.label6.TabIndex = 82;
            this.label6.Text = "Cuerpo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "Enviar correo";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 50D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(142, 667);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(264, 48);
            this.btnSend.TabIndex = 83;
            this.btnSend.Text = "Enviar correo";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(61, 322);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(418, 323);
            this.txtBody.TabIndex = 89;
            // 
            // txtReceive1
            // 
            this.txtReceive1.Location = new System.Drawing.Point(172, 168);
            this.txtReceive1.Multiline = true;
            this.txtReceive1.Name = "txtReceive1";
            this.txtReceive1.Size = new System.Drawing.Size(307, 27);
            this.txtReceive1.TabIndex = 90;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(172, 220);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(307, 27);
            this.txtSubject.TabIndex = 91;
            // 
            // InfractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 845);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtReceive1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAutores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfractionForm";
            this.Text = "InfractionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAutores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnSend;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtReceive1;
        private System.Windows.Forms.TextBox txtSubject;
    }
}