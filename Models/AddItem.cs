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

        public string? ProductName{
            get;
            set;
        }
        [Required]
         public string? Company{
            get;
            set;
        }
        [Required]
         public string? Ram{
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
        [MaxLength(500)]
          public string? Description{
            get;
            set;
        }
        [Required]
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