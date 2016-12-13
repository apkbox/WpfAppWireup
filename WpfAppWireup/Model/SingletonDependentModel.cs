// --------------------------------------------------------------------------------
// <copyright file="SingletonDependentModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SingletonDependentModel type.
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup.Model
{
    internal class SingletonDependentModel
    {
        #region Fields

        private readonly ISingletonModel model;

        #endregion

        #region Constructors and Destructors

        public SingletonDependentModel(ISingletonModel model)
        {
            this.model = model;
        }

        #endregion
    }
}
