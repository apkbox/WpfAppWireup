// --------------------------------------------------------------------------------
// <copyright file="ResolveMyselfLater.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ResolveMyselfLater type.
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup.Model
{
    internal class ResolveMyselfLater
    {
        #region Fields

        private readonly MyFactory myFactory;

        #endregion

        #region Constructors and Destructors

        public ResolveMyselfLater(MyFactory myFactory)
        {
            this.myFactory = myFactory;
        }

        #endregion
    }
}
