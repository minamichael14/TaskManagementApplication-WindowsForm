namespace TaskManagementSystem.Services
{
    public class NavigationService
    {
        public Action NavigateToForm1 { get; set; }
        public Action NavigateToMainForm { get; set; }

        public void GoToForm1()
        {
            NavigateToForm1?.Invoke();
        }

        public void GoToMainForm()
        {
            NavigateToMainForm?.Invoke();
        }
    }
}
