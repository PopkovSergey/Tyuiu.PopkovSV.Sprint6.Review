
namespace Tyuiu.PopkovSV.Sprint6.TaskReview.V30
{
    partial class FormAbout_PSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_PSV));
            this.pictureBoxAvatar_PSV = new System.Windows.Forms.PictureBox();
            this.labelInfo_PSV = new System.Windows.Forms.Label();
            this.buttonClose_PSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PSV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_PSV
            // 
            this.pictureBoxAvatar_PSV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PSV.Image")));
            this.pictureBoxAvatar_PSV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_PSV.Name = "pictureBoxAvatar_PSV";
            this.pictureBoxAvatar_PSV.Size = new System.Drawing.Size(119, 138);
            this.pictureBoxAvatar_PSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_PSV.TabIndex = 0;
            this.pictureBoxAvatar_PSV.TabStop = false;
            // 
            // labelInfo_PSV
            // 
            this.labelInfo_PSV.AutoSize = true;
            this.labelInfo_PSV.Location = new System.Drawing.Point(137, 21);
            this.labelInfo_PSV.Name = "labelInfo_PSV";
            this.labelInfo_PSV.Size = new System.Drawing.Size(290, 117);
            this.labelInfo_PSV.TabIndex = 1;
            this.labelInfo_PSV.Text = resources.GetString("labelInfo_PSV.Text");
            // 
            // buttonClose_PSV
            // 
            this.buttonClose_PSV.Location = new System.Drawing.Point(328, 222);
            this.buttonClose_PSV.Name = "buttonClose_PSV";
            this.buttonClose_PSV.Size = new System.Drawing.Size(99, 30);
            this.buttonClose_PSV.TabIndex = 2;
            this.buttonClose_PSV.Text = "ОК";
            this.buttonClose_PSV.UseVisualStyleBackColor = true;
            this.buttonClose_PSV.Click += new System.EventHandler(this.buttonClose_PSV_Click);
            // 
            // FormAbout_PSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 264);
            this.Controls.Add(this.buttonClose_PSV);
            this.Controls.Add(this.labelInfo_PSV);
            this.Controls.Add(this.pictureBoxAvatar_PSV);
            this.Name = "FormAbout_PSV";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_PSV;
        private System.Windows.Forms.Label labelInfo_PSV;
        private System.Windows.Forms.Button buttonClose_PSV;
    }
}