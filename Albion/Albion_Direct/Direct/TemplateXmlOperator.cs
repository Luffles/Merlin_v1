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
    /* Internal type: km */
    public partial class TemplateXmlOperator
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private km _internal;
        
        #region Properties
        
        public km TemplateXmlOperator_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public TemplateXmlOperator(km instance)
        {
            _internal = instance;
        }
        
        static TemplateXmlOperator()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator km(TemplateXmlOperator instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TemplateXmlOperator(km instance)
        {
            return new TemplateXmlOperator(instance);
        }
        
        public static implicit operator bool(TemplateXmlOperator instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
