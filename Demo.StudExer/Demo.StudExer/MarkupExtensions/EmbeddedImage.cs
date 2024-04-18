using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.StudExer.MarkupExtensions
{
   public class EmbeddedImage : IMarkupExtension
   {
      public string ResourceId { get; set; }
      public object ProvideValue(IServiceProvider serviceProvider)
      {
         if (string.IsNullOrEmpty(ResourceId))
            return null;

         return ImageSource.FromResource(ResourceId);
      }
   }
}
