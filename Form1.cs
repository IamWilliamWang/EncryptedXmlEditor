using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlEditor
{
    public partial class Form1 : Form
    {
        public static String fileName = null;
        private int emptyLinePointer = 1;
        private bool encrypted = true;

        public Form1()
        {
            InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "XML文件|*.xml";
                dialog.ShowDialog();
                if (dialog.FileName == "")
                    Application.Exit();
                fileName = dialog.FileName;
            }
            labelInfo.Text = "打开文件："+fileName;
        }

        private void encrypt(string filename)
        {
            Byte[] result = Encrypt.defaultEncrypt(System.IO.File.ReadAllBytes(filename));
            System.IO.File.WriteAllBytes(fileName, result);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (this.encrypted)
            {
                encrypt(fileName);
                this.encrypted = false;
            }
            String xml = System.IO.File.ReadAllText(fileName);
            int segmentStartIndex, segmentEndIndex;
            segmentStartIndex = xml.IndexOf("<name>" + textKeyword.Text,StringComparison.OrdinalIgnoreCase);
            if (segmentStartIndex == -1)
                return;
            segmentEndIndex = xml.IndexOf("</item>", segmentStartIndex);
            String segment = xml.Substring(segmentStartIndex, segmentEndIndex - segmentStartIndex);
            var list = Regex.Matches(segment, @"<(\S+)>(\S+)</\S+>");
            foreach(Match match in list)
            {
                TextWriteLine(match.Groups[1].ToString(),match.Groups[2].ToString());
            }
        }

        private void TextWriteLine(string propertyName,string propertyValue)
        {
            switch(this.emptyLinePointer)
            {
                case 1:
                    this.textProp1.Text = propertyName;
                    this.textPropVal1.Text = propertyValue;
                    break;
                case 2:
                    this.textProp2.Text = propertyName;
                    this.textPropVal2.Text = propertyValue;
                    break;
                case 3:
                    this.textProp3.Text = propertyName;
                    this.textPropVal3.Text = propertyValue;
                    break;
                case 4:
                    this.textProp4.Text = propertyName;
                    this.textPropVal4.Text = propertyValue;
                    break;
                case 5:
                    this.textProp5.Text = propertyName;
                    this.textPropVal5.Text = propertyValue;
                    break;
                case 6:
                    this.textProp6.Text = propertyName;
                    this.textPropVal6.Text = propertyValue;
                    break;
                case 7:
                    this.textProp7.Text = propertyName;
                    this.textPropVal7.Text = propertyValue;
                    break;
                default:
                    MessageBox.Show("无法在下方显示所有信息","索引溢出错误");
                    break;
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            this.textKeyword.Text = "";
            this.textProp1.Text = "";
            this.textProp2.Text = "";
            this.textProp3.Text = "";
            this.textProp4.Text = "";
            this.textProp5.Text = "";
            this.textProp6.Text = "";
            this.textProp7.Text = "";
            this.textPropVal1.Text = "";
            this.textPropVal2.Text = "";
            this.textPropVal3.Text = "";
            this.textPropVal4.Text = "";
            this.textPropVal5.Text = "";
            this.textPropVal6.Text = "";
            this.textPropVal7.Text = "";
            this.emptyLinePointer = 1;
        }

        private void buttonCopy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal1.Text);
        }

        private void buttonCopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal2.Text);
        }

        private void buttonCopy3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal3.Text);
        }

        private void buttonCopy4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal4.Text);
        }

        private void buttonCopy5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal5.Text);
        }

        private void buttonCopy6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal6.Text);
        }

        private void buttonCopy7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textPropVal7.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.encrypted == false)
                encrypt(fileName);
        }

        private void textKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                this.buttonSearch_Click(null, null);
            }
        }
    }
}
