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

			// Staticなコールバックイベント内でないとTextBoxに書き込めないので
			// TextBoxのインスタンスを生成
			textBox.Parent = panel1;
			textBox.Multiline = true;
			textBox.Dock = DockStyle.Fill;
			textBox.ScrollBars = ScrollBars.Vertical;
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
			frm2.ShowDialog();
			frm2.Dispose();
		}

		// Staticなコールバックイベント（Form2で発生したイベントからコールバックされる）
		public static void CallBackEvent(int TestNumValue, string TestStringValue)
		{
			Form1.textBox.AppendText(TestNumValue.ToString() + ": " + TestStringValue);
		}
		

	}

}
