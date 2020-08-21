using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Win_Helper.Properties;

namespace Win_Helper
{
    public partial class Form_principal : Form
    {
        List<Button> listaBotones;
        public Form_principal()
        {
            InitializeComponent();
            listaBotones = new List<Button>
            {
                Ver_Version_Windows, windows_10_home,windows_10_pro,windows_10_enterprise,windows_10_education,windows_10_single,windows_10_homeN,windows_10_proN,windows_10_enterpriseN,windows_10_educationN
            };
            gif_carga.Image = Resources.cargando;
        }
        //COMANDOS CMD
        void RunCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = "/C " + command;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Verb = "runas";
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.EnableRaisingEvents = true;
            cmd.Exited += new EventHandler(cmd_Exited);
            cmd.Start();
        }
        void cmd_Exited(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                Mensaje_Bienvenida.Visible = true;
                gif_carga.Visible = false;
            }));
        }
        //mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //barra superior
        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //boton minimizar
        private void Boton_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //boton cerrar
        private void Boton_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //boton (activar windows)
        private void ActivarWindows_Menu_Click(object sender, EventArgs e)
        {
            gif_carga.Visible = false;
            foreach (Button boton in listaBotones)
            {
                boton.Visible = true;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = false;
        }
        //segundo (desactivar windows)
        private void DesactivarWindows_Click(object sender, EventArgs e)
        {
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = true;
            Mensaje_Carga.Visible = false;
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to deactivate windows?", "Windows Message", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                RunCommand("slmgr /upk");
            }
        }
        //boton info
        private void informacion_Click(object sender, EventArgs e)
        {
            Mensaje_Bienvenida.Visible = true;
            MessageBox.Show("Win Helper Version 1.0 (beta)");
        }
        // boton (contribuciones)
        private void Contribuciones_Click(object sender, EventArgs e)
        {
            Mensaje_Bienvenida.Visible = true;
            MessageBox.Show("Discord : \n" + "Lhezver#0161\r\n" + "Nico14#4929\t", "Contributions =D");
        }

        //version de windows
        private void Ver_Version_Windows_Click(object sender, EventArgs e)
        {
            string Version_de_Windows = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = searcher.Get();
                if (information != null)
                {
                    foreach (ManagementObject obj in information)
                    {
                        Version_de_Windows = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                    }
                }
                Version_de_Windows = Version_de_Windows.Replace("NT 5.1.2600", "XP");
                Version_de_Windows = Version_de_Windows.Replace("NT 5.2.3790", "Server 2003");

            }
            MessageBox.Show(Version_de_Windows);
        }
        //logo bienvenida
        private void Logo_inicial_Click(object sender, EventArgs e)
        {
            Mensaje_Bienvenida.Visible = true;
        }
        //carga de botones
        private void windows_10_home_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }
        private void windows_10_pro_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }
        private void windows_10_enterprise_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43 & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }

        private void windows_10_education_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }

        //versiones N de windows

        private void windows_10_homeN_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }

        private void windows_10_proN_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk MH37W-N47XK-V7XM9-C7227-GCQG9 & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }

        private void windows_10_enterpriseN_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }
        private void windows_10_educationN_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }
        private void windows_10_single_Click(object sender, EventArgs e)
        {
            gif_carga.BringToFront();
            foreach (Button boton in listaBotones)
            {
                boton.Visible = false;
            }
            Mensaje_Bienvenida.Visible = false;
            Mensaje_Carga.Visible = true;
            gif_carga.Visible = true;
            RunCommand("slmgr /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH & slmgr /skms kms.digiboy.ir & slmgr /ato");
        }
        
    }
}
