using System.ComponentModel.DataAnnotations;
namespace Computer_Store.Models
{
    public  class AddItem
    {
        public int Id{
            get;
            set;
        }
        [Required]

        public string? Product_Name{
            get;
            set;
        }
        [Required]
         public string? Company{
            get;
            set;
        }
        [Required]
         public int Ram{
            get;
            set;
        }
        [Required]
         public string? Hardisk{
            get;
            set;
        }
        [Required]
          public string? OS{
            get;
            set;
        }
        [Required]
         public string? ProductType{
            get;
            set;
        }
          public string? Description{
            get;
            set;
        }
        public String? Image{
            get;
            set;
        }
      
       

    }
      public enum Operating_system
        {
            Windows,
            Mac,
            Linux    
        }
}