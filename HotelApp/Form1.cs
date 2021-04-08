using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Reservation". При необходимости она может быть перемещена или удалена.
            this.reservationTableAdapter.Fill(this.bDDataSet.Reservation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.bDDataSet.Worker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWorker f = new AddWorker(this);

            if (f.ShowDialog() == DialogResult.OK)
            {
                string Wfullname, Wdate, Wpassport, WINN, Waddress, Wposition, Wphone;

                Wfullname = f.Wfullname.Text;
                Wdate = f.Wdate.Text;
                Wpassport = f.Wpassport.Text;
                WINN = f.WINN.Text;
                Waddress = f.Waddress.Text;
                Wposition = f.Wposition.Text;
                Wphone = f.Wposition.Text;

                this.workerTableAdapter
                    .Insert(Wdate, Wfullname, Waddress, Wpassport, Wphone, WINN, Wposition);
                this.workerTableAdapter.Fill(this.bDDataSet.Worker); // отображение
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteWorker f = new DeleteWorker(this);
            string Wfullname, Wdate, Wpassport, WINN, Waddress, Wposition, Wphone;
            int index, id_worker;

            index = dataGridView1.CurrentRow.Index;

            Wfullname = Convert.ToString(dataGridView1[2, index].Value);
            Wdate = Convert.ToString(dataGridView1[0, index].Value);
            Wpassport = Convert.ToString(dataGridView1[4, index].Value);
            WINN = Convert.ToString(dataGridView1[6, index].Value);
            Waddress = Convert.ToString(dataGridView1[3, index].Value);
            Wposition = Convert.ToString(dataGridView1[7, index].Value);
            Wphone = Convert.ToString(dataGridView1[5, index].Value);
            id_worker = Convert.ToInt32(dataGridView1[1, index].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {

                this.workerTableAdapter
                   .Delete(Wdate, id_worker, Wfullname, Waddress, Wpassport, Wphone, WINN, Wposition);
                this.workerTableAdapter.Fill(this.bDDataSet.Worker);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditWorker f = new EditWorker(this);
            string Wfullname, Wdate, Wpassport, WINN, Waddress, Wposition, Wphone;
            int index, id_worker;

            if (dataGridView1.RowCount <= 1) return;

            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return;


            Wfullname = (string)dataGridView1.Rows[index].Cells[2].Value;
            Wdate = (string)dataGridView1.Rows[index].Cells[0].Value;
            Wpassport = (string)dataGridView1.Rows[index].Cells[4].Value;
            WINN = (string)dataGridView1.Rows[index].Cells[6].Value;
            Waddress = (string)dataGridView1.Rows[index].Cells[3].Value;
            Wposition = (string)dataGridView1.Rows[index].Cells[7].Value;
            Wphone = (string)dataGridView1.Rows[index].Cells[5].Value;
            id_worker = (int)dataGridView1.Rows[index].Cells[1].Value;

            f.Wfullname_e.Text = Wfullname;
            f.Wdate_e.Text = Wdate;
            f.Wpassport_e.Text = Wpassport;
            f.WINN_e.Text = WINN;
            f.Waddress_e.Text = Waddress;
            f.Wposition_e.Text = Wposition;
            f.Wphone_e.Text = Wphone;

            if (f.ShowDialog() == DialogResult.OK)
            {
                string nWfullname, nWdate, nWpassport, nWINN, nWaddress, nWposition, nWphone;


                nWfullname = f.Wfullname_e.Text;
                nWdate = f.Wdate_e.Text;
                nWpassport = f.Wpassport_e.Text;
                nWINN = f.WINN_e.Text;
                nWaddress = f.Waddress_e.Text;
                nWposition = f.Wposition_e.Text;
                nWphone = f.Wphone_e.Text;

                this.workerTableAdapter.Update(nWdate, nWfullname, nWaddress, nWpassport, nWphone, nWINN, nWposition, Wdate, id_worker, Wfullname, Waddress, Wpassport, Wphone, WINN, Wposition);
                this.workerTableAdapter.Fill(this.bDDataSet.Worker);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddReserv f = new AddReserv(this);
            if (f.ShowDialog() == DialogResult.OK)
            {
                string Rnumber, Rfullname, Rdatearivl, Rphone, Rchild, Rbage, RdateDep;

                Rnumber = f.Rnumber.Text;
                Rfullname = f.Rclient.Text;
                Rdatearivl = f.Rto.Text;
                RdateDep = f.Rfrom.Text;
                Rphone = f.Rphone.Text;
                Rchild = f.Rchild.Text;
                Rbage = f.Rbage.Text;


                this.reservationTableAdapter.Insert(Rnumber, Rfullname, Rdatearivl, Rphone, Rchild, Rbage, RdateDep);
                this.reservationTableAdapter.Fill(this.bDDataSet.Reservation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteReserv f = new DeleteReserv(this);
            int index, id_reserv;
            string Rnumber, Rfullname, Rdatearivl, Rphone, Rchild, Rbage, RdateDep;
            index = dataGridView2.CurrentRow.Index;
            Rfullname = Convert.ToString(dataGridView2[2, index].Value);
            Rnumber = Convert.ToString(dataGridView2[0, index].Value);
            Rphone = Convert.ToString(dataGridView2[4, index].Value);
            Rbage = Convert.ToString(dataGridView2[6, index].Value);
            Rdatearivl = Convert.ToString(dataGridView2[3, index].Value);
            RdateDep = Convert.ToString(dataGridView2[7, index].Value);
            Rchild = Convert.ToString(dataGridView2[5, index].Value);
            id_reserv = Convert.ToInt32(dataGridView2[1, index].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.reservationTableAdapter
                   .Delete(Rnumber, id_reserv, Rfullname, Rdatearivl, Rphone, Rchild, Rbage, RdateDep);
                this.reservationTableAdapter.Fill(this.bDDataSet.Reservation);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditReserv f = new EditReserv(this);
            int index, id_reserv;
            string Rnumber, Rfullname, Rdatearivl, Rphone, Rchild, Rbage, RdateDep;

            if (dataGridView2.RowCount <= 1) return;

            index = dataGridView2.CurrentRow.Index;

            if (index == dataGridView2.RowCount - 1) return;


            Rfullname = (string)dataGridView2.Rows[index].Cells[2].Value;
            Rnumber = (string)dataGridView2.Rows[index].Cells[0].Value;
            Rphone = (string)dataGridView2.Rows[index].Cells[4].Value;
            Rbage = (string)dataGridView2.Rows[index].Cells[6].Value;
            Rdatearivl = (string)dataGridView2.Rows[index].Cells[3].Value;
            RdateDep = (string)dataGridView2.Rows[index].Cells[7].Value;
            Rchild = (string)dataGridView2.Rows[index].Cells[5].Value;
            id_reserv = (int)dataGridView2.Rows[index].Cells[1].Value;

            f.Rclient_e.Text = Rfullname;
            f.Rfrom_e.Text = RdateDep;
            f.Rto_e.Text = Rdatearivl;
            f.Rbage_e.Text = Rbage;
            f.Rchild_e.Text = Rchild;
            f.Rnumber_e.Text = Rnumber;
            f.Rphone_e.Text = Rphone;

            if (f.ShowDialog() == DialogResult.OK)
            {
                string nRnumber, nRfullname, nRdatearivl, nRphone, nRchild, nRbage, nRdateDep;
                nRnumber = f.Rnumber_e.Text;
                nRfullname = f.Rclient_e.Text;
                nRdatearivl = f.Rto_e.Text;
                nRphone = f.Rphone_e.Text;
                nRchild = f.Rchild_e.Text;
                nRbage = f.Rbage_e.Text;
                nRdateDep = f.Rfrom_e.Text;

                this.reservationTableAdapter.Update(nRnumber, nRfullname, nRdatearivl, nRphone, nRchild, nRbage, nRdateDep, Rnumber, id_reserv, Rfullname, Rdatearivl, Rphone, Rchild, Rbage, RdateDep);
                this.reservationTableAdapter.Fill(this.bDDataSet.Reservation);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
///int id, index;

           // index = dataGridView1.CurrentRow.Index;
           // id = (int)dataGridView1.Rows[index].Cells[1].Value;
           // reservationBindingSource.Filter = "ID_Worker = " + id.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // int id, index;

           // index = dataGridView1.CurrentRow.Index;
            //id = (int)dataGridView1.Rows[index].Cells[1].Value;
           // reservationBindingSource.Filter = "ID_Worker = " + id.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            workerBindingSource.Filter = "Fullname LIKE '" + textBox1.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            reservationBindingSource.Filter = "Fullname_people LIKE '" + textBox2.Text + "%'";
        }
    }
}
