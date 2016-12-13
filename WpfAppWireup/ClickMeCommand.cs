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
        private readonly ModelWithDependencies model;

        #region Public Events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region Public Methods and Operators

        public ClickMeCommand()
        {
            model = Factory.Instance.GetInstance<ModelWithDependencies>();
        }

        public bool CanExecute(object parameter)
        {
            return model.CanIClickYou();
        }

        public void Execute(object parameter)
        {
            model.ClickMe();
        }

        #endregion
    }
}
