namespace Miner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AProggramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblMinutes = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.GameToolStripMenuItem.Text = "Игра";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.NewGameToolStripMenuItem.Text = "Новая игра";
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ResetToolStripMenuItem.Text = "Начать заново";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HardToolStripMenuItem,
            this.HandSettingsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // HardToolStripMenuItem
            // 
            this.HardToolStripMenuItem.Name = "HardToolStripMenuItem";
            this.HardToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.HardToolStripMenuItem.Text = "Сложность";
            // 
            // HandSettingsToolStripMenuItem
            // 
            this.HandSettingsToolStripMenuItem.Name = "HandSettingsToolStripMenuItem";
            this.HandSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.HandSettingsToolStripMenuItem.Text = "Ручные настройки";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AProggramToolStripMenuItem,
            this.RulesToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.AboutToolStripMenuItem.Text = "Справка";
            // 
            // AProggramToolStripMenuItem
            // 
            this.AProggramToolStripMenuItem.Name = "AProggramToolStripMenuItem";
            this.AProggramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AProggramToolStripMenuItem.Text = "О программе";
            this.AProggramToolStripMenuItem.Click += new System.EventHandler(this.AProggramToolStripMenuItem_Click);
            // 
            // RulesToolStripMenuItem
            // 
            this.RulesToolStripMenuItem.Name = "RulesToolStripMenuItem";
            this.RulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RulesToolStripMenuItem.Text = "Правила";
            this.RulesToolStripMenuItem.Click += new System.EventHandler(this.RulesToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinutes.Location = new System.Drawing.Point(18, 45);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(24, 25);
            this.lblMinutes.TabIndex = 1;
            this.lblMinutes.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeconds.Location = new System.Drawing.Point(72, 45);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(24, 25);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таймер";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMinutes);
            this.panel1.Controls.Add(this.lblSeconds);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 85);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(897, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HalloweenSapper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HandSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AProggramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RulesToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

