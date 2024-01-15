
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.cb_picture_list = new System.Windows.Forms.ComboBox();
            this.lb_picture_name = new System.Windows.Forms.Label();
            this.lb_picture_input = new System.Windows.Forms.Label();
            this.tb_directory_input = new System.Windows.Forms.TextBox();
            this.lb_image_import = new System.Windows.Forms.Label();
            this.lb_check_file = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_picture
            // 
            this.pb_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_picture.Location = new System.Drawing.Point(364, 73);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(300, 300);
            this.pb_picture.TabIndex = 0;
            this.pb_picture.TabStop = false;
            // 
            // cb_picture_list
            // 
            this.cb_picture_list.FormattingEnabled = true;
            this.cb_picture_list.Location = new System.Drawing.Point(46, 272);
            this.cb_picture_list.Name = "cb_picture_list";
            this.cb_picture_list.Size = new System.Drawing.Size(300, 20);
            this.cb_picture_list.TabIndex = 1;
            this.cb_picture_list.SelectedIndexChanged += new System.EventHandler(this.cb_picture_list_SelectedIndexChanged);
            // 
            // lb_picture_name
            // 
            this.lb_picture_name.AutoSize = true;
            this.lb_picture_name.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_picture_name.Location = new System.Drawing.Point(481, 38);
            this.lb_picture_name.Name = "lb_picture_name";
            this.lb_picture_name.Size = new System.Drawing.Size(67, 20);
            this.lb_picture_name.TabIndex = 2;
            this.lb_picture_name.Text = "Picture";
            // 
            // lb_picture_input
            // 
            this.lb_picture_input.AutoSize = true;
            this.lb_picture_input.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_picture_input.Location = new System.Drawing.Point(43, 161);
            this.lb_picture_input.Name = "lb_picture_input";
            this.lb_picture_input.Size = new System.Drawing.Size(268, 16);
            this.lb_picture_input.TabIndex = 5;
            this.lb_picture_input.Text = "불러올 이미지의 경로를 입력하세요.";
            // 
            // tb_directory_input
            // 
            this.tb_directory_input.Location = new System.Drawing.Point(46, 193);
            this.tb_directory_input.Name = "tb_directory_input";
            this.tb_directory_input.Size = new System.Drawing.Size(265, 21);
            this.tb_directory_input.TabIndex = 3;
            this.tb_directory_input.TextChanged += new System.EventHandler(this.tb_directory_input_TextChanged);
            // 
            // lb_image_import
            // 
            this.lb_image_import.AutoSize = true;
            this.lb_image_import.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_image_import.Location = new System.Drawing.Point(43, 238);
            this.lb_image_import.Name = "lb_image_import";
            this.lb_image_import.Size = new System.Drawing.Size(215, 16);
            this.lb_image_import.TabIndex = 6;
            this.lb_image_import.Text = "불러올 이미지를 선택하세요.";
            // 
            // lb_check_file
            // 
            this.lb_check_file.AutoSize = true;
            this.lb_check_file.Location = new System.Drawing.Point(44, 314);
            this.lb_check_file.Name = "lb_check_file";
            this.lb_check_file.Size = new System.Drawing.Size(77, 12);
            this.lb_check_file.TabIndex = 7;
            this.lb_check_file.Text = "                  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_check_file);
            this.Controls.Add(this.lb_image_import);
            this.Controls.Add(this.lb_picture_input);
            this.Controls.Add(this.tb_directory_input);
            this.Controls.Add(this.lb_picture_name);
            this.Controls.Add(this.cb_picture_list);
            this.Controls.Add(this.pb_picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.ComboBox cb_picture_list;
        private System.Windows.Forms.Label lb_picture_name;
        private System.Windows.Forms.Label lb_picture_input;
        private System.Windows.Forms.TextBox tb_directory_input;
        private System.Windows.Forms.Label lb_image_import;
        private System.Windows.Forms.Label lb_check_file;
    }
}

