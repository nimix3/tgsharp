namespace HoopoeTelegram
{
    using ir.telegramp;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class frmMsgReceiver : Form
    {
        private string account = "";
        private telegramApi api = new telegramApi();
        private IContainer components;
        private GroupBox groupBox1;
        private string last_message = "";
        private Label lbl_title;
        private TextBox textBox7;
        private System.Windows.Forms.Timer timer1;

        public frmMsgReceiver(string num)
        {
            this.InitializeComponent();
            this.account = num;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmMsgReceiver_Load(object sender, EventArgs e)
        {
        }

        private void frmMsgReceiver_Shown(object sender, EventArgs e)
        {
            new Thread(() => this.loadApi()).Start();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMsgReceiver));
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 17);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(451, 252);
            this.textBox7.TabIndex = 0;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(218, 1);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(19, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMsgReceiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 272);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMsgReceiver";
            this.Text = "Receiving Messages";
            this.Load += new System.EventHandler(this.frmMsgReceiver_Load);
            this.Shown += new System.EventHandler(this.frmMsgReceiver_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void loadApi()
        {
            MethodInvoker method = null;
            MethodInvoker invoker2 = null;
            try
            {
                if (method == null)
                {
                    method = delegate {
                        this.textBox7.Text = this.account.Replace("+", "") + "> ";
                        this.textBox7.SelectionStart = this.textBox7.Text.Length;
                        this.Text = this.lbl_title.Text = "Getting Ready to Get Messages of This Number... ";
                    };
                }
                base.Invoke(method);
            }
            catch
            {
            }
            this.api.login(this.account);
            this.api.sendMessageToPhone(this.account, "receiver ready...");
            try
            {
                if (invoker2 == null)
                {
                    invoker2 = () => this.Text = this.lbl_title.Text = "Messages of : " + this.account.Replace("+", "");
                }
                base.Invoke(invoker2);
            }
            catch
            {
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                this.textBox7.SelectAll();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.last_message != this.api.last_message)
            {
                this.last_message = this.api.last_message;
                string str = Encoding.UTF8.GetString(Encoding.Default.GetBytes(this.last_message));
                if (this.last_message.StartsWith("Your Login Code:"))
                {
                    str = this.last_message.Substring(0, 0x16);
                }
                if ((this.textBox7.Text == "") || (this.textBox7.Text == (this.account.Replace("+", "") + "> ")))
                {
                    if (str.ToLower().Contains("your login code:") || str.Contains("Your login code:"))
                        str = " ";
                    this.textBox7.Text = this.account.Replace("+", "") + "> " + str.Replace("\r", "").Replace("\n", Environment.NewLine);
                }
                else
                {
                    TextBox box = this.textBox7;
                    string[] strArray = new string[7];
                    int index = 0;
                    strArray[index] = this.account.Replace("+", "");
                    int num2 = 1;
                    strArray[num2] = "> ";
                    int num3 = 2;
                    strArray[num3] = str.Replace("\r", "").Replace("\n", Environment.NewLine);
                    int num4 = 3;
                    strArray[num4] = Environment.NewLine;
                    int num5 = 4;
                    strArray[num5] = "----------------------------------------------------";
                    int num6 = 5;
                    strArray[num6] = Environment.NewLine;
                    int num7 = 6;
                    strArray[num7] = this.textBox7.Text;
                    string str9 = string.Concat(strArray);
                    box.Text = str9;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

