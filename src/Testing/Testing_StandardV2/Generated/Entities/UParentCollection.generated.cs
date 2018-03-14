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
   public partial class UParentCollection
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UParentCollection()
      {
         UChildCollection = new System.Collections.Generic.HashSet<UChild>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_uchildrequired"></param>
      public UParentCollection(UChild _uchildrequired)
      {
         if (_uchildrequired == null) throw new ArgumentNullException(nameof(_uchildrequired));
         UChildRequired = _uchildrequired;

         UChildCollection = new HashSet<UChild>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_uchildrequired"></param>
      public static UParentCollection Create(UChild _uchildrequired)
      {
         return new UParentCollection(_uchildrequired);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      public int Id { get; set; }

      // Persistent navigation properties

      /// <summary>
      ///  // Required
      /// </summary>
      public virtual UChild UChildRequired { get; set; }  // Required
      public virtual ICollection<UChild> UChildCollection { get; set; } 
      public virtual UChild UChildOptional { get; set; } 
   }
}

