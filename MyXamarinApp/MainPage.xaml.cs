using Syncfusion.Data;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //dataGrid.GroupingMode = GroupingMode.Multiple;
            //dataGrid.AutoExpandGroups = true;
            //dataGrid.AllowGroupExpandCollapse = true;
            //dataGrid.ShowColumnWhenGrouped = true;

            //dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
            //{
            //    ColumnName = "ShipCountry"
            //});

            //dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
            //{
            //    ColumnName = "CustomerID"
            //});
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //dataGrid.GroupColumnDescriptions.RemoveAt(0);
            //var shipCountryGroup = dataGrid.GroupColumnDescriptions
            //    .Where(x => x.ColumnName == "ShipCountry").FirstOrDefault();
            //dataGrid.GroupColumnDescriptions.Remove(shipCountryGroup);

            dataGrid.GroupColumnDescriptions.Clear();
        }
    }
}
