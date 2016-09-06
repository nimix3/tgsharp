namespace HoopoeTelegram
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public static class Class_Files_And_Folders
    {
        public static bool Append_File(string data, string path_file, Encoding encoding_file)
        {
            try
            {
                Create_Folder(Extract_Only_Path_WithSlash(path_file));
                File.AppendAllText(path_file, data, encoding_file);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Create_Folder(string FolderName)
        {
            try
            {
                if (!Directory.Exists(FolderName))
                {
                    Directory.CreateDirectory(FolderName);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete_File(string file_name)
        {
            try
            {
                File.Delete(file_name);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete_Folder(string FolderName)
        {
            try
            {
                Directory.Delete(FolderName, true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string Extract_FileName_And_Extension(string file_name)
        {
            try
            {
                return Path.GetFileName(file_name);
            }
            catch
            {
                return "";
            }
        }

        public static string Extract_Last_Directory(string file_name)
        {
            try
            {
                string str = Extract_Only_Path_WithSlash(file_name);
                char[] separator = new char[1];
                int index = 0;
                int num2 = 0x5c;
                separator[index] = (char) num2;
                string[] strArray = str.Split(separator);
                return strArray[strArray.Length - 2];
            }
            catch
            {
                return "";
            }
        }

        public static string Extract_Only_Drive_WithSlash(string file_name)
        {
            try
            {
                return Path.GetPathRoot(file_name);
            }
            catch
            {
                return "";
            }
        }

        public static string Extract_Only_FileExtension_WithoutDOT(string file_name)
        {
            try
            {
                return Path.GetExtension(file_name).Replace(".", "");
            }
            catch
            {
                return "";
            }
        }

        public static string Extract_Only_FileName_WithoutExtension(string file_name)
        {
            try
            {
                return Path.GetFileNameWithoutExtension(file_name);
            }
            catch
            {
                return "";
            }
        }

        public static string Extract_Only_Path_WithSlash(string file_name)
        {
            try
            {
                return (Path.GetDirectoryName(file_name) + @"\");
            }
            catch
            {
                return "";
            }
        }

        public static bool File_Exist(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public static void Open_Folder_And_Select_File(string FileName)
        {
            try
            {
                Process process = new Process {
                    EnableRaisingEvents = false
                };
                Process.Start(Path.GetDirectoryName(FileName), "");
                Thread.Sleep(0x3e8);
                SendKeys.Send(Path.GetFileName(FileName).Replace("(", "{(}").Replace(")", "{)}"));
                process.Close();
            }
            catch
            {
            }
        }

        public static string ProjectPath_WithSlash()
        {
            try
            {
                return (Application.StartupPath + @"\");
            }
            catch
            {
                return "";
            }
        }

        public static string Read_Text_In_File(string path_file, Encoding encoding_file)
        {
            try
            {
                Create_Folder(Extract_Only_Path_WithSlash(path_file));
                return File.ReadAllText(path_file, encoding_file);
            }
            catch
            {
                return "";
            }
        }

        public static string Remove_Extension_From_FileName(string file_name)
        {
            try
            {
                return file_name.Replace("." + Extract_Only_FileExtension_WithoutDOT(file_name), "");
            }
            catch
            {
                return file_name;
            }
        }

        public static string Remove_Slash_FromEndPath(string path)
        {
            try
            {
                if (!path.EndsWith(@"\"))
                {
                    return path;
                }
                return path.Substring(0, path.Length - 2);
            }
            catch
            {
                return "";
            }
        }

        public static string SaveFileDialog_Image()
        {
            string fileName = "";
            try
            {
                try
                {
                    SaveFileDialog dialog = new SaveFileDialog {
                        AddExtension = true,
                        Filter = "JPG|*.jpg|Jpeg|*.jpeg|BMP|*.bmp|PNG|*.png|All File|*.*"
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = dialog.FileName;
                    }
                }
                catch
                {
                }
            }
            catch
            {
            }
            return fileName;
        }

        public static string Select_Image_File()
        {
            try
            {
                string fileName = "";
                OpenFileDialog dialog = new OpenFileDialog {
                    Multiselect = false,
                    AddExtension = true,
                    Filter = "Image(.JPG,.PNG,.GIF)|*.jpg; *.bmp; *.png; *.jpeg; |All Files|*.*"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName;
                }
                return fileName;
            }
            catch
            {
                return "";
            }
        }

        public static string Standard_FileName(string st)
        {
            return st.Replace(@"\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
        }

        public static string TempPath_WithSlash()
        {
            try
            {
                return Path.GetTempPath();
            }
            catch
            {
                return "";
            }
        }

        public static bool Write_Text_To_File(string path_file, string text, Encoding encoding_file)
        {
            try
            {
                Create_Folder(Extract_Only_Path_WithSlash(path_file));
                File.WriteAllText(path_file, text, encoding_file);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

