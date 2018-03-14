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
   public partial class AllPropertyTypesOptional
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public AllPropertyTypesOptional()
      {
         Init();
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      public int Id { get; set; }

      public byte[] BinaryAttr { get; set; }

      public bool? BooleanAttr { get; set; }

      public byte? ByteAttr { get; set; }

      public DateTime? DateTimeAttr { get; set; }

      public DateTimeOffset? DateTimeOffsetAttr { get; set; }

      public decimal? DecimalAttr { get; set; }

      public double? DoubleAttr { get; set; }

      public Guid? GuidAttr { get; set; }

      public short? Int16Attr { get; set; }

      public int? Int32Attr { get; set; }

      public long? Int64Attr { get; set; }

      public Single? SingleAttr { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      public string StringAttr { get; set; }

      public TimeSpan? TimeAttr { get; set; }

   }
}

