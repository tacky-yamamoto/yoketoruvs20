namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titlelabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.starlabel = new System.Windows.Forms.Label();
            this.highscorelabel = new System.Windows.Forms.Label();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.crearlabel = new System.Windows.Forms.Label();
            this.titlebutton = new System.Windows.Forms.Button();
            this.Templabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlelabel.Location = new System.Drawing.Point(258, 140);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(360, 62);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "よけとる2020";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startbutton.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.startbutton.Location = new System.Drawing.Point(340, 254);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(197, 101);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "スタート";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.copyrightlabel.Location = new System.Drawing.Point(12, 466);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(310, 20);
            this.copyrightlabel.TabIndex = 6;
            this.copyrightlabel.Text = "Copyright © 2020 Tacky-Yamamoto";
            this.copyrightlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(11, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(114, 30);
            this.timelabel.TabIndex = 7;
            this.timelabel.Text = "Time 100";
            this.timelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // starlabel
            // 
            this.starlabel.AutoSize = true;
            this.starlabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starlabel.Location = new System.Drawing.Point(11, 34);
            this.starlabel.Name = "starlabel";
            this.starlabel.Size = new System.Drawing.Size(63, 30);
            this.starlabel.TabIndex = 8;
            this.starlabel.Text = "★:10";
            // 
            // highscorelabel
            // 
            this.highscorelabel.AutoSize = true;
            this.highscorelabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.highscorelabel.Location = new System.Drawing.Point(328, 202);
            this.highscorelabel.Name = "highscorelabel";
            this.highscorelabel.Size = new System.Drawing.Size(221, 31);
            this.highscorelabel.TabIndex = 9;
            this.highscorelabel.Text = "HighScore 100";
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameoverlabel.Location = new System.Drawing.Point(290, 140);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(296, 62);
            this.gameoverlabel.TabIndex = 10;
            this.gameoverlabel.Text = "がめおヴぇｒ";
            this.gameoverlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameoverlabel.Visible = false;
            // 
            // crearlabel
            // 
            this.crearlabel.AutoSize = true;
            this.crearlabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.crearlabel.Location = new System.Drawing.Point(336, 140);
            this.crearlabel.Name = "crearlabel";
            this.crearlabel.Size = new System.Drawing.Size(204, 62);
            this.crearlabel.TabIndex = 11;
            this.crearlabel.Text = "くりあー";
            this.crearlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crearlabel.Visible = false;
            // 
            // titlebutton
            // 
            this.titlebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.titlebutton.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.titlebutton.Location = new System.Drawing.Point(340, 254);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(197, 101);
            this.titlebutton.TabIndex = 12;
            this.titlebutton.Text = "タイトルへ\r\n戻る";
            this.titlebutton.UseVisualStyleBackColor = false;
            this.titlebutton.Visible = false;
            this.titlebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Templabel
            // 
            this.Templabel.AutoSize = true;
            this.Templabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Templabel.Location = new System.Drawing.Point(39, 202);
            this.Templabel.Name = "Templabel";
            this.Templabel.Size = new System.Drawing.Size(42, 31);
            this.Templabel.TabIndex = 13;
            this.Templabel.Text = "★";
            this.Templabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 495);
            this.Controls.Add(this.Templabel);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.crearlabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.highscorelabel);
            this.Controls.Add(this.starlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label starlabel;
        private System.Windows.Forms.Label highscorelabel;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label crearlabel;
        private System.Windows.Forms.Button titlebutton;
        private System.Windows.Forms.Label Templabel;
    }
}

