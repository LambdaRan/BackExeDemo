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
			// 取消默认关闭行为
			e.Cancel = true;
			// 隐藏窗口
			Hide(); 
			base.OnClosing(e);
		}
	}
}