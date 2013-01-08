using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using Microsoft.Win32;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace ShotLife
{
    public partial class Config : Form
    {
        /// <summary>
        /// 配置程序参数
        /// 1 图片品质
        /// 
        /// 2 图片后缀名(不需要)
        /// 3 Smtp服务器地址，用户名，密码
        /// 4 邮件发送机制
        /// 5 截图保存地址
        /// 6 截图频率
        /// 7 是否开机自动运行
        /// </summary>
        System.Collections.ArrayList array = new System.Collections.ArrayList();
        public Config()
        {
            InitializeComponent();
            BindFrequency();
            BindPixelFormat();
             cbxAutoRun.Checked = IsSubValueExist();
            
           // ControlCollection cols = new ControlCollection(this);
            GetChildControl(this);
            System.Collections.ArrayList excludedControls = new System.Collections.ArrayList();
            excludedControls.Add(cbxAutoRun);
            foreach (object o in array)
            {
                Control c = (Control)o;

                if (excludedControls.Contains(c))
                {
                    continue;
                }
                if (c.GetType().Equals(typeof(TextBox)))
                {
                    c.TextChanged +=new EventHandler(SaveControlValue);
                    string propValue=(string) Properties.Settings.Default[c.Name.TrimStart("tbx".ToCharArray())];
                    if (c.Name.ToLower().IndexOf("password") >= 0)
                    {
                        if (!string.IsNullOrEmpty(propValue))
                        {
                            PHComponents.SCCrypto scc = new PHComponents.SCCrypto();
                            propValue = scc.Decrypting(propValue);
                        }
                    }
                    c.Text = propValue;
              
                }
                if (c.GetType().Equals(typeof(CheckBox)))
                {
                    ((CheckBox)c).CheckedChanged += new EventHandler(SaveControlValue);
                    ((CheckBox)c).Checked=Convert.ToBoolean(Properties.Settings.Default[c.Name.TrimStart("cbx".ToCharArray())]);
                }
                
            }
        }

        private void GetChildControl(Control c)
        {
            if (c.Controls.Count == 0)
            {
                array.Add(c);
            }
            else
            {
                foreach(Control cc in c.Controls)
                {
                GetChildControl(cc);
                }
            }
        }
        PixelFormat[] formats = { PixelFormat.Format32bppArgb, PixelFormat.Format32bppPArgb, PixelFormat.Format32bppRgb };

        private void BindFrequency()
        {
            nudFrequency.Value = Convert.ToDecimal(Properties.Settings.Default.Frequency);
        }
        private void BindPixelFormat()
        {

            cmbPixelFormat.Tag = formats;
            cmbPixelFormat.Items.AddRange(new string[] { "大", "中", "小" });
            cmbPixelFormat.SelectedIndex = Convert.ToInt16(Properties.Settings.Default.ImageFormat);
        }

    



        private void cmbImageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings("ImageFormat", cmbPixelFormat.SelectedIndex.ToString());
        }

        private void SaveSettings(string propName, string value)
        {
            SaveSettings(propName, value, false);
        }

        private void SaveSettings(string propName, string value, bool encrypt)
        {
            PHComponents.SCCrypto c=new PHComponents.SCCrypto();
            if (encrypt)
            {
                value = c.Encrypting(value);
            }
            Properties.Settings.Default[propName] = value;
            Properties.Settings.Default.Save();
        }

        private void cbxAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoRun.Checked)
            {
                AutoStart("create");
            }
            else
            {
                AutoStart("delete");
            }
        }

        private bool IsSubValueExist()
        {

            RegistryKey hklm = Registry.LocalMachine;
            string registerPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey registKey = hklm.OpenSubKey(registerPath);
            string[] subKeys = registKey.GetValueNames();
            bool iskeyExists = false;
            foreach (string subKeyName in subKeys)
            {
                if (subKeyName.Equals("ShotLife", StringComparison.OrdinalIgnoreCase))
                {
                    iskeyExists = true;
                    break;
                }
            }
            return iskeyExists;
        }
        private void AutoStart(string opType)
        {
            string key = "ShotLife";
            string value = Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar + Application.ProductName + ".exe";
          
            RegistryKey hklm = Registry.LocalMachine;
            string registerPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey registKey =hklm.OpenSubKey(registerPath);
            string[] subKeys = registKey.GetValueNames();
            bool iskeyExists = false;
            foreach (string subKeyName in subKeys)
            {
                if (subKeyName.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    iskeyExists = true;
                    break;
                }
            }
            try
            {
              
                switch (opType.ToLower())
                {
                    case "create":
                        if (!iskeyExists)
                        {
                            RegistryKey newRe = hklm.CreateSubKey(registerPath);   //windows7下这句话会抛出权限异常
                            newRe.SetValue(key, value);
                        }
                        break;
                    case "delete":
                        if (iskeyExists)
                        {
                            RegistryKey run = hklm.OpenSubKey(registerPath,true); //定义hklm指向注册表的LocalMachine,对注册表的结构，可以在windows的运行里，输入regedit，运行后，可以看看里面的各个子键，其中Software\Microsoft\Windows\CurrentVersion\Run就是关系到系统中随系统启动而启动的程序，通称启动项

                            run.DeleteValue(key,false);
                        }
                        break;
                    default:
                        
                        break;
                }

            }
            catch { }
            finally
            {
                hklm.Close();
            }
        }


        private void SaveControlValue(object control,EventArgs e)
        {
            string controlName = ((Control)control).Name;
            string propName=string.Empty;
            if (control.GetType() == typeof(TextBox))
            {
                 propName = controlName.TrimStart("tbx".ToCharArray());
                bool needEncrypt = false;
                if (propName.ToLower().IndexOf("password")>=0)
                {
                    needEncrypt = true;
                }
                SaveSettings(propName, ((TextBox)control).Text, needEncrypt);
            }
            if (control.GetType() == typeof(CheckBox))
            {
                 propName = controlName.TrimStart("cbx".ToCharArray());

                SaveSettings(propName, ((CheckBox)control).Checked.ToString());
            }
            if (control.GetType() == typeof(NumericUpDown))
            {
                propName = controlName.TrimStart("nud".ToCharArray());
                SaveSettings(propName, ((NumericUpDown)control).Value.ToString());
            }
        }

        private void nudFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
           // SaveControlValue(sender, null);
        }

        private void nudFrequency_Validated(object sender, EventArgs e)
        {
            SaveControlValue(sender, e);
        }

 


    }
}
