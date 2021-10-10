using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelyUI;
using RelyUI.Controls;

namespace NeverLose
{
    public partial class Form1 : RelyForm
    {
        bool Running = true;
        bool EnabledRecoil = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void MouseMove()
        {
            int i = 0;
            while (Running)
            {
                Thread.Sleep(1);
                if (MagicMouse.bGetAsyncKeyState(Keys.LButton) && EnabledRecoil && tbIncrease.Value != 0)
                {
                    MagicMouse.Move(0, tbStep.Value + (tbIncrease.Value * i));
                    if ((tbStep.Value + (tbIncrease.Value * i)) < tbMax.Value)
                        i++;
                }
                else if (MagicMouse.bGetAsyncKeyState(Keys.LButton) && EnabledRecoil)
                {
                    MagicMouse.Move(0, tbStep.Value);
                }
                else
                {
                    i = 0;
                }
            }
        }

        private void CheckingProcess()
        {
            while (true)
            {
                Thread.Sleep(500);
                Process[] pname = Process.GetProcessesByName("rainbowsix");
                if (pname.Length == 0)
                {
                    lblCheckProcess.Text = "Not Open !";
                    lblCheckProcess.ForeColor = Color.FromArgb(255, 255, 128, 128);
                    tbStep.Enabled = false;
                    tbIncrease.Enabled = false;
                    tbMax.Enabled = false;
                }
                else
                {
                    lblCheckProcess.Text = "Open !";
                    lblCheckProcess.ForeColor = Color.FromArgb(255, 128, 255, 128);
                    tbStep.Enabled = true;
                    tbIncrease.Enabled = true;
                    tbMax.Enabled = true;
                }
            }
        }

        private void Refresh_R()
        {
            while (Running)
            {
                Thread.Sleep(1);
                lblStep.Text = "● Step(" + tbStep.Value.ToString() + "):";
                lblIncrease.Text = "● Increase(" + tbIncrease.Value.ToString() + "):";
                lblMax.Text = "● Max Inc(" + tbMax.Value.ToString() + "):";

                bool buffer = true;

                while (MagicMouse.bGetAsyncKeyState(Keys.F2))
                {
                    if (buffer)
                    {
                        EnabledRecoil = !EnabledRecoil;
                        buffer = false;
                    }
                }

                if (EnabledRecoil)
                {
                    lblState.Text = "Enabled !";
                    lblState.ForeColor = Color.FromArgb(255, 128, 255, 128);
                    lblCheckProcess.Text = string.Empty;
                    tbStep.Enabled = false;
                    tbIncrease.Enabled = false;
                    tbMax.Enabled = false;
                }
                else
                {
                    lblState.Text = "Disabled !";
                    lblState.ForeColor = Color.FromArgb(255, 255, 128, 128);
                    tbStep.Enabled = true;
                    tbIncrease.Enabled = true;
                    tbMax.Enabled = true;
                }

                Thread.Sleep(1);
                buffer = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread MoveMouseTH = new Thread(MouseMove);
            Thread RefreshTH = new Thread(Refresh_R);
            Thread ChecPRCTH = new Thread(CheckingProcess);
            MoveMouseTH.Start();
            RefreshTH.Start();
            ChecPRCTH.Start();
        }

        private void relyButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmer: </SirProgrammER> | Mojtaba Karamlou\r\nTelegram: t.me/Sir_Programmer\r\nWebSite: SP-SOFT.iR\r\nEmail: Support@SP-SOFT.iR", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void relyButton5_Click(object sender, EventArgs e)
        {
            tbIncrease.Value = 0;
            tbMax.Value = 0;
            tbStep.Value = 0;
        }
    }
}
