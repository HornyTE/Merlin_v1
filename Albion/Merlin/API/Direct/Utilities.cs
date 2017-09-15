////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.97446-live
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

namespace Merlin.API.Direct
{
    /* Internal type: a41 */
    public partial class Utilities
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a41 _internal;
        
        #region Properties
        
        public a41 Utilities_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static GuiItemProxy GetStackProxy(ItemProxy A_0) => a41.a((arr)A_0);
        public static int SomeCalculationWithUnfloatyFloats(Number A_0, Number A_1) => a41.b((mx)A_0, (mx)A_1);
        
        #endregion
        
        #region Constructor
        
        public Utilities(a41 instance)
        {
            _internal = instance;
        }
        
        static Utilities()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a41(Utilities instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Utilities(a41 instance)
        {
            return new Utilities(instance);
        }
        
        public static implicit operator bool(Utilities instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}