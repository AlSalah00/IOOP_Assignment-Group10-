using IOOP_Assignment_Group10_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group10_.UserControls.ManagerUCs
{
    public partial class CustomerReviews : UserControl
    {
        public CustomerReviews()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void RefreshTable()
        {
            ReviewsTable.AutoGenerateColumns = false;
            ReviewsTable.Columns.Clear();
            ReviewsTable.Columns.Add("resID", "resID");
            ReviewsTable.Columns.Add("username", "username");
            ReviewsTable.Columns.Add("rating", "rating");
            ReviewsTable.Columns.Add("review", "review");

            List<Review> revs = Review.viewAll();

            foreach (Review rev in revs)
            {
                ReviewsTable.Rows.Add(rev.ResID, rev.Username, rev.Rating, rev.Reviews);
            }
        }
    }
}
