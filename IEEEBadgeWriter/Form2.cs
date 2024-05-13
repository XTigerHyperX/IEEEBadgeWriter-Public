
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace IEEEBadgeWriter
{
    public partial class Form2 : Form
    {
        bool dragging;
        int yoffset;
        int xoffset;
        Image Loadedimg;
        string imgloc;
        string output;
        string textpath, font;
        public static string color;
        public Form2()
        {
            InitializeComponent();
            dragging = false;
            color = "black";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                DefaultExt = "png",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Template_txtbox.Text = openFileDialog1.SafeFileName;
                try
                {
                    Loadedimg = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                    imgloc = openFileDialog1.FileName;
                }
                catch
                {

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                DefaultExt = "ttf",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.SafeFileName;
            }
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(openFileDialog1.FileName);
            label2.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            font = openFileDialog1.FileName;
        }

        private void Output_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Output_txtbox.Text = fbd.SelectedPath;
                    output = fbd.SelectedPath;
                }
            }
        }

        private async void Load_Text_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Textfile_txtbox.Text = openFileDialog1.SafeFileName;
                await Designer.LoadNames(openFileDialog1.FileName);
                Load_Text.Text = $"Loaded {Designer.Names} Name";
                textpath = openFileDialog1.FileName;
            }
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var position = pictureBox2.PointToClient(new Point(e.X, e.Y));
            var name = (string)e.Data.GetData(DataFormats.Text);

            position.X -= label2.Width / 2;
            position.Y -= label2.Height / 2;

            label2.Location = position;
            label2.Visible = true;
        }


        private void Sample_Txt_TextChanged(object sender, EventArgs e)
        {
            if (Sample_Txt.Text.Length <= 0)
            {
                label2.Text = "Move Me";
            }
            else
            {
                label2.Text = Sample_Txt.Text;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Label b;

            b = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xoffset = e.X;
                yoffset = e.Y;
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Label b;
            int xmoved;
            int ymoved;
            int newbtnx;
            int newbtny;

            b = (Label)sender;
            if (dragging)
            {
                xmoved = e.Location.X - xoffset;
                ymoved = e.Location.Y - yoffset;

                newbtnx = b.Location.X + xmoved;
                newbtny = b.Location.Y + ymoved;

                if (newbtnx <= 0)
                {
                    newbtnx = b.Location.X;
                }
                else if (newbtnx + b.Width >= this.ClientSize.Width)
                {
                    newbtnx = b.Location.X;
                }

                if (newbtny <= 0)
                {
                    newbtny = b.Location.Y;
                }
                else if (newbtny + b.Height >= this.ClientSize.Height)
                {
                    newbtny = b.Location.Y;
                }

                b.Location = new Point(newbtnx, newbtny);
            }
        }

        private void Plustext_btn_Click(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size + 1, label2.Font.Style);

        }

        private void negativetxt_btn_Click(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size - 1, label2.Font.Style);

        }

        private void Gen_btn_Click(object sender, EventArgs e)
        {
            float scaleX = (float)pictureBox2.Width / (float)Loadedimg.Width;
            float scaleY = (float)pictureBox2.Height / (float)Loadedimg.Height;
            float scaleFactor = Math.Min(scaleX, scaleY);

            float displayWidth = Loadedimg.Width * scaleFactor;
            float displayHeight = Loadedimg.Height * scaleFactor;

            float offsetX = (pictureBox2.Width - displayWidth) / 2;
            float offsetY = (pictureBox2.Height - displayHeight) / 2;

            Point labelScreenCoords = label2.PointToScreen(Point.Empty);
            Point labelRelativeToPicbox = pictureBox2.PointToClient(labelScreenCoords);

            int adjx = (int)((labelRelativeToPicbox.X - offsetX) / scaleFactor);
            int adjy = (int)((labelRelativeToPicbox.Y - offsetY) / scaleFactor);


            Debug.WriteLine($"X : {adjx} Y : {adjy} ");
            float skiaPoints = (label2.Font.Size * scaleFactor) * 72f / 96f;

            Debug.WriteLine($"{scaleFactor}");

            var lines = File.ReadLines(textpath);
            foreach (var line in lines)
            {
                var thread = new Thread(async () => await Designer.draw(imgloc, line, output + "\\", adjx, adjy + 90, skiaPoints * 34, font));
                thread.Start();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            color = "black";
            label2.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            color = "white";
            label2.ForeColor = System.Drawing.Color.White;

        }
    }
}
