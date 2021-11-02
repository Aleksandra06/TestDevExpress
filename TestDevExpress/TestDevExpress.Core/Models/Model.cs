using System.Collections.Generic;

namespace TestDevExpress.Core.Models
{
    public class Model
    {
        public string Name { get; set; }
        public int NameSize { get; set; }
        public List<BlockModel> Blocks { get; set; }
    }
}
