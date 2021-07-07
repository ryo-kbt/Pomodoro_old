namespace focus
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
			this.label1 = new System.Windows.Forms.Label();
			this.buthour = new System.Windows.Forms.Button();
			this.butmin = new System.Windows.Forms.Button();
			this.butsec = new System.Windows.Forms.Button();
			this.butstart = new System.Windows.Forms.Button();
			this.butstop = new System.Windows.Forms.Button();
			this.butreset = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.butsec2 = new System.Windows.Forms.Button();
			this.butmin2 = new System.Windows.Forms.Button();
			this.buthour2 = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.TITLE2 = new System.Windows.Forms.Label();
			this.TITLE3 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SET = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(142, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "00:00:00";
			// 
			// buthour
			// 
			this.buthour.Location = new System.Drawing.Point(127, 172);
			this.buthour.Name = "buthour";
			this.buthour.Size = new System.Drawing.Size(75, 30);
			this.buthour.TabIndex = 1;
			this.buthour.Text = "HOUR";
			this.buthour.UseVisualStyleBackColor = true;
			this.buthour.Click += new System.EventHandler(this.buthour_Click);
			// 
			// butmin
			// 
			this.butmin.Location = new System.Drawing.Point(211, 172);
			this.butmin.Name = "butmin";
			this.butmin.Size = new System.Drawing.Size(75, 30);
			this.butmin.TabIndex = 2;
			this.butmin.Text = "MIN";
			this.butmin.UseVisualStyleBackColor = true;
			this.butmin.Click += new System.EventHandler(this.butmin_Click);
			// 
			// butsec
			// 
			this.butsec.Location = new System.Drawing.Point(295, 172);
			this.butsec.Name = "butsec";
			this.butsec.Size = new System.Drawing.Size(75, 30);
			this.butsec.TabIndex = 3;
			this.butsec.Text = "SEC";
			this.butsec.UseVisualStyleBackColor = true;
			this.butsec.Click += new System.EventHandler(this.butsec_Click);
			// 
			// butstart
			// 
			this.butstart.Location = new System.Drawing.Point(274, 232);
			this.butstart.Name = "butstart";
			this.butstart.Size = new System.Drawing.Size(75, 30);
			this.butstart.TabIndex = 4;
			this.butstart.Text = "START";
			this.butstart.UseVisualStyleBackColor = true;
			this.butstart.Click += new System.EventHandler(this.butstart_Click);
			// 
			// butstop
			// 
			this.butstop.Location = new System.Drawing.Point(358, 232);
			this.butstop.Name = "butstop";
			this.butstop.Size = new System.Drawing.Size(75, 30);
			this.butstop.TabIndex = 5;
			this.butstop.Text = "STOP";
			this.butstop.UseVisualStyleBackColor = true;
			this.butstop.Click += new System.EventHandler(this.butstop_Click);
			// 
			// butreset
			// 
			this.butreset.Location = new System.Drawing.Point(442, 232);
			this.butreset.Name = "butreset";
			this.butreset.Size = new System.Drawing.Size(75, 30);
			this.butreset.TabIndex = 6;
			this.butreset.Text = "RESET";
			this.butreset.UseVisualStyleBackColor = true;
			this.butreset.Click += new System.EventHandler(this.butreset_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(427, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 50);
			this.label2.TabIndex = 7;
			this.label2.Text = "00:00:00";
			// 
			// butsec2
			// 
			this.butsec2.Location = new System.Drawing.Point(586, 172);
			this.butsec2.Name = "butsec2";
			this.butsec2.Size = new System.Drawing.Size(75, 30);
			this.butsec2.TabIndex = 10;
			this.butsec2.Text = "SEC";
			this.butsec2.UseVisualStyleBackColor = true;
			this.butsec2.Click += new System.EventHandler(this.butsec2_Click);
			// 
			// butmin2
			// 
			this.butmin2.Location = new System.Drawing.Point(502, 172);
			this.butmin2.Name = "butmin2";
			this.butmin2.Size = new System.Drawing.Size(75, 30);
			this.butmin2.TabIndex = 9;
			this.butmin2.Text = "MIN";
			this.butmin2.UseVisualStyleBackColor = true;
			this.butmin2.Click += new System.EventHandler(this.butmin2_Click);
			// 
			// buthour2
			// 
			this.buthour2.Location = new System.Drawing.Point(418, 172);
			this.buthour2.Name = "buthour2";
			this.buthour2.Size = new System.Drawing.Size(75, 30);
			this.buthour2.TabIndex = 8;
			this.buthour2.Text = "HOUR";
			this.buthour2.UseVisualStyleBackColor = true;
			this.buthour2.Click += new System.EventHandler(this.buthour2_Click);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Title.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Title.Location = new System.Drawing.Point(313, 25);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(152, 35);
			this.Title.TabIndex = 14;
			this.Title.Text = "Pomodoro";
			// 
			// TITLE2
			// 
			this.TITLE2.AutoSize = true;
			this.TITLE2.Location = new System.Drawing.Point(208, 79);
			this.TITLE2.Name = "TITLE2";
			this.TITLE2.Size = new System.Drawing.Size(94, 18);
			this.TITLE2.TabIndex = 15;
			this.TITLE2.Text = "FOCUSING";
			// 
			// TITLE3
			// 
			this.TITLE3.AutoSize = true;
			this.TITLE3.Location = new System.Drawing.Point(483, 79);
			this.TITLE3.Name = "TITLE3";
			this.TITLE3.Size = new System.Drawing.Size(79, 18);
			this.TITLE3.TabIndex = 16;
			this.TITLE3.Text = "RESTING";
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// SET
			// 
			this.SET.Location = new System.Drawing.Point(158, 232);
			this.SET.Name = "SET";
			this.SET.Size = new System.Drawing.Size(75, 30);
			this.SET.TabIndex = 17;
			this.SET.Text = "SET";
			this.SET.UseVisualStyleBackColor = true;
			this.SET.Click += new System.EventHandler(this.SET_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(12, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 31);
			this.label3.TabIndex = 18;
			this.label3.Text = "00:00:00";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(663, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 31);
			this.label4.TabIndex = 19;
			this.label4.Text = "00:00:00";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.SET);
			this.Controls.Add(this.TITLE3);
			this.Controls.Add(this.TITLE2);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.butsec2);
			this.Controls.Add(this.butmin2);
			this.Controls.Add(this.buthour2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.butreset);
			this.Controls.Add(this.butstop);
			this.Controls.Add(this.butstart);
			this.Controls.Add(this.butsec);
			this.Controls.Add(this.butmin);
			this.Controls.Add(this.buthour);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buthour;
		private System.Windows.Forms.Button butmin;
		private System.Windows.Forms.Button butsec;
		private System.Windows.Forms.Button butstart;
		private System.Windows.Forms.Button butstop;
		private System.Windows.Forms.Button butreset;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butsec2;
		private System.Windows.Forms.Button butmin2;
		private System.Windows.Forms.Button buthour2;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label TITLE2;
		private System.Windows.Forms.Label TITLE3;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button SET;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

