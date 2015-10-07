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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tuersteher
{
	/// <summary>
	/// Interaktionslogik für NewUser.xaml
	/// </summary>
	public partial class NewUser : UserControl
	{
		public NewUser()
		{
			InitializeComponent();
		}
		public event EventHandler GoBack;
		private void btnCan_Click(object sender, RoutedEventArgs e)
		{
			if (GoBack!=null)
			{
				GoBack(sender, e);
			}
		}

		private void btnCreate_Click(object sender, RoutedEventArgs e)
		{

		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			tbName.Focus();
		}
	}
}
