using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using System.Diagnostics;
using Newtonsoft.Json;

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
            if (lbl_logo.Text == "" || lbl_yoda.Text == "" || lbl_bottle.Text == "" || lbl_hand.Text == "" || lbl_point.Text  == "" || lbl_result_folder.Text == "")
            {
                MessageBox.Show("You need select file or folder result");
                return;
            }

            PointObjects pos = JsonConvert.DeserializeObject<PointObjects>(File.ReadAllText(lbl_point.Text));
            string logo_result_path = render_logo(lbl_result_folder.Text, lbl_logo.Text, lbl_yoda.Text, lbl_bottle.Text, lbl_hand.Text, pos);
            lbl_result.Text = logo_result_path;
            if (MessageBox.Show("Bạn muốn mở file không ?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(logo_result_path)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
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
            select_file(lbl_point);
        }
        private void button7_Click(object sender, EventArgs e)
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

        private string resize(string original_path, int size, bool auto_width)
        {
            string file_name = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "_" + original_path.Split('\\').Last();
            string path_temp_folder = Path.Combine(Environment.CurrentDirectory, @"temp\");
            string path_temp_file = path_temp_folder + file_name;
            if (!Directory.Exists(path_temp_folder))
            {
                Directory.CreateDirectory(path_temp_folder);
            }

            using (MagickImage img = new MagickImage(original_path))
            {
                if (auto_width)
                {
                    img.Resize(size, 0);
                }
                else
                {
                    img.Resize(0, size);
                }
                img.Write(path_temp_file);
            }
            return path_temp_file;
        }

        private string render_logo(string folder_result,string logo_p, string yoda_p, string bottle_p, string hand_p, PointObjects pos)
        {
            string file_result_path = folder_result + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + "_logo.png";
            using (MagickImage backgroud = new MagickImage(logo_p))
            {
                MagickImage yoda = new MagickImage(yoda_p);
                MagickImage bottle = new MagickImage(bottle_p);
                MagickImage hand = new MagickImage(hand_p);

                //backgroud.Composite(yoda, 0, 1153, CompositeOperator.Over);
                //backgroud.Composite(bottle, 900, 2000, CompositeOperator.Over);
                //backgroud.Composite(hand, 700, 2320, CompositeOperator.Over);

                backgroud.Composite(yoda, pos.yoda[0], pos.yoda[1], CompositeOperator.Over);
                backgroud.Composite(bottle, pos.chai[0], pos.chai[1], CompositeOperator.Over);
                backgroud.Composite(hand, pos.tay[0], pos.tay[1], CompositeOperator.Over);

                backgroud.Write(file_result_path);
            }
            return file_result_path;
        }
    }

    public class PointObjects
    {
        public int width_logo { get; set; }
        public List<int> yoda { get; set; }
        public List<int> chai { get; set; }
        public List<int> tay { get; set; }
    }
}
