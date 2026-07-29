using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MauiApp1.Models
{
    public  class RecursiveModel
    {
       public string Name { get; set; }
       public List<RecursiveModel> Directories {  get; set; }
    }
}
