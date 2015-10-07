using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace Tuersteher
{
	/// <summary>
	/// Interaktionslogik für MasterPW.xaml
	/// </summary>
	public partial class MasterPW : MetroWindow
	{
		public MasterPW()
		{
			InitializeComponent();
		}

		private void MetroWindow_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
		{
			var box = sender as PasswordBox;
			if (box.Password == "42")
			{
				DialogResult = true;
			}
		}

		private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			pw.Focus();
		}
	}
}
