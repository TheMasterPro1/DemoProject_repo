using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataAccessDemo
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void peopleFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(LastNameText.Text);

            UpdateBinding();
        }

        private void LastNameInsLabel_Click(object sender, EventArgs e)
        {

        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db =new DataAccess();

            db.InsertPerson(int.Parse(IDInsText.Text),FirstNameInsText.Text, LastNameInsText.Text, emailAdressInsText.Text, phoneNumberInsText.Text);
            IDInsText.Text = "";
            FirstNameInsText.Text = "";
            LastNameInsText.Text = "";
            emailAdressInsText.Text = "";
            phoneNumberInsText.Text = "";
        }
    }
}
