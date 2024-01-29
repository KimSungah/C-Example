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

namespace Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        //IP주소 & 포트 번호
        private string ip = "127.0.0.1"; //자신 컴퓨터
        private int portNumber = 50;
        private Socket clientSocket;
        private Thread receiveThread;
        private Thread listenThread;
        private delegate void SafeCallDelegate(string text);

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

        private void connection()
        {
            IPAddress ipAddress = IPAddress.Parse(ip);
            IPEndPoint endPoint = new IPEndPoint(ipAddress, portNumber);

            //소켓 생성
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //바인드
            serverSocket.Bind(endPoint);

            //
            serverSocket.Listen(100); //동시에 최대 100개까지 수신을 받을 수 있음.
            Log("클라이언트 요청 대기중");

            //
            clientSocket = serverSocket.Accept();
            Log("클라이언트 연결 완료" + clientSocket.LocalEndPoint.ToString());

            //thread 실행
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void Receive()
        {
            while (true)
            {
                byte[] receiveBuffer = new byte[512];
                int length = clientSocket.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None);

                string msg = Encoding.UTF8.GetString(receiveBuffer);

                ShowMsg("상대]" + msg);
                Log("메시지 수신 완료");
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

        private void btn_connect_Click(object sender, EventArgs e) //서버 시작
        {
            if (btn_connect.Text == "Connect")
            {
                btn_connect.Text = "Stop";
                Log("서버 시작");

                listenThread = new Thread(new ThreadStart(connection));
                listenThread.IsBackground = true;
                listenThread.Start();
            }

            else
            {
                btn_connect.Text = "Connect";
                Log("서버 종료");
            }
        }

        private void rtb_state_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_message_TextChanged(object sender, EventArgs e)
        {

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
                clientSocket.Send(sendBuffer);
                Log("메시지 전송 완료");
                ShowMsg("나]" + tb_message.Text);
                tb_message.Text = "";
            }
        }

        private void tb_IPAddress_TextChanged(object sender, EventArgs e)
        {
            ip = tb_IPAddress.Text;
        }

        private void tb_PortNumber_TextChanged(object sender, EventArgs e)
        {
            portNumber = Int32.Parse(tb_PortNumber.Text);
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            rtb_state.Focus();
            Log("서버 로드 완료");

            tb_IPAddress.Text = ip;
            tb_PortNumber.Text = portNumber.ToString();
        }
    }
}
