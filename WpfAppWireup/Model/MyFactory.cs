// --------------------------------------------------------------------------------
// <copyright file="MyFactory.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the MyFactory type.
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup.Model
{
    using System;

    internal class MyFactory : Factory
    {
        #region Methods

        protected override object CreateInstance(Type modelType)
        {
            if (modelType == null)
            {
                throw new NullReferenceException("model type is null");
            }

            if (modelType.IsAssignableFrom(typeof(Model)))
            {
                return new Model();
            }
            else if (modelType.IsAssignableFrom(typeof(ModelWithDependencies)))
            {
                return new ModelWithDependencies(GetInstance<Model>());
            }
            else if (modelType.IsAssignableFrom(typeof(SingletonModel)))
            {
                var s = new SingletonModel();
                this.Singletons[modelType] = s;
                return s;
            }
            else if (modelType.IsAssignableFrom(typeof(SingletonDependentModel)))
            {
                return new SingletonDependentModel(GetInstance<SingletonModel>());
            }
            else if (modelType.IsAssignableFrom(typeof(ResolveMyselfLater)))
            {
                return new ResolveMyselfLater(this);
            }

            throw new ArgumentException("Unknown type");
        }

        #endregion
    }
}
