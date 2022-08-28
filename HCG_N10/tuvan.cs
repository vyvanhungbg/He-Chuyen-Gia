using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace HCG_N10
{
    public partial class tuvan : System.Windows.Forms.Form
    {
        private List<string> listMaSach = new List<string>();
        private List<string> listTenSach = new List<string>();
        private ketnoi kn = new ketnoi();
        private bool run = false;
        public tuvan()
        {
            InitializeComponent();
        }

        private void tuvan_Load(object sender, EventArgs e)
        {
            //load list sach
            string qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien='Sach'";
            DataTable tbSach = kn.getTable(qr);
            for (int i = 0; i < tbSach.Rows.Count; i++)
            {
                listMaSach.Add(tbSach.Rows[i][0].ToString());
                listTenSach.Add(tbSach.Rows[i][1].ToString());
            }

            //load len cb_dotuoi
            qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'DoTuoi'";
            DataTable tbDoTuoi = kn.getTable(qr);
            cb_dotuoi.DataSource = tbDoTuoi;
            cb_dotuoi.DisplayMember = "MoTa";
            cb_dotuoi.ValueMember = "MaSuKien";

            //load len cb_nxb
            qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'NhaXuatBan'";
            DataTable tbNXB = kn.getTable(qr);
            cb_nxb.DataSource = tbNXB;
            cb_nxb.DisplayMember = "MoTa";
            cb_nxb.ValueMember = "MaSuKien";

            //load len cb_theloai
            qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'TheLoai'";
            DataTable tbTheLoai = kn.getTable(qr);
            cb_theloai.DataSource = tbTheLoai;
            cb_theloai.DisplayMember = "MoTa";
            cb_theloai.ValueMember = "MaSuKien";

            //load len cb_tacgia
            qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'TacGia'";
            DataTable tbTacGia = kn.getTable(qr);
            cb_tacgia.DataSource = tbTacGia;
            cb_tacgia.DisplayMember = "MoTa";
            cb_tacgia.ValueMember = "MaSuKien";

            //load len cb_giatien
            qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'GiaTien'";
            DataTable tbGiaTien = kn.getTable(qr);
            cb_giatien.DataSource = tbGiaTien;
            cb_giatien.DisplayMember = "MoTa";
            cb_giatien.ValueMember = "MaSuKien";

            //load len cb_mucdich
            //qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'MucDich'";
            //DataTable tbMucDich = kn.getTable(qr);
            //cb_mucdich.DataSource = tbMucDich;
            //cb_mucdich.DisplayMember = "MoTa";
            //cb_mucdich.ValueMember = "MaSuKien";

            //load len cb_job
            qr = "select MaSuKien, MoTa from SuKien where LoaiSuKien = 'NgheNghiep'";
            DataTable tbNgheNghiep = kn.getTable(qr);
            cb_job.DataSource = tbNgheNghiep;
            cb_job.DisplayMember = "MoTa";
            cb_job.ValueMember = "MaSuKien";
        }

        private void bt_tuvan_Click(object sender, EventArgs e)
        {
            suydientien sd = new suydientien();
            sd.DocLuatTuFfile();
            run = true;

            cb_nxb.Enabled = false;
            cb_theloai.Enabled = false;
            cb_tacgia.Enabled = false;
            cb_giatien.Enabled = false;
            //cb_mucdich.Enabled = false;
            cb_job.Enabled = false;
            cb_dotuoi.Enabled = false;
            bt_tuvan.Enabled = false;

            List<string> gt = new List<string>();
            richKQ.Text =  "";
            if (cb_nxb.Text != "" && cb_nxb.SelectedValue.ToString() != null)
            {
                gt.Add(cb_nxb.SelectedValue.ToString());
            }
            if (cb_theloai.Text != "" && cb_nxb.SelectedValue.ToString() != null)
            {
                gt.Add(cb_theloai.SelectedValue.ToString());
            }
            if (cb_tacgia.Text != "" && cb_nxb.SelectedValue.ToString() != null)
            {
                gt.Add(cb_tacgia.SelectedValue.ToString());
            }
            if (cb_giatien.Text != "" && cb_nxb.SelectedValue.ToString() != null)
            {
                gt.Add(cb_giatien.SelectedValue.ToString());
            }

            if (cb_job.Text != "" && cb_nxb.SelectedValue.ToString() != null)
            {
                gt.Add(cb_job.SelectedValue.ToString());
            }
            if (cb_dotuoi.Text != "" && cb_nxb.SelectedValue.ToString() != null)
            {
                gt.Add(cb_dotuoi.SelectedValue.ToString());
            }

            int d = 0;
            progressBar.Maximum = listMaSach.Count - 1;
            progressBar.Minimum = 0;
            if (gt.Count > 0)
            {
                int dem = 0;
                foreach (string s in listMaSach)
                {
                    if (!run)
                    {
                        bt_chonlai.Enabled = false;
                        break;
                    }
                    progressBar.Value = dem;
                    List<string> kl = new List<string>();
                    kl.Add(s);

                    if (sd.SuyDien(gt, kl) == true)
                    {
                        richKQ.Text += listTenSach.ElementAt(dem) + "\n";
                        d++;
                    }
                    dem++;
                    SendKeys.Flush();
                }
                if (d == 0 && run != false)
                {
                    richKQ.Text = "Không có sách nào phù hợp với yêu cầu !!! Xin vui lòng chọn lại!!";
                }
            }
            else
            {
                MessageBox.Show("Phải chọn một trường bạn owiiiii !");
            }
            cb_nxb.Enabled = true;
            cb_theloai.Enabled = true;
            cb_tacgia.Enabled = true;
            cb_giatien.Enabled = true;
            //cb_mucdich.Enabled = true;
            cb_job.Enabled = true;
            cb_dotuoi.Enabled = true;
            bt_tuvan.Enabled = true;
        }

        private int FinIndex(string input, List<string> s)
        {
            int i = 0;
            foreach (string a in s)
            {
                if (input == a)
                {
                    return i;
                }
                i++;
            }
            return 0;
        }

        private void bt_chonlai_Click(object sender, EventArgs e)
        {
            cb_nxb.Text = "";
            cb_theloai.Text = "";
            cb_tacgia.Text = "";
            cb_giatien.Text = "";
            //cb_mucdich.Text = "";
            cb_job.Text = "";
            cb_dotuoi.Text = "";
            richKQ.Text = "";
            run = false;
            progressBar.Value = progressBar.Maximum;            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richKQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
