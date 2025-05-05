using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class CategoryDTO
    {
        public static readonly string PREFIX = "CAT";
        public static readonly int CODE_LENGTH = 5;
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsShow { get; set; }

        public CategoryDTO() { }

        public CategoryDTO(string id, string name, string description, bool isShow = true)
        {
            Id = id;
            Name = name;
            Description = description;
            IsShow = isShow;
        }
    }
}
