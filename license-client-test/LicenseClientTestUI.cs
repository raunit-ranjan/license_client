using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using licenseclient;

namespace license_client_test
{
    public partial class LicenseClientTestUI : Form
    {
        public LicenseClientTestUI()
        {
            InitializeComponent();
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = txtProductCode.Text;
                string clientCode = txtClientCode.Text;
                string licenseKey = txtLicenseKey.Text;
                string macId = txtMacID.Text;

                var service = new LicenseClient();

                string response = await service.ActivateLicense(productCode, clientCode, licenseKey, macId);

                txtResponse.Text = response;
            }
            catch (Exception ex)
            {               
                txtResponse.Text = ex.Message;
            }
         
        }

        private async void btnValidate_Click(object sender, EventArgs e)
        {

            try
            {
                string productCode = txtProductCode.Text;
                string clientCode = txtClientCode.Text;
                string licenseKey = txtLicenseKey.Text;
                string macId = txtMacID.Text;

                var service = new LicenseClient();

                string response = await service.ValidateLicense(productCode, clientCode,  macId);

                txtResponse.Text = response;
            }
            catch (Exception ex)
            {                
                txtResponse.Text = ex.Message;
            }

        }


        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = txtProductCode.Text;
                string clientCode = txtClientCode.Text;
                string licenseKey = txtLicenseKey.Text;
                string macId = txtMacID.Text;

                var service = new LicenseClient();
                
                string response = await service.TransferLicense(productCode, clientCode, licenseKey, macId);
                
                txtResponse.Text = response;
            }
            catch (Exception ex)
            {                
                txtResponse.Text = ex.Message;
            }
        }

    }
}
