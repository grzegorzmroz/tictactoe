namespace tictactoe_v3
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBoardSize = new System.Windows.Forms.NumericUpDown();
            this.lblWin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPlayerCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(197, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(400, 400);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 34);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Board size";
            // 
            // nudBoardSize
            // 
            this.nudBoardSize.Location = new System.Drawing.Point(45, 87);
            this.nudBoardSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBoardSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudBoardSize.Name = "nudBoardSize";
            this.nudBoardSize.Size = new System.Drawing.Size(85, 20);
            this.nudBoardSize.TabIndex = 5;
            this.nudBoardSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(42, 187);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(0, 13);
            this.lblWin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Players";
            // 
            // nudPlayerCount
            // 
            this.nudPlayerCount.Location = new System.Drawing.Point(45, 154);
            this.nudPlayerCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPlayerCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPlayerCount.Name = "nudPlayerCount";
            this.nudPlayerCount.Size = new System.Drawing.Size(85, 20);
            this.nudPlayerCount.TabIndex = 8;
            this.nudPlayerCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.nudPlayerCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.nudBoardSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoardSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBoardSize;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPlayerCount;
    }
}

