using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        private string ip = "127.0.0.1"; //자신 컴퓨터
        private int portNumber = 50;
        private Socket socket;
        private Thread receiveThread; //대화 수신용
        private delegate void SafeCallDelegate(string text);

        public ClientForm()
        {
            InitializeComponent();
        }

        private void Log(string msg)
        {
            if (rtb_state.InvokeRequired)
            {
                var d = new SafeCallDelegate(Log);
                Invoke(d, new object[] { msg });
            }
            else
            {
                rtb_state.AppendText(string.Format("[{0}] {1}", DateTime.Now.ToString(), msg));
                rtb_state.AppendText("\r\n");
            }

        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            IPAddress ipaddress = IPAddress.Parse(tb_IPAddress.Text);
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(tb_PortNumber.Text));

            //소켓 생성
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //연결
            Log("서버에 연결 시도 중");
            socket.Connect(endpoint);

            Log("서버 연결 성공");
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }
        private void Receive()
        {
            while (true)
            {
                byte[] recevieBuffer = new byte[512];
                int length = socket.Receive(recevieBuffer, recevieBuffer.Length, SocketFlags.None);
                string msg = Encoding.UTF8.GetString(recevieBuffer, 0, length);

                ShowMsg("상대 ]" + msg);
            }
        }
        private void ShowMsg(string msg)
        {
            Log(msg);

            //스크롤 내리기
            this.Activate();
            rtb_state.Focus();

            rtb_state.SelectionStart = rtb_state.Text.Length;
            rtb_state.ScrollToCaret();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            rtb_state.Focus();
            Log("클라이언트 로드 완료");

            tb_IPAddress.Text = ip;
            tb_PortNumber.Text = portNumber.ToString();
        }

        private void tb_IPAddress_TextChanged(object sender, EventArgs e)
        {
            ip = tb_IPAddress.Text;
        }

        private void tb_PortNumber_TextChanged(object sender, EventArgs e)
        {
            portNumber = Int32.Parse(tb_PortNumber.Text);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_message.Text == "")
            {
                Log("메시지를 작성하세요.");
            }

            else
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(tb_message.Text.Trim());
                socket.Send(sendBuffer);
                Log("메시지 전송 완료");
                ShowMsg("나]" + tb_message.Text);
                tb_message.Text = "";
            }
        }
    }
}
