using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace functionTest
{
    public partial class FunctionTest : Form
    {
        bool isCh;
        string checkMACsPath = "00_SHOWMAC.EXE";
        string checkRS422Path = "01-MySerialTest.exe";
        string checkUSBPath = "03-USBDeview.exe";
        string checkAudioPath = "04-MV.wmv";

        public FunctionTest()
        {
            InitializeComponent();
            LanguageInitial();
            axWindowsMediaPlayer1.PlayStateChange += PlayStateChange;
        }

        #region 語言及語言切換區塊
        /// <summary>
        /// 顯示語言初始化
        /// </summary>
        private void LanguageInitial()
        {
            languageSelection.Text = "選擇顯示語言:\r\nSelect Display Language:";
            testGroupBox.Visible = true;
            isCh = true;
        }

        /// <summary>
        /// 切換語言
        /// </summary>
        private void SwitchLanguage()
        {
            if (isCh)
            {
                Chinese();
            }
            else
            {
                English();
            }
        }

        private void Chinese()
        {
            testGroupBox.Text = "測試選單視窗:";
            testListLabel.Text = "測試歷程:";

            checkMacsButton.Text = "確認網路位置";
            rs422Button.Text = "確認RS422功能";
            checkUSBButton.Text = "確認USB功能";
            checkAudioButton.Text = "確認影像及音樂功能";
        }

        private void English()
        {
            testGroupBox.Text = "Test menu window:";
            testListLabel.Text = "Test List:";

            checkMacsButton.Text = "Check MACs IP";
            rs422Button.Text = "Check RS422 Function";
            checkUSBButton.Text = "Check USB Function";
            checkAudioButton.Text = "Check Audio Function";
        }

        /// <summary>
        /// 確認使用者語言更改撥放提示語言
        /// </summary>
        /// <param name="button">測試的按鈕</param>
        private void CheckAudioLanguage(Button button)
        {
            if (isCh)
            {
                DialogResult result = MessageBox.Show("影像及音樂是否正常?", "影像及音樂確認",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    button.BackColor = Color.Green;
                    listRichTextBox.Text += "影像及音樂確認" + "= PASS\r\n";
                }
                else
                {
                    button.BackColor = Color.Red;
                    listRichTextBox.Text += "影像及音樂確認" + "= NG\r\n";
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Are the audio normal?", "Check Audio",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    button.BackColor = Color.Green;
                    listRichTextBox.Text += "Check Audio" + "= PASS\r\n";
                }
                else
                {
                    button.BackColor = Color.Red;
                    listRichTextBox.Text += "Check Audio" + "= NG\r\n";
                }
            }

            KeywordChangeColor("PASS", Color.Green);
            KeywordChangeColor("NG", Color.Red);
        }
        #endregion

        #region 自訂邏輯區
        /// <summary>
        /// 執行外部程式
        /// </summary>
        /// <param name="filePath">程式位置</param>
        /// <param name="testTitle">測試標題</param>
        /// <param name="question">提問</param>
        /// <param name="button">控制按鈕</param>
        private void OpenExternalExecutableFile(string filePath, string testTitle, string question, Button button)
        {
            Process process = new Process();
            process.StartInfo.FileName = filePath;
            process.EnableRaisingEvents = true;
            process.Exited += (sender, e) =>
            {
                DialogResult result = MessageBox.Show(question, testTitle,
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    button.BackColor = Color.Green;
                    listRichTextBox.Text += testTitle + "= PASS\r\n";
                }
                else
                {
                    button.BackColor= Color.Red;
                    listRichTextBox.Text += testTitle + "= NG\r\n";
                }
                KeywordChangeColor("PASS", Color.Green);
                KeywordChangeColor("NG", Color.Red);
            };

            try
            {
                process.Start();
            }
            catch
            {
                MessageBox.Show("無法開啟");
            }
            process.WaitForExit();
        }

        /// <summary>
        /// 關鍵字改顏色
        /// </summary>
        /// <param name="keyWord">關鍵字</param>
        /// <param name="color">顏色</param>
        private void KeywordChangeColor(string keyWord, Color color)
        {
            int startIndex = 0;
            while (startIndex < listRichTextBox.TextLength)
            {
                int wordStartIndex = listRichTextBox.Find(keyWord, startIndex, RichTextBoxFinds.WholeWord);

                if (wordStartIndex != -1)
                {
                    listRichTextBox.SelectionStart= wordStartIndex;
                    listRichTextBox.SelectionLength = keyWord.Length;
                    listRichTextBox.SelectionColor = color;
                    startIndex = wordStartIndex + keyWord.Length;
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 偵測撥放時變更動作邏輯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded ||
                (WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsPaused ||
                (WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                CheckAudioLanguage(checkAudioButton);
            }
        }

        #endregion

        #region 按鈕區
        private void chRadioButton_Click(object sender, EventArgs e)
        {
            isCh = true;
            SwitchLanguage();
        }

        private void enRadioButton_Click(object sender, EventArgs e)
        {
            isCh = false;
            SwitchLanguage();
        }

        private void checkMacsButton_Click(object sender, EventArgs e)
        {
            if (isCh)
            {
                OpenExternalExecutableFile(checkMACsPath, checkMacsButton.Text,
                    "貼紙是否與該電腦MAC一致?", checkMacsButton);
            }
            else
            {
                OpenExternalExecutableFile(checkMACsPath, checkMacsButton.Text,
                    "Is the sticker consistent with the MAC of the computer?", checkMacsButton);
            }

            if (checkMacsButton.BackColor == Color.Green)
            {
                rs422Button_Click(sender, e);
            }

        }

        private void rs422Button_Click(object sender, EventArgs e)
        {
            if (isCh)
            {
                OpenExternalExecutableFile(checkRS422Path, rs422Button.Text,
                    "RS422功能是否正常?", rs422Button);
            }
            else
            {
                OpenExternalExecutableFile(checkRS422Path, rs422Button.Text,
                    "Is the RS422 function normal?", rs422Button);
            }
            if (rs422Button.BackColor == Color.Green)
            {
                checkUSBButton_Click(sender, e);
            }
        }

        private void checkUSBButton_Click(object sender, EventArgs e)
        {
            if (isCh)
            {
                OpenExternalExecutableFile(checkUSBPath, checkUSBButton.Text,
                    "USB功能及速度是否正常?", checkUSBButton);
            }
            else
            {
                OpenExternalExecutableFile(checkUSBPath,checkUSBButton.Text,
                    "Are the USB functions and speed normal?", checkUSBButton);
            }
            if (checkUSBButton.BackColor == Color.Green)
            {
                checkAudioButton_Click(sender, e);
            }
        }

        private void checkAudioButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = checkAudioPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        #endregion
    }
}
