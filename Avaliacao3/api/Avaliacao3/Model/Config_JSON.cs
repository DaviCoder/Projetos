using Newtonsoft.Json;

namespace Avaliacao3.Model
{
    public static class Config_JSON
    {
        public static Item LoadJson()
        {
            using (StreamReader r = new StreamReader("Config.json"))
            {
                string json = r.ReadToEnd();
                Item items = JsonConvert.DeserializeObject<Item>(json);
                return items;
            }
        }
        
       
    }
    public class Item
    {
        public string Host;
        public string Database;
        public string User;
        public string Port;
        public string Password;
        public TipoBd nameSql;
    }
        public enum TipoBd
    {
        SqlServer = 0,
        PostgreSql = 1
    }
}
