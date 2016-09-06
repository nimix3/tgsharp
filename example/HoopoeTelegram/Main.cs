namespace HoopoeTelegram
{
    using Excel;
    using ir.telegramp;
    using Microsoft.Win32;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Net.Mail;
    using System.Numerics;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;

    public class Main : Form
    {
        private static string _hash = "SHA1";
        private static int _iterations = 2;
        private static int _keySize = 0x100;
        private static string _salt = "miogramnet333a32";
        private static string _vector = "2016hoopoel34tgm";
        private telegramApi[] api;
        private telegramApi apii = new telegramApi();
        private string[] attach_pic_files = new string[4];
        public static string avatar = "";
        public static bool avatar_updated = false;
        public BackgroundWorker backgroundWorker_Checker;
        private bool busy;
        private int channels = 1;
        public static string company_name = "";
        private IContainer components;
        public static int Count_PhoneNumber = 0;
        public static int creat_line = 0;
        public static string defualt_account_country = "+1";
        public static int defualt_max_line_can_work = 1;
        public static int defualt_max_mojaz_ersal_har_khat = 50;
        public static string defualt_send_type = "private";
        public static string defualt_sending_country = "+1";
        public static string defualt_Telegram_Family = "Hoopoe";
        public static string defualt_Telegram_Name = "Telegram";
        public static int delay_Type_App = 1;
        public static bool delete_after_send = false;
        private int elapsed_time;
        private string[] files = new string[4];
        public static string[] images_captions = new string[6];
        private string imgcap = "";
        private string imgsrc = "";
        public static bool initialized = false;
        private string inputfilename = "";
        private string inputpicturefilename = "";
        private string inputvideofilename = "";
        private string xFileTime = "";
        public static bool last_input_is_quick = true;
        public static string licence_register_name = "";
        private ListBox Lines_Queue = new ListBox();
        private int load_attemp;
        private object LockObject_Login = new object();
        private object LockObject_Send = new object();
        private object LockObject_Stop = new object();
        private object LockObject_Write = new object();
        private telegramApi logApi = new telegramApi();
        public static bool loggined = false;
        public static int max_groupMembers = 0x14;
        public static int max_image_height = 0x400;
        public static int max_image_width = 0x400;
        public static int max_sends = 30;
        private string msg = "";
        private telegramApi myApi = new telegramApi();
        public static int number_limit = 0;
        private bool only_check = true;
        public static string password = "";
        public static string path_defualt_message = "";
        public static string path_Emoji = "";
        public static string path_main_save_report = "";
        public static string path_project = "";
        public static string path_save_report = "";
        public static string path_Senders = "";
        public static string path_Setting = "";
        public static string path_Tel = "";
        public static string phone_Delivery = "";
        public static string[] phoneNumber;
        public PictureBox[] pictureBoxes = new PictureBox[4];
        private RegistryKey regKey;
        private int running_tasks;
        public static bool show_number_and_time_inMessage = false;
        public static bool AntiBlk = false;
        private bool task_stopped = true;
        private bool joinStop = false;
        private int total;
        public static int Type_App = 0x3e8;
        public static string username = "";
        public static string version_app = "1.00";
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label9;
        private Button button16;
        private Label label22;
        private TextBox txt_search;
        private Label label14;
        private Label label12;
        private ComboBox cmb_filter;
        private Button button11;
        private Label lbl_suspendLines;
        private Label label25;
        private Label lbl_disabledLines;
        private Label label23;
        private Label label21;
        private Label label20;
        private Button button1;
        private GroupBox groupBox7;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn selected;
        private DataGridViewTextBoxColumn radif;
        private DataGridViewTextBoxColumn Line_Number;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileAddressDataGridViewTextBoxColumn;
        private PictureBox pictureBox3;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private TabPage tabPage5;
        private PictureBox pictureBox13;
        private GroupBox groupBox15;
        private Label FLOODx;
        private Label RELEASE;
        private Label FLOOD_LB;
        private Button BUTTON;
        private Label RELEASE_LB;
        private Button button21;
        private ProgressBar progressBar3;
        private Panel panel333;
        private Label label40;
        private Label CHECK_LB;
        private Label CHECK;
        private GroupBox groupBox12;
        private GroupBox groupBox16;
        private CheckBox ReleaseAct;
        private CheckBox NoSpamAct;
        private GroupBox groupBox13;
        private GroupBox groupBox14;
        private TextBox chk;
        private Label label30;
        private Label label31;
        private PictureBox pictureBox12;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label RISTRICTED_LB;
        private Label RISTRICTED;
        private Label PeerFloodx;
        private Label Peer;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox gpass;
        private TextBox gmail;
        private Label label5;
        private Label label4;
        private string videosrc = "";

        public Main()
        {
            this.InitializeComponent();
            path_defualt_message = Class_Files_And_Folders.ProjectPath_WithSlash() + "Default_Message";
            path_project = Class_Files_And_Folders.ProjectPath_WithSlash();
            path_Setting = Class_Files_And_Folders.ProjectPath_WithSlash() + "Setting";
            path_Senders = Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts";
            path_main_save_report = Class_Files_And_Folders.ProjectPath_WithSlash() + "Reports";
            path_Emoji = Class_Files_And_Folders.ProjectPath_WithSlash() + "Emoji";
            Create_Default_Folders();
            this.load_default_setting();
            this.backgroundWorker_Checker = new BackgroundWorker();
            this.backgroundWorker_Checker.WorkerSupportsCancellation = true;
            this.backgroundWorker_Checker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_Checker_RunWorkerCompleted);
            try
            {
                File.Delete(Class_Files_And_Folders.ProjectPath_WithSlash() + "activeServers.conf");
            }
            catch
            {
            }
            this.ColumnCheckbox(this.dataGridView1);
            if (File.Exists(path_Setting + @"\Avatar.jpg"))
            {
                Image image = new Bitmap(path_Setting + @"\Avatar.jpg");
                //this.pictureBox_Avatar.Image = image.GetThumbnailImage(350, 350, null, new IntPtr());
                image.Dispose();
            }
        }

        private void backgroundWorker_Checker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.load_lines(this.txt_search.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmNewAcc().ShowDialog();
            this.load_lines(this.txt_search.Text);
            try
            {
                if (!Directory.Exists(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts"))
                {
                    Directory.CreateDirectory(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                }
                String[] files = Directory.GetFiles(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");

                comboBox1.Items.Clear();
                foreach (String file in files)
                {
                    if (file.Contains(".stat"))
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Path.GetFileNameWithoutExtension(file);
                        item.Value = Path.GetFileNameWithoutExtension(file);
                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ThreadStart start = null;
            if (!this.busy)
            {
                this.dataGridView1.EndEdit();
                this.progressBar3.Value = 0;
                int num = 0;
                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {
                    if (this.dataGridView1.Rows[i].Cells["selected"].Value.ToString().ToLower() == "true")
                    {
                        num++;
                    }
                }
                if (num <= 0)
                {
                    MessageBox.Show("No Account Selected! Please Select Accounts You Want First");
                }
                else
                {
                    this.progressBar3.Maximum = num;
                    this.progressBar3.Visible = true;
                    this.only_check = true;
                    if (start == null)
                    {
                        start = () => this.update_repair();
                    }
                    new Thread(start).Start();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Do You Want To Delete Selected Account ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.dataGridView1.EndEdit();
                    foreach (DataGridViewRow row in (IEnumerable)this.dataGridView1.Rows)
                    {
                        if ((bool)row.Cells[0].Value)
                        {
                            File.Delete(string.Concat(new object[] { path_Senders, @"\", row.Cells[2].Value, ".stat" }));
                            string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            String[] files = Directory.GetFiles(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                            if (!Directory.Exists(_Desktop + "\\HoopoeTelegram\\Accounts"))
                            {
                                Directory.CreateDirectory(_Desktop + "\\HoopoeTelegram\\Accounts");
                            }
                            if(File.Exists(_Desktop + "\\HoopoeTelegram\\Accounts\\" + row.Cells[2].Value + ".key"))
                            File.Delete(_Desktop + "\\HoopoeTelegram\\Accounts\\" + row.Cells[2].Value + ".key");
                        }
                    }
                    this.load_lines(this.txt_search.Text);
                }
            }
            catch {  }
            try
            {
                if (!Directory.Exists(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts"))
                {
                    Directory.CreateDirectory(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                }
                String[] files = Directory.GetFiles(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");

                comboBox1.Items.Clear();
                foreach (String file in files)
                {
                    if (file.Contains(".stat"))
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Path.GetFileNameWithoutExtension(file);
                        item.Value = Path.GetFileNameWithoutExtension(file);
                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.load_lines(this.txt_search.Text);
            try
            {
                if (!Directory.Exists(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts"))
                {
                    Directory.CreateDirectory(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                }
                String[] files = Directory.GetFiles(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");

                comboBox1.Items.Clear();
                foreach (String file in files)
                {
                    if (file.Contains(".stat"))
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Path.GetFileNameWithoutExtension(file);
                        item.Value = Path.GetFileNameWithoutExtension(file);
                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.inputvideofilename != "")
            {
                Process.Start(this.inputvideofilename);
            }
        }

        private bool check_status(string cn)
        {
            string str = this.cmb_filter.Text.Trim();
            if (((((((str != "All") && ((cn != "blocked") || (str != "Deactive"))) && ((cn != "session_expired") || (str != "Deactive - Session Failed"))) && ((cn != "file_corrupted") || (str != "Deactive - File Failed"))) && ((((cn != "suspend") && (cn != "file_corrupted")) && (((cn != "session_expired") && (cn != "contacts_list_full")) && (cn != "blocked"))) || (str != "Damaged"))) && (((cn != "suspend") && (cn != "contacts_list_full")) || (str != "Deactive - Suspended"))) && ((cn != "") || (str != "Active")))
            {
                if (cn.Length < 0x12)
                {
                    return false;
                }
                return (((long.Parse(cn) > DateTime.Now.Ticks) && (str == "Suspended")) || (str == "Active"));
            }
            return true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            CheckBox box = sender as CheckBox;
            if (box.Checked)
            {
                foreach (DataGridViewRow row in (IEnumerable) this.dataGridView1.Rows)
                {
                    row.Cells[0].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row2 in (IEnumerable) this.dataGridView1.Rows)
                {
                    row2.Cells[0].Value = false;
                }
            }
        }

        public static bool checkInternetConnectivity()
        {
            return true;
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.load_lines(this.txt_search.Text);
        }

        private CheckBox ColumnCheckbox(DataGridView dataGridView)
        {
            CheckBox box = new CheckBox {
                Size = new Size(15, 15),
                BackColor = System.Drawing.Color.Transparent,
                Padding = new Padding(0),
                Margin = new Padding(0),
                Text = "",
                Checked = true
            };
            box.CheckedChanged += new EventHandler(this.checkBox_CheckedChanged);
            dataGridView.Controls.Add(box);
            DataGridViewHeaderCell headerCell = dataGridView.Columns[1].HeaderCell;
            box.Location = new Point((headerCell.ContentBounds.Left + ((headerCell.ContentBounds.Right + headerCell.ContentBounds.Left) + box.Size.Width)) - 5, headerCell.ContentBounds.Top + 2);
            return box;
        }

        public static string Convert_Code_UTF16_ToEmoji(string code_UTF16)
        {
            try
            {
                byte[] bytes = new byte[8];
                string str = code_UTF16.Replace(",", " ").Replace("-", " ").Trim();
                try
                {
                    bytes[1] = (byte) Convert.ToInt32(str.Substring(0, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[0] = (byte) Convert.ToInt32(str.Substring(2, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[3] = (byte) Convert.ToInt32(str.Substring(4, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[2] = (byte) Convert.ToInt32(str.Substring(6, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[5] = (byte) Convert.ToInt32(str.Substring(8, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[4] = (byte) Convert.ToInt32(str.Substring(10, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[7] = (byte) Convert.ToInt32(str.Substring(12, 2), 0x10);
                }
                catch
                {
                }
                try
                {
                    bytes[6] = (byte) Convert.ToInt32(str.Substring(14, 2), 0x10);
                }
                catch
                {
                }
                char[] chars = new char[Encoding.Unicode.GetCharCount(bytes, 0, bytes.Length)];
                Encoding.Unicode.GetChars(bytes, 0, bytes.Length, chars, 0);
                return new string(chars);
            }
            catch
            {
            }
            return "";
        }

        public static void Create_Default_Folders()
        {
            try
            {
                Class_Files_And_Folders.Create_Folder(path_main_save_report);
                Class_Files_And_Folders.Create_Folder(path_Senders);
                Class_Files_And_Folders.Create_Folder(path_save_report);
                Class_Files_And_Folders.Create_Folder(path_defualt_message);
                Class_Files_And_Folders.Create_Folder(path_Setting);
                Class_Files_And_Folders.Create_Folder(path_Emoji);
            }
            catch
            {
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            new frmMsgReceiver(this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()).Show();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "Active")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.Green;
                    }
                    if (e.Value.ToString() == "Deactive")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.Tomato;
                    }
                    if (e.Value.ToString() == "Deactive - Suspended")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.SaddleBrown;
                    }
                    if (e.Value.ToString() == "Deactive - Session Failed")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.SaddleBrown;
                    }
                    else if (e.Value.ToString().Contains("Suspended"))
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                    }
                }
            }
            catch
            {
            }
        }

        public static string Decrypt(string value, string password)
        {
            return Decrypt<AesManaged>(value, password);
        }

        public static string Decrypt<T>(string value, string password) where T: SymmetricAlgorithm, new()
        {
            byte[] buffer4;
            byte[] bytes = Encoding.ASCII.GetBytes(_vector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(_salt);
            byte[] buffer = Convert.FromBase64String(value);
            int count = 0;
            using (T local = Activator.CreateInstance<T>())
            {
                byte[] rgbKey = new PasswordDeriveBytes(password, rgbSalt, _hash, _iterations).GetBytes(_keySize / 8);
                local.Mode = CipherMode.CBC;
                try
                {
                    using (ICryptoTransform transform = local.CreateDecryptor(rgbKey, bytes))
                    {
                        using (MemoryStream stream = new MemoryStream(buffer))
                        {
                            using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
                            {
                                buffer4 = new byte[buffer.Length];
                                count = stream2.Read(buffer4, 0, buffer4.Length);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return string.Empty;
                }
                local.Clear();
            }
            return Encoding.UTF8.GetString(buffer4, 0, count);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        public static string Encrypt(string value, string password)
        {
            return Encrypt<AesManaged>(value, password);
        }

        public static string Encrypt<T>(string value, string password) where T: SymmetricAlgorithm, new()
        {
            byte[] buffer4;
            byte[] bytes = Encoding.ASCII.GetBytes(_vector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(_salt);
            byte[] buffer = Encoding.UTF8.GetBytes(value);
            using (T local = Activator.CreateInstance<T>())
            {
                byte[] rgbKey = new PasswordDeriveBytes(password, rgbSalt, _hash, _iterations).GetBytes(_keySize / 8);
                local.Mode = CipherMode.CBC;
                using (ICryptoTransform transform = local.CreateEncryptor(rgbKey, bytes))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                        {
                            stream2.Write(buffer, 0, buffer.Length);
                            stream2.FlushFinalBlock();
                            buffer4 = stream.ToArray();
                        }
                    }
                }
                local.Clear();
            }
            return Convert.ToBase64String(buffer4);
        }

        public static void Extract_PhoneNumber_From_String(string s)
        {
            try
            {
                phoneNumber = null;
                string str = s.Trim();
                char[] separator = new char[1];
                int index = 0;
                int num2 = 10;
                separator[index] = (char) num2;
                phoneNumber = str.Split(separator);
                for (int i = 0; i < ((IEnumerable<string>) phoneNumber).Count<string>(); i++)
                {
                    string str2 = Normal_PhoneNumber(phoneNumber[i], defualt_sending_country);
                    if (str2 != "")
                    {
                        phoneNumber[i] = str2;
                    }
                }
                Count_PhoneNumber = phoneNumber.Length;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private string GetMimeType(string fileName)
        {
            string str = "application/unknown";
            string name = Path.GetExtension(fileName).ToLower();
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(name);
            if ((key != null) && (key.GetValue("Content Type") != null))
            {
                str = key.GetValue("Content Type").ToString();
            }
            return str;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.lbl_suspendLines = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_disabledLines = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.PeerFloodx = new System.Windows.Forms.Label();
            this.Peer = new System.Windows.Forms.Label();
            this.RISTRICTED = new System.Windows.Forms.Label();
            this.RISTRICTED_LB = new System.Windows.Forms.Label();
            this.FLOODx = new System.Windows.Forms.Label();
            this.RELEASE = new System.Windows.Forms.Label();
            this.FLOOD_LB = new System.Windows.Forms.Label();
            this.BUTTON = new System.Windows.Forms.Button();
            this.RELEASE_LB = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.panel333 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.CHECK_LB = new System.Windows.Forms.Label();
            this.CHECK = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpass = new System.Windows.Forms.TextBox();
            this.gmail = new System.Windows.Forms.TextBox();
            this.ReleaseAct = new System.Windows.Forms.CheckBox();
            this.NoSpamAct = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.panel333.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 345);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txt_search);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.cmb_filter);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.lbl_suspendLines);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.lbl_disabledLines);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accounts";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(147, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 106);
            this.label5.TabIndex = 81;
            this.label5.Text = "This Product is Free, for buy more\r\ncommercial products please visit :\r\n\r\n http:/" +
    "/sheypoorak.com\r\n @Sheypoorak\r\n\r\nOpen Library :\r\n  https://github.com/nimix3";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "By Amin1SoftCo && NIMIX3";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 245);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(130, 30);
            this.button16.TabIndex = 25;
            this.button16.Text = "Reload Accounts";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("X-Files", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(55, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(239, 22);
            this.label22.TabIndex = 24;
            this.label22.Text = "Account Managment";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(385, 17);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 21);
            this.txt_search.TabIndex = 22;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Search:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(502, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Sort :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cmb_filter
            // 
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Deactive",
            "Suspended",
            "Deactive - Suspended",
            "Deactive - Session Failed",
            "Deactive - File Failed",
            "Damaged"});
            this.cmb_filter.Location = new System.Drawing.Point(542, 17);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(121, 21);
            this.cmb_filter.TabIndex = 18;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 281);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 30);
            this.button11.TabIndex = 16;
            this.button11.Text = "Diagnose";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // lbl_suspendLines
            // 
            this.lbl_suspendLines.AutoSize = true;
            this.lbl_suspendLines.Location = new System.Drawing.Point(397, 298);
            this.lbl_suspendLines.Name = "lbl_suspendLines";
            this.lbl_suspendLines.Size = new System.Drawing.Size(31, 13);
            this.lbl_suspendLines.TabIndex = 15;
            this.lbl_suspendLines.Text = "0000";
            this.lbl_suspendLines.Click += new System.EventHandler(this.lbl_suspendLines_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(338, 298);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "Suspend :";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // lbl_disabledLines
            // 
            this.lbl_disabledLines.AutoSize = true;
            this.lbl_disabledLines.Location = new System.Drawing.Point(514, 298);
            this.lbl_disabledLines.Name = "lbl_disabledLines";
            this.lbl_disabledLines.Size = new System.Drawing.Size(31, 13);
            this.lbl_disabledLines.TabIndex = 13;
            this.lbl_disabledLines.Text = "0000";
            this.lbl_disabledLines.Click += new System.EventHandler(this.lbl_disabledLines_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(457, 298);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Inactive :";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(621, 298);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "0000";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(571, 298);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Active :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add New Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Location = new System.Drawing.Point(324, 57);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(342, 233);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Accounts ";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.radif,
            this.Line_Number,
            this.statusDataGridViewTextBoxColumn,
            this.fileAddressDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(336, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // selected
            // 
            this.selected.HeaderText = " ";
            this.selected.Name = "selected";
            this.selected.Width = 30;
            // 
            // radif
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.radif.DefaultCellStyle = dataGridViewCellStyle5;
            this.radif.FillWeight = 50F;
            this.radif.HeaderText = "#";
            this.radif.Name = "radif";
            this.radif.ReadOnly = true;
            this.radif.Width = 30;
            // 
            // Line_Number
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Line_Number.DefaultCellStyle = dataGridViewCellStyle6;
            this.Line_Number.HeaderText = "Number";
            this.Line_Number.Name = "Line_Number";
            this.Line_Number.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.statusDataGridViewTextBoxColumn.FillWeight = 150F;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // fileAddressDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fileAddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.fileAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.fileAddressDataGridViewTextBoxColumn.Name = "fileAddressDataGridViewTextBoxColumn";
            this.fileAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(172, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sync (Refresh)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HoopoeTelegram1.Properties.Resources.aminated_talking_people_2x;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.pictureBox13);
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.groupBox12);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.pictureBox12);
            this.tabPage5.Controls.Add(this.pictureBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(677, 319);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Checker";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(259, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 106);
            this.label4.TabIndex = 82;
            this.label4.Text = "This Product is Free, for buy more\r\ncommercial products please visit :\r\n\r\n http:/" +
    "/sheypoorak.com\r\n @Sheypoorak\r\n\r\nOpen Library :\r\n  https://github.com/nimix3";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(626, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(48, 44);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 73;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.PeerFloodx);
            this.groupBox15.Controls.Add(this.Peer);
            this.groupBox15.Controls.Add(this.RISTRICTED);
            this.groupBox15.Controls.Add(this.RISTRICTED_LB);
            this.groupBox15.Controls.Add(this.FLOODx);
            this.groupBox15.Controls.Add(this.RELEASE);
            this.groupBox15.Controls.Add(this.FLOOD_LB);
            this.groupBox15.Controls.Add(this.BUTTON);
            this.groupBox15.Controls.Add(this.RELEASE_LB);
            this.groupBox15.Controls.Add(this.button21);
            this.groupBox15.Controls.Add(this.progressBar3);
            this.groupBox15.Controls.Add(this.panel333);
            this.groupBox15.Controls.Add(this.CHECK_LB);
            this.groupBox15.Controls.Add(this.CHECK);
            this.groupBox15.Location = new System.Drawing.Point(436, 56);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(238, 260);
            this.groupBox15.TabIndex = 72;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Check Status";
            this.groupBox15.Enter += new System.EventHandler(this.groupBox15_Enter);
            // 
            // PeerFloodx
            // 
            this.PeerFloodx.AutoSize = true;
            this.PeerFloodx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PeerFloodx.Location = new System.Drawing.Point(91, 65);
            this.PeerFloodx.Name = "PeerFloodx";
            this.PeerFloodx.Size = new System.Drawing.Size(15, 13);
            this.PeerFloodx.TabIndex = 79;
            this.PeerFloodx.Text = "--";
            // 
            // Peer
            // 
            this.Peer.AutoSize = true;
            this.Peer.ForeColor = System.Drawing.Color.Red;
            this.Peer.Location = new System.Drawing.Point(6, 65);
            this.Peer.Name = "Peer";
            this.Peer.Size = new System.Drawing.Size(79, 13);
            this.Peer.TabIndex = 78;
            this.Peer.Text = "PEER_FLOOD :";
            // 
            // RISTRICTED
            // 
            this.RISTRICTED.AutoSize = true;
            this.RISTRICTED.Location = new System.Drawing.Point(88, 82);
            this.RISTRICTED.Name = "RISTRICTED";
            this.RISTRICTED.Size = new System.Drawing.Size(15, 13);
            this.RISTRICTED.TabIndex = 77;
            this.RISTRICTED.Text = "--";
            // 
            // RISTRICTED_LB
            // 
            this.RISTRICTED_LB.AutoSize = true;
            this.RISTRICTED_LB.ForeColor = System.Drawing.Color.Red;
            this.RISTRICTED_LB.Location = new System.Drawing.Point(6, 82);
            this.RISTRICTED_LB.Name = "RISTRICTED_LB";
            this.RISTRICTED_LB.Size = new System.Drawing.Size(76, 13);
            this.RISTRICTED_LB.TabIndex = 76;
            this.RISTRICTED_LB.Text = "RESTRICTED :";
            this.RISTRICTED_LB.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FLOODx
            // 
            this.FLOODx.AutoSize = true;
            this.FLOODx.Location = new System.Drawing.Point(60, 49);
            this.FLOODx.Name = "FLOODx";
            this.FLOODx.Size = new System.Drawing.Size(15, 13);
            this.FLOODx.TabIndex = 75;
            this.FLOODx.Text = "--";
            this.FLOODx.Click += new System.EventHandler(this.label35_Click);
            // 
            // RELEASE
            // 
            this.RELEASE.AutoSize = true;
            this.RELEASE.Location = new System.Drawing.Point(91, 28);
            this.RELEASE.Name = "RELEASE";
            this.RELEASE.Size = new System.Drawing.Size(15, 13);
            this.RELEASE.TabIndex = 75;
            this.RELEASE.Text = "--";
            this.RELEASE.Click += new System.EventHandler(this.label32_Click);
            // 
            // FLOOD_LB
            // 
            this.FLOOD_LB.AutoSize = true;
            this.FLOOD_LB.ForeColor = System.Drawing.Color.Red;
            this.FLOOD_LB.Location = new System.Drawing.Point(6, 49);
            this.FLOOD_LB.Name = "FLOOD_LB";
            this.FLOOD_LB.Size = new System.Drawing.Size(48, 13);
            this.FLOOD_LB.TabIndex = 74;
            this.FLOOD_LB.Text = "FLOOD :";
            this.FLOOD_LB.Click += new System.EventHandler(this.label36_Click);
            // 
            // BUTTON
            // 
            this.BUTTON.ForeColor = System.Drawing.Color.Green;
            this.BUTTON.Location = new System.Drawing.Point(5, 217);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(163, 32);
            this.BUTTON.TabIndex = 19;
            this.BUTTON.Text = "CHECK ACCOUNT";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.button20_Click);
            // 
            // RELEASE_LB
            // 
            this.RELEASE_LB.AutoSize = true;
            this.RELEASE_LB.ForeColor = System.Drawing.Color.Green;
            this.RELEASE_LB.Location = new System.Drawing.Point(6, 28);
            this.RELEASE_LB.Name = "RELEASE_LB";
            this.RELEASE_LB.Size = new System.Drawing.Size(77, 13);
            this.RELEASE_LB.TabIndex = 74;
            this.RELEASE_LB.Text = "Release Time :";
            this.RELEASE_LB.Click += new System.EventHandler(this.label33_Click);
            // 
            // button21
            // 
            this.button21.ForeColor = System.Drawing.Color.Red;
            this.button21.Location = new System.Drawing.Point(173, 217);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 32);
            this.button21.TabIndex = 3;
            this.button21.Text = "STOP";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 167);
            this.progressBar3.Maximum = 99999;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(226, 17);
            this.progressBar3.TabIndex = 0;
            this.progressBar3.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // panel333
            // 
            this.panel333.Controls.Add(this.label40);
            this.panel333.Location = new System.Drawing.Point(6, 147);
            this.panel333.Name = "panel333";
            this.panel333.Size = new System.Drawing.Size(226, 20);
            this.panel333.TabIndex = 14;
            this.panel333.Paint += new System.Windows.Forms.PaintEventHandler(this.panel333_Paint);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Left;
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(19, 13);
            this.label40.TabIndex = 6;
            this.label40.Text = "...";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // CHECK_LB
            // 
            this.CHECK_LB.AutoSize = true;
            this.CHECK_LB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CHECK_LB.Location = new System.Drawing.Point(6, 111);
            this.CHECK_LB.Name = "CHECK_LB";
            this.CHECK_LB.Size = new System.Drawing.Size(43, 13);
            this.CHECK_LB.TabIndex = 4;
            this.CHECK_LB.Text = "Check :";
            this.CHECK_LB.Click += new System.EventHandler(this.label42_Click);
            // 
            // CHECK
            // 
            this.CHECK.AutoSize = true;
            this.CHECK.Location = new System.Drawing.Point(55, 111);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(15, 13);
            this.CHECK.TabIndex = 5;
            this.CHECK.Text = "--";
            this.CHECK.Click += new System.EventHandler(this.label43_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox16);
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Location = new System.Drawing.Point(5, 56);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(249, 260);
            this.groupBox12.TabIndex = 71;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Check Option";
            this.groupBox12.Enter += new System.EventHandler(this.groupBox12_Enter);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label3);
            this.groupBox16.Controls.Add(this.label2);
            this.groupBox16.Controls.Add(this.gpass);
            this.groupBox16.Controls.Add(this.gmail);
            this.groupBox16.Controls.Add(this.ReleaseAct);
            this.groupBox16.Controls.Add(this.NoSpamAct);
            this.groupBox16.Location = new System.Drawing.Point(7, 151);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(235, 103);
            this.groupBox16.TabIndex = 38;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Release Options :";
            this.groupBox16.Enter += new System.EventHandler(this.groupBox16_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "GMail :";
            // 
            // gpass
            // 
            this.gpass.Location = new System.Drawing.Point(73, 73);
            this.gpass.Name = "gpass";
            this.gpass.Size = new System.Drawing.Size(148, 21);
            this.gpass.TabIndex = 82;
            // 
            // gmail
            // 
            this.gmail.Location = new System.Drawing.Point(73, 44);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(148, 21);
            this.gmail.TabIndex = 81;
            // 
            // ReleaseAct
            // 
            this.ReleaseAct.AutoSize = true;
            this.ReleaseAct.Location = new System.Drawing.Point(10, 20);
            this.ReleaseAct.Name = "ReleaseAct";
            this.ReleaseAct.Size = new System.Drawing.Size(107, 17);
            this.ReleaseAct.TabIndex = 20;
            this.ReleaseAct.Text = "Request Release";
            this.ReleaseAct.UseVisualStyleBackColor = true;
            this.ReleaseAct.CheckedChanged += new System.EventHandler(this.Seen_CheckedChanged);
            // 
            // NoSpamAct
            // 
            this.NoSpamAct.AutoSize = true;
            this.NoSpamAct.Checked = true;
            this.NoSpamAct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoSpamAct.Location = new System.Drawing.Point(130, 20);
            this.NoSpamAct.Name = "NoSpamAct";
            this.NoSpamAct.Size = new System.Drawing.Size(99, 17);
            this.NoSpamAct.TabIndex = 19;
            this.NoSpamAct.Text = "No Spam Assist";
            this.NoSpamAct.UseVisualStyleBackColor = true;
            this.NoSpamAct.CheckedChanged += new System.EventHandler(this.Resolve_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Controls.Add(this.chk);
            this.groupBox13.Location = new System.Drawing.Point(5, 23);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(237, 55);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Check Settings";
            this.groupBox13.Enter += new System.EventHandler(this.groupBox13_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Double Check With :";
            // 
            // chk
            // 
            this.chk.Location = new System.Drawing.Point(112, 24);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(117, 21);
            this.chk.TabIndex = 37;
            this.chk.Text = "+79253146681";
            this.chk.TextChanged += new System.EventHandler(this.ChannelUser_TextChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.comboBox1);
            this.groupBox14.Location = new System.Drawing.Point(6, 82);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(236, 65);
            this.groupBox14.TabIndex = 10;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Your Account Number :";
            this.groupBox14.Enter += new System.EventHandler(this.groupBox14_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(247, 31);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(167, 13);
            this.label30.TabIndex = 66;
            this.label30.Text = "By Amin1SoftCo && NIMIX3";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("X-Files", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(55, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(206, 22);
            this.label31.TabIndex = 65;
            this.label31.Text = "Account Checker";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(270, 63);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(148, 129);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 70;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HoopoeTelegram1.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.59091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.40909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoopoe Telegram Account Manager V.2 (Free & OpenSource)    ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.panel333.ResumeLayout(false);
            this.panel333.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void load_accounts()
        {
            try
            {
                this.load_attemp++;
                this.regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HoopoeTelegram\Accounts");
                string[] files = Directory.GetFiles(path_Senders, "*.stat");
                this.Lines_Queue.Items.Clear();
                MyLogger.log("load attemp:" + this.load_attemp,"");
                for (int i = 0; i < files.Length; i++)
                {
                    int index = i;
                    try
                    {
                        string s = "";
                        string name = Class_Files_And_Folders.Extract_Only_FileName_WithoutExtension(files[index]);
                        if (this.load_attemp > 1)
                        {
                            bool flag = false;
                            for (int j = 0; j < this.channels; j++)
                            {
                                if ((this.api[j] != null) && (this.api[j].SenderPhoneNo == name))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag)
                            {
                                continue;
                            }
                        }
                        double result = 0.0;
                        try
                        {
                            s = this.regKey.GetValue(name, "").ToString();
                        }
                        catch (Exception exception)
                        {
                            MyLogger.log("Error Loading Accounts:" + exception.Message, "");
                        }
                        if (((s != "blocked") && (s != "contacts_list_full")) && ((s != "file_corrupted") && (s != "session_expired")))
                        {
                            double.TryParse(s, out result);
                            if (result < DateTime.Now.Ticks)
                            {
                                this.Lines_Queue.Items.Add(name);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception exception2)
            {
                MyLogger.log("Error Loading Accounts:" + exception2.Message, "");
                if (MessageBox.Show("Error Loading Accounts!", "Hoopoe Telegram", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                {
                    this.load_accounts();
                }
                else
                {
                    this.PauseJob();
                }
            }
        }

        public void load_default_setting()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HoopoeTelegram\Settings");
                try
                {
                    if (key.GetValue("defualt_send_type", "").ToString() == "")
                    {
                        key.SetValue("defualt_send_type", defualt_send_type);
                    }
                    else
                    {
                        defualt_send_type = key.GetValue("defualt_send_type", "").ToString();
                    }
                    if (defualt_send_type == "private")
                    {
                        
                    }
                    else if (defualt_send_type == "group")
                    {
                        
                    }
                    else if (defualt_send_type == "channel")
                    {
                        
                    }
                }
                catch
                {
                    key.SetValue("defualt_send_type", defualt_send_type);
                }
                try
                {
                    if ((key.GetValue("defualt_sending_country", "") ?? "").ToString() == "")
                    {
                        key.SetValue("defualt_sending_country", defualt_sending_country);
                    }
                }
                catch
                {
                    key.SetValue("defualt_sending_country", defualt_sending_country);
                }
                try
                {
                    if ((key.GetValue("defualt_account_country", "") ?? "").ToString() == "")
                    {
                        key.SetValue("defualt_account_country", defualt_account_country);
                    }
                }
                catch
                {
                    key.SetValue("defualt_account_country", defualt_account_country);
                }
                try
                {
                    if ((key.GetValue("defualt_Telegram_Name", "") ?? "").ToString() == "")
                    {
                        key.SetValue("defualt_Telegram_Name", defualt_Telegram_Name);
                    }
                    else
                    {
                        defualt_Telegram_Name = key.GetValue("defualt_Telegram_Name", "").ToString();
                    }
                    //this.TextBox_Name.Text = defualt_Telegram_Name;
                }
                catch
                {
                    key.SetValue("defualt_Telegram_Name", defualt_Telegram_Name);
                }
                try
                {
                    if ((key.GetValue("defualt_Telegram_Family", "") ?? "").ToString() == "")
                    {
                        key.SetValue("defualt_Telegram_Family", defualt_Telegram_Family);
                    }
                    else
                    {
                        defualt_Telegram_Family = key.GetValue("defualt_Telegram_Family", "").ToString();
                    }
                    //this.TextBox_Family.Text = defualt_Telegram_Family;
                }
                catch
                {
                    key.SetValue("defualt_Telegram_Family", defualt_Telegram_Family);
                }
                try
                {
                    if ((key.GetValue("show_number_and_time_inMessage", "") ?? "").ToString() == "")
                    {
                        key.SetValue("show_number_and_time_inMessage", show_number_and_time_inMessage.ToString().ToLower());
                    }
                }
                catch
                {
                    key.SetValue("show_number_and_time_inMessage", show_number_and_time_inMessage.ToString().ToLower());
                }
                try
                {
                    if (key.GetValue("channels", "").ToString() == "")
                    {
                        key.SetValue("channels", this.channels.ToString());
                    }
                }
                catch
                {
                    key.SetValue("channels", this.channels.ToString());
                }
                try
                {
                    if ((key.GetValue("max_groupMembers", "") ?? "").ToString() == "")
                    {
                        key.SetValue("max_groupMembers", max_groupMembers.ToString());
                    }
                    else
                    {
                        //this.numericUpDown1.Value = int.Parse(key.GetValue("max_groupMembers", "").ToString());
                    }
                }
                catch
                {
                    key.SetValue("max_groupMembers", max_groupMembers.ToString());
                }
                try
                {
                    if ((key.GetValue("max_sends", "") ?? "").ToString() == "")
                    {
                        key.SetValue("max_sends", max_sends);
                    }
                    else
                    {
                        //this.numericUpDown3.Value = int.Parse(key.GetValue("max_sends", "").ToString());
                    }
                }
                catch
                {
                    key.SetValue("max_sends", max_sends);
                }
                try
                {
                    if ((key.GetValue("delete_after_send", "") ?? "").ToString() == "")
                    {
                        key.SetValue("delete_after_send", delete_after_send.ToString().ToLower());
                    }
                }
                catch
                {
                    key.SetValue("delete_after_send", delete_after_send.ToString());
                }
                try
                {
                    if (int.Parse((key.GetValue("max_groupMembers", "") ?? "").ToString()) > 0x27)
                    {
                        key.SetValue("max_groupMembers", max_groupMembers.ToString());
                    }
                }
                catch
                {
                    key.SetValue("max_groupMembers", "20");
                }
                delete_after_send = (key.GetValue("delete_after_send", "") ?? "").ToString() == "true";
                defualt_sending_country = (key.GetValue("defualt_sending_country", "") ?? "").ToString();
                defualt_account_country = (key.GetValue("defualt_account_country", "") ?? "").ToString();
                defualt_Telegram_Name = (key.GetValue("defualt_Telegram_Name", "") ?? "").ToString();
                defualt_Telegram_Family = (key.GetValue("defualt_Telegram_Family", "") ?? "").ToString();
                show_number_and_time_inMessage = (key.GetValue("show_number_and_time_inMessage", "") ?? "").ToString() == "true";
                this.channels = int.Parse((key.GetValue("channels", "") ?? "").ToString());
                defualt_send_type = (key.GetValue("defualt_send_type", "") ?? "").ToString();
                max_sends = int.Parse((key.GetValue("max_sends", "") ?? "").ToString());
                max_groupMembers = int.Parse((key.GetValue("max_groupMembers", "") ?? "").ToString());
                try
                {
                    if ((key.GetValue("defualt_Telegram_Family", "") ?? "").ToString() != "")
                    {
                        key.DeleteValue("aniti_Bolck_Is_Activate");
                    }
                }
                catch
                {
                }
                key.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Load Settings Error: " + exception.Message);
                MessageBox.Show("Error Loading Setting, Please Exit The Program & Open it Again!");
            }
        }

        public void load_lines(string search_key)
        {
            base.Invoke((MethodInvoker)delegate () {
                int num = 0;
                int num2 = 0;
                int num3 = 0;
                try
                {
                    this.dataGridView1.Rows.Clear();
                    Create_Default_Folders();
                    string[] files = Directory.GetFiles(path_Senders);
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HoopoeTelegram\Accounts");
                    for (int j = 0; j < files.Length; j++)
                    {
                        string name = Class_Files_And_Folders.Extract_Only_FileName_WithoutExtension(files[j]);
                        if ((search_key == "") || (name.IndexOf(search_key) >= 0))
                        {
                            string cn = "";
                            try
                            {
                                cn = key.GetValue(name, "").ToString();
                            }
                            catch
                            {
                            }
                            if (this.check_status(cn))
                            {
                                string str3;
                                if (cn == "blocked")
                                {
                                    str3 = "Deactive";
                                    num2++;
                                }
                                else if (cn == "contacts_list_full")
                                {
                                    str3 = "Deactive - Suspended";
                                    num2++;
                                }
                                else if (cn == "session_expired")
                                {
                                    str3 = "Deactive - Session Failed";
                                    num2++;
                                }
                                else if (cn == "file_corrupted")
                                {
                                    str3 = "Deactive - File Failed";
                                    num2++;
                                }
                                else if (cn == "suspend")
                                {
                                    str3 = "Deactive - Suspended";
                                    num2++;
                                }
                                else if (cn == "")
                                {
                                    str3 = "Active";
                                    num++;
                                }
                                else if (cn.Length >= 0x12)
                                {
                                    if (long.Parse(cn) > DateTime.Now.Ticks)
                                    {
                                        num3++;
                                        DateTime time = new DateTime(long.Parse(cn));
                                        object[] objArray = new object[6];
                                        int index = 0;
                                        objArray[index] = "Suspended :  ";
                                        int num6 = 1;
                                        objArray[num6] = time.ToShortDateString();//Class_Date.Convert_Milady_To_Shamsi(time.ToString());
                                        int num7 = 2;
                                        objArray[num7] = " - ";
                                        int num8 = 3;
                                        objArray[num8] = time.Hour;
                                        int num9 = 4;
                                        objArray[num9] = ":";
                                        int num10 = 5;
                                        objArray[num10] = time.Minute;
                                        str3 = string.Concat(objArray);
                                    }
                                    else
                                    {
                                        this.regKey.DeleteValue(name);
                                        str3 = "Active";
                                        num++;
                                    }
                                }
                                else
                                {
                                    str3 = "Active";
                                }
                                object[] values = new object[5];
                                values[2] = name;
                                values[3] = str3;
                                values[4] = files[j];
                                values[0] = true;
                                values[1] = j + 1;
                                this.dataGridView1.Rows.Add(values);
                            }
                        }
                    }
                    this.label21.Text = num.ToString();
                    this.lbl_disabledLines.Text = num2.ToString();
                    this.lbl_suspendLines.Text = num3.ToString();
                    this.dataGridView1.EndEdit();
                    //this.checkBox1.Checked = false;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            });
        }

        private bool loginJob(int index)
        {
            ThreadStart start = null;
            ThreadStart start2 = null;
            bool flag2;
            int num = index;
            if (sendStatus.status != "pending_the_internet")
            {
                sendStatus.prv_status = sendStatus.status;
            }
            if (!checkInternetConnectivity())
            {
                if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
                {
                    sendStatus.status = "pending_the_internet";
                }
                this.refreshStatus();
                Thread.Sleep(0x1388);
                try
                {
                    if (this.api[num] != null)
                    {
                        this.api[num].destroy();
                    }
                }
                catch
                {
                }
                if (start == null)
                {
                    start = delegate {
                        this.loginJob(index);
                    };
                }
                new Thread(start).Start();
                return false;
            }
            sendStatus.status = sendStatus.prv_status;
            try
            {
                MyLogger.log("loginJob.. channel " + index.ToString(), "");
                this.refreshStatus();
                string phone = "";
                object obj2 = this.LockObject_Login;
                lock (obj2)
                {
                    if (this.task_stopped || (HoopoeTelegram.Queue.count() < 1))
                    {
                        if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
                        {
                            this.StopJob();
                        }
                        return false;
                    }
                    if (this.Lines_Queue.Items.Count < 1)
                    {
                        this.load_accounts();
                        MyLogger.log(string.Concat(new object[] { "index #", index, ", Reloaded.. Active Accounts: ", this.Lines_Queue.Items.Count }), "");
                        if (this.Lines_Queue.Items.Count < 1)
                        {
                            if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
                            {
                                sendStatus.status = "searching_active_account";
                            }
                            this.refreshStatus();
                            Thread.Sleep(0x1388);
                            if (this.api[num] != null)
                            {
                                this.api[num].destroy();
                            }
                            if (start2 == null)
                            {
                                start2 = delegate {
                                    this.loginJob(index);
                                };
                            }
                            new Thread(start2).Start();
                            return false;
                        }
                    }
                    phone = this.Lines_Queue.Items[0].ToString();
                    this.Lines_Queue.Items.RemoveAt(0);
                }
                if (this.api[num] != null)
                {
                    this.api[num].destroy();
                    this.api[num] = new telegramApi();
                }
                if (this.api[num].login(phone).ToLower().Contains("loaded"))
                {
                    int timeOut = 0x61a8;
                    if (!this.api[num].setStatus(false, 0x1388))
                    {
                        timeOut = 0x2710;
                    }
                    int num3 = this.api[num].countContacts(timeOut);
                    if (num3 == -1)
                    {
                        if (!this.api[num].setStatus(false, 0x1388) && checkInternetConnectivity())
                        {
                            this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "session_expired");
                        }
                        int api_index = index;
                        if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
                        {
                            sendStatus.status = "switching_account";
                        }
                        new Thread(delegate() {
                            this.loginJob(api_index);
                        }).Start();
                        return false;
                    }
                    if (num3 > 700)
                    {
                        this.api[num].clearContacts();
                        int api_index = index;
                        if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
                        {
                            sendStatus.status = "switching_account";
                        }
                        new Thread(delegate() {
                            this.loginJob(api_index);
                        }).Start();
                        return false;
                    }
                    if (num3 > 150)
                    {
                        this.api[num].clearContacts();
                    }
                    this.sendJob(index);
                    return true;
                }
                this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "file_corrupted");
                throw new Exception("Login failed!");
            }
            catch (Exception exception)
            {
                this.refreshStatus();
                this.api[num].logWithSenderNumber(((this.api[num] != null) ? ("#" + this.api[num].SenderPhoneNo + ": ") : "") + "LoginJob Error...... " + exception.Message);
                int api_index = index;
                if (this.api[num] != null)
                {
                    this.api[num].destroy();
                    this.api[num] = new telegramApi();
                }
                if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
                {
                    sendStatus.status = "switching_account";
                }
                new Thread(delegate() {
                    this.loginJob(api_index);
                }).Start();
                flag2 = false;
            }
            return flag2;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_Window_Control.close_all_process_advance("HoopoeTelegram");
            Environment.Exit(Environment.ExitCode);
        }

        static string ROT13(string input)
        {
            return !string.IsNullOrEmpty(input) ? new string(input.ToCharArray().Select(s => { return (char)((s >= 97 && s <= 122) ? ((s + 13 > 122) ? s - 13 : s + 13) : (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s)); }).ToArray()) : input;
        }

        private void Main_Load(object sender, EventArgs e)
        {
           try {
                System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
                privateFonts.AddFontFile(path_project+ "xfiles.ttf");
                System.Drawing.Font font = new Font(privateFonts.Families[0], 16);
                label22.Font = font;
                label31.Font = font;
            }
            catch { }
            try
            {
                string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!Directory.Exists(_Desktop + "\\HoopoeTelegram\\Accounts"))
                {
                    Directory.CreateDirectory(_Desktop + "\\HoopoeTelegram\\Accounts");
                }
                String[] files = Directory.GetFiles(_Desktop + "\\HoopoeTelegram\\Accounts");

                string RawDT = "";
                foreach (String file in files)
                {
                    if (file.Contains(".tga"))
                    {
                        RawDT = Encoding.Default.GetString(Convert.FromBase64String(ROT13(File.ReadAllText(file))));
                        File.WriteAllText(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts\\" + Path.GetFileName(file).ToString().Replace(".tga", ".stat").Replace("+", ""), RawDT, Encoding.Default);
                        //File.Copy(file, Class_Files_And_Folders.ProjectPath_WithSlash() + "Senders\\" + Path.GetFileName(file).ToString().Replace(".key", ".stat"), true);
                    }
                }
            }
            catch { }
            this.cmb_filter.SelectedIndex = 0;
                this.load_lines(this.txt_search.Text);
                int width = 0x18;
                int num2 = 0;
                int num3 = (100 / width) - 1;
                int y = 0;
                try
                {
                    string[] files = Directory.GetFiles(path_Emoji);
                    for (int i = 0; i < files.Length; i++)
                    {
                        string str = Class_Files_And_Folders.Extract_Only_FileName_WithoutExtension(files[i]);
                        PictureBox pictureBox1 = new PictureBox {
                            Cursor = Cursors.Hand,
                            Image = new Bitmap(files[i]),
                            Location = new Point(num2 * width, y),
                            Name = "pictureBox1" + i.ToString(),
                            Size = new Size(width, width),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            TabIndex = 1,
                            TabStop = false,
                            Tag = str
                        };
                        pictureBox1.Click += new EventHandler(this.pictureBox1_SelectEmoji);
                        //base.Invoke(new Action(() => this.panel_Icons.Controls.Add(pictureBox1)));
                        num2++;
                        if (num2 >= num3)
                        {
                            num2 = 0;
                            y += width;
                        }
                    }
                }
                catch (Exception exception)
                {
                    MyLogger.log("initial error1:" + exception.Message, "");
                }

            try
            {
                if (!Directory.Exists(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts"))
                {
                    Directory.CreateDirectory(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                }
                String[] files = Directory.GetFiles(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");

                comboBox1.Items.Clear();
                foreach (String file in files)
                {
                    if (file.Contains(".stat"))
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Path.GetFileNameWithoutExtension(file);
                        item.Value = Path.GetFileNameWithoutExtension(file);
                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        public static string Normal_PhoneNumber(string phoneNumber, string default_country_code)
        {
            Regex regex = new Regex(@"[^\d]");
            string input = regex.Replace(phoneNumber, "");
            string str2 = regex.Replace(default_country_code, "");
            if (phoneNumber.Trim().Length == 0)
            {
                return "";
            }
            try
            {
                string str3 = (!input.StartsWith("+") && !input.StartsWith(str2)) ? (!input.StartsWith("0098") ? (!input.StartsWith("0") ? ((input.Length != 10) ? input : (str2 + input)) : (str2 + input.Substring(1))) : input.Substring(2)) : input;
                return regex.Replace(str3, "");
            }
            catch
            {
                return regex.Replace(input, "");
            }
        }

        private void PauseJob()
        {
            base.Invoke((MethodInvoker)delegate {
                sendStatus.status = "pause";
                this.task_stopped = true;
                this.refreshStatus();
            });
        }

        private void pictureBox_Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Title = "Load From File",
                Filter = "Picture Files (*.jpg)|*.jpg|All files (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //this.pictureBox_Avatar.Image = new Bitmap(dialog.FileName);
                //this.pictureBox_Avatar.Image.Save(path_Setting + @"\Avatar.jpg", ImageFormat.Jpeg);
            }
        }

        private void pictureBox1_SelectEmoji(object sender, EventArgs e)
        {
            //this.textBox1.Text = this.textBox1.Text + Convert_Code_UTF16_ToEmoji((sender as Control).Tag.ToString());
            //this.panel_Icons.Visible = false;
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T) formatter.Deserialize(stream);
            }
        }

        private void refreshStatus()
        {
            MethodInvoker method = null;
            MethodInvoker invoker2 = null;
            try
            {
                if (((sendStatus.status == "searching_active_account") || (sendStatus.status == "initialize")) || (sendStatus.status == "pending_the_internet"))
                {
                    if (method == null)
                    {
                        //method = () => this.pictureBox_loader.Visible = true;
                    }
                    base.Invoke(method);
                }
                else
                {
                    if (invoker2 == null)
                    {
                        //invoker2 = () => this.pictureBox_loader.Visible = false;
                    }
                    base.Invoke(invoker2);
                }
                string current_status = "";
                if (this.task_stopped)
                {
                    sendStatus.status = "stop";
                }
                string s = sendStatus.status;
                if (s == "pending_the_internet")
                {
                    current_status = "Waiting For Internet Connection...";
                }
                else if (s == "pause")
                {
                    current_status = "Pause";
                }
                else if (s == "sending")
                {
                    current_status = "Sending Messages...";
                }
                if (s == "stop")
                {
                    current_status = "Ready";
                }
                else if (s == "switching_account")
                {
                    current_status = "Switching Account...";
                }
                if (s == "searching_active_account")
                {
                    current_status = "Finding Active Accounts to Deploy...";
                }
                else if (s == "initialize")
                {
                    current_status = "Getting Ready...";
                }
                base.Invoke((MethodInvoker)delegate {
                    if (s == "stop")
                    {
                    }
                    if (!this.task_stopped)
                    {
                        try
                        {
                            this.progressBar3.Value = (sendStatus.duplicate + sendStatus.sent) + sendStatus.sendError;
                        }
                        catch
                        {
                            this.progressBar3.Value = this.progressBar3.Maximum;
                        }
                    }
                    if (sendStatus.sent > 1)
                    {
                        //this.pictureBox_loader.Visible = false;
                        if (sendStatus.status != "stop")
                        {
                            sendStatus.status = "sending";
                        }
                    }
                });
            }
            catch (Exception exception)
            {
                MyLogger.log("Refresh Error " + exception.Message, "");
            }
        }


        private bool sendJob(int index)
        {
            int num = index;
            this.api[num].logWithSenderNumber("sendJob...");
            bool flag = false;
            bool flag2 = false;
            string[] source = new string[0];
            string phoneNo = "";
            int lines = max_sends;
            if ((defualt_send_type == "group") || (defualt_send_type == "channel"))
            {
                lines = max_groupMembers;
            }
            try
            {
                this.running_tasks++;
                this.api[num].sended_messages = 0;
                int num3 = 0;
                while (!this.api[num].flood_wait && !this.api[num].peer_flood)
                {
                    object obj2 = this.LockObject_Send;
                    lock (obj2)
                    {
                        try
                        {
                            this.api[num].logWithSenderNumber("add cycle " + (num3 + 1));
                            int num5 = 0;
                            try
                            {
                                num5 = this.api[num].extractedIds.size();
                            }
                            catch (Exception exception)
                            {
                                this.api[num].logWithSenderNumber("get extracted size error:" + exception.Message);
                            }
                            if (this.task_stopped)
                            {
                                if (num5 > 0)
                                {
                                    HoopoeTelegram.Queue.write(this.api[num].getExtractedNumbers());
                                    goto Label_0120;
                                }
                                goto Label_111E;
                            }
                            if ((HoopoeTelegram.Queue.count() < 1) && (num5 == 0))
                            {
                                goto Label_111E;
                            }
                        Label_0120:
                            source = HoopoeTelegram.Queue.read(lines);
                            this.api[num].logWithSenderNumber(source.Count<string>() + " number fetched");
                        }
                        catch (Exception exception2)
                        {
                            throw new Exception("Fetch Error! " + exception2.Message);
                        }
                    }
                    flag = false;
                    flag2 = false;
                    int num6 = 0;
                    string str2 = this.api[num].extractMembersWithId(source, num3, true, 1);
                    if (!str2.Equals("imported"))
                    {
                        HoopoeTelegram.Queue.write(source);
                        if (str2.Equals("contacts_list_full"))
                        {
                            this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "contacts_list_full");
                            HoopoeTelegram.Queue.write(this.api[num].getExtractedNumbers());
                            return this.switchAccount(num);
                        }
                        if (str2.Contains("phones include null"))
                        {
                            HoopoeTelegram.Queue.write(this.api[num].getExtractedNumbers());
                            return this.switchAccount(num);
                        }
                        if (this.api[num].extractedNumbers.size() == 0)
                        {
                            return this.switchAccount(num);
                        }
                    }
                    else
                    {
                        string str3 = "";
                        for (int i = 0; i < source.Count<string>(); i++)
                        {
                            int num8 = i;
                            if (!this.api[num].extractedNumbers.contains(source[num8]))
                            {
                                string str4 = source[num8];
                                if (str4.StartsWith("98"))
                                {
                                    str4 = "0" + str4.Substring(2);
                                }
                                if (str4.StartsWith("+98"))
                                {
                                    str4 = "0" + str4.Substring(3);
                                }
                                str3 = str3 + str4 + "\r\n";
                                num6++;
                                sendStatus.isNotMember++;
                                sendStatus.sent++;
                                this.refreshStatus();
                            }
                        }
                        if (str3 != "")
                        {
                            this.writeNotMemberReport(str3);
                            flag = true;
                        }
                    }
                    if ((((this.api[num].extractedIds.size() < lines) && (HoopoeTelegram.Queue.count() > 0)) && (num3 < 10)) || (this.api[num].extractedIds.size() == 0))
                    {
                        num3++;
                    }
                    else
                    {
                        if (this.api[num].extractedNumbers.size() > lines)
                        {
                            this.api[num].logWithSenderNumber("remove extra 1");
                            string str5 = "";
                            for (int j = this.api[num].extractedNumbers.size() - 1; j >= lines; j--)
                            {
                                int num10 = j;
                                str5 = str5 + this.api[num].extractedNumbers.get(num10) + "\n";
                                this.api[num].extractedNumbers.remove(j);
                                this.api[num].extractedIds.remove(j);
                            }
                            HoopoeTelegram.Queue.writeText(str5);
                            this.api[num].logWithSenderNumber("remove extra 2");
                        }
                        this.api[num].logWithSenderNumber("Placement 1");
                        this.api[num].extractedIds.size();
                        this.api[num].logWithSenderNumber("Placement 2");
                        this.api[num].extractedNumbers.size();
                        this.api[num].logWithSenderNumber("Placement 3");
                        string[] strArray2 = this.api[num].getExtractedNumbers();
                        this.api[num].logWithSenderNumber("Placement 4");
                        int[] numArray = this.api[num].getExtractedIds();
                        int num11 = 0;
                        phoneNo = "";
                        flag2 = false;
                        this.api[num].peer_flood = false;
                        this.api[num].flood_wait = false;
                        this.api[num].flood_time = 0;
                        this.api[num].logWithSenderNumber("Extracted Members: " + ((IEnumerable<string>) strArray2).Count<string>());
                        if (defualt_send_type == "channel")
                        {
                            this.api[num].logWithSenderNumber("channel trace 1");

                            //bool flag4 = this.api[num].createChannel(defualt_Telegram_Name.Replace("%%",new Random().Next(10000, 99999).ToString()) + " " + defualt_Telegram_Family.Replace("%%",new Random().Next(10000, 99999).ToString()), textBoxAbout.Text.Replace("%%",new Random().Next(10000, 99999).ToString()));
                            this.api[num].logWithSenderNumber("channel trace 2");
                            /*if (!flag4)
                            {
                                this.api[num].logWithSenderNumber("channel_else_block3");
                                if ((this.api[num].sended_messages == 0) && checkInternetConnectivity())
                                {
                                    this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                                }
                                else
                                {
                                    this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), DateTime.Now.AddSeconds(86460.0).Ticks.ToString());
                                }
                                HoopoeTelegram.Queue.write(strArray2);
                                return this.switchAccount(num);
                            }*/
                            this.api[num].logWithSenderNumber("channel trace 3");
                            string[] strArray3 = null;
                            try
                            {
                                this.api[num].InviteCurrentMembersToChannel();
                                strArray3[0] = "ok";
                            }
                            catch { strArray3[0] = "error"; }
                            this.api[num].logWithSenderNumber("channel trace 4");
                            if ((strArray3.Length == 0) || strArray3[0].Contains("error"))
                            {
                                this.api[num].logWithSenderNumber("channel_else_block2");
                                if ((this.api[num].sended_messages == 0) && checkInternetConnectivity())
                                {
                                    this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                                }
                                else
                                {
                                    this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), DateTime.Now.AddSeconds(86460.0).Ticks.ToString());
                                }
                                HoopoeTelegram.Queue.write(strArray2);
                                return this.switchAccount(num);
                            }
                            this.api[num].logWithSenderNumber("channel trace 5");
                            try
                            {
                                if (File.Exists(path_Setting + @"\Avatar.jpg"))
                                {
                                    string avatar = this.api[num].uploadProfilePic(path_Setting + @"\Avatar.jpg");
                                    this.api[num].changeChannelPhoto(avatar);
                                }
                            }
                            catch (Exception exception3)
                            {
                                this.api[num].logWithSenderNumber("Change Chat Photo error.. " + exception3.Message);
                            }
                            this.api[num].logWithSenderNumber("channel trace 6");
                            if (!this.sendMessages(0, "", index, "channel"))
                            {
                                this.api[num].logWithSenderNumber("channel_else_block1");
                                if ((this.api[num].sended_messages == 0) && checkInternetConnectivity())
                                {
                                    this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                                }
                                else
                                {
                                    this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), DateTime.Now.AddSeconds(86460.0).Ticks.ToString());
                                }
                                HoopoeTelegram.Queue.write(strArray2);
                                return this.switchAccount(num);
                            }
                            this.api[num].logWithSenderNumber("channel send 7");
                            string str7 = "";
                            for (int k = 0; k < ((IEnumerable<string>) strArray2).Count<string>(); k++)
                            {
                                int num13 = k;
                                if (((IEnumerable<string>) strArray3).Contains<string>(numArray[num13].ToString()))
                                {
                                    telegramApi api1 = this.api[num];
                                    api1.sended_messages++;
                                    string str8 = strArray2[num13].ToString();
                                    if (str8.StartsWith("98"))
                                    {
                                        str8 = "0" + str8.Substring(2);
                                    }
                                    if (str8.StartsWith("+98"))
                                    {
                                        str8 = "0" + str8.Substring(3);
                                    }
                                    sendStatus.isMember++;
                                    sendStatus.sent++;
                                    num11++;
                                    phoneNo = phoneNo + str8 + "\r\n";
                                    this.refreshStatus();
                                }
                                else
                                {
                                    this.api[num].flood_wait = true;
                                    this.api[num].flood_time = 0x15180;
                                    num11++;
                                    str7 = str7 + strArray2[num13] + "\n";
                                }
                            }
                            telegramApi api = this.api[num];
                            string str9 = str7;
                            string[] separator = new string[2];
                            int num14 = 0;
                            separator[num14] = "\r\n";
                            int num15 = 1;
                            separator[num15] = "\n";
                            int num16 = 0;
                            string message = str9.Split(separator, (StringSplitOptions) num16).Count<string>() + " Recovered.";
                            api.logWithSenderNumber(message);
                            HoopoeTelegram.Queue.writeText(str7);
                            this.api[num].logWithSenderNumber("channel trace 8");
                            if (phoneNo != "")
                            {
                                this.writeSentReport(phoneNo);
                                flag2 = true;
                            }
                            this.api[num].logWithSenderNumber("channel trace 9");
                            this.api[num].flood_time = 0x15180;
                            this.api[num].flood_wait = true;
                        }
                        else if (defualt_send_type == "group")
                        {
                            string[] strArray5 = this.api[num].createChatWithCurrentMembers(defualt_Telegram_Name.Replace("%%",new Random().Next(10000, 99999).ToString()) + " " + defualt_Telegram_Family.Replace("%%",new Random().Next(10000, 99999).ToString()));
                            if (strArray5[0].Equals("error"))
                            {
                                if (strArray5[1].ToLower().Contains("users_too_few"))
                                {
                                    if (this.api[num].sended_messages == 0)
                                    {
                                        this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                                    }
                                    else
                                    {
                                        this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), DateTime.Now.AddSeconds(86460.0).Ticks.ToString());
                                    }
                                }
                                HoopoeTelegram.Queue.write(strArray2);
                                return this.switchAccount(num);
                            }
                            Console.WriteLine("group size:" + strArray5.Count<string>());
                            try
                            {
                                if (File.Exists(path_Setting + @"\Avatar.jpg"))
                                {
                                    string str13 = this.api[num].uploadProfilePic(path_Setting + @"\Avatar.jpg");
                                    this.api[num].changeChatPhoto(str13);
                                }
                            }
                            catch
                            {
                                this.api[num].logWithSenderNumber("Change Chat Photo error..");
                            }
                            if (!this.sendMessages(0, "", index, "group"))
                            {
                                if (this.api[num].flood_wait)
                                {
                                    if (this.api[num].sended_messages == 0)
                                    {
                                        this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                                    }
                                    else
                                    {
                                        this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), DateTime.Now.AddSeconds((double) (this.api[num].flood_time + 60)).Ticks.ToString());
                                    }
                                }
                                HoopoeTelegram.Queue.write(strArray2);
                                return this.switchAccount(num);
                            }
                            string str14 = "";
                            for (int m = 0; m < ((IEnumerable<string>) strArray2).Count<string>(); m++)
                            {
                                int num18 = m;
                                if (((IEnumerable<string>) strArray5).Contains<string>(numArray[num18].ToString()))
                                {
                                    telegramApi api3 = this.api[num];
                                    api3.sended_messages++;
                                    string str15 = strArray2[num18].ToString();
                                    if (str15.StartsWith("98"))
                                    {
                                        str15 = "0" + str15.Substring(2);
                                    }
                                    if (str15.StartsWith("+98"))
                                    {
                                        str15 = "0" + str15.Substring(3);
                                    }
                                    sendStatus.isMember++;
                                    sendStatus.sent++;
                                    phoneNo = phoneNo + str15 + "\r\n";
                                    this.refreshStatus();
                                }
                                else
                                {
                                    this.api[num].flood_wait = true;
                                    this.api[num].flood_time = 0x15180;
                                    str14 = str14 + strArray2[num18].ToString();
                                }
                            }
                            HoopoeTelegram.Queue.writeText(str14);
                            if (phoneNo != "")
                            {
                                this.writeSentReport(phoneNo);
                                flag2 = true;
                            }
                            if (this.api[num].sended_messages >= max_groupMembers)
                            {
                                this.api[num].flood_time = 0x15180;
                                this.api[num].flood_wait = true;
                            }
                        }
                        else
                        {
                            int count = -1;
                            for (int n = 0; n < numArray.Count<int>(); n++)
                            {
                                Console.WriteLine("private trace1");
                                if (this.task_stopped)
                                {
                                    this.running_tasks--;
                                    this.api[num] = null;
                                    return false;
                                }
                                this.sendMessages(numArray[n], strArray2[n].ToString(), index, "private");
                                Console.WriteLine("trace2");
                                this.api[num].logWithSenderNumber("private trace 2");
                                if ((this.api[num].flood_wait || this.api[num].peer_flood) || (this.api[num].sended_messages >= max_sends))
                                {
                                    if ((this.api[num].sended_messages >= max_sends) || this.api[num].peer_flood)
                                    {
                                        this.api[num].flood_wait = true;
                                        this.api[num].flood_time = 0x15180;
                                    }
                                    telegramApi api2 = this.api[num];
                                    string str16 = string.Concat(new object[] { "Flood_Time: ", this.api[num].flood_time, ", Sended_Messages: ", this.api[num].sended_messages });
                                    api2.logWithSenderNumber(str16);
                                    if (this.api[num].sended_messages == 0)
                                    {
                                        this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                                    }
                                    else
                                    {
                                        RegistryKey regKey = this.regKey;
                                        string name = this.api[num].SenderPhoneNo.ToString();
                                        regKey.SetValue(name, DateTime.Now.AddSeconds((double) (this.api[num].flood_time + 60)).Ticks.ToString());
                                    }
                                }
                                if (this.api[num].sent_result.ToLower().Contains("sent") || (this.api[num].sended_files > 0))
                                {
                                    count = n;
                                    string str18 = strArray2[n].ToString();
                                    if (str18.StartsWith("98"))
                                    {
                                        str18 = "0" + str18.Substring(2);
                                    }
                                    if (str18.StartsWith("+98"))
                                    {
                                        str18 = "0" + str18.Substring(3);
                                    }
                                    sendStatus.isMember++;
                                    sendStatus.sent++;
                                    phoneNo = phoneNo + str18 + "\r\n";
                                    this.refreshStatus();
                                }
                                if ((!this.api[num].sent_result.ToLower().Contains("sent") || (this.api[num].sended_files <= 0)) || this.api[num].flood_wait)
                                {
                                    if (phoneNo != "")
                                    {
                                        this.writeSentReport(phoneNo);
                                    }
                                    return this.switchAccount(num);
                                }
                                HoopoeTelegram.Queue.write(strArray2.Skip<string>(count).ToArray<string>());
                            }
                            if (phoneNo != "")
                            {
                                this.writeSentReport(phoneNo);
                            }
                            flag2 = true;
                        }
                    }
                    if ((HoopoeTelegram.Queue.count() > 0) && !this.task_stopped)
                    {
                        continue;
                    }
                Label_111E:
                    this.api[num] = null;
                    this.running_tasks--;
                    object obj3 = this.LockObject_Send;
                    lock (obj3)
                    {
                        if ((!this.task_stopped && (HoopoeTelegram.Queue.count() <= 0)) && ((this.running_tasks <= 0) && (sendStatus.status != "pause")))
                        {
                            this.StopJob();
                        }
                    }
                    return true;
                }
                this.api[num].logWithSenderNumber("FL_IF");
                if (this.api[num].peer_flood)
                {
                    this.api[num].flood_time = 0x15180;
                }
                if (this.api[num].flood_time > 0)
                {
                    if (this.api[num].sended_messages == 0)
                    {
                        this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                        this.api[num].logWithSenderNumber("No message sent... line blocked.");
                    }
                    else
                    {
                        DateTime time = DateTime.Now.AddSeconds((double) (this.api[num].flood_time + 60));
                        this.api[num].logWithSenderNumber("Line suspended for " + (this.api[num].flood_time + 60) + " second");
                        RegistryKey key2 = this.regKey;
                        string str19 = this.api[num].SenderPhoneNo.ToString();
                        string str20 = time.Ticks.ToString();
                        key2.SetValue(str19, str20);
                    }
                }
                return this.switchAccount(num);
            }
            catch (Exception exception4)
            {
                try
                {
                    if ((phoneNo != "") && !flag2)
                    {
                        this.writeSentReport(phoneNo);
                        flag2 = true;
                    }
                    if (!flag)
                    {
                    }
                    if ((this.api[num].flood_wait || this.api[num].peer_flood) || (this.api[num].sended_messages > 0))
                    {
                        if (this.api[num].peer_flood || (this.api[num].sended_messages > 0))
                        {
                            this.api[num].flood_time = 0x15180;
                        }
                        if (this.api[num].flood_time > 0)
                        {
                            if (this.api[num].sended_messages == 0)
                            {
                                this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), "blocked");
                            }
                            else
                            {
                                DateTime time2 = DateTime.Now.AddSeconds((double) (this.api[num].flood_time + 60));
                                this.regKey.SetValue(this.api[num].SenderPhoneNo.ToString(), time2.Ticks.ToString());
                            }
                        }
                        return this.switchAccount(num);
                    }
                }
                catch (Exception exception5)
                {
                    this.api[num].logWithSenderNumber("recover error: " + exception5.Message);
                }
                this.api[num].logWithSenderNumber("trace send exception," + exception4.Message);
                return this.switchAccount(num);
            }
        }

        public bool sendMessages(int rec_id, string recevier_number, int api_index, string chat_type)
        {
            this.api[api_index].sended_files = 0;
            this.api[api_index].sent_result = "";
            this.api[api_index].logWithSenderNumber("sending 1");
            try
            {
                if (this.msg != "")
                {
                    string msg = this.msg;
                    if (show_number_and_time_inMessage)
                    {
                        //msg = msg + "\r\n" + recevier_number.ToString();
                        msg = msg.Replace("%CODE%", new Random().Next(100000000, 999999999).ToString());
                        msg = msg.Replace("%TIME%", DateTime.Now.ToShortTimeString());
                        msg = msg.Replace("%DATE%", DateTime.Now.Date.ToShortDateString());
                        msg = msg.Replace("%JDATE%", Class_Date.Convert_Milady_To_Shamsi(DateTime.Now.Date.ToShortDateString()));
                        msg = msg.Replace("%HDATE%", Class_Date.Convert_Milady_To_Hijry(DateTime.Now.Date.ToShortDateString()));
                        msg = msg.Replace("%NUMBER%", recevier_number.ToString());
                    }
                    if (AntiBlk)
                    {
                        var regex = new Regex(Regex.Escape(" "));
                        msg = regex.Replace(msg, "  ", new Random().Next(1, 5));
                        regex = new Regex(Regex.Escape(Environment.NewLine));
                        msg = regex.Replace(msg, "." + Environment.NewLine + Environment.NewLine, new Random().Next(1, 3));
                    }

                    this.api[api_index].sent_result = this.api[api_index].sendMessageByUid(rec_id, msg, chat_type,false);
                }
                if (this.api[api_index].sent_result.ToLower().Contains("flood_wait") || this.api[api_index].sent_result.ToLower().Contains("peer_flood"))
                {
                    this.api[api_index].flood_wait = true;
                    this.api[api_index].flood_time = !this.api[api_index].sent_result.ToLower().Contains("peer_flood") ? int.Parse(this.api[api_index].sent_result.ToLower().Replace("flood_wait_", "").Replace("err:", "").Trim()) : 0x15180;
                    return false;
                }
                if (this.api[api_index].sent_result.ToLower().Contains("sent"))
                {
                    telegramApi api1 = this.api[api_index];
                    api1.sended_messages++;
                }
            }
            catch (Exception exception)
            {
                this.api[api_index].logWithSenderNumber("text sending error.." + exception.Message);
            }
            this.api[api_index].sended_files = 0;
            try
            {
                int index = 0;
                if (((this.imgsrc != null) && (this.imgsrc != "")) && (!this.api[api_index].flood_wait && File.Exists(this.imgsrc)))
                {
                    if (this.api[api_index].files[index].Equals(""))
                    {
                        this.api[api_index].uploadFile(this.imgsrc, index, this.imgcap);
                    }
                    string str2 = this.api[api_index].sendFileByUid(rec_id, this.api[api_index].files[index], chat_type,false).ToLower();
                    if (str2.ToLower().Contains("file sent"))
                    {
                        telegramApi api2 = this.api[api_index];
                        api2.sended_files++;
                        telegramApi api3 = this.api[api_index];
                        api3.sended_messages++;
                    }
                    else if (str2.ToLower().Contains("flood_wait") || str2.ToLower().Contains("peer_flood"))
                    {
                        this.api[api_index].flood_wait = true;
                        this.api[api_index].flood_time = !str2.ToLower().Contains("peer_flood") ? int.Parse(str2.ToLower().Replace("flood_wait_", "").Replace("err:", "").Trim()) : 0x15180;
                        return false;
                    }
                }
            }
            catch (Exception exception2)
            {
                this.api[api_index].logWithSenderNumber("file sending error.." + exception2.Message);
            }
            try
            {
                if (((this.videosrc != null) && (this.videosrc != "")) && (!this.api[api_index].flood_wait && File.Exists(this.videosrc.ToString())))
                {
                    if (this.api[api_index].files[5].Equals(""))
                    {
                        this.api[api_index].uploadFile(this.videosrc, 5);
                    }
                    string str3 = this.api[api_index].sendFileByUid(rec_id, this.api[api_index].files[5], chat_type,false).ToLower();
                    if (str3.ToLower().Contains("file sent"))
                    {
                        telegramApi api4 = this.api[api_index];
                        api4.sended_files++;
                        telegramApi api5 = this.api[api_index];
                        api5.sended_messages++;
                    }
                    else if (str3.ToLower().Contains("flood_wait") || str3.ToLower().Contains("peer_flood"))
                    {
                        this.api[api_index].flood_wait = true;
                        this.api[api_index].flood_time = !str3.ToLower().Contains("peer_flood") ? int.Parse(str3.ToLower().Replace("flood_wait_", "").Replace("err:", "").Trim()) : 0x15180;
                        return false;
                    }
                }
            }
            catch (Exception exception3)
            {
                this.api[api_index].logWithSenderNumber("media sending error.." + exception3.Message);
            }
            return true;
        }

        public void setReady(string status)
        {
            base.Invoke((MethodInvoker)delegate {
                sendStatus.status = "stop";
            });
        }

        private void StopJob()
        {
            base.Invoke((MethodInvoker)delegate {
                sendStatus.status = "stop";
                this.task_stopped = true;
                this.progressBar3.Value = 0;
                this.refreshStatus();
                MessageBox.Show("Sending Operations Done Successfully", "Hoopoe Telegram", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            });
        }

        private bool switchAccount(int index)
        {
            this.running_tasks--;
            MyLogger.log("channel " + index + ": switching account...", "");
            if (this.api[index] != null)
            {
                this.api[index].destroy();
                this.api[index] = new telegramApi();
            }
            int api_index = index;
            if ((sendStatus.status != "stop") && (sendStatus.status != "pause"))
            {
                sendStatus.status = "switching_account";
            }
            new Thread(delegate() {
                this.loginJob(api_index);
            }).Start();
            return true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.panel_Icons.Visible = false;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            this.load_lines(this.txt_search.Text);
        }

        private void Checking()
        {
            MethodInvoker method = null;
            int index = 0;
            string numb = "N/A";
            string strFlood = "N/A";
            string strPeerFlood = "N/A";
            string strRistrict = "N/A";
            string strSpam = "N/A";
            int floodwait = 0;
            if (!this.busy)
            {
                this.busy = true;
                base.Invoke((MethodInvoker)delegate
                {
                    this.pictureBox13.Visible = true;
                });

                MethodInvoker invoker = null;
                base.Invoke((MethodInvoker)delegate { this.label40.Text = "Start checking account, Getting ready..."; });
                
                try
                    {
                    if (this.joinStop)
                    {
                        goto Label_02A4;
                    }
                    try
                        {
                            if (this.apii != null)
                            {
                                this.apii.destroy();
                            }
                        }
                        catch
                        {
                        }
                        string phone = "";
                        base.Invoke((MethodInvoker)delegate { phone = this.comboBox1.Text; });
                        numb = phone;
                        if (phone != "" && phone != null)
                        {
                            string str2 = this.apii.login(phone);
                            if (str2.ToLower() == "loaded")
                            {
                                try {
                                    base.Invoke((MethodInvoker)delegate { this.label40.Text = "Account loaded successfully"; });
                                    string Rez = "N/A";

                                    if (chk.Text == "")
                                        Rez = this.apii.sendMessageToPhone("+79253146681", "Hi \n Test " + RandomString(26));
                                    else
                                    {
                                        this.apii.sendMessageToPhone("+79253146681", "Hi \n Test " + RandomString(26));
                                        Rez = this.apii.sendMessageToPhone(chk.Text, "Hi \n Test " + RandomString(26));
                                    }
                                        

                                    if (Rez.ToLower().Contains("sent"))
                                    {
                                        strSpam = "NO";
                                        base.Invoke((MethodInvoker)delegate { this.label40.Text = "Sending check message was successfull..."; });
                                    }
                                    else
                                    {
                                        strSpam = "YES";
                                        base.Invoke((MethodInvoker)delegate { this.label40.Text = "Sending check message was fail..."; });
                                    }


                                    base.Invoke((MethodInvoker)delegate { this.label40.Text = "Checking..."; });
                                    if (this.apii.flood_wait)
                                    {
                                        base.Invoke((MethodInvoker)delegate { this.FLOODx.Text = "YES"; this.RELEASE.Text = this.apii.flood_time.ToString(); });
                                        strFlood = "YES";
                                    }
                                    else
                                    {
                                        strFlood = "NO";
                                    }

                                    if (this.apii.peer_flood)
                                    {
                                        //base.Invoke((MethodInvoker)delegate { this.PeerFloodx.Text = "YES"; this.RELEASE.Text = this.apii.flood_time.ToString(); });
                                        strPeerFlood = "YES";
                                    }
                                    else
                                    {
                                        strPeerFlood = "NO";
                                    }


                                if (this.apii.createChannel("TestChannel " + RandomString(3), RandomString(15)) != null)
                                {
                                    //base.Invoke((MethodInvoker)delegate { this.RISTRICTED.Text = "NO"; });
                                    strRistrict = "NO";
                                }
                                else
                                {
                                    //base.Invoke((MethodInvoker)delegate { this.RISTRICTED.Text = "YES"; });
                                    strRistrict = "YES";
                                }

                                string logdata = File.ReadAllText(Class_Files_And_Folders.ProjectPath_WithSlash() + "debug.log");

                                if(strRistrict == "YES" && logdata.Contains("USER_RESTRICTED"))
                                {
                                    strRistrict = "YES";
                                }
                                else if(strRistrict == "YES")
                                {
                                    strRistrict = "NO";
                                }
                                else
                                {
                                    strRistrict = "NO";
                                }

                                if(strPeerFlood == "YES" || logdata.Contains("PEER_FLOOD"))
                                {
                                    strPeerFlood = "YES";
                                }else
                                { strPeerFlood = "NO"; }

                                if (strFlood == "YES" || logdata.Contains("FLOOD_WAIT"))
                                {
                                    strFlood = "YES";
                                }
                                else
                                { strFlood = "NO"; }

                                try
                                {
                                    Regex regex = new Regex(@"FLOOD_WAIT_(.+?)$");
                                    Match match = regex.Match(logdata);
                                    if (match.Success)
                                    {
                                        floodwait = Int32.Parse(match.Groups[1].Value);
                                    }
                                }
                                catch { floodwait = this.apii.flood_time; }


                                if (ReleaseAct.Checked && (strFlood == "YES" || strPeerFlood == "YES"))
                                    {
                                    base.Invoke((MethodInvoker)delegate { this.label40.Text = "Try to release account..."; });
                                    SendEmailRelease("+"+phone);
                                    }

                                    goto Label_02A4;
                                    }
                                catch
                                    {
                                    base.Invoke((MethodInvoker)delegate { this.label40.Text = "Checking failed with error!"; });
                                    goto Label_02A4;
                                    }
                           }
                           else
                           {
                            base.Invoke((MethodInvoker)delegate { this.label40.Text = "Account loading failed!"; });
                            if (invoker == null)
                            {
                                invoker = () => this.dataGridView1.Rows[index].Cells["selected"].Value = false;
                            }
                            base.Invoke(invoker);
                           }
                        }
                        else
                        {
                            MessageBox.Show("Cannot find your number in account list, please add your number first!");
                            goto Label_02A4;
                        }


                        Label_02A4:
                        if (method == null)
                        {
                            method += () => this.pictureBox13.Visible = true;
                            if(strSpam == "YES" && floodwait <= 0 && strRistrict == "YES")
                            method += () => this.RELEASE.Text = "9999999999999999";
                            else
                            method += () => this.RELEASE.Text = (floodwait/ 3600).ToString()+" Hours";
                            method += () => this.PeerFloodx.Text = strPeerFlood;
                            method += () => this.FLOODx.Text = strFlood;
                            method += () => this.RISTRICTED.Text = strRistrict;
                            method += () => this.CHECK.Text = "+"+numb;
                        }
                        base.Invoke(method);
                    }
                    catch (Exception exception3)
                    {
                        base.Invoke((MethodInvoker)delegate { this.label40.Text = "Unknown error occured..."; });
                        Console.WriteLine("TL: " + exception3.Message);
                    }
                this.busy = false;
                this.load_lines(this.txt_search.Text);
                base.Invoke((MethodInvoker) delegate { this.pictureBox13.Visible = false;
                    this.label40.Text = "...";
                });

                this.xFileTime = string.Format("{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
                path_save_report = path_main_save_report + @"\" + xFileTime;
                var repmsg = "Number Checked : " + numb + Environment.NewLine + "Flood : " + strFlood + Environment.NewLine + "Peer Flood : " + strPeerFlood + Environment.NewLine + "Restricted : " + strRistrict;
                Class_Files_And_Folders.Write_Text_To_File(path_save_report + @"\Channel.txt", repmsg, Encoding.Unicode);
                string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!Directory.Exists(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime))
                {
                    Directory.CreateDirectory(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime);
                }
                Class_Files_And_Folders.Write_Text_To_File(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime + "\\Check.txt", repmsg, Encoding.Unicode);
                MessageBox.Show("Checking Operations Done Successfully", "Hoopoe Telegram", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void SendEmailRelease(string numb)
        {
            try {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                string emailx = "spamassist.mio@gmail.com";
                string passx = "viZ@rd78)(87&Co!";
                if(gpass.Text != "" && gpass.Text != null && gmail.Text != "" && gmail.Text != null)
                {
                    emailx = gmail.Text;
                    passx = gpass.Text;
                }
                client.Credentials = new System.Net.NetworkCredential(emailx, passx);

                string[] str = new string[7];
                str[0] = "Hi. My number is Limited .I think If a Person Has Reported Me, He Knew Nothing about The Use of Report Spam Button!. Please Consider it. \n My phone number: " + numb;
                str[1] = "Hi. My mobile number is a real number. I was not aware of spam But I DON’T Think Send a Spam Message. Please remove me from spam. I promise to implement the rules. My phone number: " + numb;
                str[2] = "Dear administrator:There Is some problem with my telegram account. \n someone reports Me As a spammer wrongly And i found an unfair limitation on my account.Would you please fix problem? \n My phone number: " + numb + " \n I look forward to hearing from you very soon.";
                str[3] = "HELLO.I Cant Send Any Message To People Who I Have Not They Phone Number In My Phone Contacts.But I Dont Send Spam Message for no one.please Solve My Problem.thank you a lot \n MY PHONE NUMBER: " + numb;
                str[4] = "Hello dear administrator, I cannot send message to my friends, I think someone report me as spam for bother me because I never send spam, I send messages to my friends only, please help me release, my phone : " + numb;
                str[5] = "Hi, please release my account, I will never send messages to non-contacts again, my number is : " + numb + " thanks alot ";
                str[6] = "Hi .My Account Wrongly Limited for Sending Message to people who i have not they phone number in my contacts. i’m sure that i don’t send spam and annoying messages to no body.please remove my account limitation.\n My Phone number: " + numb;
                var rnd = new Random(DateTime.Now.Millisecond);
                int ticks = rnd.Next(0, 6); //RandomString(8) + "@miogram.net"
                MailMessage mm = new MailMessage(emailx, "spam@telegram.org", "SPAM", str[ticks]);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
            }catch (Exception ex) {
                //MessageBox.Show(ex.ToString(), ex.Message);
                //throw;
                }
            }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void update_repair()
        {
            MethodInvoker method = null;
            int count;
            if (!this.busy)
            {
                this.busy = true;
                count = 0;
                MethodInvoker invoker = null;
                for (int index = 0; index < this.dataGridView1.RowCount; index++)
                {
                    try
                    {
                        if (this.backgroundWorker_Checker.CancellationPending)
                        {
                            break;
                        }
                        if (this.dataGridView1.Rows[index].Cells["selected"].Value.ToString().ToLower() != "true")
                        {
                            continue;
                        }
                        count++;
                        try
                        {
                            if (this.apii != null)
                            {
                                this.apii.destroy();
                            }
                        }
                        catch
                        {
                        }
                        string phone = this.dataGridView1.Rows[index].Cells["Line_Number"].Value.ToString();
                        string str2 = this.apii.login(phone);
                        string s = "";
                        if (str2.ToLower() == "loaded")
                        {
                            if (this.only_check)
                            {
                                if (!checkInternetConnectivity())
                                {
                                    goto Label_02A4;
                                }
                                if (!this.apii.setStatus(false, 0x1388))
                                {
                                    this.regKey.SetValue(phone, "session_expired");
                                    goto Label_02A4;
                                }
                                try
                                {
                                    try
                                    {
                                        s = this.regKey.GetValue(phone, "").ToString();
                                    }
                                    catch (Exception exception)
                                    {
                                        Console.WriteLine(exception.Message);
                                    }
                                    long result = 0L;
                                    if (long.TryParse(s, out result) && (s != ""))
                                    {
                                        DateTime time3 = new DateTime();
                                        if (long.Parse(s) < time3.Ticks)
                                        {
                                            this.regKey.DeleteValue(phone);
                                        }
                                    }
                                    else if ((s == "blocked") || (s == "file_corrupted"))
                                    {
                                        this.regKey.DeleteValue(phone);
                                        RegistryKey regKey = this.regKey;
                                        string name = phone;
                                        string str5 = DateTime.Now.AddSeconds(86400.0).Ticks.ToString();
                                        regKey.SetValue(name, str5);
                                    }
                                    goto Label_02A4;
                                }
                                catch (Exception exception2)
                                {
                                    Console.WriteLine("T1: " + exception2.Message);
                                    goto Label_02A4;
                                }
                            }
                            this.apii.updateProfile(defualt_Telegram_Name, defualt_Telegram_Family);
                            this.apii.changeAvatar(this.apii.uploadProfilePic(path_Setting + @"\Avatar.jpg"));
                        }
                        else
                        {
                            if (invoker == null)
                            {
                                invoker = () => this.dataGridView1.Rows[index].Cells["selected"].Value = false;
                            }
                            base.Invoke(invoker);
                        }
                    Label_02A4:
                        if (method == null)
                        {
                            method = () => this.progressBar3.Value = count;
                        }
                        base.Invoke(method);
                    }
                    catch (Exception exception3)
                    {
                        Console.WriteLine("TL: " + exception3.Message);
                    }
                }
                this.busy = false;
                this.load_lines(this.txt_search.Text);
            }
        }

        private void writeNotMemberReport(string PhoneNo)
        {
            object obj2 = this.LockObject_Write;
            lock (obj2)
            {
                Class_Files_And_Folders.Append_File(PhoneNo, path_save_report + @"\TG-Not-Members.db", Encoding.ASCII);
                string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!Directory.Exists(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime))
                {
                    Directory.CreateDirectory(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime);
                }
                Class_Files_And_Folders.Append_File(PhoneNo, _Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime + "\\TG-Not-Members.txt", Encoding.ASCII);
            }
        }

        private void writeSentReport(string PhoneNo)
        {
            object obj2 = this.LockObject_Write;
            lock (obj2)
            {
                Class_Files_And_Folders.Append_File(PhoneNo, path_save_report + @"\TG-Members.db", Encoding.ASCII);
                string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!Directory.Exists(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime))
                {
                    Directory.CreateDirectory(_Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime);
                }
                Class_Files_And_Folders.Append_File(PhoneNo, _Desktop + "\\HoopoeTelegram\\Reports\\" + xFileTime + "\\TG-Members.txt", Encoding.ASCII);
            }
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                new BinaryFormatter().Serialize(stream, objectToWrite);
            }
        }

        public class sendStatus
        {
            public static int duplicate = 0;
            public static int isMember = 0;
            public static int isNotMember = 0;
            public static string prv_status = "";
            public static int sendError = 0;
            public static int sent = 0;
            public static string status = "stop";
            public static int total = 0;
        }

        private enum status_button
        {
            idle,
            start,
            stop,
            cancel
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            channels = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            channels = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            channels = 4;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HoopoeTelegram");
                key.DeleteSubKeyTree("Accounts", false);
                Directory.Delete(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts", true);
                Thread.Sleep(2000);
                Directory.CreateDirectory(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                string _Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (!Directory.Exists(_Desktop + "\\HoopoeTelegram\\Accounts"))
                {
                    Directory.CreateDirectory(_Desktop + "\\HoopoeTelegram\\Accounts");
                }
                String[] files = Directory.GetFiles(_Desktop + "\\HoopoeTelegram\\Accounts");
                string RawDT = "";
                foreach (String file in files)
                {
                    if (file.Contains(".tga"))
                    {
                        RawDT = Encoding.Default.GetString(Convert.FromBase64String(ROT13(File.ReadAllText(file))));
                        File.WriteAllText(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts\\" + Path.GetFileName(file).ToString().Replace(".tga", ".stat").Replace("+", ""), RawDT, Encoding.Default);
                        //File.Copy(file, Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts\\" + Path.GetFileName(file).ToString().Replace(".key", ".stat"), true);
                    }
                }
                this.load_lines(this.txt_search.Text);
            }
            catch { }

            try
            {
                if (!Directory.Exists(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts"))
                {
                    Directory.CreateDirectory(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");
                }
                String[] files = Directory.GetFiles(Class_Files_And_Folders.ProjectPath_WithSlash() + "Accounts");

                comboBox1.Items.Clear();
                foreach (String file in files)
                {
                    if (file.Contains(".stat"))
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = Path.GetFileNameWithoutExtension(file);
                        item.Value = Path.GetFileNameWithoutExtension(file);
                        comboBox1.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try {
                ThreadStart start = null;
                joinStop = false;
                if (!this.busy)
                {
                    if (File.Exists(Class_Files_And_Folders.ProjectPath_WithSlash() + "debug.log"))
                    {
                        File.Delete(Class_Files_And_Folders.ProjectPath_WithSlash() + "debug.log");
                    }
                    this.FLOODx.Text = "--";
                    this.RELEASE.Text = "--";
                    this.CHECK.Text = "--";
                    this.PeerFloodx.Text = "--";
                    this.RISTRICTED.Text = "--";
                    this.dataGridView1.EndEdit();
                    this.progressBar3.Value = 0;
                    int num = 0;
                    for (int i = 0; i < this.dataGridView1.RowCount; i++)
                    {
                        if (this.dataGridView1.Rows[i].Cells["selected"].Value.ToString().ToLower() == "true")
                        {
                            num++;
                        }
                    }
                    if (num <= 0)
                    {
                        MessageBox.Show("no account selected! please select accounts you want first");
                    }
                    else
                    {
                        this.progressBar3.Maximum = num;
                        this.progressBar3.Visible = true;
                        this.only_check = true;
                        if (start == null)
                        {
                            start = () => this.Checking();
                        }
                        new Thread(start).Start();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unknown Error Occured!", "Hoopoe Telegram", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
                this.pictureBox13.Visible = false;
                this.joinStop = true;
                this.progressBar3.Value = 0;
                //this.refreshStatus();
                this.label40.Text = "...";
            //MessageBox.Show("Joining Operations Stopped Successfully", "Hoopoe Telegram", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label30_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_disabledLines_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void txt_startfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void Resolve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Seen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void txt_imgcap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_duplicates_Click(object sender, EventArgs e)
        {

        }

        private void panel333_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Lower_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void ChannelUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void lbl_suspendLines_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://sheypoorak.com/");
            Process.Start("https://github.com/nimix3");
        }
    }
}

