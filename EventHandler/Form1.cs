using System;
using System.Windows.Forms;

namespace EventHandler
{
	public partial class Form1 : Form
	{
		public static TextBox textBox = new TextBox();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//アプリケーションを閉じる
			Application.Exit();
		}

		private void buttonExe_Click(object sender, EventArgs e)
		{
			// Form2の表示
			Form2 frm2 = new Form2();
			// メインウィンドウ（Form1）の横に表示
			frm2.Left = this.Left + this.Width;
			frm2.Top = this.Top;

			//----------------------------------------------------------------------
			// イベントハンドラの追加（コールバックイベントの追加）
			//----------------------------------------------------------------------
			frm2.MyProgressEvent += new Form2.MyEventHandler(CallBackEventProgress);
						
			frm2.ShowDialog();
			frm2.Dispose();
					
		}

		//----------------------------------------------------------------------
		// コールバックイベント
		//----------------------------------------------------------------------
		private void CallBackEventProgress(Form2.MyEventArgs e)
		{
			textBox1.AppendText(e.TestNumValue.ToString() + ":" + e.TestStringValue);
			
		}

	}

}
