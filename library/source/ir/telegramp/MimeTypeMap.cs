namespace ir.telegramp
{
    using IKVM.Attributes;
    using java.lang;
    using java.util;
    using java.util.regex;
    using System;
    using System.Runtime.CompilerServices;

    public class MimeTypeMap : Object
    {
        [Signature("Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;")]
        private HashMap mExtensionToMimeTypeMap = new HashMap();
        [Signature("Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;")]
        private HashMap mMimeTypeToExtensionMap = new HashMap();
        private static MimeTypeMap sMimeTypeMap;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x6b, 0x6b })]
        private MimeTypeMap()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x57, 0x6c, 0xb2 })]
        public virtual string getExtensionFromMimeType(string mimeType)
        {
            if ((mimeType != null) && (String.instancehelper_length(mimeType) > 0))
            {
                return (string) this.mMimeTypeToExtensionMap.get(mimeType);
            }
            return null;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 190, 0x72, 0x69, 100, 0x8a, 0x69, 0x68, 0xc9, 0x6f, 0x77, 0x6a, 0x65, 0xed, 0x45 })]
        public static string getFileExtensionFromUrl(string url)
        {
            if ((url != null) && (String.instancehelper_length(url) > 0))
            {
                int num = String.instancehelper_lastIndexOf(url, 0x3f);
                if (num > 0)
                {
                    url = String.instancehelper_substring(url, 0, num);
                }
                int num2 = String.instancehelper_lastIndexOf(url, 0x2f);
                string str = (0 > num2) ? url : String.instancehelper_substring(url, num2 + 1);
                if (String.instancehelper_length(str) > 0)
                {
                    CharSequence sequence;
                    object obj2 = str;
                    sequence.__<ref> = obj2;
                    if (Pattern.matches(@"[a-zA-Z_0-9\.\-]+", sequence))
                    {
                        int num3 = String.instancehelper_lastIndexOf(str, 0x2e);
                        if (0 <= num3)
                        {
                            return String.instancehelper_substring(str, num3 + 1);
                        }
                    }
                }
            }
            return "";
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x41, 0x6c, 0xb2 })]
        public virtual string getMimeTypeFromExtension(string extension)
        {
            if ((extension != null) && (String.instancehelper_length(extension) > 0))
            {
                return (string) this.mExtensionToMimeTypeMap.get(extension);
            }
            return null;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x62, 0x6a, 0xea, 0x4e, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x95, 0x75, 0x75, 0xb5, 0xb5, 0xb5, 0xb5, 0x95, 0xb5, 0xb5,
            0x95, 0xb5, 0xb5, 0xb5, 0x75, 0x75, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95,
            0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x95, 0x75, 0x75, 0x95, 0x75, 0x95, 0x75, 0x75, 0x75,
            0x75, 0x95, 0x95, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x95, 0x75, 0x75, 0x75, 0x75, 0x75, 0x95, 0x95, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x95, 0x75, 0x75, 0x95, 0x95, 0x75, 0x95, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x95, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75, 0x75,
            0x75, 0x75, 0x75, 0x75, 0xb5
        })]
        public static MimeTypeMap getSingleton()
        {
            if (sMimeTypeMap == null)
            {
                sMimeTypeMap = new MimeTypeMap();
                sMimeTypeMap.loadEntry("application/andrew-inset", "ez", false);
                sMimeTypeMap.loadEntry("application/dsptype", "tsp", false);
                sMimeTypeMap.loadEntry("application/futuresplash", "spl", false);
                sMimeTypeMap.loadEntry("application/hta", "hta", false);
                sMimeTypeMap.loadEntry("application/mac-binhex40", "hqx", false);
                sMimeTypeMap.loadEntry("application/mac-compactpro", "cpt", false);
                sMimeTypeMap.loadEntry("application/mathematica", "nb", false);
                sMimeTypeMap.loadEntry("application/msaccess", "mdb", false);
                sMimeTypeMap.loadEntry("application/oda", "oda", false);
                sMimeTypeMap.loadEntry("application/ogg", "ogg", false);
                sMimeTypeMap.loadEntry("application/pdf", "pdf", false);
                sMimeTypeMap.loadEntry("application/pgp-keys", "key", false);
                sMimeTypeMap.loadEntry("application/pgp-signature", "pgp", false);
                sMimeTypeMap.loadEntry("application/pics-rules", "prf", false);
                sMimeTypeMap.loadEntry("application/rar", "rar", false);
                sMimeTypeMap.loadEntry("application/rdf+xml", "rdf", false);
                sMimeTypeMap.loadEntry("application/rss+xml", "rss", false);
                sMimeTypeMap.loadEntry("application/zip", "zip", false);
                sMimeTypeMap.loadEntry("application/vnd.android.package-archive", "apk", false);
                sMimeTypeMap.loadEntry("application/vnd.cinderella", "cdy", false);
                sMimeTypeMap.loadEntry("application/vnd.ms-pki.stl", "stl", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.database", "odb", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.formula", "odf", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.graphics", "odg", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.graphics-template", "otg", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.image", "odi", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.spreadsheet", "ods", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.spreadsheet-template", "ots", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.text", "odt", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.text-master", "odm", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.text-template", "ott", false);
                sMimeTypeMap.loadEntry("application/vnd.oasis.opendocument.text-web", "oth", false);
                sMimeTypeMap.loadEntry("application/vnd.rim.cod", "cod", false);
                sMimeTypeMap.loadEntry("application/vnd.smaf", "mmf", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.calc", "sdc", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.draw", "sda", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.impress", "sdd", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.impress", "sdp", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.math", "smf", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.writer", "sdw", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.writer", "vor", false);
                sMimeTypeMap.loadEntry("application/vnd.stardivision.writer-global", "sgl", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.calc", "sxc", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.calc.template", "stc", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.draw", "sxd", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.draw.template", "std", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.impress", "sxi", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.impress.template", "sti", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.math", "sxm", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.writer", "sxw", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.writer.global", "sxg", false);
                sMimeTypeMap.loadEntry("application/vnd.sun.xml.writer.template", "stw", false);
                sMimeTypeMap.loadEntry("application/vnd.visio", "vsd", false);
                sMimeTypeMap.loadEntry("application/x-abiword", "abw", false);
                sMimeTypeMap.loadEntry("application/x-apple-diskimage", "dmg", false);
                sMimeTypeMap.loadEntry("application/x-bcpio", "bcpio", false);
                sMimeTypeMap.loadEntry("application/x-bittorrent", "torrent", false);
                sMimeTypeMap.loadEntry("application/x-cdf", "cdf", false);
                sMimeTypeMap.loadEntry("application/x-cdlink", "vcd", false);
                sMimeTypeMap.loadEntry("application/x-chess-pgn", "pgn", false);
                sMimeTypeMap.loadEntry("application/x-cpio", "cpio", false);
                sMimeTypeMap.loadEntry("application/x-debian-package", "deb", false);
                sMimeTypeMap.loadEntry("application/x-debian-package", "udeb", false);
                sMimeTypeMap.loadEntry("application/x-director", "dcr", false);
                sMimeTypeMap.loadEntry("application/x-director", "dir", false);
                sMimeTypeMap.loadEntry("application/x-director", "dxr", false);
                sMimeTypeMap.loadEntry("application/x-dms", "dms", false);
                sMimeTypeMap.loadEntry("application/x-doom", "wad", false);
                sMimeTypeMap.loadEntry("application/x-dvi", "dvi", false);
                sMimeTypeMap.loadEntry("application/x-flac", "flac", false);
                sMimeTypeMap.loadEntry("application/x-font", "pfa", false);
                sMimeTypeMap.loadEntry("application/x-font", "pfb", false);
                sMimeTypeMap.loadEntry("application/x-font", "gsf", false);
                sMimeTypeMap.loadEntry("application/x-font", "pcf", false);
                sMimeTypeMap.loadEntry("application/x-font", "pcf.Z", false);
                sMimeTypeMap.loadEntry("application/x-freemind", "mm", false);
                sMimeTypeMap.loadEntry("application/x-futuresplash", "spl", false);
                sMimeTypeMap.loadEntry("application/x-gnumeric", "gnumeric", false);
                sMimeTypeMap.loadEntry("application/x-go-sgf", "sgf", false);
                sMimeTypeMap.loadEntry("application/x-graphing-calculator", "gcf", false);
                sMimeTypeMap.loadEntry("application/x-gtar", "gtar", false);
                sMimeTypeMap.loadEntry("application/x-gtar", "tgz", false);
                sMimeTypeMap.loadEntry("application/x-gtar", "taz", false);
                sMimeTypeMap.loadEntry("application/x-hdf", "hdf", false);
                sMimeTypeMap.loadEntry("application/x-ica", "ica", false);
                sMimeTypeMap.loadEntry("application/x-internet-signup", "ins", false);
                sMimeTypeMap.loadEntry("application/x-internet-signup", "isp", false);
                sMimeTypeMap.loadEntry("application/x-iphone", "iii", false);
                sMimeTypeMap.loadEntry("application/x-iso9660-image", "iso", false);
                sMimeTypeMap.loadEntry("application/x-jmol", "jmz", false);
                sMimeTypeMap.loadEntry("application/x-kchart", "chrt", false);
                sMimeTypeMap.loadEntry("application/x-killustrator", "kil", false);
                sMimeTypeMap.loadEntry("application/x-koan", "skp", false);
                sMimeTypeMap.loadEntry("application/x-koan", "skd", false);
                sMimeTypeMap.loadEntry("application/x-koan", "skt", false);
                sMimeTypeMap.loadEntry("application/x-koan", "skm", false);
                sMimeTypeMap.loadEntry("application/x-kpresenter", "kpr", false);
                sMimeTypeMap.loadEntry("application/x-kpresenter", "kpt", false);
                sMimeTypeMap.loadEntry("application/x-kspread", "ksp", false);
                sMimeTypeMap.loadEntry("application/x-kword", "kwd", false);
                sMimeTypeMap.loadEntry("application/x-kword", "kwt", false);
                sMimeTypeMap.loadEntry("application/x-latex", "latex", false);
                sMimeTypeMap.loadEntry("application/x-lha", "lha", false);
                sMimeTypeMap.loadEntry("application/x-lzh", "lzh", false);
                sMimeTypeMap.loadEntry("application/x-lzx", "lzx", false);
                sMimeTypeMap.loadEntry("application/x-maker", "frm", false);
                sMimeTypeMap.loadEntry("application/x-maker", "maker", false);
                sMimeTypeMap.loadEntry("application/x-maker", "frame", false);
                sMimeTypeMap.loadEntry("application/x-maker", "fb", false);
                sMimeTypeMap.loadEntry("application/x-maker", "book", false);
                sMimeTypeMap.loadEntry("application/x-maker", "fbdoc", false);
                sMimeTypeMap.loadEntry("application/x-mif", "mif", false);
                sMimeTypeMap.loadEntry("application/x-ms-wmd", "wmd", false);
                sMimeTypeMap.loadEntry("application/x-ms-wmz", "wmz", false);
                sMimeTypeMap.loadEntry("application/x-msi", "msi", false);
                sMimeTypeMap.loadEntry("application/x-ns-proxy-autoconfig", "pac", false);
                sMimeTypeMap.loadEntry("application/x-nwc", "nwc", false);
                sMimeTypeMap.loadEntry("application/x-object", "o", false);
                sMimeTypeMap.loadEntry("application/x-oz-application", "oza", false);
                sMimeTypeMap.loadEntry("application/x-pkcs7-certreqresp", "p7r", false);
                sMimeTypeMap.loadEntry("application/x-pkcs7-crl", "crl", false);
                sMimeTypeMap.loadEntry("application/x-quicktimeplayer", "qtl", false);
                sMimeTypeMap.loadEntry("application/x-shar", "shar", false);
                sMimeTypeMap.loadEntry("application/x-stuffit", "sit", false);
                sMimeTypeMap.loadEntry("application/x-sv4cpio", "sv4cpio", false);
                sMimeTypeMap.loadEntry("application/x-sv4crc", "sv4crc", false);
                sMimeTypeMap.loadEntry("application/x-tar", "tar", false);
                sMimeTypeMap.loadEntry("application/x-texinfo", "texinfo", false);
                sMimeTypeMap.loadEntry("application/x-texinfo", "texi", false);
                sMimeTypeMap.loadEntry("application/x-troff", "t", false);
                sMimeTypeMap.loadEntry("application/x-troff", "roff", false);
                sMimeTypeMap.loadEntry("application/x-troff-man", "man", false);
                sMimeTypeMap.loadEntry("application/x-ustar", "ustar", false);
                sMimeTypeMap.loadEntry("application/x-wais-source", "src", false);
                sMimeTypeMap.loadEntry("application/x-wingz", "wz", false);
                sMimeTypeMap.loadEntry("application/x-webarchive", "webarchive", false);
                sMimeTypeMap.loadEntry("application/x-x509-ca-cert", "crt", false);
                sMimeTypeMap.loadEntry("application/x-xcf", "xcf", false);
                sMimeTypeMap.loadEntry("application/x-xfig", "fig", false);
                sMimeTypeMap.loadEntry("audio/basic", "snd", false);
                sMimeTypeMap.loadEntry("audio/midi", "mid", false);
                sMimeTypeMap.loadEntry("audio/midi", "midi", false);
                sMimeTypeMap.loadEntry("audio/midi", "kar", false);
                sMimeTypeMap.loadEntry("audio/mpeg", "mpga", false);
                sMimeTypeMap.loadEntry("audio/mpeg", "mpega", false);
                sMimeTypeMap.loadEntry("audio/mpeg", "mp2", false);
                sMimeTypeMap.loadEntry("audio/mpeg", "mp3", false);
                sMimeTypeMap.loadEntry("audio/mpeg", "m4a", false);
                sMimeTypeMap.loadEntry("audio/mpegurl", "m3u", false);
                sMimeTypeMap.loadEntry("audio/prs.sid", "sid", false);
                sMimeTypeMap.loadEntry("audio/x-aiff", "aif", false);
                sMimeTypeMap.loadEntry("audio/x-aiff", "aiff", false);
                sMimeTypeMap.loadEntry("audio/x-aiff", "aifc", false);
                sMimeTypeMap.loadEntry("audio/x-gsm", "gsm", false);
                sMimeTypeMap.loadEntry("audio/x-mpegurl", "m3u", false);
                sMimeTypeMap.loadEntry("audio/x-ms-wma", "wma", false);
                sMimeTypeMap.loadEntry("audio/x-ms-wax", "wax", false);
                sMimeTypeMap.loadEntry("audio/x-pn-realaudio", "ra", false);
                sMimeTypeMap.loadEntry("audio/x-pn-realaudio", "rm", false);
                sMimeTypeMap.loadEntry("audio/x-pn-realaudio", "ram", false);
                sMimeTypeMap.loadEntry("audio/x-realaudio", "ra", false);
                sMimeTypeMap.loadEntry("audio/x-scpls", "pls", false);
                sMimeTypeMap.loadEntry("audio/x-sd2", "sd2", false);
                sMimeTypeMap.loadEntry("audio/x-wav", "wav", false);
                sMimeTypeMap.loadEntry("image/bmp", "bmp", false);
                sMimeTypeMap.loadEntry("image/gif", "gif", false);
                sMimeTypeMap.loadEntry("image/ico", "cur", false);
                sMimeTypeMap.loadEntry("image/ico", "ico", false);
                sMimeTypeMap.loadEntry("image/ief", "ief", false);
                sMimeTypeMap.loadEntry("image/jpeg", "jpeg", false);
                sMimeTypeMap.loadEntry("image/jpeg", "jpg", false);
                sMimeTypeMap.loadEntry("image/jpeg", "jpe", false);
                sMimeTypeMap.loadEntry("image/pcx", "pcx", false);
                sMimeTypeMap.loadEntry("image/png", "png", false);
                sMimeTypeMap.loadEntry("image/svg+xml", "svg", false);
                sMimeTypeMap.loadEntry("image/svg+xml", "svgz", false);
                sMimeTypeMap.loadEntry("image/tiff", "tiff", false);
                sMimeTypeMap.loadEntry("image/tiff", "tif", false);
                sMimeTypeMap.loadEntry("image/vnd.djvu", "djvu", false);
                sMimeTypeMap.loadEntry("image/vnd.djvu", "djv", false);
                sMimeTypeMap.loadEntry("image/vnd.wap.wbmp", "wbmp", false);
                sMimeTypeMap.loadEntry("image/x-cmu-raster", "ras", false);
                sMimeTypeMap.loadEntry("image/x-coreldraw", "cdr", false);
                sMimeTypeMap.loadEntry("image/x-coreldrawpattern", "pat", false);
                sMimeTypeMap.loadEntry("image/x-coreldrawtemplate", "cdt", false);
                sMimeTypeMap.loadEntry("image/x-corelphotopaint", "cpt", false);
                sMimeTypeMap.loadEntry("image/x-icon", "ico", false);
                sMimeTypeMap.loadEntry("image/x-jg", "art", false);
                sMimeTypeMap.loadEntry("image/x-jng", "jng", false);
                sMimeTypeMap.loadEntry("image/x-ms-bmp", "bmp", false);
                sMimeTypeMap.loadEntry("image/x-photoshop", "psd", false);
                sMimeTypeMap.loadEntry("image/x-portable-anymap", "pnm", false);
                sMimeTypeMap.loadEntry("image/x-portable-bitmap", "pbm", false);
                sMimeTypeMap.loadEntry("image/x-portable-graymap", "pgm", false);
                sMimeTypeMap.loadEntry("image/x-portable-pixmap", "ppm", false);
                sMimeTypeMap.loadEntry("image/x-rgb", "rgb", false);
                sMimeTypeMap.loadEntry("image/x-xbitmap", "xbm", false);
                sMimeTypeMap.loadEntry("image/x-xpixmap", "xpm", false);
                sMimeTypeMap.loadEntry("image/x-xwindowdump", "xwd", false);
                sMimeTypeMap.loadEntry("model/iges", "igs", false);
                sMimeTypeMap.loadEntry("model/iges", "iges", false);
                sMimeTypeMap.loadEntry("model/mesh", "msh", false);
                sMimeTypeMap.loadEntry("model/mesh", "mesh", false);
                sMimeTypeMap.loadEntry("model/mesh", "silo", false);
                sMimeTypeMap.loadEntry("text/calendar", "ics", true);
                sMimeTypeMap.loadEntry("text/calendar", "icz", true);
                sMimeTypeMap.loadEntry("text/comma-separated-values", "csv", true);
                sMimeTypeMap.loadEntry("text/css", "css", true);
                sMimeTypeMap.loadEntry("text/h323", "323", true);
                sMimeTypeMap.loadEntry("text/iuls", "uls", true);
                sMimeTypeMap.loadEntry("text/mathml", "mml", true);
                sMimeTypeMap.loadEntry("text/plain", "asc", true);
                sMimeTypeMap.loadEntry("text/plain", "txt", true);
                sMimeTypeMap.loadEntry("text/plain", "text", true);
                sMimeTypeMap.loadEntry("text/plain", "diff", true);
                sMimeTypeMap.loadEntry("text/plain", "pot", true);
                sMimeTypeMap.loadEntry("text/richtext", "rtx", true);
                sMimeTypeMap.loadEntry("text/rtf", "rtf", true);
                sMimeTypeMap.loadEntry("text/texmacs", "ts", true);
                sMimeTypeMap.loadEntry("text/text", "phps", true);
                sMimeTypeMap.loadEntry("text/tab-separated-values", "tsv", true);
                sMimeTypeMap.loadEntry("text/x-bibtex", "bib", true);
                sMimeTypeMap.loadEntry("text/x-boo", "boo", true);
                sMimeTypeMap.loadEntry("text/x-c++hdr", "h++", true);
                sMimeTypeMap.loadEntry("text/x-c++hdr", "hpp", true);
                sMimeTypeMap.loadEntry("text/x-c++hdr", "hxx", true);
                sMimeTypeMap.loadEntry("text/x-c++hdr", "hh", true);
                sMimeTypeMap.loadEntry("text/x-c++src", "c++", true);
                sMimeTypeMap.loadEntry("text/x-c++src", "cpp", true);
                sMimeTypeMap.loadEntry("text/x-c++src", "cxx", true);
                sMimeTypeMap.loadEntry("text/x-chdr", "h", true);
                sMimeTypeMap.loadEntry("text/x-component", "htc", true);
                sMimeTypeMap.loadEntry("text/x-csh", "csh", true);
                sMimeTypeMap.loadEntry("text/x-csrc", "c", true);
                sMimeTypeMap.loadEntry("text/x-dsrc", "d", true);
                sMimeTypeMap.loadEntry("text/x-haskell", "hs", true);
                sMimeTypeMap.loadEntry("text/x-java", "java", true);
                sMimeTypeMap.loadEntry("text/x-literate-haskell", "lhs", true);
                sMimeTypeMap.loadEntry("text/x-moc", "moc", true);
                sMimeTypeMap.loadEntry("text/x-pascal", "p", true);
                sMimeTypeMap.loadEntry("text/x-pascal", "pas", true);
                sMimeTypeMap.loadEntry("text/x-pcs-gcd", "gcd", true);
                sMimeTypeMap.loadEntry("text/x-setext", "etx", true);
                sMimeTypeMap.loadEntry("text/x-tcl", "tcl", true);
                sMimeTypeMap.loadEntry("text/x-tex", "tex", true);
                sMimeTypeMap.loadEntry("text/x-tex", "ltx", true);
                sMimeTypeMap.loadEntry("text/x-tex", "sty", true);
                sMimeTypeMap.loadEntry("text/x-tex", "cls", true);
                sMimeTypeMap.loadEntry("text/x-vcalendar", "vcs", true);
                sMimeTypeMap.loadEntry("text/x-vcard", "vcf", true);
                sMimeTypeMap.loadEntry("video/dl", "dl", false);
                sMimeTypeMap.loadEntry("video/dv", "dif", false);
                sMimeTypeMap.loadEntry("video/dv", "dv", false);
                sMimeTypeMap.loadEntry("video/fli", "fli", false);
                sMimeTypeMap.loadEntry("video/mpeg", "mpeg", false);
                sMimeTypeMap.loadEntry("video/mpeg", "mpg", false);
                sMimeTypeMap.loadEntry("video/mpeg", "mpe", false);
                sMimeTypeMap.loadEntry("video/mp4", "mp4", false);
                sMimeTypeMap.loadEntry("video/quicktime", "qt", false);
                sMimeTypeMap.loadEntry("video/quicktime", "mov", false);
                sMimeTypeMap.loadEntry("video/vnd.mpegurl", "mxu", false);
                sMimeTypeMap.loadEntry("video/x-la-asf", "lsf", false);
                sMimeTypeMap.loadEntry("video/x-la-asf", "lsx", false);
                sMimeTypeMap.loadEntry("video/x-mng", "mng", false);
                sMimeTypeMap.loadEntry("video/x-ms-asf", "asf", false);
                sMimeTypeMap.loadEntry("video/x-ms-asf", "asx", false);
                sMimeTypeMap.loadEntry("video/x-ms-wm", "wm", false);
                sMimeTypeMap.loadEntry("video/x-ms-wmv", "wmv", false);
                sMimeTypeMap.loadEntry("video/x-ms-wmx", "wmx", false);
                sMimeTypeMap.loadEntry("video/x-ms-wvx", "wvx", false);
                sMimeTypeMap.loadEntry("video/x-msvideo", "avi", false);
                sMimeTypeMap.loadEntry("video/x-sgi-movie", "movie", false);
                sMimeTypeMap.loadEntry("x-conference/x-cooltalk", "ice", false);
            }
            return sMimeTypeMap;
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x4c, 0x6c, 0xaf })]
        public virtual bool hasExtension(string extension) => 
            (((extension != null) && (String.instancehelper_length(extension) > 0)) && this.mExtensionToMimeTypeMap.containsKey(extension));

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x36, 0x6c, 0xaf })]
        public virtual bool hasMimeType(string mimeType) => 
            (((mimeType != null) && (String.instancehelper_length(mimeType) > 0)) && this.mMimeTypeToExtensionMap.containsKey(mimeType));

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x79, 0x62, 110, 0xee, 0x49, 0x63, 0x8e })]
        private void loadEntry(string text1, string text2, bool flag1)
        {
            int num = (int) flag1;
            if (!this.mMimeTypeToExtensionMap.containsKey(text1))
            {
                this.mMimeTypeToExtensionMap.put(text1, text2);
            }
            if (num == 0)
            {
                this.mExtensionToMimeTypeMap.put(text2, text1);
            }
        }
    }
}

