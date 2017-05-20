namespace GameOfLife
{
    partial class GameOfLifeForm
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
            this.components = new System.ComponentModel.Container();
            this.pbUniverse = new System.Windows.Forms.PictureBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnTick = new System.Windows.Forms.Button();
            this.btnAutoTick = new System.Windows.Forms.Button();
            this.btnRandomSeed = new System.Windows.Forms.Button();
            this.groupBox4Buttons = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnManualSeed = new System.Windows.Forms.Button();
            this.btnShowResultInArray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUniverse)).BeginInit();
            this.groupBox4Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUniverse
            // 
            this.pbUniverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUniverse.Location = new System.Drawing.Point(0, 0);
            this.pbUniverse.Name = "pbUniverse";
            this.pbUniverse.Size = new System.Drawing.Size(940, 759);
            this.pbUniverse.TabIndex = 0;
            this.pbUniverse.TabStop = false;
            this.pbUniverse.Paint += new System.Windows.Forms.PaintEventHandler(this.pbUniverse_Paint);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(12, 19);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 39);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init Universe";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnTick
            // 
            this.btnTick.Enabled = false;
            this.btnTick.Location = new System.Drawing.Point(477, 19);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(75, 39);
            this.btnTick.TabIndex = 2;
            this.btnTick.Text = "Tick";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // btnAutoTick
            // 
            this.btnAutoTick.Enabled = false;
            this.btnAutoTick.Location = new System.Drawing.Point(558, 19);
            this.btnAutoTick.Name = "btnAutoTick";
            this.btnAutoTick.Size = new System.Drawing.Size(125, 39);
            this.btnAutoTick.TabIndex = 3;
            this.btnAutoTick.Text = "Auto Tick/Sec";
            this.btnAutoTick.UseVisualStyleBackColor = true;
            this.btnAutoTick.Click += new System.EventHandler(this.btnAutoTick_Click);
            // 
            // btnRandomSeed
            // 
            this.btnRandomSeed.Enabled = false;
            this.btnRandomSeed.Location = new System.Drawing.Point(93, 19);
            this.btnRandomSeed.Name = "btnRandomSeed";
            this.btnRandomSeed.Size = new System.Drawing.Size(105, 39);
            this.btnRandomSeed.TabIndex = 4;
            this.btnRandomSeed.Text = "Random Seed";
            this.btnRandomSeed.UseVisualStyleBackColor = true;
            this.btnRandomSeed.Click += new System.EventHandler(this.btnRandomSeed_Click);
            // 
            // groupBox4Buttons
            // 
            this.groupBox4Buttons.Controls.Add(this.btnShowResultInArray);
            this.groupBox4Buttons.Controls.Add(this.btnManualSeed);
            this.groupBox4Buttons.Controls.Add(this.btnInit);
            this.groupBox4Buttons.Controls.Add(this.btnRandomSeed);
            this.groupBox4Buttons.Controls.Add(this.btnTick);
            this.groupBox4Buttons.Controls.Add(this.btnAutoTick);
            this.groupBox4Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4Buttons.Location = new System.Drawing.Point(0, 759);
            this.groupBox4Buttons.Name = "groupBox4Buttons";
            this.groupBox4Buttons.Size = new System.Drawing.Size(940, 68);
            this.groupBox4Buttons.TabIndex = 5;
            this.groupBox4Buttons.TabStop = false;
            // 
            // btnManualSeed
            // 
            this.btnManualSeed.Enabled = false;
            this.btnManualSeed.Location = new System.Drawing.Point(204, 19);
            this.btnManualSeed.Name = "btnManualSeed";
            this.btnManualSeed.Size = new System.Drawing.Size(105, 39);
            this.btnManualSeed.TabIndex = 5;
            this.btnManualSeed.Text = "Manual Seed";
            this.btnManualSeed.UseVisualStyleBackColor = true;
            this.btnManualSeed.Click += new System.EventHandler(this.btnManualSeed_Click);
            // 
            // btnShowResultInArray
            // 
            this.btnShowResultInArray.Enabled = false;
            this.btnShowResultInArray.Location = new System.Drawing.Point(763, 19);
            this.btnShowResultInArray.Name = "btnShowResultInArray";
            this.btnShowResultInArray.Size = new System.Drawing.Size(125, 39);
            this.btnShowResultInArray.TabIndex = 6;
            this.btnShowResultInArray.Text = "Show Current Universe in Array";
            this.btnShowResultInArray.UseVisualStyleBackColor = true;
            this.btnShowResultInArray.Click += new System.EventHandler(this.btnShowResultInArray_Click);
            // 
            // GameOfLifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 827);
            this.Controls.Add(this.pbUniverse);
            this.Controls.Add(this.groupBox4Buttons);
            this.Name = "GameOfLifeForm";
            this.Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pbUniverse)).EndInit();
            this.groupBox4Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUniverse;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnTick;
        private System.Windows.Forms.Button btnAutoTick;
        private System.Windows.Forms.Button btnRandomSeed;
        private System.Windows.Forms.GroupBox groupBox4Buttons;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnManualSeed;
        private System.Windows.Forms.Button btnShowResultInArray;
    }
}

