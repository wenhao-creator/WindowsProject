using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace WindowsProject
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        ///
        /// </summary>
        private readonly DispatcherTimer showTimer = new DispatcherTimer();

        private int _seconds = 180;

        /// <summary>
        /// 初始化
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.ShowInTaskbar = true;

            {
                //定时器
                showTimer.Tick += ShowTimer_Tick;
                showTimer.Interval = new TimeSpan(0, 0, 1);
                showTimer.Start();
            }
            {
                //鼠标拖动窗口（设置Window 的MouseMove事件）
                this.MouseMove += Window_MouseMove;
            }
        }

        /// <summary>
        /// 关机
        /// </summary>
        private void CloseWindows()
        {
            try
            {
                // 修改 EWX_SHUTDOWN 或者 EWX_LOGOFF, EWX_REBOOT等实现不同得功能。
                // 在XP下可以看到帮助信息，以得到不同得参数
                // SHUTDOWN /?
                ShutDown.DoExitWin(ShutDown.EWX_SHUTDOWN);
                // System.Diagnostics.Process.Start("shutdown.exe", "-s -t 0");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                showTimer.Start();
                _seconds = 3;
                throw;
            }
        }

        /// <summary>
        /// 延迟关机
        /// </summary>
        private void AddHours()
        {
            _seconds += 60 * 60;
        }

        #region 控件点击事件

        /// <summary>
        /// 取消关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("延迟关机,每取消一次延迟一小时", "确认", MessageBoxButton.OKCancel);
            if(result == MessageBoxResult.OK)
            {
                AddHours();
            }
        }

        /// <summary>
        /// 立即关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("立即关机 ？", "确认", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if(result == MessageBoxResult.OK)
            {
                showTimer.Stop();
                CloseWindows();
            }
        }

        #endregion 控件点击事件

        #region Event

        /// <summary>
        /// 定时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            _seconds--;
            this.Label1.Content = $"关机倒计时 {_seconds} 秒";

            if(_seconds == 10)
            {
                //关机时间剩余10秒 提醒一次
                this.WindowState = WindowState.Normal;
                this.Topmost = true;
            }
            else if(_seconds <= 0)
            {
                CloseWindows();
            }
        }

        /// <summary>
        /// 鼠标拖动窗口（设置Window 的MouseMove事件）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        #endregion Event

        #region 最大 最小 关闭

        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Min_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        /// <summary>
        /// 最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Max_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            var ret = MessageBox.Show("Are you sure to exit audit?", "Alert", MessageBoxButton.YesNo);
            if(ret == MessageBoxResult.Yes)
            {
                //终止所有线程
                Environment.Exit(Environment.ExitCode);
            }
        }

        #endregion 最大 最小 关闭
    }
}