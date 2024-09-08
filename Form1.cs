using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //ファイルを開くダイアログを表示します。ユーザーがOKをクリックするとユーザーが選択した
            //画像を読み込みます。
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }    
        }

        private void claerButton_Click(object sender, EventArgs e)
        {
            //写真を消す
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //色のダイアログボックスを表示します。ユーザーがOKをクリックすると、PictureBoxコントロール
            //の背景がユーザーが選択した色に変更されます。
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //フォームを閉じる
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ユーザーがStretchチェックボックスを選択した場合は、PictureBoxの
            //SizaModeプロパティを"Stretch"に変更します。ユーザーがチェックボックス
            //をオフにした場合は"Normal"に変更します。
            if (!checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }



    }
}