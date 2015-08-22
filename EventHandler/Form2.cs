using System;
using System.Windows.Forms;

namespace EventHandler
{

	public partial class Form2 : Form
	{
		//イベントで表示するカウンタの初期化
		public int i = 0;

		//-----------------------------------
		// Form2コンストラクタ
		public Form2()
		{
			InitializeComponent();
			//イベントで表示する内容の初期化
			labelNumber.Text = "0";
			labelDateTime.Text = "-";
		}

		//-----------------------------------
		// フォームをロード
		private void Form2_Load(object sender, EventArgs e)
		{
			//イベントのチェーンにハンドラを追加
			this.MyEvent += Form1.CallBackEvent;
			
			//タイマーイベント・スタート
			timer1.Enabled = true;
		}

		//-----------------------------------
		// タイマーイベントで定期的にイベントを発生させる
		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			i++;

			// Form2側にも表示
			labelNumber.Text = i.ToString();
			labelDateTime.Text = dt.ToString("yyyy/MM/dd (ddd) HH:mm:ss" + "\n");

			// イベント発生（→ Form1）
			this.FireEvent(i, dt);
		}

		//-----------------------------------
		// フォームを閉じるボタン
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		//-----------------------------------

		// イベントで使うデリゲートを宣言する
		public delegate void MyEventHandler(int TestNumValue, string TestStringValue);
		// イベントを宣言する
		public event MyEventHandler MyEvent;

		// イベントを送信する、Form2上のメソッド
		public void FireEvent(int Num, DateTime dt)
		{
			if (MyEvent != null)
			{
				MyEvent(Num, dt.ToString("yyyy/MM/dd (ddd) HH:mm:ss" + "\n"));
			}
		}

	}


}
