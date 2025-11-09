using Student_app.Main;

namespace Student_app
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Login.Login login = new Login.Login();

            if (login.ShowDialog() == DialogResult.OK)
            {

                Application.Run(new Home(login.SuccessfulLoginData));
            }
        }
    }
}