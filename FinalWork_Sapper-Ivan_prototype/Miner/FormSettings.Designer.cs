namespace Miner
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
            this.hScrollBarX = new System.Windows.Forms.HScrollBar();
            this.XFields = new System.Windows.Forms.Label();
            this.HandComplexity = new System.Windows.Forms.CheckBox();
            this.Complexity = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.СheckedComplexity = new System.Windows.Forms.CheckedListBox();
            this.Bombs = new System.Windows.Forms.Label();
            this.hScrollBarBomb = new System.Windows.Forms.HScrollBar();
            this.YFields = new System.Windows.Forms.Label();
            this.hScrollBarY = new System.Windows.Forms.HScrollBar();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hScrollBarX
            // 
            this.hScrollBarX.Location = new System.Drawing.Point(425, 90);
            this.hScrollBarX.Name = "hScrollBarX";
            this.hScrollBarX.Size = new System.Drawing.Size(155, 21);
            this.hScrollBarX.TabIndex = 0;
            // 
            // XFields
            // 
            this.XFields.AutoSize = true;
            this.XFields.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XFields.Location = new System.Drawing.Point(262, 82);
            this.XFields.Name = "XFields";
            this.XFields.Size = new System.Drawing.Size(101, 29);
            this.XFields.TabIndex = 1;
            this.XFields.Text = "Ширина";
            // 
            // HandComplexity
            // 
            this.HandComplexity.AutoSize = true;
            this.HandComplexity.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandComplexity.Location = new System.Drawing.Point(301, 34);
            this.HandComplexity.Name = "HandComplexity";
            this.HandComplexity.Size = new System.Drawing.Size(254, 33);
            this.HandComplexity.TabIndex = 2;
            this.HandComplexity.Text = "Настроить вручную";
            this.HandComplexity.UseVisualStyleBackColor = true;
            this.HandComplexity.CheckedChanged += new System.EventHandler(this.HandComplexity_CheckedChanged);
            // 
            // Complexity
            // 
            this.Complexity.AutoSize = true;
            this.Complexity.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complexity.Location = new System.Drawing.Point(48, 34);
            this.Complexity.Name = "Complexity";
            this.Complexity.Size = new System.Drawing.Size(200, 29);
            this.Complexity.TabIndex = 3;
            this.Complexity.Text = "Сложность игры";
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok.Location = new System.Drawing.Point(455, 251);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(125, 39);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // СheckedComplexity
            // 
            this.СheckedComplexity.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.СheckedComplexity.FormattingEnabled = true;
            this.СheckedComplexity.Items.AddRange(new object[] {
            "Легко",
            "Средне",
            "Сложно"});
            this.СheckedComplexity.Location = new System.Drawing.Point(53, 82);
            this.СheckedComplexity.Name = "СheckedComplexity";
            this.СheckedComplexity.Size = new System.Drawing.Size(123, 97);
            this.СheckedComplexity.TabIndex = 5;
            // 
            // Bombs
            // 
            this.Bombs.AutoSize = true;
            this.Bombs.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bombs.Location = new System.Drawing.Point(262, 177);
            this.Bombs.Name = "Bombs";
            this.Bombs.Size = new System.Drawing.Size(153, 58);
            this.Bombs.TabIndex = 7;
            this.Bombs.Text = "Количество \nбомб";
            // 
            // hScrollBarBomb
            // 
            this.hScrollBarBomb.Location = new System.Drawing.Point(425, 191);
            this.hScrollBarBomb.Name = "hScrollBarBomb";
            this.hScrollBarBomb.Size = new System.Drawing.Size(155, 21);
            this.hScrollBarBomb.TabIndex = 6;
            // 
            // YFields
            // 
            this.YFields.AutoSize = true;
            this.YFields.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YFields.Location = new System.Drawing.Point(262, 124);
            this.YFields.Name = "YFields";
            this.YFields.Size = new System.Drawing.Size(96, 29);
            this.YFields.TabIndex = 9;
            this.YFields.Text = "Высота";
            // 
            // hScrollBarY
            // 
            this.hScrollBarY.Location = new System.Drawing.Point(425, 132);
            this.hScrollBarY.Name = "hScrollBarY";
            this.hScrollBarY.Size = new System.Drawing.Size(155, 21);
            this.hScrollBarY.TabIndex = 8;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(53, 251);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(123, 39);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 304);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.YFields);
            this.Controls.Add(this.hScrollBarY);
            this.Controls.Add(this.Bombs);
            this.Controls.Add(this.hScrollBarBomb);
            this.Controls.Add(this.СheckedComplexity);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Complexity);
            this.Controls.Add(this.HandComplexity);
            this.Controls.Add(this.XFields);
            this.Controls.Add(this.hScrollBarX);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarX;
        private System.Windows.Forms.Label XFields;
        private System.Windows.Forms.CheckBox HandComplexity;
        private System.Windows.Forms.Label Complexity;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.CheckedListBox СheckedComplexity;
        private System.Windows.Forms.Label Bombs;
        private System.Windows.Forms.HScrollBar hScrollBarBomb;
        private System.Windows.Forms.Label YFields;
        private System.Windows.Forms.HScrollBar hScrollBarY;
        private System.Windows.Forms.Button Cancel;
    }
}