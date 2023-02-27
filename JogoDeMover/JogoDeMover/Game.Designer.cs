namespace JogoDeMover
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.pct_Player = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.btn_Right);
            this.groupBox1.Controls.Add(this.btn_Left);
            this.groupBox1.Controls.Add(this.btn_Down);
            this.groupBox1.Controls.Add(this.btn_Up);
            this.groupBox1.Location = new System.Drawing.Point(561, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controllers";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(18, 125);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(294, 29);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(218, 49);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(94, 29);
            this.btn_Right.TabIndex = 3;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(18, 49);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(94, 29);
            this.btn_Left.TabIndex = 2;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(118, 76);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(94, 29);
            this.btn_Down.TabIndex = 1;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(118, 26);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(94, 29);
            this.btn_Up.TabIndex = 0;
            this.btn_Up.Text = "UP";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // pct_Player
            // 
            this.pct_Player.Image = ((System.Drawing.Image)(resources.GetObject("pct_Player.Image")));
            this.pct_Player.InitialImage = ((System.Drawing.Image)(resources.GetObject("pct_Player.InitialImage")));
            this.pct_Player.Location = new System.Drawing.Point(12, 301);
            this.pct_Player.Name = "pct_Player";
            this.pct_Player.Size = new System.Drawing.Size(228, 206);
            this.pct_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_Player.TabIndex = 1;
            this.pct_Player.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pct_Player);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Submit;
        private Button btn_Right;
        private Button btn_Left;
        private Button btn_Down;
        private Button btn_Up;
        private PictureBox pct_Player;
    }
}