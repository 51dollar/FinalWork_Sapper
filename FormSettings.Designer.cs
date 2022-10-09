namespace FinalWork_Sapper
{
    partial class FormSettings
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
            this.XFields = new System.Windows.Forms.Label();
            this.hScrollBarBomb = new System.Windows.Forms.HScrollBar();
            this.Cancel = new System.Windows.Forms.Button();
            this.hScrollBarY = new System.Windows.Forms.HScrollBar();
            this.hScrollBarX = new System.Windows.Forms.HScrollBar();
            this.Bombs = new System.Windows.Forms.Label();
            this.YFields = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.HandComplexity = new System.Windows.Forms.CheckBox();
            this.Сomplexity = new System.Windows.Forms.Label();
            this.CheckedComplexity = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // XFields
            // 
            this.XFields.AutoSize = true;
            this.XFields.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XFields.Location = new System.Drawing.Point(242, 61);
            this.XFields.Name = "XFields";
            this.XFields.Size = new System.Drawing.Size(101, 29);
            this.XFields.TabIndex = 0;
            this.XFields.Text = "Ширина";
            // 
            // hScrollBarBomb
            // 
            this.hScrollBarBomb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hScrollBarBomb.Location = new System.Drawing.Point(478, 163);
            this.hScrollBarBomb.Name = "hScrollBarBomb";
            this.hScrollBarBomb.Size = new System.Drawing.Size(241, 33);
            this.hScrollBarBomb.TabIndex = 4;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(21, 220);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(113, 40);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // hScrollBarY
            // 
            this.hScrollBarY.Location = new System.Drawing.Point(478, 104);
            this.hScrollBarY.Name = "hScrollBarY";
            this.hScrollBarY.Size = new System.Drawing.Size(241, 33);
            this.hScrollBarY.TabIndex = 8;
            // 
            // hScrollBarX
            // 
            this.hScrollBarX.Location = new System.Drawing.Point(478, 61);
            this.hScrollBarX.Name = "hScrollBarX";
            this.hScrollBarX.Size = new System.Drawing.Size(241, 33);
            this.hScrollBarX.TabIndex = 9;
            // 
            // Bombs
            // 
            this.Bombs.AutoSize = true;
            this.Bombs.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bombs.Location = new System.Drawing.Point(242, 148);
            this.Bombs.Name = "Bombs";
            this.Bombs.Size = new System.Drawing.Size(153, 58);
            this.Bombs.TabIndex = 10;
            this.Bombs.Text = "Количество \nбомб";
            // 
            // YFields
            // 
            this.YFields.AutoSize = true;
            this.YFields.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YFields.Location = new System.Drawing.Point(242, 104);
            this.YFields.Name = "YFields";
            this.YFields.Size = new System.Drawing.Size(96, 29);
            this.YFields.TabIndex = 11;
            this.YFields.Text = "Высота";
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ok.Location = new System.Drawing.Point(601, 220);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(118, 40);
            this.Ok.TabIndex = 12;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // HandComplexity
            // 
            this.HandComplexity.AutoSize = true;
            this.HandComplexity.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandComplexity.Location = new System.Drawing.Point(242, 20);
            this.HandComplexity.Name = "HandComplexity";
            this.HandComplexity.Size = new System.Drawing.Size(254, 33);
            this.HandComplexity.TabIndex = 13;
            this.HandComplexity.Text = "Настроить вручную";
            this.HandComplexity.UseVisualStyleBackColor = true;
            this.HandComplexity.CheckedChanged += new System.EventHandler(this.HandComplexity_CheckedChanged);
            // 
            // Сomplexity
            // 
            this.Сomplexity.AutoSize = true;
            this.Сomplexity.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Сomplexity.Location = new System.Drawing.Point(21, 20);
            this.Сomplexity.Name = "Сomplexity";
            this.Сomplexity.Size = new System.Drawing.Size(200, 29);
            this.Сomplexity.TabIndex = 14;
            this.Сomplexity.Text = "Сложность игры";
            this.Сomplexity.Click += new System.EventHandler(this.Сomplexity_Click);
            // 
            // CheckedComplexity
            // 
            this.CheckedComplexity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckedComplexity.CheckOnClick = true;
            this.CheckedComplexity.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckedComplexity.FormattingEnabled = true;
            this.CheckedComplexity.Items.AddRange(new object[] {
            "Легко",
            "Средне",
            "Сложно"});
            this.CheckedComplexity.Location = new System.Drawing.Point(21, 57);
            this.CheckedComplexity.Name = "CheckedComplexity";
            this.CheckedComplexity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckedComplexity.Size = new System.Drawing.Size(131, 97);
            this.CheckedComplexity.TabIndex = 15;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 278);
            this.Controls.Add(this.CheckedComplexity);
            this.Controls.Add(this.Сomplexity);
            this.Controls.Add(this.HandComplexity);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.YFields);
            this.Controls.Add(this.Bombs);
            this.Controls.Add(this.hScrollBarX);
            this.Controls.Add(this.hScrollBarY);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.hScrollBarBomb);
            this.Controls.Add(this.XFields);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label XFields;
        private HScrollBar hScrollBarBomb;
        private Button Cancel;
        private HScrollBar hScrollBarY;
        private HScrollBar hScrollBarX;
        private Label Bombs;
        private Label YFields;
        private Button Ok;
        private CheckBox HandComplexity;
        private Label Сomplexity;
        private CheckedListBox CheckedComplexity;
    }
}