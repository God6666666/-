using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._26test
{
    public partial class Form1 : Form
    {
        private SerialPort _sp;
        private readonly StringBuilder _rxBuffer=new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            InitUi();
            RefreshPorts();
            SetUiConnected(false);
        }
        private void InitUi()
        {
            cmbBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            cmbBaud.SelectedIndex = 0;
            cmbDataBits.Items.AddRange(new object[] { "7", "8" });
            cmbDataBits.SelectedIndex = 1;
            cmbStopBits.Items.Clear();
            cmbStopBits.Items.Add(StopBits.One);
            cmbStopBits.Items.Add(StopBits.Two);
            cmbStopBits.Items.Add(StopBits.OnePointFive);
            cmbStopBits.SelectedItem = StopBits.One;

            cmbParity.Items.Clear();
            cmbParity.Items.Add(Parity.None);
            cmbParity.Items.Add(Parity.Odd);
            cmbParity.Items.Add(Parity.Even);
            cmbParity.Items.Add(Parity.Mark);
            cmbParity.Items.Add(Parity.Space);
            cmbParity.SelectedItem = Parity.None;


            lblStatus.Text = "未连接";




        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }
        private void RefreshPorts()
        {
            var ports = SerialPort.GetPortNames()
                .OrderBy(p => p)//按名称排序，通常COM1, COM2...这样排序会更自然
                .ToArray();
            cmbPort.Items.Clear();
            cmbPort.Items.AddRange(ports);
            if (ports.Length > 0)
                cmbPort.SelectedIndex = 0;
            lblStatus.Text = ports.Length > 0 ? $"已检测到{ports.Length}个串口" : "未找到串口";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_sp != null && _sp.IsOpen)
            {
                MessageBox.Show("串口已打开");
                return;

            }
            if (cmbPort.SelectedItem == null || cmbPort.SelectedIndex < 0)
            {
                MessageBox.Show("请选择端口号");
                return;
            }
            if (!int.TryParse(cmbBaud.Text, out int baud))
            {
                MessageBox.Show("请选择有效的波特率");
                return;

            }
            if (!int.TryParse(cmbDataBits.Text, out int databits))
            {
                MessageBox.Show("请选择有效的数据位");
                return;
            }
            var portName = cmbPort.SelectedItem.ToString();
            var stopBits = (StopBits)cmbStopBits.SelectedItem;
            var parity = (Parity)cmbParity.SelectedItem;

            try//给端口打开和配置的代码块加上异常处理，避免常见错误导致程序崩溃，并给用户友好提示
            {
                
                _sp = new SerialPort(portName, baud, parity, databits, stopBits)//给SerialPort构造函数传入用户选择的参数，创建串口对象
                { 
                    ReadTimeout = 500,
                   WriteTimeout = 500,
                    NewLine = "\n",           // 可选：若你后面用 ReadLine 会用到
                    Encoding = Encoding.ASCII // 可选：按设备实际编码调整
                };
                _sp.DataReceived += Sp_DataReceived; // 订阅数据接收事件
                _sp.Open();
                lblStatus.Text = $"已连接到{portName}";
                SetUiConnected(true);
                AppendLog($"[{DateTime.Now:HH:mm:ss}] 已打开串口 {portName}\r\n");
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("没有权限访问该串口（可能被占用或权限不足）。");
                lblStatus.Text = "打开失败：无权限/被占用";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("串口参数错误：" + ex.Message);
                lblStatus.Text = "打开失败：参数错误";
            }
            catch (IOException ex)
            {
                MessageBox.Show("串口I/O错误：" + ex.Message);
                lblStatus.Text = "打开失败：I/O错误";
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开串口失败：" + ex.Message);
                lblStatus.Text = "打开失败：未知错误";
            }

        }
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (_sp == null || !_sp.IsOpen) return;

                string chunk = _sp.ReadExisting();
                lock (_rxBuffer)
                {
                    _rxBuffer.Append(chunk);
                    while (true)
                    {
                        string buf = _rxBuffer.ToString();
                        int idx = buf.IndexOf('\n');
                        if (idx < 0) break;//没有完整行了    
                        string line = buf.Substring(0, idx).TrimEnd('\r');
                        _rxBuffer.Remove(0, idx + 1);
                        string msg = $"[{DateTime.Now:HH:mm:ss}] {line}\r\n";
                        AppendLog(msg);




                    }



                }
            }
            catch { }
        }

        private void AppendLog(string text)
        {
            if(txtReceive.IsDisposed) return;
            if (txtReceive.InvokeRequired)
            {
                txtReceive.BeginInvoke(new Action(() => AppendLog(text)));
                return;
            }
            txtReceive.AppendText(text);

            // 自动滚动到底部
            txtReceive.SelectionStart = txtReceive.TextLength;
            txtReceive.ScrollToCaret();

        }







        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseSerial();
        }
        private void CloseSerial()
        {
            try
            {
                if (_sp != null)
                {
                    if (_sp.IsOpen) _sp.Close();
                    _sp.Dispose();
                    _sp = null;
                }
                lock (_rxBuffer) _rxBuffer.Clear();
                lblStatus.Text = "串口已关闭";
                SetUiConnected(false);
                AppendLog($"[{DateTime.Now:HH:mm:ss}] 串口已关闭\r\n");

            }
            catch(Exception ex)
            {
                MessageBox.Show("关闭串口失败：" + ex.Message);
                lblStatus.Text = "关闭失败：未知错误";
            }

        }
       

        private void SetUiConnected(bool connected)
        {
            // 连接后禁用参数设置，避免运行中改参数导致混乱
            cmbPort.Enabled = !connected;
            cmbBaud.Enabled = !connected;
            cmbDataBits.Enabled = !connected;
            cmbStopBits.Enabled = !connected;
            cmbParity.Enabled = !connected;
            btnRefresh.Enabled = !connected;
            btnOpen.Enabled = !connected;
            btnClose.Enabled = connected;
        }

        // 防止直接点右上角关闭窗体导致端口占用
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseSerial();
            base.OnFormClosing(e);
        }

        private void btnClearReceive_Click_1(object sender, EventArgs e)
        {
            txtReceive.Clear();
        }
    }
}
