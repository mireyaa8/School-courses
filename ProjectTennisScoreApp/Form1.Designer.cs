namespace ProjectTennisScoreApp
{
    partial class Form1
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
            this.Ranking = new System.Windows.Forms.Label();
            this.TennisScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colFirstPlayer = new System.Windows.Forms.ColumnHeader();
            this.Colum1 = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.FirstPlayer = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.colScore = new System.Windows.Forms.ColumnHeader();
            this.moreInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ranking
            // 
            this.Ranking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ranking.AutoSize = true;
            this.Ranking.Location = new System.Drawing.Point(47, 48);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(125, 41);
            this.Ranking.TabIndex = 0;
            this.Ranking.Text = "Ranking";
            // 
            // TennisScore
            // 
            this.TennisScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TennisScore.AutoSize = true;
            this.TennisScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TennisScore.Location = new System.Drawing.Point(743, 35);
            this.TennisScore.Name = "TennisScore";
            this.TennisScore.Size = new System.Drawing.Size(192, 41);
            this.TennisScore.TabIndex = 1;
            this.TennisScore.Text = "Tennis Score";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latest Games";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstPlayer,
            this.Colum1});
            this.listView1.Location = new System.Drawing.Point(47, 170);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1722, 256);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colFirstPlayer
            // 
            this.colFirstPlayer.Text = "Name";
            this.colFirstPlayer.Width = 400;
            // 
            // Colum1
            // 
            this.Colum1.Text = "Score";
            this.Colum1.Width = 400;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstPlayer,
            this.columnHeader5,
            this.columnHeader1,
            this.colScore});
            this.listView2.Location = new System.Drawing.Point(47, 657);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1722, 256);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // FirstPlayer
            // 
            this.FirstPlayer.Text = "First Player";
            this.FirstPlayer.Width = 400;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = " Second Player";
            this.columnHeader5.Width = 400;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Winner";
            this.columnHeader1.Width = 400;
            // 
            // colScore
            // 
            this.colScore.Text = "Score";
            this.colScore.Width = 400;
            // 
            // moreInfo
            // 
            this.moreInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moreInfo.AutoSize = true;
            this.moreInfo.Location = new System.Drawing.Point(47, 440);
            this.moreInfo.Name = "moreInfo";
            this.moreInfo.Size = new System.Drawing.Size(888, 41);
            this.moreInfo.TabIndex = 5;
            this.moreInfo.Text = "*click player\'s name to see more information about their matches.";
            this.moreInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1877, 1013);
            this.Controls.Add(this.moreInfo);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TennisScore);
            this.Controls.Add(this.Ranking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ranking;
        private Label TennisScore;
        private Label label2;
        private ListView listView1;
        private ColumnHeader colFirstPlayer;
        private ColumnHeader Colum1;
        private ListView listView2;
        private ColumnHeader FirstPlayer;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader1;
        private ColumnHeader colScore;
        private Label moreInfo;
    }
}