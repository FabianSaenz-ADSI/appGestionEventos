using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmCompraQr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarQr_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img = encoder.Encode(txtCode.Text);
            System.Drawing.Image Qr = (System.Drawing.Image)img;

            using (MemoryStream ms = new MemoryStream())
            {
                Qr.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                imgCtrl.Src = "data:image/gif;base64," + Convert.ToBase64String(imageBytes);
                imgCtrl.Height = 200;
                imgCtrl.Width = 200;
            }
        }
    }
}