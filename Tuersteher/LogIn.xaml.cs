using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
namespace Tuersteher
{
	/// <summary>
	/// Interaktionslogik für LogIn.xaml
	/// </summary>
	public partial class LogIn : UserControl
	{
		DispatcherTimer timer;
		public LogIn(string nfc, string User, string UserPassword)
		{
			InitializeComponent();
			NfcID = nfc;
			PassWord = UserPassword;
			this.User = User;
			timer = new DispatcherTimer();
			timer.Interval = new TimeSpan(0, 0, 15);
			timer.Tick += Timer_Tick;
			timer.Start();
		}
		public event EventHandler GoBack;

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (GoBack!=null)
			{
				timer.Stop();
				GoBack(sender, e);
			}
		}

		private string NfcID;
		private string User;
		private string PassWord;
		private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
		{
			var box = sender as PasswordBox;
			if (box.Password == PassWord)
			{
				MessageBox.Show("Test");
			}
		}

		private void PasswordBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			if (!char.IsNumber(e.Text.ToCharArray()[0]))
			{
				e.Handled = true;
			}
		}

		private void LoggingIn_Loaded(object sender, RoutedEventArgs e)
		{
			lblName.Content = User;
			pwBox.Focus();
		}

		private void btnDel_Click(object sender, RoutedEventArgs e)
		{
			MasterPW master = new MasterPW();
			if (master.ShowDialog()==true)
			{

			}
		}
	}
}
