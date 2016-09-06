namespace HoopoeTelegram
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class FormUpload
    {
        private static readonly Encoding encoding = Encoding.UTF8;

        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream stream = new MemoryStream();
            bool flag = false;
            foreach (KeyValuePair<string, object> pair in postParameters)
            {
                if (flag)
                {
                    stream.Write(encoding.GetBytes("\r\n"), 0, encoding.GetByteCount("\r\n"));
                }
                flag = true;
                if (pair.Value is FileParameter)
                {
                    FileParameter parameter = (FileParameter) pair.Value;
                    object[] args = new object[] { boundary, pair.Key, parameter.FileName ?? pair.Key, parameter.ContentType ?? "application/octet-stream" };
                    string str = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n", args);
                    stream.Write(encoding.GetBytes(str), 0, encoding.GetByteCount(str));
                    stream.Write(parameter.File, 0, parameter.File.Length);
                }
                else
                {
                    string str2 = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}", boundary, pair.Key, pair.Value);
                    stream.Write(encoding.GetBytes(str2), 0, encoding.GetByteCount(str2));
                }
            }
            string s = "\r\n--" + boundary + "--\r\n";
            stream.Write(encoding.GetBytes(s), 0, encoding.GetByteCount(s));
            stream.Position = 0L;
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Close();
            return buffer;
        }

        public static HttpWebResponse MultipartFormDataPost(string postUrl, string userAgent, Dictionary<string, object> postParameters)
        {
            string boundary = string.Format("----------{0:N}", Guid.NewGuid());
            string contentType = "multipart/form-data; boundary=" + boundary;
            byte[] multipartFormData = GetMultipartFormData(postParameters, boundary);
            return PostForm(postUrl, userAgent, contentType, multipartFormData);
        }

        private static HttpWebResponse PostForm(string postUrl, string userAgent, string contentType, byte[] formData)
        {
            HttpWebRequest request = WebRequest.Create(postUrl) as HttpWebRequest;
            if (request == null)
            {
                throw new NullReferenceException("request is not a http request");
            }
            request.Method = "POST";
            request.ContentType = contentType;
            request.UserAgent = userAgent;
            request.CookieContainer = new CookieContainer();
            request.ContentLength = formData.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(formData, 0, formData.Length);
                stream.Close();
            }
            return (request.GetResponse() as HttpWebResponse);
        }

        public class FileParameter
        {
            public FileParameter(byte[] file) : this(file, null)
            {
            }

            public FileParameter(byte[] file, string filename) : this(file, filename, null)
            {
            }

            public FileParameter(byte[] file, string filename, string contenttype)
            {
                this.File = file;
                this.FileName = filename;
                this.ContentType = contenttype;
            }

            public string ContentType { get; set; }

            public byte[] File { get; set; }

            public string FileName { get; set; }
        }
    }
}

