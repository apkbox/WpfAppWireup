// --------------------------------------------------------------------------------
// <copyright file="ModelWithDependencies.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ModelWithDependencies type.
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup.Model
{
    using System.Diagnostics;

    public class ModelWithDependencies
    {
        #region Fields

        private readonly IModel model;

        #endregion

        #region Constructors and Destructors

        public ModelWithDependencies(IModel model)
        {
            this.model = model;
        }

        #endregion

        #region Public Methods and Operators

        public bool CanIClickYou()
        {
            return true;
        }

        public void ClickMe()
        {
            Debug.WriteLine("AAAAA! I am clicked!");
            this.model.ClickMeHard();
        }

        #endregion
    }
}
