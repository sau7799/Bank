using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            database.InItData();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            LstResult1.Items.Clear();
            string search1 = textBox2.Text;

            //perform my linq query

            var results = from person in database.people
                          join owner in database.owners on person.PersonID equals owner.PersonId
                          join account in database.accounts on owner.AccountId equals account.AccountID
                          where person.Name.Contains(search1)
                          select new { person.Name, account.AccountID, account.Balance };
             
            foreach (var result in results)
            {
                LstResult1.Items.Add(result.ToString());

            }
        }

        
    }
}
