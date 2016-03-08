using System.Windows;
using System.Windows.Controls;
using WcfEntitiesSample.ServiceRefs;

namespace WcfEntitiesSample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            // Required to initialize variables
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int searchId;

            if (int.TryParse(txtID.Text, out searchId))
            {

                var client = new AdventureWorksServiceClient();

                client.GetProductByIDCompleted += (s, ea) =>
                {
                    DataContext = ea.Result;
                };

                client.GetProductByIDAsync(searchId);
            }
            else
            {
                MessageBox.Show("Invalid customer ID. Please enter a number.");
            }
        }
    }
}