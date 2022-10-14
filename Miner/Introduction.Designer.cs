namespace Miner
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.labelIntroduction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(216, 474);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 31);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Ранее";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForward.Location = new System.Drawing.Point(517, 474);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(99, 31);
            this.buttonForward.TabIndex = 1;
            this.buttonForward.Text = "Далее";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSkip.Location = new System.Drawing.Point(370, 536);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(107, 29);
            this.buttonSkip.TabIndex = 2;
            this.buttonSkip.Text = "Пропустить";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // labelIntroduction
            // 
            this.labelIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.labelIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntroduction.Location = new System.Drawing.Point(203, 156);
            this.labelIntroduction.Name = "labelIntroduction";
            this.labelIntroduction.Size = new System.Drawing.Size(452, 266);
            this.labelIntroduction.TabIndex = 3;
            this.labelIntroduction.Text = resources.GetString("labelIntroduction.Text");
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Miner.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 577);
            this.Controls.Add(this.labelIntroduction);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label labelIntroduction;
    }
}