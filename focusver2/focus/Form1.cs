using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace focus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// マウスポインタの場所に表示
			this.DesktopLocation = new Point(System.Windows.Forms.Cursor.Position.X,
			  System.Windows.Forms.Cursor.Position.Y);
			timer1.Enabled = false;
			timer2.Enabled = false;
		}

		//初期設定
		int sec = 0; // 計測時間（集中）
		int sec2 = 0;//計測時間（休み）
		string label1Ini;//初期設定時間の表示（集中）
		string label2Ini;//初期設定時間の表示（休み）
		int secSum = 0;//初期設定時間Timer1のカウント
		int sec2Sum = 0;//初期設定時間Timer2のカウント

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//Timer1カウント（集中：左）
		private void timer1_Tick(object sender, EventArgs e)
		{
			sec--;
			viewtime();
			//Timer1が0となったとき初期状態にリセット及びTimer2起動
			if (0 == sec)
			{
				timer1.Stop();
				sec = secSum;
				timer1.Enabled = false;
				timer2.Enabled=true;
				//初期値を入力
				label1.Text = label3.Text;
				//System.Media.SystemSounds.Beep.Play();
				//this.Activate();
			}	
		}
		//Timer2カウント（休み：右）
		private void timer2_Tick(object sender, EventArgs e)
		{
			sec2--;
			viewtime2();
			//Timer2が0となったとき初期状態にリセット及びTimer1起動
			if (0 == sec2)
			{
				timer2.Stop();
				sec2 = sec2Sum;
				timer2.Enabled = false;
				timer1.Enabled = true;
				//初期値を入力
				label2.Text = label4.Text;
				//System.Media.SystemSounds.Beep.Play();
				//this.Activate();
			}
		}

		//集中用時間設定ボタン各種（左）
		private void butsec_Click(object sender, EventArgs e)
		{
			sec += 1;
			viewtime();
		}

		private void butmin_Click(object sender, EventArgs e)
		{
			sec += 60;
			viewtime();
		}

		private void buthour_Click(object sender, EventArgs e)
		{
			sec += 3600;
			if (sec >= 360000) sec = 0;
			viewtime();
		}

		//休み用時間設定ボタン各種（右）
		private void butsec2_Click(object sender, EventArgs e)
		{
			sec2 += 1;
			viewtime2();
		}

		private void butmin2_Click(object sender, EventArgs e)
		{
			sec2 += 60;
			viewtime2();
		}

		private void buthour2_Click(object sender, EventArgs e)
		{
			sec2 += 3600;
			if (sec2 >= 360000) sec = 0;
			viewtime2();
		}

		private void SET_Click(object sender, EventArgs e)
		{
			//リピートのため初期状態を保存
			label1Ini = label1.Text;
			label3.Text = label1.Text;
			label2Ini = label2.Text;
			label4.Text = label2.Text;
			MessageBox.Show("Push Start");
		}

		//タイマースタート（統合）
		private void butstart_Click(object sender, EventArgs e)
		{
			if(timer1.Enabled == false & timer2.Enabled == false & label1.Text == label3.Text & label2.Text==label4.Text)
			{
				MessageBox.Show("初回起動");
				//if (0 == sec)return;
				secSum = sec;
				sec2Sum = sec2;
				timer1.Enabled = true;
				timer2.Enabled = false;
				this.butstop.Enabled = true;
				this.butstart.Enabled = false;
				this.buthour.Enabled = false;
				this.butmin.Enabled = false;
				this.butsec.Enabled = false;
				this.buthour2.Enabled = false;
				this.butmin2.Enabled = false;
				this.butsec2.Enabled = false;
				this.butreset.Enabled = false;
			}
			else if(label1.Text != label3.Text & label2.Text == label4.Text)
			{
				timer1.Start();
				MessageBox.Show("timer1再開");
				this.butstop.Enabled = true;
				this.butstart.Enabled = false;
				this.buthour.Enabled = false;
				this.butmin.Enabled = false;
				this.butsec.Enabled = false;
				this.buthour2.Enabled = false;
				this.butmin2.Enabled = false;
				this.butsec2.Enabled = false;
				this.butreset.Enabled = false;
			}
			else if (label1.Text == label3.Text & label2.Text != label4.Text)
			{
				timer2.Start();
				MessageBox.Show("timer2再開");
				this.butstop.Enabled = true;
				this.butstart.Enabled = false;
				this.buthour.Enabled = false;
				this.butmin.Enabled = false;
				this.butsec.Enabled = false;
				this.buthour2.Enabled = false;
				this.butmin2.Enabled = false;
				this.butsec2.Enabled = false;
				this.butreset.Enabled = false;
			}

		}
		//集中：左のカウント０になったら、タイマー１を止め、カウントを初期状態
		//休み：右のカウントをスタートさせる
		//休みが０になったらタイマー２を止めカウントを初期状態。集中を開始する。これを繰り返す。

		private void butstop_Click(object sender, EventArgs e)
		{
			if(timer1.Enabled == true & timer2.Enabled == false)
			{
				timer1.Stop();
				MessageBox.Show("timer1の停止");
				this.butstop.Enabled = false;
				this.butstart.Enabled = true;
				this.buthour.Enabled = true;
				this.butmin.Enabled = true;
				this.butsec.Enabled = true;
				this.buthour2.Enabled = true;
				this.butmin2.Enabled = true;
				this.butsec2.Enabled = true;
				this.butreset.Enabled = true;
			}
			else if(timer1.Enabled == false & timer2.Enabled == true)
			{
				timer2.Stop();
				MessageBox.Show("timer2の停止");
				this.butstop.Enabled = false;
				this.butstart.Enabled = true;
				this.buthour.Enabled = true;
				this.butmin.Enabled = true;
				this.butsec.Enabled = true;
				this.buthour2.Enabled = true;
				this.butmin2.Enabled = true;
				this.butsec2.Enabled = true;
				this.butreset.Enabled = true;
			}

		}

		private void butreset_Click(object sender, EventArgs e)
		{
			label1.Text = "00:00:00";
			label2.Text = "00:00:00";
			sec = 0;
			sec2 = 0; 
		}

		//時間表示（集中：左）Timer1とリンク
		private void viewtime()
		{
			label1.Text = "" + sec / 36000 % 10 + sec / 3600 % 10 +
						   ":" + sec / 600 % 6 + sec / 60 % 10 +
						   ":" + sec / 10 % 6 + sec % 10;

		}
		//時間表示（休み：右）Timer2とリンク
		private void viewtime2()
		{
			label2.Text = "" + sec2 / 36000 % 10 + sec2 / 3600 % 10 +
						   ":" + sec2 / 600 % 6 + sec2 / 60 % 10 +
						   ":" + sec2 / 10 % 6 + sec2 % 10;
		}


		private void 常に手前に表示ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//クリックするごとにこのフォームを常に手前または解除します。
			this.TopMost = !this.TopMost;
		}

	}
}
