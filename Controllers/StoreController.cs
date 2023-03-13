using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Computer_Store.Models;
using Computer_Store.Entities;

namespace Computer_Store.Controllers;

public class StoreController : Controller
{
  
   private Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;
    public StoreController(ILogger<HomeController> logger, Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment)
    {
    
        Environment = _environment;
    }
    public IActionResult AddIt(int Id,AddItem addItem) 
    {
       return View(addItem);
    
    }
     public IActionResult Deleteitem(int Id)
    {
        using (var context = new StoreDBContext())
        {
            var item = context.ItemDetails.FirstOrDefault(x => x.Id == Id);
            if (item != null)
            {
                context.ItemDetails.Remove(item);
                context.SaveChanges();

            }
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
    }
public IActionResult ViewItem(int Id)
    {
        using (var context = new StoreDBContext())
        {
            var item = context.ItemDetails.FirstOrDefault(x => x.Id == Id);  
             return View(item);
            
            
        }
    }
    [HttpPost]
     public IActionResult AddInfo(AddItem AddDetails,IFormFile Image)
     {
        string wwwPath = this.Environment.WebRootPath;
        string contentPath = this.Environment.ContentRootPath;
        string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        List<string> uploadedFiles = new List<string>();
            string fileName = Path.GetFileName(Image.FileName);
                  using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                Image.CopyTo(stream);
                uploadedFiles.Add(fileName);
                ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
            }

         using (var context=new StoreDBContext())
        {
            
            ItemDetail Item =new ItemDetail();
            Item.Product_Name=AddDetails.Product_Name;
            Item.Company=AddDetails.Company;
            Item.Ram=AddDetails.Ram;
            Item.Hardisk=AddDetails.Hardisk;
            Item.Os=AddDetails.OS;
            Item.ProductType=AddDetails.ProductType;
            Item.Description=AddDetails.Description;
            Item.Image=fileName;
            
              if (AddDetails.Id > 0)
            {
                Item.Id = AddDetails.Id;
                context.Update(Item);
            }
            else
            {
                context.Add(Item);
            }
            context.SaveChanges();
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
        
     }

    
    
}