using Avalonia.Controls;
using BackExeDemo.ViewModels;

namespace BackExeDemo.Views
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			DataContext = new MainWindowViewModel();
			InitializeComponent();
		}

		protected override void OnClosing(WindowClosingEventArgs e)
		{
			// ȡ��Ĭ�Ϲر���Ϊ
			e.Cancel = true;
			// ���ش���
			Hide(); 
			base.OnClosing(e);
		}
	}
}