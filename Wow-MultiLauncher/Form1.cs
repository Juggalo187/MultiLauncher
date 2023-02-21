using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var fInfopassvanilla = new FileInfo(@"Data\Paths\passvanilla.txt");
            var fInfopassTBC = new FileInfo(@"Data\Paths\passTBC.txt");
            var fInfopassWotlk = new FileInfo(@"Data\Paths\passWotlk.txt");
            var fInfopassCata = new FileInfo(@"Data\Paths\passCata.txt");
            var fInfopassMop = new FileInfo(@"Data\Paths\passMop.txt");
            var fInfopassLegion = new FileInfo(@"Data\Paths\passLegion.txt");
            var fInfopassBFA = new FileInfo(@"Data\Paths\passBFA.txt");
            var fInfopassSL = new FileInfo(@"Data\Paths\passSL.txt");

            if (fInfopassvanilla.Exists)
            {
                var passlinevanilla = File.ReadLines(@"Data\Paths\passvanilla.txt").First();
                textBox2.Text = passlinevanilla; 
            }

            if (fInfopassTBC.Exists)
            {
                var passlineTBC = File.ReadLines(@"Data\Paths\passTBC.txt").First();
                textBox4.Text = passlineTBC;
            }

            if (fInfopassWotlk.Exists)
            {
                var passlineWotlk = File.ReadLines(@"Data\Paths\passWotlk.txt").First();
                textBox6.Text = passlineWotlk;
            }

            if (fInfopassCata.Exists)
            {
                var passlineCata = File.ReadLines(@"Data\Paths\passCata.txt").First();
                textBox8.Text = passlineCata;
            }

            if (fInfopassMop.Exists)
            {
                var passlineMop = File.ReadLines(@"Data\Paths\passMop.txt").First();
                textBox10.Text = passlineMop;
            }

            if (fInfopassLegion.Exists)
            {
                var passlineLegion = File.ReadLines(@"Data\Paths\passLegion.txt").First();
                textBox12.Text = passlineLegion;
            }

            if (fInfopassBFA.Exists)
            {
                var passlineBFA = File.ReadLines(@"Data\Paths\passBFA.txt").First();
                textBox14.Text = passlineBFA;
            }

            if (fInfopassSL.Exists)
            {
                var passlineSL = File.ReadLines(@"Data\Paths\passSL.txt").First();
                textBox17.Text = passlineSL;
            }

            textBox2.PasswordChar = '*';
            textBox4.PasswordChar = '*';
            textBox6.PasswordChar = '*';
            textBox8.PasswordChar = '*';
            textBox10.PasswordChar = '*';
            textBox12.PasswordChar = '*';
            textBox14.PasswordChar = '*';
            textBox17.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startWotlk.txt");
            string filePath;
            string passPath;


            if (textBox6.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startWotlk.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox6.Text;
                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passWotlk.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox6.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox6.Text;


                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startWotlk.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passWotlk.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox6.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox6.Text;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startWotlk.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passWotlk.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox6.Text);

                    }



                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startvanilla.txt");
            string filePath;
            string passPath;


            if (textBox2.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startvanilla.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox2.Text;
                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passvanilla.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox2.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox2.Text;


                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startvanilla.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passvanilla.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox2.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox2.Text;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startvanilla.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passvanilla.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox2.Text);

                    }



                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startTBC.txt");
            string filePath;
            string passPath;


            if (textBox4.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startTBC.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox4.Text;

                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passTBC.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox4.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox4.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startTBC.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passTBC.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox4.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox4.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startTBC.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passTBC.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox4.Text);

                    }



                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startCata.txt");
            string filePath;
            string passPath;


            if (textBox8.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startCata.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox8.Text;

                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passCata.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox8.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox8.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startCata.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passCata.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox8.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox8.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startCata.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passCata.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox8.Text);

                    }



                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startMop.txt");
            string filePath;
            string passPath;


            if (textBox10.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startMop.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox10.Text;

                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passMop.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox10.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox10.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startMop.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passMop.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox10.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox10.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startMop.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passMop.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox10.Text);

                    }



                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startLegion.txt");
            string filePath;
            string passPath;


            if (textBox12.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startLegion.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox12.Text;

                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passLegion.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox12.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox12.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startLegion.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passLegion.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox12.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox12.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startLegion.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passLegion.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox12.Text);

                    }



                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startBFA.txt");
            string filePath;
            string passPath;


            if (textBox14.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startBFA.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox14.Text;

                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passBFA.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox14.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox14.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startBFA.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passBFA.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox14.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox14.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startBFA.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passBFA.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox14.Text);

                    }



                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\startSL.txt");
            string filePath;
            string passPath;


            if (textBox17.Text == "Password")
            {

                DialogResult d;
                d = MessageBox.Show("Please enter your Password before Launching WoW", "Enter your Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (d == DialogResult.OK)
                {

                }

            }

            else
            {
                if (fInfo.Exists)
                {
                    var wowline1 = File.ReadLines(@"Data\Paths\startSL.txt").First();
                    var fInfo2 = new FileInfo(wowline1);

                    if (fInfo2.Exists)
                    {
                        passPath = textBox17.Text;

                        filePath = wowline1;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = wowline1;
                        wow.Start();

                        TextWriter pass = new StreamWriter(@"Data\Paths\passSL.txt");
                        pass.Write(passPath);
                        pass.Close();
                        Clipboard.SetDataObject(textBox17.Text);

                    }
                    else
                    {

                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "exe files (*.exe)|*.exe";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var path = @"Data\Paths\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox17.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\startSL.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\passSL.txt");
                            txt.Write(filePath);
                            pass.Write(passPath);
                            txt.Close();
                            pass.Close();
                            Clipboard.SetDataObject(textBox17.Text);

                        }

                    }
                }
                else
                {

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "exe files (*.exe)|*.exe";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var path = @"Data\Paths\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox17.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\startSL.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\passSL.txt");
                        txt.Write(filePath);
                        pass.Write(passPath);
                        txt.Close();
                        pass.Close();
                        Clipboard.SetDataObject(textBox17.Text);

                    }



                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/H2FD3MKfau");
        }
    }
}
