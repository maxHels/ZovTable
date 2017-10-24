using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZovTable
{
    public class Rootobject
    {
        [Key]
        public int Key { get; set; }
        public virtual ICollection<Ship> Ships { get; set; }
        public string DriverName { get; set; }
        public string DeliveryCar { get; set; }
        public Rootobject()
        {
            Ships = new List<Ship>();
        }
    }

    public class Ship
    {
        [Key]
        public int Key { get; set; }
        public string Number { get; set; }
        public int ShipID { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime SDate { get; set; }
        public string Note { get; set; }
        public int State { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime LastEditDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime CreationDate { get; set; }
        public string rowguid { get; set; }
        public bool shipFromSborka { get; set; }
        public string CreateUser { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Ship()
        {
            Orders = new List<Order>();
        }
    }

    public class Order
    {
        [Key]
        public int Key { get; set; }
        public int OrderID { get; set; }
        public int GTIN { get; set; }
        public int ShipID { get; set; }
        public string Customer { get; set; }
        public string Number { get; set; }
        public int Qty { get; set; }
        public string AddedBy { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime AddedTime { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime LastEditDate { get; set; }
        public string rowguid { get; set; }
        public string orderOUID { get; set; }
        public int ispacked { get; set; }
        public virtual ICollection<Pack> Packs { get; set; }
        public int foreignOrderId_int { get; set; }
        public string Note { get; set; }
        public string foreignOrderId { get; set; }
        public Order()
        {
            Packs = new List<Pack>();
        }
    }

    public class Pack
    {
        [Key]
        public int Key { get; set; }
        public int Serial { get; set; }
        public int GTIN { get; set; }
        public int TaskID { get; set; }
        public int OrderID { get; set; }
        public DateTime RegTime { get; set; }
        public string RegBy { get; set; }
        public bool RegAuto { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime ShippedTime { get; set; }
        public string ShippedBy { get; set; }
        public bool ShippedAuto { get; set; }
        public string AddedBy { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime AddedTime { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime LastEditDate { get; set; }
        public string rowguid { get; set; }
        public int isprinted { get; set; }
        public int driverShip { get; set; }
        public bool isSended { get; set; }
        public bool isInsight { get; set; }
        public bool isInsightPacked { get; set; }
        public bool isInsightShipped { get; set; }
        public bool AcceptedAuto { get; set; }
        public string AcceptedBy { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime AcceptedTime { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
        public Pack()
        {
            Details = new List<Detail>();
        }
    }

    public class Detail
    {
        [Key]
        public int Key { get; set; }
        public int DetailID { get; set; }
        public int IncomeID { get; set; }
        public string Customer { get; set; }
        public string Number { get; set; }
        public string ColorName { get; set; }
        public string ArticleName { get; set; }
        public int Qty { get; set; }
        public int GTIN { get; set; }
        public int Serial { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime LastEditDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime CreationDate { get; set; }
        public string ForeignID { get; set; }
        public int Status { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime statusModfiedDate { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Texture { get; set; }
        public string Edge { get; set; }
        public int Taping { get; set; }
        public string Shape { get; set; }
        public string Pallet { get; set; }
        public string Rounding { get; set; }
        public int Thickness { get; set; }
        public string EdgeName { get; set; }
        public int CathetusL { get; set; }
        public int CathetusW { get; set; }
        public int waterproof { get; set; }
        public int FrezR { get; set; }
        public float x { get; set; }
        public float y { get; set; }
    }
}
