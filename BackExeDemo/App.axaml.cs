using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using BackExeDemo.ViewModels;
using BackExeDemo.Views;

namespace BackExeDemo
{
	public partial class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
				// Line below is needed to remove Avalonia data validation.
				// Without this line you will get duplicate validations from both Avalonia and CT
				BindingPlugins.DataValidators.RemoveAt(0);
				// ��ֹ���ڹر�ʱ�˳�Ӧ��
				desktop.ShutdownMode = ShutdownMode.OnExplicitShutdown;
			}

			base.OnFrameworkInitializationCompleted();
		}
		private void AppExit(object? sender, System.EventArgs e)
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
				desktop.Shutdown(); // �ر�Ӧ��
			}
		}
		private void ShowWindow(object? sender, System.EventArgs e)
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
				if (desktop.MainWindow is null) {
					desktop.MainWindow = new MainWindow();
				}
				desktop.MainWindow?.Show();
			}
		}
	}
}