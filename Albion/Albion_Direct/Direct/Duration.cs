////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.115208-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: ao6 */
    public partial struct Duration
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ao6 _internal;
        
        #region Properties
        
        public ao6 Duration_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public Duration(ao6 instance)
        {
            _internal = instance;
        }
        
        static Duration()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ao6(Duration instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Duration(ao6 instance)
        {
            return new Duration(instance);
        }
        #endregion
    }
}
