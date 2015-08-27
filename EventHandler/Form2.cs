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
			
			//-----------------------------------
			// Form1側のアップデート（コールバック）
			//-----------------------------------
			UpdateProgress(i, labelDateTime.Text);
			
		}

		//-----------------------------------
		// フォームを閉じるボタン
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//-----------------------------------
		// Form1へ伝えるイベントハンドラを定義
		public event MyEventHandler MyProgressEvent;
		// Form1へイベントを伝える関数を定義
		private void UpdateProgress(int TestNumValue, string TestStringValue)
		{
			MyProgressEvent(new MyEventArgs(TestNumValue, TestStringValue));
		}
		
		//-----------------------------------
		//イベントハンドラのデリゲートを定義
		public delegate void MyEventHandler(MyEventArgs e);

		//-----------------------------------
		// 渡せるイベントデータ引数、EventArgsを継承したクラスを拡張
		public class MyEventArgs : EventArgs
		{
			private readonly int _TestNumValue;
			private readonly string _TestStringValue;

			public MyEventArgs(int TestNumValue, string TestStringValue)
			{
				_TestNumValue = TestNumValue;
				_TestStringValue = TestStringValue;
			}
			public int TestNumValue { get { return _TestNumValue; } }
			public string TestStringValue { get { return _TestStringValue; } }

		}

	}

}
