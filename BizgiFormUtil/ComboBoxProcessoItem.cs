using BizagiServicesClient;

namespace BizgiFormUtil
{
    public class ComboBoxProcessoItem
    {
        
        public string Value { get;  set; }
        public string Name { get;  set; }
        public Process Tag { get;  set; }
        public override string ToString() { return this.Name; }
    }
}