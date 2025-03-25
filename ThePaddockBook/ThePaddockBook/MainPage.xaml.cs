namespace ThePaddockBook
{
    public partial class MainPage : ContentPage
    {
 
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Task_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskPage());
        }
    }

}
