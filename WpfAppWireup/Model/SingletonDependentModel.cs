namespace WpfAppWireup.Model
{
    internal class SingletonDependentModel
    {
        private readonly SingletonModel model;

        public SingletonDependentModel(SingletonModel model)
        {
            this.model = model;
        }
    }
}