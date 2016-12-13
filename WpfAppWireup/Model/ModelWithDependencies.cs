namespace WpfAppWireup.Model
{
    using System.Diagnostics;

    public class ModelWithDependencies
    {
        private readonly Model model;

        public ModelWithDependencies(Model model)
        {
            this.model = model;
        }

        public void ClickMe()
        {
            Debug.WriteLine("AAAAA! I am clicked!");
            this.model.ClickMeHard();
        }
    }
}