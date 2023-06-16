using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace WindowsFormAppSerialKeyGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    
        string Hash = "";
        int iAccess = 0;
        string PrivateSalt = "Alpha";
        string SourceString = "";
        string guidString;

        private void btnGenerate_Click(object sender, EventArgs e)
        {



            Guid theGuid;


            while (true)
            {
                theGuid =  Guid.NewGuid();
                guidString = theGuid.ToString().Replace("-", "").Substring(0, 16);
                SourceString = guidString + "|" + iAccess.ToString() + "|" + PrivateSalt;

                byte[] data = Encoding.Default.GetBytes(SourceString);

                CryptographicException Crypto = new CryptographicException();

                Hash = GenerateSHA512String(SourceString);
              
          
                if (Hash.StartsWith(GetDiff()))
                {
                    break;
                }

                iAccess++;
            }

            string str = GetDiff();

            string s1, s2, s3, s4;
            s1 = guidString.Substring(0, 4);
            s2 = guidString.Substring(4, 4);
            s3 = guidString.Substring(8, 4);
            s4 = guidString.Substring(12, 4);
            string serial = s1 + "-" + s2 + "-" + s3 + "-" + s4;

            this.txtSl.Text = serial;
            this.lbCode.Text = str;

        }

        private string GetDiff()
        {
            return iAccess.ToString();
        }


        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        public bool IsSerialValid(string serialCode, string ProductCode)
        {
            string SourceString = serialCode.Replace("-", "") + "|" + ProductCode + "|" + "Alpha";

            byte[] data = Encoding.Default.GetBytes(SourceString);

            Hash = GenerateSHA512String(SourceString);

            if (Hash.StartsWith(GetDiff()))
            {
                return true;
            }
            return false;
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IsSerialValid(this.txtSl.Text, this.lbCode.Text).ToString());
        }
    }
}
