using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RD2BountyCountdown
{
    public partial class MainForm : Form
    {
        public static TimeSpan countDownSp;//用户设定的倒计时
        public static TimeSpan minusSp = new TimeSpan(0, 0, 0, 1);//一秒的时间间隔，用作被减的间隔
        Thread CountDownThread;
        Thread StatisticsThread;
        public static TimeSpan sourceCountDownSp;
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button_StartCountDown_Click(object sender, EventArgs e)
        {
            //倒计时线程
            Thread countDownThread = new Thread(() =>
            {
                while (countDownSp.TotalSeconds >= 0)
                {
                    if(countDownSp.Minutes < 10)
                        label_Minute.Text = string.Format("0{0}",countDownSp.Minutes.ToString());
                    else
                        label_Minute.Text = countDownSp.Minutes.ToString();

                    if (countDownSp.Seconds < 10)
                        label_Second.Text = string.Format("0{0}", countDownSp.Seconds.ToString());
                    else
                        label_Second.Text = countDownSp.Seconds.ToString();

                    countDownSp = countDownSp.Subtract(minusSp);
                    Thread.Sleep(1000);
                }
                Toast.ShowNotifiy("赏金任务的时间到啦！！",string.Format("你设定的赏金任务倒计时目标 {0} 分 {1} 秒已经完成\n预期:{2}\n请立即将通缉犯送往警察局",sourceCountDownSp.Minutes, sourceCountDownSp.Seconds,label_RealGoldGet.Text),this.Icon,5000);
                button_StartCountDown.Enabled = true;
                button_StopCountDown.Enabled = false;
            });

            //统计线程
            Thread statisticsThread = new Thread(() =>
            {
                TimeSpan statisticsSp = new TimeSpan(0, 0, -1);
                while (countDownSp.TotalSeconds >= 0)
                {
                    statisticsSp = statisticsSp.Add(minusSp);
                    if(statisticsSp.TotalMinutes < 3)
                    {
                        label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                    }
                    else
                    {
                        if(statisticsSp.TotalMinutes >=3 && statisticsSp.TotalMinutes < 6)
                            label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.08 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                        else
                        {
                            if (statisticsSp.TotalMinutes >= 6 && statisticsSp.TotalMinutes < 9)
                                label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.16 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                            else
                            {
                                if (statisticsSp.TotalMinutes >= 9 && statisticsSp.TotalMinutes < 12)
                                    label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.24 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                                else
                                {
                                    if (statisticsSp.TotalMinutes >= 12 && statisticsSp.TotalMinutes < 15)
                                        label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.32 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                                    else
                                    {
                                        if (statisticsSp.TotalMinutes >= 15 && statisticsSp.TotalMinutes < 20)
                                            label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.36 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                                        else
                                        {
                                            if (statisticsSp.TotalMinutes >= 20 && statisticsSp.TotalMinutes < 25)
                                                label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.40 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                                            else
                                            {
                                                if (statisticsSp.TotalMinutes >= 25 && statisticsSp.TotalMinutes < 30)
                                                    label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.44 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                                                else
                                                {
                                                    if (statisticsSp.TotalMinutes >=30)
                                                        label_RealGoldGet.Text = string.Format("已开始 {0} 分钟 {1} 秒 可获得 0.48 根金条", statisticsSp.Minutes, statisticsSp.Seconds);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
            });

            StatisticsThread = statisticsThread;
            CountDownThread = countDownThread;
            if (comboBox_ChooseTime.SelectedIndex != -1)
            {
                switch (comboBox_ChooseTime.SelectedIndex)
                {
                    case 0:
                        {
                            countDownSp = new TimeSpan(0, 3, 0);
                            break;
                        }
                    case 1:
                        {
                            countDownSp = new TimeSpan(0, 6, 0);
                            break;
                        }
                    case 2:
                        {
                            countDownSp = new TimeSpan(0, 9, 0);
                            break;
                        }
                    case 3:
                        {
                            countDownSp = new TimeSpan(0, 12, 0);
                            break;
                        }
                    case 4:
                        {
                            countDownSp = new TimeSpan(0, 15, 0);
                            break;
                        }
                    case 5:
                        {
                            countDownSp = new TimeSpan(0, 20, 0);
                            break;
                        }
                    case 6:
                        {
                            countDownSp = new TimeSpan(0, 25, 0);
                            break;
                        }
                    case 7:
                        {
                            countDownSp = new TimeSpan(0, 30, 0);
                            break;
                        }
                }
                sourceCountDownSp = countDownSp;
                button_StartCountDown.Enabled = false;
                button_StopCountDown.Enabled = true;
                CountDownThread.Start();
                StatisticsThread.Start();
            }
            else
                MessageBox.Show("请先选择计时时间后再点击开始！", "赏金倒计时", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_StopCountDown_Click(object sender, EventArgs e)
        {
            button_StopCountDown.Enabled = false;
            CountDownThread.Abort();
            StatisticsThread.Abort();
            button_StartCountDown.Enabled = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
