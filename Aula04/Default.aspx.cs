using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlMes_SelectedIndexChanged(object sender, EventArgs e)
    {
        //lblResultado.Text = ddlMes.SelectedItem.Value;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblResultado.Text = ddlMes.SelectedItem.Text;
    }

    protected void btnIncluir_Click(object sender, EventArgs e)
    {
        if (lst1.SelectedIndex != -1)
        {
            lst2.Items.Add(new ListItem(lst1.SelectedItem.Text, lst1.SelectedItem.Value));
            lst1.Items.Remove(lst1.SelectedItem);

        }
    }

    protected void btnTodos_Click(object sender, EventArgs e)
    {
        for (int count = 0; count < lst1.Items.Count; count++)
        {
            int i = 0;
            lst2.Items.Add(lst1.Items[count]);
            i++;
        }
        lst1.Items.Clear();
    }


    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (lst2.SelectedIndex != -1)
        {
            lst1.Items.Add(new ListItem(lst2.SelectedItem.Text, lst2.SelectedItem.Value));
            lst2.Items.Remove(lst2.SelectedItem);
        }
    }

    protected void btnRemoverTodos_Click(object sender, EventArgs e)
    {
        for (int count = 0; count < lst2.Items.Count; count++)
        {
            int i = 0;
            lst1.Items.Add(lst2.Items[count]);
            i++;
        }
        lst2.Items.Clear();
    }
}