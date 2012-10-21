using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridViewTest
{
    public partial class Form1 : Form
    {
        List<Human> dataSource = new List<Human>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 1000; i++)
			{
                dataSource.Add(new Human(){ Name="User"+i.ToString(), Age=new Random().Next(100), Sex=new Random().Next(1)});
			}

            this.dg_Human.DataSource = this.dataSource;
            this.cb_Human.DataSource = this.dataSource;
            this.cb_Human.DisplayMember = "Name";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            var selected = this.cb_Human.SelectedItem as Human;
            foreach (var row in this.dg_Human.Rows )
            {
                var currentRow =  (row as DataGridViewRow);
                var item = currentRow.DataBoundItem as Human;
                if (selected.Equals(item))
                {
                    currentRow.Selected = true;
                    dg_Human.Refresh();
                }
            }
                
        }
    }
}
