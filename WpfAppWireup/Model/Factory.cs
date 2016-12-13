// --------------------------------------------------------------------------------
// <copyright file="Factory.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Factory type.
// </summary>
// --------------------------------------------------------------------------------
namespace WpfAppWireup.Model
{
    using System;
    using System.Collections.Generic;

    public abstract class Factory
    {
        #region Constructors and Destructors

        protected Factory()
        {
            this.Singletons = new Dictionary<Type, object>();
        }

        #endregion

        #region Public Properties

        public static Factory Instance { get; set; }

        #endregion

        #region Properties

        protected Dictionary<Type, object> Singletons { get; set; }

        #endregion

        #region Public Methods and Operators

        public object GetInstance(Type modelType)
        {
            object instance;
            if (this.Singletons.TryGetValue(modelType, out instance))
            {
                return instance;
            }

            return this.CreateInstance(modelType);
        }

        public T GetInstance<T>() where T : class
        {
            return this.GetInstance(typeof(T)) as T;
        }

        #endregion

        #region Methods

        protected abstract object CreateInstance(Type modelType);

        #endregion
    }
}
