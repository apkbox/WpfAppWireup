// --------------------------------------------------------------------------------
// <copyright file="ClickMeCommand.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ClickMeCommand type.
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup
{
    using System;
    using System.Windows.Input;

    using WpfAppWireup.Model;

    public class ClickMeCommand : ICommand
    {
        #region Public Events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region Public Methods and Operators

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var model = Factory.Instance.GetInstance<ModelWithDependencies>();
            model.ClickMe();
        }

        #endregion
    }
}
