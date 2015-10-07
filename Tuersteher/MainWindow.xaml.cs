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
using MahApps.Metro.Controls;

namespace Tuersteher
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		public MainWindow()
		{
			InitializeComponent();

		}

		private void MetroWindow_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.L&&!(transControl.Content is LogIn))
			{
				LogIn L = new LogIn("123","Bernd Brecht","1337");
				L.GoBack += new EventHandler(GoStandby);
				transControl.Content = L;
			}
			if (e.Key == Key.N && !(transControl.Content is NewUser))
			{
				NewUser nu = new NewUser();
				nu.GoBack += new EventHandler(GoStandby);
				transControl.Content = nu;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MasterPW master = new MasterPW();
			bool? bla = master.ShowDialog();
		}

		private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			StandBy Sb = new StandBy();
			transControl.Content = Sb;
		}
		private void GoStandby(object sender, EventArgs e)
		{
			StandBy Sb = new StandBy();
			transControl.Content = Sb;
		}
	}
}
