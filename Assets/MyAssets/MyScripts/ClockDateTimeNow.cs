using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class ClockDateTimeNow : MonoBehaviour
{
    public static void Main()
    {
      DateTime localDate = DateTime.Now;
      DateTime utcDate = DateTime.UtcNow;
      String[] cultureNames = { "pt-PT", "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" } ;

      foreach (var cultureName in cultureNames) {
         var culture = new CultureInfo(cultureName);
         Console.WriteLine("{0}:", culture.NativeName);
         Console.WriteLine("   Local date and time: {0}, {1:G}",
                           localDate.ToString(culture), localDate.Kind);
         Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                           utcDate.ToString(culture), utcDate.Kind);
      }
    }
}

// The example displays the following output:
//       Portuguese (Portugal):
//          Local date and time: 22/05/2022 18:28:50 PM, Local
//          UTC date and time: 22/05/2022 17:28:50 PM, Utc
//
//       English (United States):
//          Local date and time: 6/19/2015 10:35:50 AM, Local
//          UTC date and time: 6/19/2015 5:35:50 PM, Utc
//
//       English (United Kingdom):
//          Local date and time: 19/06/2015 10:35:50, Local
//          UTC date and time: 19/06/2015 17:35:50, Utc
//
//       français (France):
//          Local date and time: 19/06/2015 10:35:50, Local
//          UTC date and time: 19/06/2015 17:35:50, Utc
//
//       Deutsch (Deutschland):
//          Local date and time: 19.06.2015 10:35:50, Local
//          UTC date and time: 19.06.2015 17:35:50, Utc
//
//       русский (Россия):
//          Local date and time: 19.06.2015 10:35:50, Local
//          UTC date and time: 19.06.2015 17:35:50, Utc
