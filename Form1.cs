using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices;
using WindowsInput;


namespace Scraping
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public string inputFileText1 = "";
        public string outputFileText1 = "";
        public string inputFileText2 = "";
        public string outputFileText2 = "";
        public string inputFileText3 = "";
        public string outputFileText3 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private int CalculateLongLinesLength(int length1, int length2, int length3)
        {
            if(length1 > length2 && length1 > length3) {
                return length1;
            }
            if (length2 > length1 && length2 > length3)
            {
                return length2;
            }
            if (length3 > length2 && length3 > length1)
            {
                return length3;
            }
            return 0;

        }

        private async void start_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(inputFileText1);
            string[] rad_lines = File.ReadAllLines(inputFileText2);
            string[] hil_lines = File.ReadAllLines(inputFileText3);

            int longLength = CalculateLongLinesLength(lines.Length, rad_lines.Length, hil_lines.Length);

            //MessageBox.Show(longLength.ToString());

            for( int i = 0; i< longLength; i++)
            {
                if(i < lines.Length)
                {
                    string line = lines[i];
                    await extract1(line);
                }
                if (i < rad_lines.Length)
                {
                    string line = rad_lines[i];
                    await extract2(line);
                }
                if (i < hil_lines.Length)
                {
                    string line = hil_lines[i];
                    await extract3(line);
                }

            }   
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input_text.Text = openFileDialog1.FileName;
                inputFileText1 = input_text.Text;
            }
            string[] lines = File.ReadAllLines(inputFileText1);

        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Title = "Output Text File";
            openFileDialog2.DefaultExt = "txt";
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                output_text.Text = openFileDialog2.FileName;
                outputFileText1 = output_text.Text;
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
                inputFileText2 = textBox2.Text;
            }
            string[] lines = File.ReadAllLines(inputFileText2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Title = "Output Text File";
            openFileDialog2.DefaultExt = "txt";
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog2.FileName;
                outputFileText2 = textBox1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Title = "Browse Text Files";
            openFileDialog3.DefaultExt = "txt";
            openFileDialog3.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog3.FileName;
                inputFileText3 = textBox4.Text;
            }
            string[] lines = File.ReadAllLines(inputFileText3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Title = "Output Text File";
            openFileDialog3.DefaultExt = "txt";
            openFileDialog3.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog3.FileName;
                outputFileText3 = textBox3.Text;
            }
        }

        private async Task extract1(string line)
        {
            string[] infoList = line.Split("|");
            string mail = infoList[1].Replace(" ", "");
            string pass = infoList[2].Replace(" ", "");
            CoreWebView2Profile webView2Profile = webView23.CoreWebView2.Profile;
            //await webView2Profile.ClearBrowsingDataAsync();
            await webView23.ExecuteScriptAsync("window.location.href = 'https://www.britishairways.com/travel/echome/execclub/_gf/en_hk';");
            await Task.Delay(20000);
            await webView23.ExecuteScriptAsync(string.Format("var event = new Event('change');\r\ndocument.getElementById('membershipNumber').value = '{0}'\r\ndocument.getElementById('membershipNumber').dispatchEvent(event);\r\ndocument.getElementById('input_password').value = '{1}'\r\ndocument.getElementById('input_password').dispatchEvent(event);\r\ndocument.getElementById('ecuserlogbutton').click()", mail, pass));
            await Task.Delay(35000);
            string aviosStr = await webView23.ExecuteScriptAsync("document.getElementsByClassName('tier-points-value exc-home-block')[0].innerHTML");
            using StreamWriter file = new(outputFileText1, append: true);
            await file.WriteLineAsync(line + " | aviosStr: " + aviosStr + "\n");
            file.Close();
            await webView23.ExecuteScriptAsync("document.getElementsByClassName('mobile-menu menu-icon-new')[0].click();\r\ndocument.getElementsByClassName('logout')[0].children[0].click();");
            await Task.Delay(5000);
        }

        private async Task extract2(string line)
        {
            string[] infoList = line.Split("|");
            string mail = infoList[1].Replace(" ", "");
            string pass = infoList[2].Replace(" ", "");
            //await webView2Profile.ClearBrowsingDataAsync();

            await webView23.ExecuteScriptAsync("window.location.href = 'https://www.radissonhotels.com/';");
            await Task.Delay(10000);
            await webView23.ExecuteScriptAsync("document.getElementsByClassName('btn loyalty-visibility show')[0].click();");
            await Task.Delay(500);
            await webView23.ExecuteScriptAsync(string.Format("document.querySelectorAll('#modal-email-rewards').forEach(i=>i.value='{0}')\r\n",mail));
            await Task.Delay(500);
            //await webView23.ExecuteScriptAsync("var event = new Event('change');\r\ndocument.getElementById('modal-email-rewards').value = 6015998002209106;\r\ndocument.getElementById('modal-email-rewards').dispatchEvent(event);\r\n\r\n");
            await webView23.ExecuteScriptAsync(string.Format("var event = new Event('change');\r\ndocument.getElementById('password-rewards-mobile-nlp').value = '{0}';\r\ndocument.getElementById('password-rewards-mobile-nlp').dispatchEvent(event);\r\n\r\n",pass));
            await Task.Delay(500);
            await webView23.ExecuteScriptAsync("document.getElementsByClassName('btn entity-modal-nlp__button entity-modal-nlp__button entity-modal-nlp__button--mobile btn-primary w-100 text-uppercase')[0].click()");
            await Task.Delay(1500);
            await webView23.ExecuteScriptAsync("document.getElementsByClassName(\"btn d-flex align-items-center py-0 js-offcanvas-loyalty customer-info-button loyalty-visibility show\")[0].click();");
            await Task.Delay(1500);
            string pointsStr = await webView23.ExecuteScriptAsync("document.getElementsByClassName('points-count user-rewards-points')[0].innerHTML\r\n");
            using StreamWriter file = new(outputFileText2, append: true);
            await file.WriteLineAsync(line + " | points: " + pointsStr + "\n");
            file.Close();
            await Task.Delay(1500);
            await webView23.ExecuteScriptAsync("document.getElementById('customer-logout-btn').click();");
            await Task.Delay(500);
        }

        private async Task extract3(string line)
        {
            await webView23.ExecuteScriptAsync("window.location.href = 'https://www.hilton.com/';");
            await Task.Delay(15000);
            string[] infoList = line.Split("|");
            string mail = infoList[1].Replace(" ", "");
            string pass = infoList[2].Replace(" ", "");

            SetCursorPos(this.Left + 301, this.Top + 80);
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (int)X, (int)Y, 0, 0);
            await Task.Delay(3500);
            SetCursorPos(this.Left + 150, this.Top + 210);
            uint X1 = (uint)Cursor.Position.X;
            uint Y1 = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (int)X1, (int)Y1, 0, 0);

            InputSimulator Simulator = new InputSimulator();
            Simulator.Keyboard.TextEntry(mail);

            await Task.Delay(1500);
            SetCursorPos(this.Left + 220, this.Top + 280);
            uint X2 = (uint)Cursor.Position.X;
            uint Y2 = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (int)X1, (int)Y1, 0, 0);

            InputSimulator Simulator1 = new InputSimulator();
            Simulator1.Keyboard.TextEntry(pass);

            SetCursorPos(this.Left + 220, this.Top + 380);
            uint X3 = (uint)Cursor.Position.X;
            uint Y3 = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (int)X3, (int)Y3, 0, 0);


            await Task.Delay(1500);
            await webView23.ExecuteScriptAsync("document.getElementById('menu-button--menu').click();");
            await Task.Delay(1500);
            string pointsStr = await webView23.ExecuteScriptAsync("document.getElementsByClassName('flex flex-col px-2 py-3')[0].children[0].children[1].innerHTML");
            using StreamWriter file = new(outputFileText3, append: true);
            await file.WriteLineAsync(line + " | points: " + pointsStr + "\n");
            file.Close();
            await Task.Delay(1500);
            await webView23.ExecuteScriptAsync("document.getElementsByClassName('text-text hover:text-text-alt highlighted:bg-bg-alt block px-2 py-3')[1].click();");

        }

        private void webView23_Click(object sender, EventArgs e)
        {

        }
    }
     
}