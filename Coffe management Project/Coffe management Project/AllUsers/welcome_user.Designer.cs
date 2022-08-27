namespace Coffe_management_Project.AllUsers
{
    partial class welcome_user
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_user));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.labelBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelBanner
            // 
            this.labelBanner.Image = ((System.Drawing.Image)(resources.GetObject("labelBanner.Image")));
            this.labelBanner.Location = new System.Drawing.Point(0, 0);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(420, 320);
            this.labelBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelBanner.TabIndex = 0;
            this.labelBanner.TabStop = false;
            // 
            // welcome_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelBanner);
            this.Name = "welcome_user";
            this.Size = new System.Drawing.Size(420, 320);
            ((System.ComponentModel.ISupportInitialize)(this.labelBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox labelBanner;
    }
}
