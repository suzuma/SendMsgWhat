using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendSmgWhat.Comun;

using WhatsAppApi;
//https://www.youtube.com/watch?v=5NmxBl-Xjhk
namespace SendSmgWhat
{
    public partial class frmSendMensaje : Form
    {
        public miCelular mCelular = new miCelular();
        public miKey mKey = new miKey();

        String COUNTRY_CODE = "52";
        String USER_NAME = "";
        String TARGET_CELL = "";
        String MESSAGE = "";
        WhatsApp wa;
        Boolean disponible = false;

        public frmSendMensaje()
        {
            InitializeComponent();
            USER_NAME = mCelular.Propietario;
            
        }

        private void frmSendMensaje_Load(object sender, EventArgs e)
        {
            wa = new WhatsApp(mCelular.Numero, mKey.Key, USER_NAME, false, false);

            wa.OnConnectSuccess += Wa_OnConnectSuccess;
            wa.OnConnectFailed += Wa_OnConnectFailed;

            wa.OnLoginSuccess += Wa_OnLoginSuccess;
            wa.OnLoginFailed += Wa_OnLoginFailed;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MESSAGE = txtMensaje.Text;
            TARGET_CELL = txtPais.Text + txtNoDestinatario.Text;
            wa.SendMessage(TARGET_CELL, MESSAGE);

          
            /*wa.OnConnectSuccess += () =>
            {
                lblMsg.Text = "Conectado...";
                wa.OnLoginSuccess += (phone, data) =>
                {
                    wa.SendMessage(TARGET_CELL, MESSAGE);
                    lblMsg.Text = "Mensaje enviado...";
                };
                wa.OnLoginFailed += (data) =>
                {
                    lblMsg.Text = "ERROR: No se pudo realizar la Autentificación";
                };
                wa.Login();
            };
            wa.OnConnectFailed += (ex) =>
            {
                lblMsg.Text = "ERROR: sin conección";
            };*/

            
        }

        private void Wa_OnLoginFailed(string data)
        {
            disponible = false;
            lblMsg.Text = "ERROR: No se pudo realizar la Autentificación";
        }

        private void Wa_OnLoginSuccess(string phoneNumber, byte[] data)
        {
            disponible = true;
        }

        private void Wa_OnConnectFailed(Exception ex)
        {
            lblMsg.Text = "ERROR: sin conección";
        }

        private void Wa_OnConnectSuccess()
        {
            lblMsg.Text = "Conectado...";
            wa.Login();
        }

        private void txtNoDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
