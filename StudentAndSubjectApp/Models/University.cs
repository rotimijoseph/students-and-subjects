using System;
namespace StudentAndSubjectApp.Models
{
	public class University
	{
         public required string Course { get; set; }
         public required List<University> Universities { get; set; }
         public required string Link { get; set; }
     }


    public class PartnerUniversities
    {
          public string? Name { get; set; }
          public string? Country { get; set; }
    }
    
}

