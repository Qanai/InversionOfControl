using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
    public class Resolver
    {
        private Dictionary<Type, Type> dependencyMap = new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            Type resolvedType = null;

            try
            {
                resolvedType = dependencyMap[typeToResolve];
            }
            catch 
            {

                throw new Exception(string.Format("Cannot resolve type {0}", typeToResolve.FullName));
            }

            return resolvedType;
        }
    }
}
