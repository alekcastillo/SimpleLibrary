namespace Library.Views
{
    partial class BookTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTypeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAutores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFilter = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.DataGridBookType = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBookType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 52);
            this.label1.TabIndex = 59;
            this.label1.Text = "Lista de tipos de libros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAutores
            // 
            this.lbAutores.BackColor = System.Drawing.Color.Transparent;
            this.lbAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbAutores.Location = new System.Drawing.Point(27, 10);
            this.lbAutores.Name = "lbAutores";
            this.lbAutores.Size = new System.Drawing.Size(1009, 52);
            this.lbAutores.TabIndex = 58;
            this.lbAutores.Text = "Tipos de libros";
            this.lbAutores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label7.Location = new System.Drawing.Point(58, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 36);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ingrese el tipo de libro a buscar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Editar tipo de libro";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 50D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(270, 685);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(241, 48);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Text = "Editar tipo de libro";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Eliminar tipo de libro";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 50D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(23, 684);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(241, 48);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Eliminar tipo de libro";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.txtFilter.Location = new System.Drawing.Point(62, 259);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(259, 35);
            this.txtFilter.TabIndex = 55;
            // 
            // DataGridBookType
            // 
            this.DataGridBookType.AllowUserToAddRows = false;
            this.DataGridBookType.AllowUserToDeleteRows = false;
            this.DataGridBookType.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridBookType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBookType.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridBookType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBookType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBookType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridBookType.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridBookType.DoubleBuffered = true;
            this.DataGridBookType.EnableHeadersVisualStyles = false;
            this.DataGridBookType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.DataGridBookType.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.DataGridBookType.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridBookType.Location = new System.Drawing.Point(23, 310);
            this.DataGridBookType.MultiSelect = false;
            this.DataGridBookType.Name = "DataGridBookType";
            this.DataGridBookType.ReadOnly = true;
            this.DataGridBookType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBookType.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridBookType.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridBookType.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridBookType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBookType.Size = new System.Drawing.Size(1013, 349);
            this.DataGridBookType.TabIndex = 51;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Agregar tipo de libro";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(795, 685);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(241, 48);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Agregar tipo de libro";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ver inventario";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(517, 685);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 60;
            this.bunifuFlatButton1.Text = "Ver inventario";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BookTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 742);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAutores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.DataGridBookType);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTypeForm";
            this.Text = "BookTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBookType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAutores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtFilter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridBookType;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}