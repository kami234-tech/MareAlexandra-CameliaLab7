using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace MareAlexandra_CameliaLab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID {  get; set; }
        [MaxLength(250), Unique]
        public String Description {  get; set; }
        public DateTime Date { get; set; }

    }
}
