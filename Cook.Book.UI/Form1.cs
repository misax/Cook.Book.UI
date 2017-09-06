using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cook.Book.UI
{
    public partial class mainForm : Form
    {
        private string connectString;
        private SqlConnection connect;
        public mainForm()
        {
            InitializeComponent();
            connectString = ConfigurationManager.ConnectionStrings["Cook.Book.UI.Properties.Settings.CookBookMDFConnectionString"].ConnectionString;
        }


        private void PopulateRecipes()
        {
            string query = "SELECT * FROM Recipe";
            using (connect = new SqlConnection(connectString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect))
                {

                    DataTable tables = new DataTable();
                    dataAdapter.Fill(tables);

                    recipeListBox.DisplayMember = "Name";
                    recipeListBox.ValueMember = "Id";
                    recipeListBox.DataSource = tables;
                }    
            }
        }
        private void PopulateIngredient()
        {
            string query = "SELECT a.Name * FROM Ingredient a " + 
                "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " + 
                "WHERE b.RecipeId = @RecipeId";
            using (connect = new SqlConnection(connectString))
                using(SqlCommand command = new SqlCommand(query,connect))
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@RecipeId", ingredientListbox.SelectedValue);
                    DataTable tables = new DataTable();
                    dataAdapter.Fill(tables);

                    ingredientListbox.DisplayMember = "Name";
                    ingredientListbox.ValueMember = "Id";
                   ingredientListbox.DataSource = tables;
                }
        }

        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(recipeListBox.SelectedValue.ToString());
        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {
            PopulateRecipes();
           PopulateIngredient();
        }

        private void ingredientListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
