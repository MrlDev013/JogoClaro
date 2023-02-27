namespace JogoDeMover
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_MenuName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(244, 197);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(94, 29);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(244, 241);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(94, 29);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_MenuName
            // 
            this.lbl_MenuName.AutoSize = true;
            this.lbl_MenuName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MenuName.Location = new System.Drawing.Point(244, 89);
            this.lbl_MenuName.Name = "lbl_MenuName";
            this.lbl_MenuName.Size = new System.Drawing.Size(98, 41);
            this.lbl_MenuName.TabIndex = 2;
            this.lbl_MenuName.Text = "Game";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 343);
            this.Controls.Add(this.lbl_MenuName);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Play);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Play;
        private Button btn_Quit;
        private Label lbl_MenuName;
    }
}