namespace HoopoeTelegram
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    internal class appState
    {
        private List<string> accounts;
        private string countper;
        private string desc;
        private string inputfilename;
        private string inputpicturefilename;
        private string inputvideofilename;
        private string prefixname;
        private string sended;
        private string SendType;
        private string SleepTime;
        private string textBox7;
        private string totalNumber;

        public List<string> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }

        public string Countper
        {
            get
            {
                return this.countper;
            }
            set
            {
                this.countper = value;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }
            set
            {
                this.desc = value;
            }
        }

        public string Inputfilename
        {
            get
            {
                return this.inputfilename;
            }
            set
            {
                this.inputfilename = value;
            }
        }

        public string Inputpicturefilename
        {
            get
            {
                return this.inputpicturefilename;
            }
            set
            {
                this.inputpicturefilename = value;
            }
        }

        public string Inputvideofilename
        {
            get
            {
                return this.inputvideofilename;
            }
            set
            {
                this.inputvideofilename = value;
            }
        }

        public string Prefixname
        {
            get
            {
                return this.prefixname;
            }
            set
            {
                this.prefixname = value;
            }
        }

        public string Sended
        {
            get
            {
                return this.sended;
            }
            set
            {
                this.sended = value;
            }
        }

        public string sendType
        {
            get
            {
                return this.SendType;
            }
            set
            {
                this.SendType = value;
            }
        }

        public string sleepTime
        {
            get
            {
                return this.SleepTime;
            }
            set
            {
                this.SleepTime = value;
            }
        }

        public string TextBox7
        {
            get
            {
                return this.textBox7;
            }
            set
            {
                this.textBox7 = value;
            }
        }

        public string TotalNumber
        {
            get
            {
                return this.totalNumber;
            }
            set
            {
                this.totalNumber = value;
            }
        }
    }
}

