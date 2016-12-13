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

            if (modelType.IsAssignableFrom(typeof(IModel)))
            {
                return new Model();
            }
            else if (modelType.IsAssignableFrom(typeof(ModelWithDependencies)))
            {
                return new ModelWithDependencies(GetInstance<IModel>());
            }
            else if (modelType.IsAssignableFrom(typeof(ISingletonModel)))
            {
                var s = new SingletonModel();

                // All three types resolve to a single instance.
                // As a rule you want to make your instance classes internal and
                // use interfaces only.

                // This one resolve the requested type (could be a base class of actual instance)
                this.Singletons[modelType] = s;

                // This one resolve the actual instance type.
                this.Singletons[s.GetType()] = s;

                // This once resolve the interface.
                this.Singletons[typeof(ISingletonModel)] = s;
                return s;
            }
            else if (modelType.IsAssignableFrom(typeof(SingletonDependentModel)))
            {
                return new SingletonDependentModel(GetInstance<ISingletonModel>());
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
