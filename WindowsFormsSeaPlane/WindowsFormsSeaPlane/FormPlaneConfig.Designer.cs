namespace WindowsFormsSeaPlane
{
    partial class FormPlaneConfig
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
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelSeaPlane = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBox.SuspendLayout();
            this.panelPlane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(15, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(155, 112);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelSeaPlane);
            this.groupBox.Controls.Add(this.labelPlane);
            this.groupBox.Location = new System.Drawing.Point(12, 22);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(141, 100);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Создать самолёт";
            // 
            // labelSeaPlane
            // 
            this.labelSeaPlane.AllowDrop = true;
            this.labelSeaPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeaPlane.Location = new System.Drawing.Point(6, 64);
            this.labelSeaPlane.Name = "labelSeaPlane";
            this.labelSeaPlane.Size = new System.Drawing.Size(100, 34);
            this.labelSeaPlane.TabIndex = 3;
            this.labelSeaPlane.Text = "Гидросамолёт";
            this.labelSeaPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSeaPlane_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.AllowDrop = true;
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(6, 16);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(100, 38);
            this.labelPlane.TabIndex = 2;
            this.labelPlane.Text = "Самолёт";
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.labelDopColor);
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Controls.Add(this.labelBaseColor);
            this.panelPlane.Location = new System.Drawing.Point(178, 12);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(187, 248);
            this.panelPlane.TabIndex = 2;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(43, 177);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 33);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Дополнительный";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(43, 136);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(100, 29);
            this.labelBaseColor.TabIndex = 3;
            this.labelBaseColor.Text = "Основной";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.DarkOrange;
            this.panelYellow.Location = new System.Drawing.Point(482, 191);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(57, 33);
            this.panelYellow.TabIndex = 23;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(402, 191);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(57, 33);
            this.panelGray.TabIndex = 22;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.Location = new System.Drawing.Point(482, 140);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(57, 33);
            this.panelGold.TabIndex = 21;
            this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(402, 140);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(57, 33);
            this.panelRed.TabIndex = 20;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(482, 91);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(57, 33);
            this.panelBlue.TabIndex = 19;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(402, 91);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(57, 33);
            this.panelGreen.TabIndex = 18;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(482, 43);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(57, 33);
            this.panelWhite.TabIndex = 17;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(402, 43);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(57, 33);
            this.panelBlack.TabIndex = 16;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AllowDrop = true;
            this.buttonAdd.Location = new System.Drawing.Point(18, 149);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 24);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 179);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(77, 24);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 309);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelGray);
            this.Controls.Add(this.panelGold);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panelBlack);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panelPlane);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelSeaPlane;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}