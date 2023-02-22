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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            if (!Directory.Exists(@"Data\Paths\Alt\Alt\"))
            { Directory.CreateDirectory(@"Data\Paths\Alt\Alt\"); }

            var fInfopassvanilla = new FileInfo(@"Data\Paths\Alt\passvanilla.txt");
            var fInfopassTBC = new FileInfo(@"Data\Paths\Alt\passTBC.txt");
            var fInfopassWotlk = new FileInfo(@"Data\Paths\Alt\passWotlk.txt");
            var fInfopassCata = new FileInfo(@"Data\Paths\Alt\passCata.txt");
            var fInfopassMop = new FileInfo(@"Data\Paths\Alt\passMop.txt");
            var fInfopassLegion = new FileInfo(@"Data\Paths\Alt\passLegion.txt");
            var fInfopassBFA = new FileInfo(@"Data\Paths\Alt\passBFA.txt");
            var fInfopassSL = new FileInfo(@"Data\Paths\Alt\passSL.txt");


            var snamevanilla = new FileInfo(@"Data\Paths\Alt\servervanilla.txt");
            var snameTBC = new FileInfo(@"Data\Paths\Alt\serverTBC.txt");
            var snameWotlk = new FileInfo(@"Data\Paths\Alt\serverWotlk.txt");
            var snameCata = new FileInfo(@"Data\Paths\Alt\serverCata.txt");
            var snameMop = new FileInfo(@"Data\Paths\Alt\serverMop.txt");
            var snameLegion = new FileInfo(@"Data\Paths\Alt\serverLegion.txt");
            var snameBFA = new FileInfo(@"Data\Paths\Alt\serverBFA.txt");
            var snameSL = new FileInfo(@"Data\Paths\Alt\serverSL.txt");



            if (fInfopassvanilla.Exists)
            {
                var passlinevanilla = File.ReadLines(@"Data\Paths\Alt\passvanilla.txt").First();
                textBox2.Text = passlinevanilla; 
            }

            if (fInfopassTBC.Exists)
            {
                var passlineTBC = File.ReadLines(@"Data\Paths\Alt\passTBC.txt").First();
                textBox4.Text = passlineTBC;
            }

            if (fInfopassWotlk.Exists)
            {
                var passlineWotlk = File.ReadLines(@"Data\Paths\Alt\passWotlk.txt").First();
                textBox6.Text = passlineWotlk;
            }

            if (fInfopassCata.Exists)
            {
                var passlineCata = File.ReadLines(@"Data\Paths\Alt\passCata.txt").First();
                textBox8.Text = passlineCata;
            }

            if (fInfopassMop.Exists)
            {
                var passlineMop = File.ReadLines(@"Data\Paths\Alt\passMop.txt").First();
                textBox10.Text = passlineMop;
            }

            if (fInfopassLegion.Exists)
            {
                var passlineLegion = File.ReadLines(@"Data\Paths\Alt\passLegion.txt").First();
                textBox12.Text = passlineLegion;
            }

            if (fInfopassBFA.Exists)
            {
                var passlineBFA = File.ReadLines(@"Data\Paths\Alt\passBFA.txt").First();
                textBox14.Text = passlineBFA;
            }

            if (fInfopassSL.Exists)
            {
                var passlineSL = File.ReadLines(@"Data\Paths\Alt\passSL.txt").First();
                textBox17.Text = passlineSL;
            }




            if (snamevanilla.Exists)
            {
                var vanillaname = File.ReadLines(@"Data\Paths\Alt\servervanilla.txt").First();
                textBox1.Text = vanillaname;
            }

            if (snameTBC.Exists)
            {
                var TBCaname = File.ReadLines(@"Data\Paths\Alt\serverTBC.txt").First();
                textBox3.Text = TBCaname;
            }


            if (snameWotlk.Exists)
            {
                var Wotlkname = File.ReadLines(@"Data\Paths\Alt\serverWotlk.txt").First();
                textBox5.Text = Wotlkname;
            }


            if (snameCata.Exists)
            {
                var Cataname = File.ReadLines(@"Data\Paths\Alt\serverCata.txt").First();
                textBox7.Text = Cataname;
            }



            if (snameMop.Exists)
            {
                var Mopname = File.ReadLines(@"Data\Paths\Alt\serverMop.txt").First();
                textBox9.Text = Mopname;
            }


            if (snameLegion.Exists)
            {
                var Legionname = File.ReadLines(@"Data\Paths\Alt\serverLegion.txt").First();
                textBox11.Text = Legionname;
            }

            if (snameBFA.Exists)
            {
                var BFAname = File.ReadLines(@"Data\Paths\Alt\serverBFA.txt").First();
                textBox13.Text = BFAname;
            }


            if (snameSL.Exists)
            {
                var SLname = File.ReadLines(@"Data\Paths\Alt\serverSL.txt").First();
                textBox15.Text = SLname;
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startWotlk.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox5.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverWotlk.txt");
            servername.Write(servernamePath);
            servername.Close();

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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startWotlk.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passWotlk.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox6.Text;


                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startWotlk.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passWotlk.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox6.Text;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startWotlk.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passWotlk.txt");
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startvanilla.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox1.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\servervanilla.txt");
            servername.Write(servernamePath);
            servername.Close();



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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startvanilla.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passvanilla.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox2.Text;


                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startvanilla.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passvanilla.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox2.Text;

                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startvanilla.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passvanilla.txt");
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var fInfo = new FileInfo(@"Data\Paths\Alt\startTBC.txt");
            string filePath;
            string passPath;

            string servernamePath;

            servernamePath = textBox3.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverTBC.txt");
            servername.Write(servernamePath);
            servername.Close();


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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startTBC.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passTBC.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox4.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startTBC.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passTBC.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox4.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startTBC.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passTBC.txt");
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startCata.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox7.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverCata.txt");
            servername.Write(servernamePath);
            servername.Close();

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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startCata.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passCata.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox8.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startCata.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passCata.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox8.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startCata.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passCata.txt");
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startMop.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox9.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverMop.txt");
            servername.Write(servernamePath);
            servername.Close();

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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startMop.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passMop.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox10.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startMop.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passMop.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox10.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startMop.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passMop.txt");
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startLegion.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox11.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverLegion.txt");
            servername.Write(servernamePath);
            servername.Close();

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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startLegion.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passLegion.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox12.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startLegion.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passLegion.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox12.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startLegion.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passLegion.txt");
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startBFA.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox13.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverBFA.txt");
            servername.Write(servernamePath);
            servername.Close();

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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startBFA.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passBFA.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox14.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startBFA.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passBFA.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox14.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startBFA.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passBFA.txt");
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
            var fInfo = new FileInfo(@"Data\Paths\Alt\startSL.txt");
            string filePath;
            string passPath;
            string servernamePath;

            servernamePath = textBox15.Text;
            TextWriter servername = new StreamWriter(@"Data\Paths\Alt\serverSL.txt");
            servername.Write(servernamePath);
            servername.Close();

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
                    var wowline1 = File.ReadLines(@"Data\Paths\Alt\startSL.txt").First();
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

                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passSL.txt");
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
                            var path = @"Data\Paths\Alt\";
                            _ = Directory.CreateDirectory(path);

                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            passPath = textBox17.Text;

                            string directoryPath = Path.GetDirectoryName(filePath);
                            var wow = new Process();
                            wow.StartInfo.WorkingDirectory = directoryPath;
                            wow.StartInfo.FileName = filePath;
                            wow.Start();

                            TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startSL.txt");
                            TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passSL.txt");
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
                        var path = @"Data\Paths\Alt\";
                        _ = Directory.CreateDirectory(path);

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        passPath = textBox17.Text;
                        string directoryPath = Path.GetDirectoryName(filePath);
                        var wow = new Process();
                        wow.StartInfo.WorkingDirectory = directoryPath;
                        wow.StartInfo.FileName = filePath;
                        wow.Start();

                        TextWriter txt = new StreamWriter(@"Data\Paths\Alt\startSL.txt");
                        TextWriter pass = new StreamWriter(@"Data\Paths\Alt\passSL.txt");
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

        private void button9_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.ShowDialog();
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void TextBox3_GotFocus(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void TextBox5_GotFocus(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void TextBox7_GotFocus(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }


        private void TextBox9_GotFocus(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void TextBox11_GotFocus(object sender, EventArgs e)
        {
            textBox11.Text = "";
        }

        private void TextBox13_GotFocus(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void TextBox15_GotFocus(object sender, EventArgs e)
        {
            textBox15.Text = "";
        }
        //Lost Focus

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            var snamevanilla = new FileInfo(@"Data\Paths\Alt\servervanilla.txt");
            if (textBox1.Text.Length == 0 && snamevanilla.Exists)
            {
                var vanillaname = File.ReadLines(@"Data\Paths\Alt\servervanilla.txt").First();
                textBox1.Text = vanillaname; 
            
            }
        }

        private void TextBox3_LostFocus(object sender, EventArgs e)
        {
            var snameTBC = new FileInfo(@"Data\Paths\Alt\serverTBC.txt");
            if (textBox3.Text.Length == 0 && snameTBC.Exists)
            {
                var TBCname = File.ReadLines(@"Data\Paths\Alt\serverTBC.txt").First();
                textBox3.Text = TBCname;

            }
        }

        private void TextBox5_LostFocus(object sender, EventArgs e)
        {
            var snameWotlk = new FileInfo(@"Data\Paths\Alt\serverWotlk.txt");
            if (textBox5.Text.Length == 0 && snameWotlk.Exists)
            {
                var Wotlkname = File.ReadLines(@"Data\Paths\Alt\serverWotlk.txt").First();
                textBox5.Text = Wotlkname;

            }
        }

        private void TextBox7_LostFocus(object sender, EventArgs e)
        {
            var snameCata = new FileInfo(@"Data\Paths\Alt\serverCata.txt");
            if (textBox7.Text.Length == 0 && snameCata.Exists)
            {
                var Cataname = File.ReadLines(@"Data\Paths\Alt\serverCata.txt").First();
                textBox7.Text = Cataname;

            }
        }


        private void TextBox9_LostFocus(object sender, EventArgs e)
        {
            var snameMop = new FileInfo(@"Data\Paths\Alt\serverMop.txt");
            if (textBox9.Text.Length == 0 && snameMop.Exists)
            {
                var Mopname = File.ReadLines(@"Data\Paths\Alt\serverMop.txt").First();
                textBox9.Text = Mopname;

            }
        }

        private void TextBox11_LostFocus(object sender, EventArgs e)
        {
            var snameLegion = new FileInfo(@"Data\Paths\Alt\serverLegion.txt");
            if (textBox11.Text.Length == 0 && snameLegion.Exists)
            {
                var Legionname = File.ReadLines(@"Data\Paths\Alt\serverLegion.txt").First();
                textBox11.Text = Legionname;

            }
        }

        private void TextBox13_LostFocus(object sender, EventArgs e)
        {
            var snameBFA = new FileInfo(@"Data\Paths\Alt\serverBFA.txt");
            if (textBox13.Text.Length == 0 && snameBFA.Exists)
            {
                var BFAname = File.ReadLines(@"Data\Paths\Alt\serverBFA.txt").First();
                textBox13.Text = BFAname;

            }
        }

        private void TextBox15_LostFocus(object sender, EventArgs e)
        {
            var snameSL = new FileInfo(@"Data\Paths\Alt\serverSL.txt");
            if (textBox15.Text.Length == 0 && snameSL.Exists)
            {
                var SLname = File.ReadLines(@"Data\Paths\Alt\serverSL.txt").First();
                textBox15.Text = SLname;

            }
        }
    }



    }

