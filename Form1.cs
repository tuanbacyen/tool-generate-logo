using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

namespace logo_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = 600;
            foreach(RadioButton rd in gr_size.Controls)
            {
                if(rd == null)
                {
                    return;
                }
                if (rd.Checked)
                {
                    if (rd.Name.IndexOf("800") > 0)
                    {
                        size = 800;
                    }
                    else if (rd.Name.IndexOf("1000") > 0)
                    {
                        size = 1000;
                    }
                }
            }
            if(lbl_logo.Text == "" || lbl_yoda.Text == "" || lbl_bottle.Text == "" || lbl_hand.Text == "" || lbl_result_folder.Text == "")
            {
                MessageBox.Show("You need select file or folder result");
                return;
            }
            //MessageBox.Show(lbl_logo.Text.Trim().Split('\\').Last());
            string out_put_path = resize(lbl_logo.Text.Trim(), size);
            lbl_result.Text = out_put_path;
            MessageBox.Show(out_put_path);
            //string path_bottle = @"C:\Users\tuanb\source\repos\logo_tool\logo_tool\public\b.png";
            //string path_yoda = @"C:\Users\tuanb\source\repos\logo_tool\logo_tool\public\baby_yoda.png";
            //string path_hand = @"C:\Users\tuanb\source\repos\logo_tool\logo_tool\public\hand_yoda.png";
            //string path_final = @"C:\Users\tuanb\source\repos\logo_tool\logo_tool\public\final.png";
            //string path_resize = @"C:\Users\tuanb\source\repos\logo_tool\logo_tool\public\resize.png";

            //using (MagickImage logo = new MagickImage(path_background))
            //{
            //    MagickImage yoda = new MagickImage(path_yoda);
            //    //MagickImage bottle = new MagickImage(path_bottle);
            //    //MagickImage hand = new MagickImage(path_hand);

            //    yoda.Resize(200, 200);
            //    yoda.Write(path_resize);

            //    MagickImage new_bottle = new MagickImage(path_resize);

            //    //logo.Composite(yoda, 0, 500, CompositeOperator.Over);
            //    logo.Composite(new_bottle, 0, 500, CompositeOperator.Over);
            //    //logo.Composite(hand, 500, 900, CompositeOperator.Over);

            //    logo.Write(path_final);
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            select_file(lbl_logo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            select_file(lbl_yoda);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_file(lbl_bottle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            select_file(lbl_hand);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            select_folder(lbl_result_folder);
        }

        private void select_file(Label lbl)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lbl.Text = ofd.FileName;
                }
            }
        }

        private void select_folder(Label lbl)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lbl.Text = fbd.SelectedPath;
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbl_logo.Text = lbl_yoda.Text = lbl_bottle.Text = lbl_hand.Text = "";
        }

        private string resize(string original_path, int size)
        {
            string file_name = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "_" + original_path.Split('\\').Last();
            //string path_temp_folder = lbl_result_folder.Text + file_name;
            string path_temp_folder = System.IO.Path.Combine(Environment.CurrentDirectory, @"temp\", file_name);
            using (MagickImage img = new MagickImage(original_path))
            {
                img.Resize(size, size);
                img.Write(path_temp_folder);
            }
            return file_name;
        }
    }
}
