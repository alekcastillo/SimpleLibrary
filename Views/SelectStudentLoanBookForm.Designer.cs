namespace Library.Views
{
    partial class SelectStudentLoanBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStudentLoanBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DropStudent = new Bunifu.Framework.UI.BunifuDropdown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 52);
            this.label1.TabIndex = 62;
            this.label1.Text = "Seleccionar estudiante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DropStudent
            // 
            this.DropStudent.BackColor = System.Drawing.Color.Transparent;
            this.DropStudent.BorderRadius = 3;
            this.DropStudent.ForeColor = System.Drawing.Color.White;
            this.DropStudent.Items = new string[0];
            this.DropStudent.Location = new System.Drawing.Point(143, 159);
            this.DropStudent.Margin = new System.Windows.Forms.Padding(4);
            this.DropStudent.Name = "DropStudent";
            this.DropStudent.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.DropStudent.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.DropStudent.selectedIndex = -1;
            this.DropStudent.Size = new System.Drawing.Size(412, 35);
            this.DropStudent.TabIndex = 65;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(108, 159);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.BorderRadius = 0;
            this.btnAction.ButtonText = "Seleccionar";
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.DisabledColor = System.Drawing.Color.Gray;
            this.btnAction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAction.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAction.Iconimage")));
            this.btnAction.Iconimage_right = null;
            this.btnAction.Iconimage_right_Selected = null;
            this.btnAction.Iconimage_Selected = null;
            this.btnAction.IconMarginLeft = 0;
            this.btnAction.IconMarginRight = 0;
            this.btnAction.IconRightVisible = true;
            this.btnAction.IconRightZoom = 0D;
            this.btnAction.IconVisible = true;
            this.btnAction.IconZoom = 90D;
            this.btnAction.IsTab = false;
            this.btnAction.Location = new System.Drawing.Point(206, 257);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAction.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAction.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAction.selected = false;
            this.btnAction.Size = new System.Drawing.Size(241, 48);
            this.btnAction.TabIndex = 66;
            this.btnAction.Text = "Seleccionar";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAction.Textcolor = System.Drawing.Color.White;
            this.btnAction.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(17, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(51, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 67;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // SelectStudentLoanBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 402);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.DropStudent);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectStudentLoanBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectStudentLoanBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown DropStudent;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAction;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}