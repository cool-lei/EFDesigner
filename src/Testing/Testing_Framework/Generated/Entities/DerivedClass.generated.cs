//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Testing
{
   public partial class DerivedClass : BaseClass
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public DerivedClass(): base()
      {
         Init();
      }

      // Persistent properties

      public string Property1 { get; set; }

      public string PropertyInChild { get; set; }

   }
}

