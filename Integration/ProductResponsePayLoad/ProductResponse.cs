namespace TEST.API.Integration.ProductResponsePayLoad
{

    //Main Entity------
 public class ProductResponse 
 {
    public bool success { get; set; }
    public string message { get; set; }
    public int responseCode { get; set; }
    public string domain { get; set; }
    public string fields { get; set; }
    public string object_name { get; set; }
    public Permisssions permisssions { get; set; } 
    public int model_id { get; set; }
    public IList<Data> data { get; set; }
}
    
    
public class Permisssions 
    {
    public bool read { get; set; }
    public bool write { get; set; }
    public bool delete { get; set; }
    public bool create { get; set; }

    }
public class Categ_id 
    {
    public int id { get; set; }
    public string name { get; set; }

    }

public class Uom_id 
    {
    public int id { get; set; }
    public string name { get; set; }
    }
public class Uom_po_id 
    {
     public int id { get; set; }
 public string name { get; set; }

    }
public class Seller_ids 
{
 public int id { get; set; }

}
public class Variant_seller_ids 
{
 public int id { get; set; }

}

public class Product_variant_ids 
{
 public int id { get; set; }
 public string name { get; set; }

}
public class Message_follower_ids 
{
 public int id { get; set; }
 public string name { get; set; }

}
public class Message_ids 
{
 public int id { get; set; }
}
public class Create_uid 
{
 public int id { get; set; }
 public string name { get; set; }
}
public class Write_uid {
 public int id { get; set; }
 public string name { get; set; }

}
public class Data {
 public string name { get; set; }
 public int sequence { get; set; }
 public object description { get; set; }
 public object description_purchase { get; set; }
 public object description_sale { get; set; }
 public IList<Categ_id> categ_id { get; set; }
 public double list_price { get; set; }
 //public int volume { get; set; }
 public double weight { get; set; }
 public bool sale_ok { get; set; }
 public bool purchase_ok { get; set; }
 public IList<Uom_id> uom_id { get; set; }
 public IList<Uom_po_id> uom_po_id { get; set; }
 //public IList<undefined> company_id { get; set; }
 public IList<Seller_ids> seller_ids { get; set; }
 public IList<Variant_seller_ids> variant_seller_ids { get; set; }
 public bool active { get; set; }
 public string color { get; set; }
 public IList<Product_variant_ids> product_variant_ids { get; set; }
 public string default_code { get; set; }
 public bool can_image_1024_be_zoomed { get; set; }
 public bool has_configurable_attributes { get; set; }
 public string type { get; set; }
 public int sale_delay { get; set; }
 public string tracking { get; set; }
 public bool description_picking { get; set; }
 public bool description_pickingout { get; set; }
 public bool description_pickingin { get; set; }
 public string service_type { get; set; }
 public string sale_line_warn { get; set; }
 public bool sale_line_warn_msg { get; set; }
 public string expense_policy { get; set; }
 public string invoice_policy { get; set; }
 public string image_1920 { get; set; }
 public string image_1024 { get; set; }
 public string image_512 { get; set; }
 public string image_256 { get; set; }
 public string image_128 { get; set; }
 public IList<Message_follower_ids> message_follower_ids { get; set; }
 public IList<Message_ids> message_ids { get; set; }
 //public IList<undefined> message_main_attachment_id { get; set; }
 public int id { get; set; }
 public IList<Create_uid> create_uid { get; set; }
 public DateTime create_date { get; set; }
 public IList<Write_uid> write_uid { get; set; }
 public DateTime write_date { get; set; }

}


}