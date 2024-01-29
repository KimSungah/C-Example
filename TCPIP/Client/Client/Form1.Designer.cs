
namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_state = new System.Windows.Forms.RichTextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_PortNumber = new System.Windows.Forms.TextBox();
            this.tb_IPAddress = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lb_PortNumber = new System.Windows.Forms.Label();
            this.lb_IPAddress = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lb_SendMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_state
            // 
            this.rtb_state.Location = new System.Drawing.Point(35, 132);
            this.rtb_state.Name = "rtb_state";
            this.rtb_state.Size = new System.Drawing.Size(595, 234);
            this.rtb_state.TabIndex = 15;
            this.rtb_state.Text = "";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(105, 91);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(320, 21);
            this.tb_message.TabIndex = 14;
            // 
            // tb_PortNumber
            // 
            this.tb_PortNumber.Location = new System.Drawing.Point(105, 52);
            this.tb_PortNumber.Name = "tb_PortNumber";
            this.tb_PortNumber.Size = new System.Drawing.Size(320, 21);
            this.tb_PortNumber.TabIndex = 13;
            this.tb_PortNumber.TextChanged += new System.EventHandler(this.tb_PortNumber_TextChanged);
            // 
            // tb_IPAddress
            // 
            this.tb_IPAddress.Location = new System.Drawing.Point(105, 23);
            this.tb_IPAddress.Name = "tb_IPAddress";
            this.tb_IPAddress.Size = new System.Drawing.Size(320, 21);
            this.tb_IPAddress.TabIndex = 12;
            this.tb_IPAddress.TextChanged += new System.EventHandler(this.tb_IPAddress_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(441, 91);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(189, 23);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lb_PortNumber
            // 
            this.lb_PortNumber.AutoSize = true;
            this.lb_PortNumber.Location = new System.Drawing.Point(33, 61);
            this.lb_PortNumber.Name = "lb_PortNumber";
            this.lb_PortNumber.Size = new System.Drawing.Size(27, 12);
            this.lb_PortNumber.TabIndex = 10;
            this.lb_PortNumber.Text = "Port";
            // 
            // lb_IPAddress
            // 
            this.lb_IPAddress.AutoSize = true;
            this.lb_IPAddress.Location = new System.Drawing.Point(33, 26);
            this.lb_IPAddress.Name = "lb_IPAddress";
            this.lb_IPAddress.Size = new System.Drawing.Size(44, 12);
            this.lb_IPAddress.TabIndex = 9;
            this.lb_IPAddress.Text = "IP 주소";
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(441, 26);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(189, 47);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lb_SendMessage
            // 
            this.lb_SendMessage.AutoSize = true;
            this.lb_SendMessage.Location = new System.Drawing.Point(33, 96);
            this.lb_SendMessage.Name = "lb_SendMessage";
            this.lb_SendMessage.Size = new System.Drawing.Size(58, 12);
            this.lb_SendMessage.TabIndex = 16;
            this.lb_SendMessage.Text = "Message";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 396);
            this.Controls.Add(this.lb_SendMessage);
            this.Controls.Add(this.rtb_state);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_PortNumber);
            this.Controls.Add(this.tb_IPAddress);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lb_PortNumber);
            this.Controls.Add(this.lb_IPAddress);
            this.Controls.Add(this.btn_connect);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_state;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_PortNumber;
        private System.Windows.Forms.TextBox tb_IPAddress;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lb_PortNumber;
        private System.Windows.Forms.Label lb_IPAddress;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lb_SendMessage;
    }
}

