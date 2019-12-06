namespace WindowsFormsSeaPlane
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.buttonSetSeaPlane = new System.Windows.Forms.Button();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTakePlane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(625, 445);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(676, 12);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(100, 44);
            this.buttonSetPlane.TabIndex = 1;
            this.buttonSetPlane.Text = "Посадить самолёт";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.ButtonSetPlane_Click);
            // 
            // buttonSetSeaPlane
            // 
            this.buttonSetSeaPlane.Location = new System.Drawing.Point(676, 62);
            this.buttonSetSeaPlane.Name = "buttonSetSeaPlane";
            this.buttonSetSeaPlane.Size = new System.Drawing.Size(100, 42);
            this.buttonSetSeaPlane.TabIndex = 2;
            this.buttonSetSeaPlane.Text = "Посадить гидросамолёт";
            this.buttonSetSeaPlane.UseVisualStyleBackColor = true;
            this.buttonSetSeaPlane.Click += new System.EventHandler(this.ButtonSetSeaPlane_Click);
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(686, 310);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(75, 23);
            this.buttonTakePlane.TabIndex = 12;
            this.buttonTakePlane.Text = "На взлёт";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(706, 284);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.maskedTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Взлететь на самолёте";
            // 
            // pictureBoxTakePlane
            // 
            this.pictureBoxTakePlane.Location = new System.Drawing.Point(658, 338);
            this.pictureBoxTakePlane.Name = "pictureBoxTakePlane";
            this.pictureBoxTakePlane.Size = new System.Drawing.Size(122, 100);
            this.pictureBoxTakePlane.TabIndex = 13;
            this.pictureBoxTakePlane.TabStop = false;
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxTakePlane);
            this.Controls.Add(this.buttonTakePlane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetSeaPlane);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.Button buttonSetSeaPlane;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTakePlane;
    }
}