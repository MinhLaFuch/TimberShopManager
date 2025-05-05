using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.BUS;
using timber_shop_manager.Utils;

namespace timber_shop_manager.GUI
{
    public partial class frmInvoiceDetail : Form
    {
        private readonly SaleBUS saleBUS = new();
        private readonly ImportDetailBUS importDetailBUS = new();
        private readonly ProductBUS productBUS = new();

        private string id;
        private bool isSaleInvoice;
        private Form frm = null;
        public frmInvoiceDetail()
        {
            InitializeComponent();
        }

        public frmInvoiceDetail(Form frm, string id) : this()
        {
            this.frm = frm;
            this.id = id;
        }

        public frmInvoiceDetail(string id, bool isSaveInvoice = true) : this()
        {
            this.id = id;
            this.isSaleInvoice = isSaveInvoice;
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            if (frm != null && frm is frmCategory)
            {
                dgv.DataSource = productBUS.GetProductsByCategoryId(id);
                dgv.Columns["CatId"].Visible = false;
                dgv.Columns["IsDeleted"].Visible = false;
                this.Text = "Danh sách sản phẩm";
            }
            else if (isSaleInvoice)
            {
                dgv.DataSource = saleBUS.GetInvoiceDetails(id);
            }
            else
            {
                dgv.DataSource = importDetailBUS.GetInvoiceDetail(id);
                dgv.Columns["Id"].Visible = false;
            }

            // Định dạng cột
            if (dgv.Columns["Price"] != null)
                dgv.Columns["Price"].DefaultCellStyle.Format = "N0";
            if (dgv.Columns["Total"] != null)
                dgv.Columns["Total"].DefaultCellStyle.Format = "N0";
            if (dgv.Columns["WarrantyDateEnd"] != null)
                dgv.Columns["WarrantyDateEnd"].DefaultCellStyle.Format = "dd/MM/yyyy";

            var columnHeaders = new Dictionary<string, string> {
                {"ProductId", "Mã SP" },
                {"ProductName", "Tên SP" },
                {"Price", "Đơn giá" },
                {"Quantity", "Số lượng" },
                {"Unit", "Đơn vị tính" },
                {"Total", "Thành tiền" },
                {"WarrantyEnd", "Ngày kết thúc bảo hành" },
                {"ProId", "Mã SP" },
                {"ProName", "Tên sản phẩm" },
                {"Tax", "Thuế" },
                {"WarrantyDateEnd", "Ngày kết thúc bảo hành" },
                {"Id", "Mã" },
                {"Name", "Tên sản phẩm" },
                {"CalculationUnit", "ĐV tính" },
                {"CustomerWarranty", "Bảo hành (năm)" },
                {"Description", "Mô tả" },
                {"PriceQuotation", "Đơn giá" }
            };

            DataGridViewHelper.SetVietnameseHeaders(dgv, columnHeaders);
        }
    }
}
