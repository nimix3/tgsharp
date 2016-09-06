namespace HoopoeTelegram
{
    using ir.telegramp;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class frmNewAcc : Form
    {
        private telegramApi api = new telegramApi();
        private BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private Button button1;
        private Button button2;
        private CheckBox chk_active_members;
        private CheckBox chk_sendCall;
        private bool code_sent;
        private IContainer components;
        public string defualt_country_code = "+1";
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Panel panel1;
        private frmNewAcc parent;
        public string pass = "";
        private PictureBox pictureBox_loader;
        public int port = 0x16;
        public string server = "";
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txt_password;
        private Label label5;
        private CheckBox checkBox1;
        public string user = "";

        public frmNewAcc()
        {
            this.InitializeComponent();
            this.backgroundWorker1 = new BackgroundWorker();
            this.backgroundWorker2 = new BackgroundWorker();
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker2.DoWork += new DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.pictureBox_loader.Visible = true;
            this.pictureBox_loader.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MethodInvoker method = null;
            MethodInvoker invoker2 = null;
            MethodInvoker invoker3 = null;
            MethodInvoker invoker4 = null;
            MethodInvoker invoker5 = null;
            MethodInvoker invoker6 = null;
            MethodInvoker invoker7 = null;
            MethodInvoker invoker8 = null;
            MethodInvoker invoker9 = null;
            MethodInvoker invoker10 = null;
            MethodInvoker invoker11 = null;
            MethodInvoker invoker12 = null;
            MethodInvoker invoker13 = null;
            try
            {
                this.code_sent = false;
                if (method == null)
                {
                    method = () => this.label3.Text = "Sending Code...";
                }
                base.Invoke(method);
                string phoneNo = this.textBox1.Text.Trim() + this.textBox2.Text;
                phoneNo = string.Join<char>("", phoneNo.ToCharArray().Where<char>(new Func<char, bool>(char.IsDigit)));
                if ((!this.chk_active_members.Checked && this.api.checkPhone(phoneNo).Equals("IsMember") && (MessageBox.Show("This Number was Registered in Telegram Before, Do You Want To Add This Number?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.No)))
                {
                    if (invoker2 == null)
                    {
                        invoker2 = () => this.label3.Text = "Number Activation";
                    }
                    base.Invoke(invoker2);
                    if (invoker3 == null)
                    {
                        invoker3 = () => this.pictureBox_loader.Visible = false;
                    }
                    base.Invoke(invoker3);
                }
                else
                {
                    string Result = this.api.login(phoneNo, true, this.chk_sendCall.Checked, true);
                    if (Result.IndexOf("Code Sent") > -1)
                    {
                        this.code_sent = true;
                        if (invoker4 == null)
                        {
                            invoker4 = () => this.label3.Text = "Code Sent.";
                        }
                        base.Invoke(invoker4);
                    }
                    else if (Result.Contains("PHONE_NUMBER_INVALID"))
                    {
                        if (invoker5 == null)
                        {
                            invoker5 = () => this.label3.Text = "Number is Invalid";
                        }
                        base.Invoke(invoker5);
                        if (invoker6 == null)
                        {
                            invoker6 = () => this.groupBox1.Enabled = true;
                        }
                        base.Invoke(invoker6);
                    }
                    else if (Result.Contains("network"))
                    {
                        if (invoker7 == null)
                        {
                            invoker7 = () => this.label3.Text = "Connection Error";
                        }
                        base.Invoke(invoker7);
                        if (invoker8 == null)
                        {
                            invoker8 = () => this.groupBox1.Enabled = true;
                        }
                        base.Invoke(invoker8);
                    }
                    else if (Result.ToLower().Contains("error") || Result.ToLower().Contains("err:"))
                    {
                        if (invoker9 == null)
                        {
                            invoker9 = () => this.label3.Text = "Error Sending Code";
                        }
                        base.Invoke(invoker9);
                        if (invoker10 == null)
                        {
                            invoker10 = () => this.groupBox1.Enabled = true;
                        }
                        base.Invoke(invoker10);
                    }
                    else
                    {
                        base.Invoke(new Action(() => this.label3.Text = Result));
                    }
                    if (invoker11 == null)
                    {
                        invoker11 = () => this.pictureBox_loader.Visible = false;
                    }
                    base.Invoke(invoker11);
                }
            }
            catch (Exception exception)
            {
                this.api.logWithSenderNumber(exception.Message);
                if (invoker12 == null)
                {
                    invoker12 = () => this.label3.Text = "Error.. Please Try Again";
                }
                base.Invoke(invoker12);
                if (invoker13 == null)
                {
                    invoker13 = () => this.groupBox1.Enabled = true;
                }
                base.Invoke(invoker13);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pictureBox_loader.Visible = false;
        }
        static string ROT13(string input)
        {
            return !string.IsNullOrEmpty(input) ? new string(input.ToCharArray().Select(s => { return (char)((s >= 97 && s <= 122) ? ((s + 13 > 122) ? s - 13 : s + 13) : (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s)); }).ToArray()) : input;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            MethodInvoker method = null;
            MethodInvoker invoker2 = null;
            MethodInvoker invoker3 = null;
            MethodInvoker invoker4 = null;
            MethodInvoker invoker5 = null;
            try
            {
                string str = this.api.Authrize(this.maskedTextBox1.Text.Trim(), Main.defualt_Telegram_Name, Main.defualt_Telegram_Family);
                if (str.Contains("and loaded"))
                {
                    string phoneNumber = this.textBox1.Text.Trim() + this.textBox2.Text;
                    phoneNumber = string.Join<char>("", phoneNumber.ToCharArray().Where<char>(new Func<char, bool>(char.IsDigit)));
                    //this.api.uploadStat(phoneNumber, Main.username);
                    
                    if ((this.txt_password.Text != "") && !str.Contains("Login by password"))
                    {
                        this.api.changeAccountPassword("", this.txt_password.Text);
                    }
                    if (method == null)
                    {
                        method = delegate {
                            MessageBox.Show("The Number Added To List Successfully.","Hoopoe Telegram");
                            try {
                                string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                                File.WriteAllText(_Desktop + "\\HoopoeTelegram\\Accounts\\" + phoneNumber + ".tga", ROT13(System.Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(File.ReadAllText(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts\\" + phoneNumber + ".stat", System.Text.Encoding.Default)))), new System.Text.UTF8Encoding(false));
                            }
                            catch { }
                            this.textBox2.Text = "";
                            this.maskedTextBox1.Text = "";
                            this.label3.Text = "";
                            this.textBox2.Focus();
                        };
                    }
                    base.Invoke(method);
                }
                else if (str.IndexOf("PHONE_CODE_INVALID") > -1)
                {
                    if (invoker2 == null)
                    {
                        invoker2 = () => this.label3.Text = "The Verification Code is Wrong!";
                    }
                    base.Invoke(invoker2);
                }
                else if (str.IndexOf("PASSWORD_HASH_INVALID") > -1)
                {
                    if (invoker3 == null)
                    {
                        invoker3 = () => this.label3.Text = "The Number is Lock. Password is Wrong!";
                    }
                    base.Invoke(invoker3);
                }
                else
                {
                    MessageBox.Show("An Error Occured: \n" + str);
                }
                if (invoker4 == null)
                {
                    invoker4 = () => this.pictureBox_loader.Visible = false;
                }
                base.Invoke(invoker4);
            }
            catch (Exception exception)
            {
                if (invoker5 == null)
                {
                    invoker5 = () => this.pictureBox_loader.Visible = false;
                }
                base.Invoke(invoker5);
                MessageBox.Show("An Error Occured: \n" + exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.backgroundWorker1.IsBusy)
            {
                long result = 0L;
                if ((this.textBox2.Text.Trim().ToString().Length < 9) || !long.TryParse(this.textBox2.Text.Trim().ToString(), out result))
                {
                    MessageBox.Show("The Number You Entered is Wrong!");
                }
                else
                {
                    this.code_sent = false;
                    this.pictureBox_loader.Visible = true;
                    this.maskedTextBox1.Focus();
                    this.backgroundWorker1.RunWorkerAsync();
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.backgroundWorker2.IsBusy)
            {
                long result = 0L;
                if ((this.maskedTextBox1.Text.Trim().Length < 5) || !long.TryParse(this.maskedTextBox1.Text.Trim(), out result))
                {
                    MessageBox.Show("The Verification Code is Wrong!");
                }
                else
                {
                    this.pictureBox_loader.Visible = true;
                    this.backgroundWorker2.RunWorkerAsync();
                }
                this.groupBox1.Enabled = true;
                this.groupBox2.Enabled = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmNewAcc_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.api = null;
            }
            catch
            {
            }
        }

        private void frmNewAcc_Load(object sender, EventArgs e)
        {
        }

        private void frmNewAcc_Shown(object sender, EventArgs e)
        {
            this.textBox1.Text = this.defualt_country_code;
            this.textBox2.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAcc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_active_members = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.chk_sendCall = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_loader = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chk_active_members);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.chk_sendCall);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox_loader);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Force SMS";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password  :";
            // 
            // chk_active_members
            // 
            this.chk_active_members.AutoSize = true;
            this.chk_active_members.Location = new System.Drawing.Point(8, 84);
            this.chk_active_members.Name = "chk_active_members";
            this.chk_active_members.Size = new System.Drawing.Size(156, 17);
            this.chk_active_members.TabIndex = 7;
            this.chk_active_members.Text = "Active Registered Numbers";
            this.chk_active_members.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(75, 112);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 21);
            this.txt_password.TabIndex = 5;
            // 
            // chk_sendCall
            // 
            this.chk_sendCall.AutoSize = true;
            this.chk_sendCall.Location = new System.Drawing.Point(8, 56);
            this.chk_sendCall.Name = "chk_sendCall";
            this.chk_sendCall.Size = new System.Drawing.Size(86, 17);
            this.chk_sendCall.TabIndex = 6;
            this.chk_sendCall.Text = "Request Call";
            this.chk_sendCall.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "+1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_loader
            // 
            this.pictureBox_loader.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_loader.Image")));
            this.pictureBox_loader.Location = new System.Drawing.Point(237, 12);
            this.pictureBox_loader.Name = "pictureBox_loader";
            this.pictureBox_loader.Size = new System.Drawing.Size(41, 39);
            this.pictureBox_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_loader.TabIndex = 7;
            this.pictureBox_loader.TabStop = false;
            this.pictureBox_loader.Visible = false;
            this.pictureBox_loader.Click += new System.EventHandler(this.pictureBox_loader_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(283, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(7, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number Verification";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(81, 25);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify Code :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 13);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label5.Location = new System.Drawing.Point(103, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hoopoe Telegram";
            // 
            // frmNewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 252);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register New Number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewAcc_FormClosing);
            this.Load += new System.EventHandler(this.frmNewAcc_Load);
            this.Shown += new System.EventHandler(this.frmNewAcc_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_loader_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

