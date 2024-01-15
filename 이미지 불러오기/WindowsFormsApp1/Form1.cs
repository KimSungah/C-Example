using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string img_directory = ""; //입력받은 파일 디렉토리를 저장할 프로퍼티 생성
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_picture_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_img = img_directory + @"\" + cb_picture_list.SelectedItem.ToString();

            if (selected_img.Contains(".png") | selected_img.Contains(".jpg")) //이미지 파일이 선택되었을 때
            {
                pb_picture.Image = Image.FromFile(selected_img); //picture box에 이미지 띄우기
                pb_picture.SizeMode = PictureBoxSizeMode.StretchImage; //이미지 사이즈를 picture box에 맞추기(이미지가 짤리는 것을 방지)
            }
            else //이미지가 아닌 파일이 선택되었을 때
            {
                lb_check_file.Text = "확장자명을 다시 확인해주세요.";
            }
        }

        private void tb_directory_input_TextChanged(object sender, EventArgs e)
        {
            img_directory = tb_directory_input.Text; //파일 디렉토리 입력

            string[] files = Directory.GetFiles(img_directory);
            for (int i = 0; i < files.Length; i++) //combo box에 디렉토리명을 제외한 부분만 보이도록 하기(이미지 이름만 보이는게 깔끔해서)
            {
                string bfiles = files[i].Replace(img_directory+@"\", "");
                cb_picture_list.Items.Add(bfiles);
            }
        }
    }
}
