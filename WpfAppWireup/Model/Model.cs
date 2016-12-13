// --------------------------------------------------------------------------------
// <copyright file="Model.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Model type.
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup.Model
{
    using System.Diagnostics;

    internal class Model : IModel
    {
        #region Public Methods and Operators

        public void ClickMeHard()
        {
            Debug.WriteLine("Oh!");
        }

        #endregion
    }
}
